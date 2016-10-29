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

        private static string DB_FILEPATH = "flashcards.sqlite";


        public frmFlashCards() {
            InitializeComponent();
        }


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
                SQLiteConnection db_connection;
                db_connection = new SQLiteConnection("data source=" + DB_FILEPATH);// + ";foreign keys=ON");
                db_connection.Open();
                

                // Create folder table
                string sql = "create table Folder (folder_id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                  "folder_name varchar(1000))";
                SQLiteCommand command = new SQLiteCommand(sql, db_connection);
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
                
                db_connection.Close();
            }
            
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










            // Refresh treeview on main screen
            refreshTreeView();

            // Return to main screen
            showPanel("pnlMain");
        }


        // Move to the Card Creation panel
        private void btnNewDeckNext_Click(object sender, EventArgs e) {
            showPanel("pnlNewCard");
            /*
            // Open connection to db
            SQLiteConnection db = openDB();


            // Verify deck is not in db
            string newName = txtDeckName.Text;
            string sql = "select * from Deck where deck_name = '" + newName + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                MessageBox.Show("Deck: '" + newName + "' already exists.");
                return;
            }

            reader.Close();


            // Add deck to database
            int folderIndex = cbFolderName.SelectedIndex;
            sql = "insert into Deck (deck_name, folder_id) values ('" + newName + "', " + folderIndex + ")";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            db.Close();


            // Refresh treeview on main screen
            refreshTreeView();

            // Return to main screen
            showPanel("pnlMain");
            */
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

            while(reader.Read()) {
                tvDecks.Nodes.Add(Convert.ToString(reader["folder_name"]));
            }


            // Get decks
            sql = "select * from Deck";
            cmd = new SQLiteCommand(sql, db);
            reader = cmd.ExecuteReader();

            while (reader.Read()) {
                // Add each deck to the right folder
                int parentIndex = Convert.ToInt16(reader["folder_id"]) - 1;
                string deckName = Convert.ToString(reader["deck_name"]);

                if (parentIndex == -1) {
                    tvDecks.Nodes.Add(deckName);
                }
                else {
                    tvDecks.Nodes[parentIndex].Nodes.Add(deckName);
                }
            }
        }


        // Opens a connection the database and returns the connection object
        private SQLiteConnection openDB() {
            SQLiteConnection db_connection;
            db_connection = new SQLiteConnection("data source=" + DB_FILEPATH);
            db_connection.Open();

            return db_connection;
        }
    }
}





































/* TEST */
/*

*/
