using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace FlashCards {
    public partial class frmFlashCards : Form {

        public struct Card {
            public string qText;
            public string qImage;
            public string aText;
            public string aImage;
            public int skill;
            public int deckID;
        };

        private List<Card> cards = new List<Card>();
        private static string DB_FILEPATH = "flashcards.sqlite";
        private int cardIndex = 1;
        private bool isEdit = false; // Flag to show if a deck is being edited

        public frmFlashCards() {
            InitializeComponent();
        }


        #region Methods

        // Takes user to new folder screen
        private void btnNewFolder_Click(object sender, EventArgs e) {
            showPanel("pnlNewFolder");
        }


        // Takes user to the new deck screen
        private void btnNewDeck_Click(object sender, EventArgs e) {
            showPanel("pnlNewDeck");

            // Populate the Folder dropdown
            SQLiteConnection db = openDB();
            string sql = "select folder_name from Folder";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();

            cbFolderName.Items.Clear();
            cbFolderName.Items.Add("- None -");

            while(reader.Read()) {
                cbFolderName.Items.Add(reader["folder_name"]);
            }

            cbFolderName.SelectedIndex = 0;
        }


        // Creates db/tables
        private void frmFlashCards_Load(object sender, EventArgs e) {

            // Create the database file
            if (!File.Exists(DB_FILEPATH)) {

                // Create and open db
                SQLiteConnection.CreateFile(DB_FILEPATH);
                SQLiteConnection db = openDB();

                // Create folder table
                string sql = "create table Folder (folder_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                  "folder_name varchar(1000))";
                SQLiteCommand command = new SQLiteCommand(sql, db);
                command.ExecuteNonQuery();
                

                // Create deck table
                sql = "create table Deck (deck_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                         "deck_name varchar(1000)," +
                                         "folder_id INTEGER," +
                                         "FOREIGN KEY(folder_id) REFERENCES Folder(folder_id))";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                
                // Create card table
                sql = "create table Card (card_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                         "card_q_text varchar(5000)," +
                                         "card_q_image varchar(5000)," +
                                         "card_a_text varchar(5000)," +
                                         "card_a_image varchar(5000)," +
                                         "card_skill int," +
                                         "deck_id int," +
                                         "FOREIGN KEY(deck_id) REFERENCES Deck(deck_id))";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                db.Close();
            }

            refreshTreeView();
            showPanel("pnlMain");
            this.Size = new Size(500, 500);
        }

        
        // Creates a new folder
        private void btnCreateNewFolder_Click(object sender, EventArgs e) {

            // Open connection to db
            SQLiteConnection db = openDB();


            // Verify folder is not in db
            string newName = txtFolderName.Text;
            string sql = "select * from Folder where folder_name = '" + newName + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();

            // Count # of rows
            int i = 0;
            while(reader.Read()) {
                i++;
            }
            reader.Close();

            // Folder name already exists
            if(i > 0) {
                MessageBox.Show("Folder: '" + newName + "' already exists.");
                return;
            }


            // Add folder to database
            sql = "insert into Folder (folder_name) values ('" + newName + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            db.Close();





            /* TEST TEST TEST */
            /*
            // Connect to db
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("data source=" + DB_FILEPATH);
            m_dbConnection.Open();


            // Insert into Folder table
            sql = "insert into Folder (folder_name) values ('Test value')";
            cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.ExecuteNonQuery();


            // Insert into Deck table
            sql = "insert into Deck (deck_name, folder_id) values ('deeeeck', 2)";
            cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.ExecuteNonQuery();


            // Insert into Card table
            sql = "insert into Card (card_q_text, card_q_image, card_a_text, card_a_image, card_skill, deck_id) values ('Test card q text', 'Test card q image', 'text card a text', 'test card a image', 3, 1)";
            cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.ExecuteNonQuery();
            */









            // Refresh treeview on main screen
            refreshTreeView();

            // Return to main screen
            showPanel("pnlMain");
        }


        // Move to the Card Creation panel
        private void btnNewDeckNext_Click(object sender, EventArgs e) {
            
            // Verify deck is not in db
            SQLiteConnection db = openDB();
            string newName = txtDeckName.Text;
            string sql = "select * from Deck where deck_name = '" + newName + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                MessageBox.Show("Deck: '" + newName + "' already exists.");
                return;
            }

            reader.Close();
            db.Close();
            showPanel("pnlNewCard");
            cardIndex = 0;
        }

        
        // Gets image path for a card question
        private void btnCardQImage_Click(object sender, EventArgs e) {
            setImagePath(txtCardQImage);
        }


        // Gets image path for a card answer
        private void btnCardAImage_Click(object sender, EventArgs e) {
            setImagePath(txtCardAImage);
        }


        // Advance to next card creation slide
        private void btnNewCardNext_Click(object sender, EventArgs e) {

            // Save current card
            Card tempCard = new Card();
            tempCard.qText = rtbCardQ.Text;
            tempCard.qImage = txtCardQImage.Text;
            tempCard.aText = rtbCardA.Text;
            tempCard.aImage = txtCardAImage.Text;
            tempCard.skill = 3;
            
            if(lstCards.Items.Count == cards.Count()) {
                cards.Add(tempCard);
            } else {
                cards[cardIndex] = tempCard;
            }


            clearCardInputs();
            

            // Add card to listbox
            string description = tempCard.qText;
            if (description.Length > 35) {
                description = description.Substring(0, 35) + "...";
            }
            lstCards.Items.Add(Convert.ToString(++cardIndex) + ") " + description);
        }

        
        // Cancels new deck creation
        private void btnNewCardCancel_Click(object sender, EventArgs e) {

            // Cancel deck creation and return to main panel
            if (verifyDialogue("Are you sure you want to cancel this deck? All unsaved progress will be lost.")) {
                clearCardInputs();
                lstCards.Items.Clear();
                cards.Clear();
                showPanel("pnlMain");
            }
        }


        // Cancels new deck creation
        private void btnCancelNewDeck_Click(object sender, EventArgs e) {

            // Cancel deck creation and return to main panel
            if(verifyDialogue("Are you sure you want to cancel this deck? All unsaved progress will be lost.")) {
                clearCardInputs();
                lstCards.Items.Clear();
                cards.Clear();
                showPanel("pnlMain");
            }
        }


        // Updates the card inputs when the listbox index changes
        private void lstCards_SelectedIndexChanged(object sender, EventArgs e) {

            // Display card data in inputs
            if (lstCards.SelectedIndex != -1) {
                Card tempCard = cards[lstCards.SelectedIndex];
                rtbCardQ.Text = tempCard.qText;
                txtCardQImage.Text = tempCard.qImage;
                rtbCardA.Text = tempCard.aText;
                txtCardAImage.Text = tempCard.aImage;

                btnDeleteCard.Enabled = true;
            } else {
                btnDeleteCard.Enabled = false;
            }
            
        }


        // Deletes a card from a deck
        private void btnDeleteCard_Click(object sender, EventArgs e) {

            // Delete the selected card
            if (lstCards.SelectedIndex != -1) {
                cards.RemoveAt(lstCards.SelectedIndex);
                lstCards.Items.RemoveAt(lstCards.SelectedIndex);
                clearCardInputs();
            }
        }


        // Saves a deck to the db
        private void btnSaveDeck_Click(object sender, EventArgs e) {

            // Insert the deck
            SQLiteConnection db = openDB();
            string sql = "insert into Deck (deck_name, folder_id) values ('" + txtDeckName.Text + "', " + cbFolderName.SelectedIndex + ")";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            cmd.ExecuteNonQuery();


            // Get the id of the deck
            sql = "select * from Deck where deck_name = '" + txtDeckName.Text + "'";
            cmd.CommandText = sql;
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int deckID = Convert.ToInt32(reader["deck_id"]);
            reader.Close();


            // Insert each card
            for (int i = 0; i < cards.Count; i++) {
                sql = "insert into Card (card_q_text, card_q_image, card_a_text, card_a_image, card_skill, deck_id) " +
                                 "values ('" + cards[i].qText + "', " +
                                         "'" + cards[i].qImage + "', " +
                                         "'" + cards[i].aText + "', " +
                                         "'" + cards[i].aImage + "', " +
                                         "'" + cards[i].skill + "', " +
                                         "'" + deckID + "')";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine(sql);
            }
            
            db.Close();
            refreshTreeView();
            showPanel("pnlMain");
        }


        // Open deck for viewing
        private void tvDecks_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {

            // Get ID of deck that was clicked
            if (tvDecks.Nodes[0].Parent == null) {

                cards.Clear();


                // Get the id of the deck
                SQLiteConnection db = openDB();
                string sql = "select * from Deck where deck_name = '" + e.Node.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(sql, db);
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int deckID = Convert.ToInt32(reader["deck_id"]);
                reader.Close();


                // Get cards
                sql = "select * from Card where deck_id = " + deckID;
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Card c = new Card();
                    c.qText = reader["card_q_text"].ToString();
                    c.qImage = reader["card_q_image"].ToString();
                    c.aText = reader["card_a_text"].ToString();
                    c.aImage = reader["card_a_image"].ToString();
                    c.skill = Convert.ToInt32(reader["card_skill"]);

                    cards.Add(c);
                }


                // Change to question panel and load the first card
                if (cards.Count > 0) {
                    cardIndex = 0;
                    showPanel("pnlCardQuestion");
                    showCardQuestion(cardIndex);
                }
                else {
                    MessageBox.Show("There are no cards in this deck");
                    showPanel("pnlMain");
                }
            }
        }


        // Shows answer to card question
        private void btnShowAnswer_Click(object sender, EventArgs e) {
            showCardAnswer(cardIndex);
            showPanel("pnlCardAnswer");
        }


        // Saves skill for a card answer and moves to next slide
        private void btnCardAnswerNext_Click(object sender, EventArgs e) {

            // Saves skill to cards list
            int skill = 0;
            if (rb1.Checked) { skill = 1; }
            if (rb2.Checked) { skill = 2; }
            if (rb3.Checked) { skill = 3; }
            if (rb4.Checked) { skill = 4; }
            if (rb5.Checked) { skill = 5; }
            
            Card c = cards[cardIndex];
            c.skill = skill;
            cards[cardIndex] = c;


            // Show the next slide
            cardIndex = getNextCardIndex();
            showCardQuestion(cardIndex);
            showPanel("pnlCardQuestion");
        }

        #endregion


        #region Functions

        // Clears the inputs for the new card panel
        private void clearCardInputs() {
            rtbCardQ.Text = "";
            txtCardQImage.Text = "";
            rtbCardA.Text = "";
            txtCardAImage.Text = "";
        }


        // Hides all panels, shows the given panel
        private void showPanel(string panelName) {

            // Hide all panels and set dock = fill
            foreach (Control p in Controls) {
                if (p is Panel) {
                    p.Visible = false;
                    p.Dock = DockStyle.Fill;

                    // Show the given panel
                    if (p.Name == panelName) {
                        p.Visible = true;
                    }
                }
            }
        }


        // Refreshes the folders/decks/cards on the main panel
        private void refreshTreeView() {
            SQLiteConnection db = openDB();

            tvDecks.Nodes.Clear();
            


            // Get folders
            string sql = "select * from Folder";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                tvDecks.Nodes.Add(Convert.ToString(reader["folder_name"]));
            }

            // Folder for decks without a folder
            tvDecks.Nodes.Add("- No Folder -");


            // Get decks
            sql = "select * from Deck";
            cmd = new SQLiteCommand(sql, db);
            reader = cmd.ExecuteReader();

            while (reader.Read()) {
                // Add each deck to the right folder
                int parentIndex = Convert.ToInt16(reader["folder_id"]) - 1;
                string deckName = Convert.ToString(reader["deck_name"]);

                // Check if deck has folder
                if (parentIndex == -1) {
                    tvDecks.Nodes[tvDecks.Nodes.Count - 1].Nodes.Add(deckName);
                }
                else {
                    tvDecks.Nodes[parentIndex].Nodes.Add(deckName);
                }
            }
        }


        // Sets image path in a textbox
        private void setImagePath(TextBox t) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd.DefaultExt = "jpg";
            ofd.ShowDialog();

            if (ofd.FileName != "") {
                t.Text = ofd.FileName;
            }
        }


        // Opens a connection the database and returns the connection object
        private SQLiteConnection openDB() {
            SQLiteConnection db_connection;
            db_connection = new SQLiteConnection("data source=" + DB_FILEPATH);
            db_connection.Open();

            return db_connection;
        }


        // Asks a message and gets a yes/no answer
        private bool verifyDialogue(string message) {
            DialogResult dialogResult = MessageBox.Show(message, "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                return true;
            }
            else {
                return false;
            }
        }


        // Shows a card question on the pnlCardQuestion panel
        private void showCardQuestion(int index) {
            lblViewDeckQuestion.Text = "Deck: " + "";
            lblViewCardQText.Text = cards[index].qText;
        }


        // Shows a card answer on the pnlCardAnswer panel
        private void showCardAnswer(int index) {
            lblViewDeckAnswer.Text = "Deck: " + "";
            lblViewCardAText.Text = cards[index].aText;

            switch (cards[index].skill) {
                case 1:
                    rb1.Checked = true;
                    break;
                case 2:
                    rb2.Checked = true;
                    break;
                case 3:
                    rb3.Checked = true;
                    break;
                case 4:
                    rb4.Checked = true;
                    break;
                case 5:
                    rb5.Checked = true;
                    break;
            }
        }


        // Selects a new card based on skill ratings
        private int getNextCardIndex() {

            // Create map of weights -> index based on skill (skill 5 = weight 1, skill 4 = weight 2 etc)
            // (higher weight = less skill = more probability of that slide being chosen)
            int totalWeight = 0;
            int[] skills = { 5, 4, 3, 2, 1 };
            List<int> indexes = new List<int>();
            for(int i = 0; i < cards.Count; i++) {

                // Add the card index n times to the indexes array (n = weight)
                int weight = skills[cards[i].skill - 1];
                for(int j = 0; j < weight; j++) {
                    indexes.Add(i);
                }
                totalWeight += weight;
            }


            // Choose a new card index
            Random rnd = new Random();
            int rand = rnd.Next(1, totalWeight);
            return indexes[rand];

            //return ++cardIndex;
        }

        #endregion


        private void btnTest_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            showPanel("pnlMain");
        }
    }
}
