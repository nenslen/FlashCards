﻿using System;
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
            public int ID;
            public string qText;
            public string qImage;
            public string aText;
            public string aImage;
            public int skill;
            public int deckID;
        };

        private List<Card> cards = new List<Card>();
        private static string DB_FILEPATH = "flashcards.sqlite";
        private int cardIndex = 0;
        private bool isEdit = false; // Flag to show if a deck is being edited
        private string currentDeckName = "";
        private int currentDeckID = 0;


        public frmFlashCards() {
            InitializeComponent();
        }

        /*
         * TODO
         * 
         * Escape characters or do not allow certain chars
         * 
         * Show question and answer on same slide (just make answer visible? Panel within a panel? Show question on answer panel?)
         * 
         * Add stats to answer slide
         */


        #region Events

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
                                         "deck_percent INTEGER," +
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
            this.Size = new Size(900, 900);
        }


        #region Main Panel

        // Takes user to new folder screen
        private void btnNewFolder_Click(object sender, EventArgs e) {
            showPanel("pnlNewFolder");
            txtFolderName.Text = "";
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

            while (reader.Read()) {
                cbFolderName.Items.Add(reader["folder_name"]);
            }

            reader.Close();
            db.Close();

            cbFolderName.SelectedIndex = 0;
            txtDeckName.Text = "";
        }


        // Bring up context menu strip when node is right-clicked
        private void tvDecks_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (e.Node.Parent != null) {
                    // Selects the clicked node
                    int nodeIndex = e.Node.Index;
                    int parentIndex = e.Node.Parent.Index;
                    tvDecks.SelectedNode = tvDecks.Nodes[parentIndex].Nodes[nodeIndex];

                    // Show the context menu
                    var relativeMousePosition = tvDecks.PointToClient(Cursor.Position);
                    cmsTreeView.Show(tvDecks, relativeMousePosition);
                }
            }
        }


        // Open deck for viewing
        private void tvDecks_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node.Parent != null) {

                int d = Convert.ToInt32(e.Node.Tag);
                //viewDeck(e.Node.Text);
                viewDeck(d);
            }
        }


        // Open deck for viewing
        private void viewToolStripMenuItem_Click(object sender, EventArgs e) {
            //viewDeck(tvDecks.SelectedNode.Text);
        }


        // Opens deck for editing
        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            //editDeck(tvDecks.SelectedNode.Text);
        }


        // Resets skills for a deck
        private void resetSkillsToolStripMenuItem_Click(object sender, EventArgs e) {
            
            if (verifyDialogue("Are you sure? All skills will be reset for this deck.")) {
                SQLiteConnection db = openDB();
                int deckID = getDeckID(tvDecks.SelectedNode.Text, db);
                SQLiteCommand cmd = new SQLiteCommand("UPDATE Card SET card_skill = 3 WHERE deck_id = " + deckID, db);
                cmd.ExecuteNonQuery();
                db.Close();
            }
        }


        // Deletes a deck
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {

            if (verifyDialogue("Are you sure? This deck and all cards within will be permanently deleted.")) {
                //SQLiteConnection db = openDB();
                //int deckID = getDeckID(tvDecks.SelectedNode.Text, db);

                deleteDeck(tvDecks.SelectedNode.Text);
                /*
                // Delete deck
                SQLiteCommand delDeck = new SQLiteCommand("DELETE FROM Deck WHERE deck_id = @deckIDParam", db);
                delDeck.Parameters.AddWithValue("@deckIDParam", deckID);
                delDeck.ExecuteNonQuery();
                delDeck.Parameters.Clear();

                // Delete cards
                SQLiteCommand delCards = new SQLiteCommand("DELETE FROM Card WHERE deck_id = @deckIDParam", db);
                delCards.Parameters.AddWithValue("@deckIDParam", deckID);
                delCards.ExecuteNonQuery();
                delCards.Parameters.Clear();
                
                db.Close();
                */            
                refreshTreeView();
            }
        }

        #endregion

        #region New Folder Panel

        // Cancels new deck creation
        private void btnCancelNewFolder_Click(object sender, EventArgs e) {
            txtFolderName.Text = "";
            showPanel("pnlMain");
        }


        // Creates a new folder
        private void btnCreateNewFolder_Click(object sender, EventArgs e) {

            // Verify folder is not in db
            SQLiteConnection db = openDB();
            string newName = txtFolderName.Text;
            string sql = "select * from Folder where folder_name = '" + newName + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();

            // Count # of rows
            int i = 0;
            while (reader.Read()) {
                i++;
            }
            reader.Close();


            // Folder name already exists
            if (i > 0) {
                MessageBox.Show("Folder: '" + newName + "' already exists.");
                return;
            }


            // Add folder to database
            sql = "insert into Folder (folder_name) values ('" + newName + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            db.Close();


            // Refresh treeview on main screen
            refreshTreeView();


            // Return to main screen
            showPanel("pnlMain");
        }

        #endregion

        #region New Deck Panel

        // Cancels new deck creation
        private void btnCancelNewDeck_Click(object sender, EventArgs e) {

            // Cancel deck creation and return to main panel
            if (verifyDialogue("Are you sure you want to cancel this deck? All unsaved progress will be lost.")) {
                txtDeckName.Text = "";
                clearCardInputs();
                lstCards.Items.Clear();
                cards.Clear();
                showPanel("pnlMain");
            }
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
            cards.Clear();
            lstCards.Items.Clear();
            cardIndex = 0;
        }

        #endregion

        #region New Card Panel

        // Cancels new deck creation
        private void btnNewCardCancel_Click(object sender, EventArgs e) {

            // Cancel deck creation and return to main panel
            if (verifyDialogue("Are you sure you want to cancel this deck? All unsaved progress will be lost.")) {
                txtDeckName.Text = "";
                clearCardInputs();
                lstCards.Items.Clear();
                cards.Clear();
                showPanel("pnlMain");
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


        // Saves current card and clears inputs
        private void btnNewCardNext_Click(object sender, EventArgs e) {

            // Save current card
            Card tempCard = new Card();
            tempCard.ID = cardIndex++;
            tempCard.qText = rtbCardQ.Text;
            tempCard.qImage = txtCardQImage.Text;
            tempCard.aText = rtbCardA.Text;
            tempCard.aImage = txtCardAImage.Text;
            tempCard.skill = 3;
            cards.Add(tempCard);


            // Clear screen for next card
            clearCardInputs();
            refreshCardsListBox();
            lstCards.ClearSelected();
        }


        // Saves edit to current card and clears inputs
        private void btnSaveCardEdit_Click(object sender, EventArgs e) {

            // Save card to the selected index in the cards list
            Card tempCard = new Card();
            tempCard.qText = rtbCardQ.Text;
            tempCard.qImage = txtCardQImage.Text;
            tempCard.aText = rtbCardA.Text;
            tempCard.aImage = txtCardAImage.Text;
            cards[lstCards.SelectedIndex] = tempCard;


            // Clear screen for next card
            clearCardInputs();
            refreshCardsListBox();
            lstCards.ClearSelected();
            lstCards.SelectedIndex = -1;
            btnDeleteCard.Enabled = false;
            btnSaveCardEdit.Enabled = false;
        }


        // Saves a deck to the db
        private void btnSaveDeck_Click(object sender, EventArgs e) {

            // Make sure there is at least 1 card
            if (cards.Count() < 1) {
                MessageBox.Show("There must be at least 1 card to save the deck.");
                return;
            }


            // Delete deck and cards if deck already exists
            SQLiteConnection db = openDB();
            //int deckID = getDeckID(txtDeckName.Text, db);
            int deckID = currentDeckID;
            int folderID = 0;
            int deckPercent = getDeckPercentage();

            if (deckID != -1) {
                //TODO
                // GET folder ID here and set it so that the deck will go into the correct folder again (this might not actually happen)
                deleteDeck(txtDeckName.Text);
            } else {
                folderID = cbFolderName.SelectedIndex;
            }
            

            // Insert the deck
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Deck (deck_name, deck_percent, folder_id) VALUES (@deckNameParam,@deckPercent,@folderIDParam)", db);
            cmd.Parameters.AddWithValue("@deckNameParam", txtDeckName.Text);
            cmd.Parameters.AddWithValue("@deckPercent", deckPercent);
            cmd.Parameters.AddWithValue("@folderIDParam", folderID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            

            // Insert each card
            deckID = getDeckID(txtDeckName.Text, db);

            for (int i = 0; i < cards.Count; i++) {
                SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Card (card_q_text, card_q_image, card_a_text, card_a_image, card_skill, deck_id) " +
                                                            "VALUES (@qTextParam,@qImageParam,@aTextParam,@aImageParam,@skillParam,@deckIDParam)", db);
                insertSQL.Parameters.AddWithValue("@qTextParam", cards[i].qText);
                insertSQL.Parameters.AddWithValue("@qImageParam", cards[i].qImage);
                insertSQL.Parameters.AddWithValue("@aTextParam", cards[i].aText);
                insertSQL.Parameters.AddWithValue("@aImageParam", cards[i].aImage);
                insertSQL.Parameters.AddWithValue("@skillParam", cards[i].skill);
                insertSQL.Parameters.AddWithValue("@deckIDParam", deckID);
                insertSQL.ExecuteNonQuery();
            }

            db.Close();
            refreshTreeView();
            showPanel("pnlMain");
        }


        // Sets image path for a card question
        private void btnCardQImage_Click(object sender, EventArgs e) {
            setImagePath(txtCardQImage);
        }


        // Sets image path for a card answer
        private void btnCardAImage_Click(object sender, EventArgs e) {
            setImagePath(txtCardAImage);
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
                btnSaveCardEdit.Enabled = true;
            }
            else {
                btnDeleteCard.Enabled = false;
                btnSaveCardEdit.Enabled = false;
            }
        }

        #endregion

        #region View Card Question Panel

        // Shows answer to card question
        private void btnShowAnswer_Click(object sender, EventArgs e) {
            showCardAnswer(cardIndex);
            showPanel("pnlCardAnswer");
        }

        #endregion

        #region View Card Answer Panel

        // Move to next slide
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


        // Updates the skills of each card in db for the current deck
        private void btnFinishDeck_Click(object sender, EventArgs e) {

            SQLiteConnection db = openDB();
            int deckID = getDeckID(currentDeckName, db);


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


            // Update each card's skill in db
            for (int i = 0; i < cards.Count; i++) {
                SQLiteCommand cmd = new SQLiteCommand("UPDATE Card SET card_skill = " + cards[i].skill + " WHERE deck_id = " + deckID, db);
                cmd.ExecuteNonQuery();
            }


            // Return to main screen
            db.Close();
            refreshTreeView();
            showPanel("pnlMain");
        }

        #endregion

        private void btnTest_Click(object sender, EventArgs e) {

        }

        #endregion


        #region Methods

        #region Deck/Card Creation

        // Clears the inputs for the new card panel
        private void clearCardInputs() {
            rtbCardQ.Text = "";
            txtCardQImage.Text = "";
            rtbCardA.Text = "";
            txtCardAImage.Text = "";
        }


        // Refreshes the list of cards in the pnlNewCard panel
        private void refreshCardsListBox() {

            lstCards.Items.Clear();

            for(int i = 0; i < cards.Count(); i++) {
                string description = cards[i].qText;
                if (description.Length > 35) {
                    description = description.Substring(0, 35) + "...";
                }
                lstCards.Items.Add(Convert.ToString(i + 1) + ") " + description);
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

        #endregion


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
            reader.Close();


            // Folder for decks without a folder
            tvDecks.Nodes.Add("- No Folder -");


            // Get decks
            sql = "select * from Deck";
            cmd = new SQLiteCommand(sql, db);
            reader = cmd.ExecuteReader();

            int deckIndex = 0;
            while (reader.Read()) {
                // Add each deck to the right folder
                int parentIndex = Convert.ToInt32(reader["folder_id"]) - 1;
                string deckName = Convert.ToString(reader["deck_name"]) + " (" + Convert.ToString(reader["deck_percent"]) + "%)";
                int ID = Convert.ToInt32(reader["deck_id"]);

                // Check if deck has folder
                if (parentIndex == -1) {
                    tvDecks.Nodes[tvDecks.Nodes.Count - 1].Nodes.Add(deckName);
                    tvDecks.Nodes[tvDecks.Nodes.Count - 1].Nodes[deckIndex].Tag = ID;
                }
                else {
                    tvDecks.Nodes[parentIndex].Nodes.Add(deckName);
                    tvDecks.Nodes[parentIndex].Nodes[deckIndex].Tag = ID;
                }

                // Set the deck's tag as its ID
                
            }

            reader.Close();
            db.Close();
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
            lblViewDeckQuestion.Text = "Deck: " + currentDeckName;
            rtbViewCardQuestionText.Text = cards[index].qText;
        }


        // Shows a card answer on the pnlCardAnswer panel
        private void showCardAnswer(int index) {
            int complete = getDeckPercentage();
            lblViewDeckAnswer.Text = "Deck: " + currentDeckName + " (" + complete + "% complete)";
            rtbViewCardQuestion.Text = cards[index].qText;
            rtbViewCardAnswer.Text = cards[index].aText;

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


        // Returns what percentage of the deck is complete (based on currently loaded cards in the cards list)
        private int getDeckPercentage() {

            double totalSkill = 0;
            double maxSkill = 0;

            foreach(Card c in cards) {
                totalSkill += c.skill;
                maxSkill += 5;
            }

            return Convert.ToInt32((totalSkill / maxSkill) * 100);
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
            int rand = rnd.Next(0, totalWeight);
            return indexes[rand];
        }


        // Starts viewing a deck of a given name
        //private void viewDeck(string deckName) {
        private void viewDeck(int deckID) {
            
            if (tvDecks.SelectedNode.Parent != null) {

                cards.Clear();
                //currentDeckName = deckName;
                currentDeckID = deckID;


                // Get cards
                SQLiteConnection db = openDB();
                //int deckID = getDeckID(deckName, db);
                string sql = "select * from Card where deck_id = " + deckID;
                SQLiteCommand cmd = new SQLiteCommand(sql, db);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Card c = new Card();
                    c.qText = reader["card_q_text"].ToString();
                    c.qImage = reader["card_q_image"].ToString();
                    c.aText = reader["card_a_text"].ToString();
                    c.aImage = reader["card_a_image"].ToString();
                    c.skill = Convert.ToInt32(reader["card_skill"]);

                    cards.Add(c);
                }
                reader.Close();
                db.Close();


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


        // Starts editing a deck of a given name
        //private void editDeck(string deckName) {
        private void editDeck(int deckID) {

            if (tvDecks.SelectedNode.Parent != null) {

                currentDeckID = deckID;
                // Gather cards from db
                cards.Clear();

                SQLiteConnection db = openDB();
                //int deckID = getDeckID(deckName, db);
                string sql = "select * from Card where deck_id = " + deckID;
                SQLiteCommand cmd = new SQLiteCommand(sql, db);
                SQLiteDataReader reader = cmd.ExecuteReader();

                int counter = 0;
                while (reader.Read()) {
                    Card c = new Card();
                    c.ID = counter++;
                    c.qText = reader["card_q_text"].ToString();
                    c.qImage = reader["card_q_image"].ToString();
                    c.aText = reader["card_a_text"].ToString();
                    c.aImage = reader["card_a_image"].ToString();
                    c.skill = Convert.ToInt32(reader["card_skill"]);

                    cards.Add(c);
                }
                reader.Close();
                db.Close();


                // Get panel ready for editing
                //txtDeckName.Text = deckName;
                refreshCardsListBox();
                showPanel("pnlNewCard");
            }
        }


        // Deletes a deck and all of its cards
        private void deleteDeck(string deckName) {
            SQLiteConnection db = openDB();
            int deckID = getDeckID(deckName, db);

            // Delete deck
            SQLiteCommand delDeck = new SQLiteCommand("DELETE FROM Deck WHERE deck_id = @deckIDParam", db);
            delDeck.Parameters.AddWithValue("@deckIDParam", deckID);
            delDeck.ExecuteNonQuery();
            delDeck.Parameters.Clear();

            // Delete cards
            SQLiteCommand delCards = new SQLiteCommand("DELETE FROM Card WHERE deck_id = @deckIDParam", db);
            delCards.Parameters.AddWithValue("@deckIDParam", deckID);
            delCards.ExecuteNonQuery();
            delCards.Parameters.Clear();
        }


        // Returns the ID of the deck with a given name
        private int getDeckID(string deckName, SQLiteConnection db) {

            string sql = "select * from Deck where deck_name = '" + deckName + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int deckID = 0;

            try {
                deckID = Convert.ToInt32(reader["deck_id"]);
            } catch (Exception e) {
                MessageBox.Show("No such deck");
                deckID = -1;
            } finally {
                reader.Close();
            }
            
            return deckID;
        }


        // Returns the name of the deck with a given ID
        private string getDeckName(int deckID, SQLiteConnection db) {

            string sql = "select * from Deck where deck_id = '" + deckID + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string deckName = "";

            try {
                deckName = Convert.ToString(reader["deck_name"]);
            }
            catch (Exception e) {
                MessageBox.Show("No such deck");
                deckName = "";
            }
            finally {
                reader.Close();
            }

            return deckName;
        }


        // Returns the ID of the folder that a deck belongs to
        private int getFolderID(string deckName, SQLiteConnection db) {

            string sql = "select * from Deck where deck_name = '" + deckName + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int folderID = 0;

            try {
                folderID = Convert.ToInt32(reader["folder_id"]);
            }
            catch (Exception e) {
                MessageBox.Show("No such folder");
                folderID = -1;
            }
            finally {
                reader.Close();
            }

            return folderID;
        }


        #endregion

        
    }
}
