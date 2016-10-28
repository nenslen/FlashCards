namespace FlashCards {
    partial class frmFlashCards {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tvDecks = new System.Windows.Forms.TreeView();
            this.btnNewDeck = new System.Windows.Forms.Button();
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.pnlNewFolder = new System.Windows.Forms.Panel();
            this.btnCreateNewFolder = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.lblNewFolder = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewDeckNext = new System.Windows.Forms.Button();
            this.lblNewDeck = new System.Windows.Forms.Label();
            this.txtDeckName = new System.Windows.Forms.TextBox();
            this.lblDeckName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewCardNext = new System.Windows.Forms.Button();
            this.lblNewCard = new System.Windows.Forms.Label();
            this.lblCardQText = new System.Windows.Forms.Label();
            this.rtbCardQ = new System.Windows.Forms.RichTextBox();
            this.lblCardQImage = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtCardQImage = new System.Windows.Forms.TextBox();
            this.btnCardQImage = new System.Windows.Forms.Button();
            this.btnCardAImage = new System.Windows.Forms.Button();
            this.txtCardAImage = new System.Windows.Forms.TextBox();
            this.lblCardAImage = new System.Windows.Forms.Label();
            this.rtbCardA = new System.Windows.Forms.RichTextBox();
            this.lblCardAText = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnNewCardPrevious = new System.Windows.Forms.Button();
            this.btnNewCardFinish = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlNewFolder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tvDecks);
            this.pnlMain.Controls.Add(this.btnNewDeck);
            this.pnlMain.Controls.Add(this.btnNewFolder);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(391, 275);
            this.pnlMain.TabIndex = 0;
            // 
            // tvDecks
            // 
            this.tvDecks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDecks.Location = new System.Drawing.Point(3, 47);
            this.tvDecks.Name = "tvDecks";
            this.tvDecks.Size = new System.Drawing.Size(385, 225);
            this.tvDecks.TabIndex = 3;
            // 
            // btnNewDeck
            // 
            this.btnNewDeck.Location = new System.Drawing.Point(103, 3);
            this.btnNewDeck.Name = "btnNewDeck";
            this.btnNewDeck.Size = new System.Drawing.Size(94, 38);
            this.btnNewDeck.TabIndex = 1;
            this.btnNewDeck.Text = "New Deck";
            this.btnNewDeck.UseVisualStyleBackColor = true;
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Location = new System.Drawing.Point(3, 3);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(94, 38);
            this.btnNewFolder.TabIndex = 0;
            this.btnNewFolder.Text = "New Folder";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // pnlNewFolder
            // 
            this.pnlNewFolder.Controls.Add(this.btnCreateNewFolder);
            this.pnlNewFolder.Controls.Add(this.txtFolderName);
            this.pnlNewFolder.Controls.Add(this.lblFolderName);
            this.pnlNewFolder.Controls.Add(this.lblNewFolder);
            this.pnlNewFolder.Location = new System.Drawing.Point(409, 12);
            this.pnlNewFolder.Name = "pnlNewFolder";
            this.pnlNewFolder.Size = new System.Drawing.Size(368, 275);
            this.pnlNewFolder.TabIndex = 1;
            // 
            // btnCreateNewFolder
            // 
            this.btnCreateNewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNewFolder.Location = new System.Drawing.Point(271, 234);
            this.btnCreateNewFolder.Name = "btnCreateNewFolder";
            this.btnCreateNewFolder.Size = new System.Drawing.Size(94, 38);
            this.btnCreateNewFolder.TabIndex = 4;
            this.btnCreateNewFolder.Text = "Done";
            this.btnCreateNewFolder.UseVisualStyleBackColor = true;
            // 
            // txtFolderName
            // 
            this.txtFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderName.Location = new System.Drawing.Point(114, 121);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(218, 20);
            this.txtFolderName.TabIndex = 2;
            // 
            // lblFolderName
            // 
            this.lblFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Location = new System.Drawing.Point(38, 124);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(70, 13);
            this.lblFolderName.TabIndex = 1;
            this.lblFolderName.Text = "Folder Name:";
            // 
            // lblNewFolder
            // 
            this.lblNewFolder.AutoSize = true;
            this.lblNewFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFolder.Location = new System.Drawing.Point(3, 3);
            this.lblNewFolder.Name = "lblNewFolder";
            this.lblNewFolder.Size = new System.Drawing.Size(121, 25);
            this.lblNewFolder.TabIndex = 0;
            this.lblNewFolder.Text = "New Folder";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewDeckNext);
            this.panel1.Controls.Add(this.lblNewDeck);
            this.panel1.Controls.Add(this.txtDeckName);
            this.panel1.Controls.Add(this.lblDeckName);
            this.panel1.Location = new System.Drawing.Point(783, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 275);
            this.panel1.TabIndex = 2;
            // 
            // btnNewDeckNext
            // 
            this.btnNewDeckNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewDeckNext.Location = new System.Drawing.Point(326, 234);
            this.btnNewDeckNext.Name = "btnNewDeckNext";
            this.btnNewDeckNext.Size = new System.Drawing.Size(94, 38);
            this.btnNewDeckNext.TabIndex = 7;
            this.btnNewDeckNext.Text = "Next";
            this.btnNewDeckNext.UseVisualStyleBackColor = true;
            // 
            // lblNewDeck
            // 
            this.lblNewDeck.AutoSize = true;
            this.lblNewDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewDeck.Location = new System.Drawing.Point(3, 3);
            this.lblNewDeck.Name = "lblNewDeck";
            this.lblNewDeck.Size = new System.Drawing.Size(109, 25);
            this.lblNewDeck.TabIndex = 5;
            this.lblNewDeck.Text = "New Deck";
            // 
            // txtDeckName
            // 
            this.txtDeckName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeckName.Location = new System.Drawing.Point(127, 121);
            this.txtDeckName.Name = "txtDeckName";
            this.txtDeckName.Size = new System.Drawing.Size(250, 20);
            this.txtDeckName.TabIndex = 6;
            // 
            // lblDeckName
            // 
            this.lblDeckName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeckName.AutoSize = true;
            this.lblDeckName.Location = new System.Drawing.Point(54, 124);
            this.lblDeckName.Name = "lblDeckName";
            this.lblDeckName.Size = new System.Drawing.Size(67, 13);
            this.lblDeckName.TabIndex = 5;
            this.lblDeckName.Text = "Deck Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNewCardFinish);
            this.panel2.Controls.Add(this.btnNewCardPrevious);
            this.panel2.Controls.Add(this.lblAnswer);
            this.panel2.Controls.Add(this.lblQuestion);
            this.panel2.Controls.Add(this.lblCardAText);
            this.panel2.Controls.Add(this.btnCardAImage);
            this.panel2.Controls.Add(this.txtCardAImage);
            this.panel2.Controls.Add(this.lblCardAImage);
            this.panel2.Controls.Add(this.rtbCardA);
            this.panel2.Controls.Add(this.btnCardQImage);
            this.panel2.Controls.Add(this.txtCardQImage);
            this.panel2.Controls.Add(this.lblCardQImage);
            this.panel2.Controls.Add(this.rtbCardQ);
            this.panel2.Controls.Add(this.btnNewCardNext);
            this.panel2.Controls.Add(this.lblNewCard);
            this.panel2.Controls.Add(this.lblCardQText);
            this.panel2.Location = new System.Drawing.Point(1212, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 492);
            this.panel2.TabIndex = 8;
            // 
            // btnNewCardNext
            // 
            this.btnNewCardNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCardNext.Location = new System.Drawing.Point(294, 451);
            this.btnNewCardNext.Name = "btnNewCardNext";
            this.btnNewCardNext.Size = new System.Drawing.Size(94, 38);
            this.btnNewCardNext.TabIndex = 7;
            this.btnNewCardNext.Text = "Next";
            this.btnNewCardNext.UseVisualStyleBackColor = true;
            // 
            // lblNewCard
            // 
            this.lblNewCard.AutoSize = true;
            this.lblNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCard.Location = new System.Drawing.Point(3, 3);
            this.lblNewCard.Name = "lblNewCard";
            this.lblNewCard.Size = new System.Drawing.Size(106, 25);
            this.lblNewCard.TabIndex = 5;
            this.lblNewCard.Text = "New Card";
            // 
            // lblCardQText
            // 
            this.lblCardQText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardQText.AutoSize = true;
            this.lblCardQText.Location = new System.Drawing.Point(13, 77);
            this.lblCardQText.Name = "lblCardQText";
            this.lblCardQText.Size = new System.Drawing.Size(31, 13);
            this.lblCardQText.TabIndex = 5;
            this.lblCardQText.Text = "Text:";
            // 
            // rtbCardQ
            // 
            this.rtbCardQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCardQ.Location = new System.Drawing.Point(58, 74);
            this.rtbCardQ.Name = "rtbCardQ";
            this.rtbCardQ.Size = new System.Drawing.Size(319, 87);
            this.rtbCardQ.TabIndex = 8;
            this.rtbCardQ.Text = "";
            // 
            // lblCardQImage
            // 
            this.lblCardQImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardQImage.AutoSize = true;
            this.lblCardQImage.Location = new System.Drawing.Point(13, 170);
            this.lblCardQImage.Name = "lblCardQImage";
            this.lblCardQImage.Size = new System.Drawing.Size(39, 13);
            this.lblCardQImage.TabIndex = 9;
            this.lblCardQImage.Text = "Image:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtCardQImage
            // 
            this.txtCardQImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardQImage.Location = new System.Drawing.Point(58, 167);
            this.txtCardQImage.Name = "txtCardQImage";
            this.txtCardQImage.Size = new System.Drawing.Size(238, 20);
            this.txtCardQImage.TabIndex = 8;
            // 
            // btnCardQImage
            // 
            this.btnCardQImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCardQImage.Location = new System.Drawing.Point(302, 165);
            this.btnCardQImage.Name = "btnCardQImage";
            this.btnCardQImage.Size = new System.Drawing.Size(75, 23);
            this.btnCardQImage.TabIndex = 10;
            this.btnCardQImage.Text = "Choose...";
            this.btnCardQImage.UseVisualStyleBackColor = true;
            // 
            // btnCardAImage
            // 
            this.btnCardAImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCardAImage.Location = new System.Drawing.Point(302, 354);
            this.btnCardAImage.Name = "btnCardAImage";
            this.btnCardAImage.Size = new System.Drawing.Size(75, 23);
            this.btnCardAImage.TabIndex = 14;
            this.btnCardAImage.Text = "Choose...";
            this.btnCardAImage.UseVisualStyleBackColor = true;
            // 
            // txtCardAImage
            // 
            this.txtCardAImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardAImage.Location = new System.Drawing.Point(58, 356);
            this.txtCardAImage.Name = "txtCardAImage";
            this.txtCardAImage.Size = new System.Drawing.Size(238, 20);
            this.txtCardAImage.TabIndex = 11;
            // 
            // lblCardAImage
            // 
            this.lblCardAImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardAImage.AutoSize = true;
            this.lblCardAImage.Location = new System.Drawing.Point(13, 359);
            this.lblCardAImage.Name = "lblCardAImage";
            this.lblCardAImage.Size = new System.Drawing.Size(39, 13);
            this.lblCardAImage.TabIndex = 13;
            this.lblCardAImage.Text = "Image:";
            // 
            // rtbCardA
            // 
            this.rtbCardA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCardA.Location = new System.Drawing.Point(58, 261);
            this.rtbCardA.Name = "rtbCardA";
            this.rtbCardA.Size = new System.Drawing.Size(319, 87);
            this.rtbCardA.TabIndex = 12;
            this.rtbCardA.Text = "";
            // 
            // lblCardAText
            // 
            this.lblCardAText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardAText.AutoSize = true;
            this.lblCardAText.Location = new System.Drawing.Point(13, 264);
            this.lblCardAText.Name = "lblCardAText";
            this.lblCardAText.Size = new System.Drawing.Size(31, 13);
            this.lblCardAText.TabIndex = 15;
            this.lblCardAText.Text = "Text:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 47);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(86, 24);
            this.lblQuestion.TabIndex = 16;
            this.lblQuestion.Text = "Question";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 234);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(74, 24);
            this.lblAnswer.TabIndex = 17;
            this.lblAnswer.Text = "Answer";
            // 
            // btnNewCardPrevious
            // 
            this.btnNewCardPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewCardPrevious.Location = new System.Drawing.Point(3, 451);
            this.btnNewCardPrevious.Name = "btnNewCardPrevious";
            this.btnNewCardPrevious.Size = new System.Drawing.Size(94, 38);
            this.btnNewCardPrevious.TabIndex = 18;
            this.btnNewCardPrevious.Text = "Previous";
            this.btnNewCardPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNewCardFinish
            // 
            this.btnNewCardFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCardFinish.Location = new System.Drawing.Point(134, 451);
            this.btnNewCardFinish.MinimumSize = new System.Drawing.Size(94, 38);
            this.btnNewCardFinish.Name = "btnNewCardFinish";
            this.btnNewCardFinish.Size = new System.Drawing.Size(128, 38);
            this.btnNewCardFinish.TabIndex = 19;
            this.btnNewCardFinish.Text = "Finish";
            this.btnNewCardFinish.UseVisualStyleBackColor = true;
            // 
            // frmFlashCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2048, 797);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNewFolder);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmFlashCards";
            this.Text = "Flash Cards";
            this.pnlMain.ResumeLayout(false);
            this.pnlNewFolder.ResumeLayout(false);
            this.pnlNewFolder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TreeView tvDecks;
        private System.Windows.Forms.Button btnNewDeck;
        private System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.Panel pnlNewFolder;
        private System.Windows.Forms.Button btnCreateNewFolder;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.Label lblNewFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewDeckNext;
        private System.Windows.Forms.Label lblNewDeck;
        private System.Windows.Forms.TextBox txtDeckName;
        private System.Windows.Forms.Label lblDeckName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewCardFinish;
        private System.Windows.Forms.Button btnNewCardPrevious;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblCardAText;
        private System.Windows.Forms.Button btnCardAImage;
        private System.Windows.Forms.TextBox txtCardAImage;
        private System.Windows.Forms.Label lblCardAImage;
        private System.Windows.Forms.RichTextBox rtbCardA;
        private System.Windows.Forms.Button btnCardQImage;
        private System.Windows.Forms.TextBox txtCardQImage;
        private System.Windows.Forms.Label lblCardQImage;
        private System.Windows.Forms.RichTextBox rtbCardQ;
        private System.Windows.Forms.Button btnNewCardNext;
        private System.Windows.Forms.Label lblNewCard;
        private System.Windows.Forms.Label lblCardQText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

