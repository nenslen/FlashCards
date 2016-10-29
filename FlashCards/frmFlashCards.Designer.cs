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
            this.pnlNewDeck = new System.Windows.Forms.Panel();
            this.btnNewDeckNext = new System.Windows.Forms.Button();
            this.lblNewDeck = new System.Windows.Forms.Label();
            this.txtDeckName = new System.Windows.Forms.TextBox();
            this.lblDeckName = new System.Windows.Forms.Label();
            this.pnlNewCard = new System.Windows.Forms.Panel();
            this.btnNewCardFinish = new System.Windows.Forms.Button();
            this.btnNewCardPrevious = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblCardAText = new System.Windows.Forms.Label();
            this.btnCardAImage = new System.Windows.Forms.Button();
            this.txtCardAImage = new System.Windows.Forms.TextBox();
            this.lblCardAImage = new System.Windows.Forms.Label();
            this.rtbCardA = new System.Windows.Forms.RichTextBox();
            this.btnCardQImage = new System.Windows.Forms.Button();
            this.txtCardQImage = new System.Windows.Forms.TextBox();
            this.lblCardQImage = new System.Windows.Forms.Label();
            this.rtbCardQ = new System.Windows.Forms.RichTextBox();
            this.btnNewCardNext = new System.Windows.Forms.Button();
            this.lblNewCard = new System.Windows.Forms.Label();
            this.lblCardQText = new System.Windows.Forms.Label();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlCardQuestion = new System.Windows.Forms.Panel();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.pbCardQuestion = new System.Windows.Forms.PictureBox();
            this.lblViewCardQText = new System.Windows.Forms.Label();
            this.lblViewDeck = new System.Windows.Forms.Label();
            this.pnlCardAnswer = new System.Windows.Forms.Panel();
            this.gbSkill = new System.Windows.Forms.GroupBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.btnCardAnswerNext = new System.Windows.Forms.Button();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.pbCardAnswer = new System.Windows.Forms.PictureBox();
            this.lblViewCardAText = new System.Windows.Forms.Label();
            this.lblViewDeck2 = new System.Windows.Forms.Label();
            this.lblFolder_Name = new System.Windows.Forms.Label();
            this.cbFolderName = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlNewFolder.SuspendLayout();
            this.pnlNewDeck.SuspendLayout();
            this.pnlNewCard.SuspendLayout();
            this.pnlCardQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardQuestion)).BeginInit();
            this.pnlCardAnswer.SuspendLayout();
            this.gbSkill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tvDecks);
            this.pnlMain.Controls.Add(this.btnNewDeck);
            this.pnlMain.Controls.Add(this.btnNewFolder);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(391, 277);
            this.pnlMain.TabIndex = 0;
            // 
            // tvDecks
            // 
            this.tvDecks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDecks.Location = new System.Drawing.Point(3, 47);
            this.tvDecks.Name = "tvDecks";
            this.tvDecks.Size = new System.Drawing.Size(385, 227);
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
            this.btnNewDeck.Click += new System.EventHandler(this.btnNewDeck_Click);
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
            this.pnlNewFolder.Size = new System.Drawing.Size(368, 277);
            this.pnlNewFolder.TabIndex = 1;
            // 
            // btnCreateNewFolder
            // 
            this.btnCreateNewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNewFolder.Location = new System.Drawing.Point(271, 236);
            this.btnCreateNewFolder.Name = "btnCreateNewFolder";
            this.btnCreateNewFolder.Size = new System.Drawing.Size(94, 38);
            this.btnCreateNewFolder.TabIndex = 4;
            this.btnCreateNewFolder.Text = "Done";
            this.btnCreateNewFolder.UseVisualStyleBackColor = true;
            this.btnCreateNewFolder.Click += new System.EventHandler(this.btnCreateNewFolder_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFolderName.Location = new System.Drawing.Point(114, 122);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(218, 20);
            this.txtFolderName.TabIndex = 2;
            // 
            // lblFolderName
            // 
            this.lblFolderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Location = new System.Drawing.Point(38, 125);
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
            // pnlNewDeck
            // 
            this.pnlNewDeck.Controls.Add(this.cbFolderName);
            this.pnlNewDeck.Controls.Add(this.lblFolder_Name);
            this.pnlNewDeck.Controls.Add(this.btnNewDeckNext);
            this.pnlNewDeck.Controls.Add(this.lblNewDeck);
            this.pnlNewDeck.Controls.Add(this.txtDeckName);
            this.pnlNewDeck.Controls.Add(this.lblDeckName);
            this.pnlNewDeck.Location = new System.Drawing.Point(783, 12);
            this.pnlNewDeck.Name = "pnlNewDeck";
            this.pnlNewDeck.Size = new System.Drawing.Size(423, 277);
            this.pnlNewDeck.TabIndex = 2;
            // 
            // btnNewDeckNext
            // 
            this.btnNewDeckNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewDeckNext.Location = new System.Drawing.Point(326, 236);
            this.btnNewDeckNext.Name = "btnNewDeckNext";
            this.btnNewDeckNext.Size = new System.Drawing.Size(94, 38);
            this.btnNewDeckNext.TabIndex = 7;
            this.btnNewDeckNext.Text = "Next";
            this.btnNewDeckNext.UseVisualStyleBackColor = true;
            this.btnNewDeckNext.Click += new System.EventHandler(this.btnNewDeckNext_Click);
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
            this.txtDeckName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDeckName.Location = new System.Drawing.Point(126, 151);
            this.txtDeckName.Name = "txtDeckName";
            this.txtDeckName.Size = new System.Drawing.Size(250, 20);
            this.txtDeckName.TabIndex = 6;
            // 
            // lblDeckName
            // 
            this.lblDeckName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeckName.AutoSize = true;
            this.lblDeckName.Location = new System.Drawing.Point(53, 154);
            this.lblDeckName.Name = "lblDeckName";
            this.lblDeckName.Size = new System.Drawing.Size(67, 13);
            this.lblDeckName.TabIndex = 5;
            this.lblDeckName.Text = "Deck Name:";
            // 
            // pnlNewCard
            // 
            this.pnlNewCard.Controls.Add(this.btnNewCardFinish);
            this.pnlNewCard.Controls.Add(this.btnNewCardPrevious);
            this.pnlNewCard.Controls.Add(this.lblAnswer);
            this.pnlNewCard.Controls.Add(this.lblQuestion);
            this.pnlNewCard.Controls.Add(this.lblCardAText);
            this.pnlNewCard.Controls.Add(this.btnCardAImage);
            this.pnlNewCard.Controls.Add(this.txtCardAImage);
            this.pnlNewCard.Controls.Add(this.lblCardAImage);
            this.pnlNewCard.Controls.Add(this.rtbCardA);
            this.pnlNewCard.Controls.Add(this.btnCardQImage);
            this.pnlNewCard.Controls.Add(this.txtCardQImage);
            this.pnlNewCard.Controls.Add(this.lblCardQImage);
            this.pnlNewCard.Controls.Add(this.rtbCardQ);
            this.pnlNewCard.Controls.Add(this.btnNewCardNext);
            this.pnlNewCard.Controls.Add(this.lblNewCard);
            this.pnlNewCard.Controls.Add(this.lblCardQText);
            this.pnlNewCard.Location = new System.Drawing.Point(1212, 12);
            this.pnlNewCard.Name = "pnlNewCard";
            this.pnlNewCard.Size = new System.Drawing.Size(395, 453);
            this.pnlNewCard.TabIndex = 8;
            // 
            // btnNewCardFinish
            // 
            this.btnNewCardFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCardFinish.Location = new System.Drawing.Point(134, 412);
            this.btnNewCardFinish.MinimumSize = new System.Drawing.Size(94, 38);
            this.btnNewCardFinish.Name = "btnNewCardFinish";
            this.btnNewCardFinish.Size = new System.Drawing.Size(132, 38);
            this.btnNewCardFinish.TabIndex = 19;
            this.btnNewCardFinish.Text = "Finish";
            this.btnNewCardFinish.UseVisualStyleBackColor = true;
            // 
            // btnNewCardPrevious
            // 
            this.btnNewCardPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewCardPrevious.Location = new System.Drawing.Point(3, 412);
            this.btnNewCardPrevious.Name = "btnNewCardPrevious";
            this.btnNewCardPrevious.Size = new System.Drawing.Size(94, 38);
            this.btnNewCardPrevious.TabIndex = 18;
            this.btnNewCardPrevious.Text = "Previous";
            this.btnNewCardPrevious.UseVisualStyleBackColor = true;
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
            // btnCardAImage
            // 
            this.btnCardAImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCardAImage.Location = new System.Drawing.Point(306, 354);
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
            this.txtCardAImage.Size = new System.Drawing.Size(242, 20);
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
            this.rtbCardA.Size = new System.Drawing.Size(323, 87);
            this.rtbCardA.TabIndex = 12;
            this.rtbCardA.Text = "";
            // 
            // btnCardQImage
            // 
            this.btnCardQImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCardQImage.Location = new System.Drawing.Point(306, 165);
            this.btnCardQImage.Name = "btnCardQImage";
            this.btnCardQImage.Size = new System.Drawing.Size(75, 23);
            this.btnCardQImage.TabIndex = 10;
            this.btnCardQImage.Text = "Choose...";
            this.btnCardQImage.UseVisualStyleBackColor = true;
            // 
            // txtCardQImage
            // 
            this.txtCardQImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardQImage.Location = new System.Drawing.Point(58, 167);
            this.txtCardQImage.Name = "txtCardQImage";
            this.txtCardQImage.Size = new System.Drawing.Size(242, 20);
            this.txtCardQImage.TabIndex = 8;
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
            // rtbCardQ
            // 
            this.rtbCardQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCardQ.Location = new System.Drawing.Point(58, 74);
            this.rtbCardQ.Name = "rtbCardQ";
            this.rtbCardQ.Size = new System.Drawing.Size(323, 87);
            this.rtbCardQ.TabIndex = 8;
            this.rtbCardQ.Text = "";
            // 
            // btnNewCardNext
            // 
            this.btnNewCardNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCardNext.Location = new System.Drawing.Point(298, 412);
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
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // pnlCardQuestion
            // 
            this.pnlCardQuestion.Controls.Add(this.btnShowAnswer);
            this.pnlCardQuestion.Controls.Add(this.pbCardQuestion);
            this.pnlCardQuestion.Controls.Add(this.lblViewCardQText);
            this.pnlCardQuestion.Controls.Add(this.lblViewDeck);
            this.pnlCardQuestion.Location = new System.Drawing.Point(1613, 12);
            this.pnlCardQuestion.Name = "pnlCardQuestion";
            this.pnlCardQuestion.Size = new System.Drawing.Size(350, 412);
            this.pnlCardQuestion.TabIndex = 8;
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAnswer.Location = new System.Drawing.Point(253, 371);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(94, 38);
            this.btnShowAnswer.TabIndex = 20;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            // 
            // pbCardQuestion
            // 
            this.pbCardQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCardQuestion.Location = new System.Drawing.Point(3, 130);
            this.pbCardQuestion.Name = "pbCardQuestion";
            this.pbCardQuestion.Size = new System.Drawing.Size(344, 217);
            this.pbCardQuestion.TabIndex = 7;
            this.pbCardQuestion.TabStop = false;
            // 
            // lblViewCardQText
            // 
            this.lblViewCardQText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblViewCardQText.AutoSize = true;
            this.lblViewCardQText.Location = new System.Drawing.Point(4, 49);
            this.lblViewCardQText.Name = "lblViewCardQText";
            this.lblViewCardQText.Size = new System.Drawing.Size(124, 13);
            this.lblViewCardQText.TabIndex = 6;
            this.lblViewCardQText.Text = "Card Question Text Here";
            // 
            // lblViewDeck
            // 
            this.lblViewDeck.AutoSize = true;
            this.lblViewDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDeck.Location = new System.Drawing.Point(3, 3);
            this.lblViewDeck.Name = "lblViewDeck";
            this.lblViewDeck.Size = new System.Drawing.Size(187, 25);
            this.lblViewDeck.TabIndex = 5;
            this.lblViewDeck.Text = "Deck_Name_Here";
            // 
            // pnlCardAnswer
            // 
            this.pnlCardAnswer.Controls.Add(this.gbSkill);
            this.pnlCardAnswer.Controls.Add(this.pbCardAnswer);
            this.pnlCardAnswer.Controls.Add(this.lblViewCardAText);
            this.pnlCardAnswer.Controls.Add(this.lblViewDeck2);
            this.pnlCardAnswer.Location = new System.Drawing.Point(1969, 12);
            this.pnlCardAnswer.Name = "pnlCardAnswer";
            this.pnlCardAnswer.Size = new System.Drawing.Size(357, 471);
            this.pnlCardAnswer.TabIndex = 21;
            // 
            // gbSkill
            // 
            this.gbSkill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSkill.Controls.Add(this.rb5);
            this.gbSkill.Controls.Add(this.btnCardAnswerNext);
            this.gbSkill.Controls.Add(this.rb4);
            this.gbSkill.Controls.Add(this.rb3);
            this.gbSkill.Controls.Add(this.rb2);
            this.gbSkill.Controls.Add(this.rb1);
            this.gbSkill.Location = new System.Drawing.Point(6, 329);
            this.gbSkill.Name = "gbSkill";
            this.gbSkill.Size = new System.Drawing.Size(344, 134);
            this.gbSkill.TabIndex = 22;
            this.gbSkill.TabStop = false;
            this.gbSkill.Text = "How well did you do?";
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(6, 112);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(59, 17);
            this.rb5.TabIndex = 4;
            this.rb5.Text = "Perfect";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // btnCardAnswerNext
            // 
            this.btnCardAnswerNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCardAnswerNext.Location = new System.Drawing.Point(244, 90);
            this.btnCardAnswerNext.Name = "btnCardAnswerNext";
            this.btnCardAnswerNext.Size = new System.Drawing.Size(94, 38);
            this.btnCardAnswerNext.TabIndex = 21;
            this.btnCardAnswerNext.Text = "Next";
            this.btnCardAnswerNext.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(6, 89);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(51, 17);
            this.rb4.TabIndex = 3;
            this.rb4.Text = "Good";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Checked = true;
            this.rb3.Location = new System.Drawing.Point(6, 66);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(59, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "Neutral";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 43);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(71, 17);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "Not Great";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 20);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(68, 17);
            this.rb1.TabIndex = 0;
            this.rb1.Text = "Very Bad";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // pbCardAnswer
            // 
            this.pbCardAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCardAnswer.Location = new System.Drawing.Point(6, 93);
            this.pbCardAnswer.Name = "pbCardAnswer";
            this.pbCardAnswer.Size = new System.Drawing.Size(344, 217);
            this.pbCardAnswer.TabIndex = 7;
            this.pbCardAnswer.TabStop = false;
            // 
            // lblViewCardAText
            // 
            this.lblViewCardAText.AutoSize = true;
            this.lblViewCardAText.Location = new System.Drawing.Point(5, 47);
            this.lblViewCardAText.Name = "lblViewCardAText";
            this.lblViewCardAText.Size = new System.Drawing.Size(117, 13);
            this.lblViewCardAText.TabIndex = 6;
            this.lblViewCardAText.Text = "Card Answer Text Here";
            // 
            // lblViewDeck2
            // 
            this.lblViewDeck2.AutoSize = true;
            this.lblViewDeck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDeck2.Location = new System.Drawing.Point(3, 3);
            this.lblViewDeck2.Name = "lblViewDeck2";
            this.lblViewDeck2.Size = new System.Drawing.Size(187, 25);
            this.lblViewDeck2.TabIndex = 5;
            this.lblViewDeck2.Text = "Deck_Name_Here";
            // 
            // lblFolder_Name
            // 
            this.lblFolder_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFolder_Name.AutoSize = true;
            this.lblFolder_Name.Location = new System.Drawing.Point(81, 113);
            this.lblFolder_Name.Name = "lblFolder_Name";
            this.lblFolder_Name.Size = new System.Drawing.Size(39, 13);
            this.lblFolder_Name.TabIndex = 8;
            this.lblFolder_Name.Text = "Folder:";
            // 
            // cbFolderName
            // 
            this.cbFolderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFolderName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFolderName.FormattingEnabled = true;
            this.cbFolderName.Location = new System.Drawing.Point(126, 110);
            this.cbFolderName.Name = "cbFolderName";
            this.cbFolderName.Size = new System.Drawing.Size(250, 21);
            this.cbFolderName.TabIndex = 9;
            // 
            // frmFlashCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2439, 797);
            this.Controls.Add(this.pnlCardAnswer);
            this.Controls.Add(this.pnlCardQuestion);
            this.Controls.Add(this.pnlNewCard);
            this.Controls.Add(this.pnlNewDeck);
            this.Controls.Add(this.pnlNewFolder);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmFlashCards";
            this.Text = "Flash Cards";
            this.Load += new System.EventHandler(this.frmFlashCards_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlNewFolder.ResumeLayout(false);
            this.pnlNewFolder.PerformLayout();
            this.pnlNewDeck.ResumeLayout(false);
            this.pnlNewDeck.PerformLayout();
            this.pnlNewCard.ResumeLayout(false);
            this.pnlNewCard.PerformLayout();
            this.pnlCardQuestion.ResumeLayout(false);
            this.pnlCardQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardQuestion)).EndInit();
            this.pnlCardAnswer.ResumeLayout(false);
            this.pnlCardAnswer.PerformLayout();
            this.gbSkill.ResumeLayout(false);
            this.gbSkill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardAnswer)).EndInit();
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
        private System.Windows.Forms.Panel pnlNewDeck;
        private System.Windows.Forms.Button btnNewDeckNext;
        private System.Windows.Forms.Label lblNewDeck;
        private System.Windows.Forms.TextBox txtDeckName;
        private System.Windows.Forms.Label lblDeckName;
        private System.Windows.Forms.Panel pnlNewCard;
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
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Panel pnlCardQuestion;
        private System.Windows.Forms.PictureBox pbCardQuestion;
        private System.Windows.Forms.Label lblViewCardQText;
        private System.Windows.Forms.Label lblViewDeck;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Panel pnlCardAnswer;
        private System.Windows.Forms.PictureBox pbCardAnswer;
        private System.Windows.Forms.Label lblViewCardAText;
        private System.Windows.Forms.Label lblViewDeck2;
        private System.Windows.Forms.GroupBox gbSkill;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.Button btnCardAnswerNext;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label lblFolder_Name;
        private System.Windows.Forms.ComboBox cbFolderName;
    }
}

