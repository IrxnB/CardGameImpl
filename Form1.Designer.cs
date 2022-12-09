namespace CardGameImpl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSuitLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxSuitRight = new System.Windows.Forms.ComboBox();
            this.comboBoxValueRight = new System.Windows.Forms.ComboBox();
            this.comboBoxValueLeft = new System.Windows.Forms.ComboBox();
            this.pictureBoxLeftCard = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightCard = new System.Windows.Forms.PictureBox();
            this.buttonTry = new System.Windows.Forms.Button();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.pictureBoxTrumpSuit = new System.Windows.Forms.PictureBox();
            this.labelTrump = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrumpSuit)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSuitLeft
            // 
            this.comboBoxSuitLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuitLeft.FormattingEnabled = true;
            this.comboBoxSuitLeft.Location = new System.Drawing.Point(46, 372);
            this.comboBoxSuitLeft.Name = "comboBoxSuitLeft";
            this.comboBoxSuitLeft.Size = new System.Drawing.Size(183, 28);
            this.comboBoxSuitLeft.TabIndex = 2;
            this.comboBoxSuitLeft.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeftSuit_SelectedIndexChanged);
            // 
            // comboBoxSuitRight
            // 
            this.comboBoxSuitRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuitRight.FormattingEnabled = true;
            this.comboBoxSuitRight.Location = new System.Drawing.Point(451, 372);
            this.comboBoxSuitRight.Name = "comboBoxSuitRight";
            this.comboBoxSuitRight.Size = new System.Drawing.Size(183, 28);
            this.comboBoxSuitRight.TabIndex = 3;
            this.comboBoxSuitRight.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuitRight_SelectedIndexChanged);
            // 
            // comboBoxValueRight
            // 
            this.comboBoxValueRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValueRight.FormattingEnabled = true;
            this.comboBoxValueRight.Location = new System.Drawing.Point(451, 422);
            this.comboBoxValueRight.Name = "comboBoxValueRight";
            this.comboBoxValueRight.Size = new System.Drawing.Size(183, 28);
            this.comboBoxValueRight.TabIndex = 5;
            this.comboBoxValueRight.SelectedIndexChanged += new System.EventHandler(this.comboBoxValueRight_SelectedIndexChanged);
            // 
            // comboBoxValueLeft
            // 
            this.comboBoxValueLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValueLeft.FormattingEnabled = true;
            this.comboBoxValueLeft.Location = new System.Drawing.Point(46, 422);
            this.comboBoxValueLeft.Name = "comboBoxValueLeft";
            this.comboBoxValueLeft.Size = new System.Drawing.Size(183, 28);
            this.comboBoxValueLeft.TabIndex = 4;
            this.comboBoxValueLeft.SelectedIndexChanged += new System.EventHandler(this.comboBoxValueLeft_SelectedIndexChanged);
            // 
            // pictureBoxLeftCard
            // 
            this.pictureBoxLeftCard.Location = new System.Drawing.Point(46, 28);
            this.pictureBoxLeftCard.Name = "pictureBoxLeftCard";
            this.pictureBoxLeftCard.Size = new System.Drawing.Size(224, 312);
            this.pictureBoxLeftCard.TabIndex = 6;
            this.pictureBoxLeftCard.TabStop = false;
            // 
            // pictureBoxRightCard
            // 
            this.pictureBoxRightCard.Location = new System.Drawing.Point(410, 28);
            this.pictureBoxRightCard.Name = "pictureBoxRightCard";
            this.pictureBoxRightCard.Size = new System.Drawing.Size(224, 312);
            this.pictureBoxRightCard.TabIndex = 7;
            this.pictureBoxRightCard.TabStop = false;
            // 
            // buttonTry
            // 
            this.buttonTry.Location = new System.Drawing.Point(276, 406);
            this.buttonTry.Name = "buttonTry";
            this.buttonTry.Size = new System.Drawing.Size(128, 46);
            this.buttonTry.TabIndex = 8;
            this.buttonTry.Text = "BEAT!";
            this.buttonTry.UseVisualStyleBackColor = true;
            this.buttonTry.Click += new System.EventHandler(this.buttonTry_Click);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(304, 28);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxResult.TabIndex = 9;
            this.pictureBoxResult.TabStop = false;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(276, 372);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(128, 28);
            this.buttonRandomize.TabIndex = 10;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // pictureBoxTrumpSuit
            // 
            this.pictureBoxTrumpSuit.Location = new System.Drawing.Point(304, 270);
            this.pictureBoxTrumpSuit.Name = "pictureBoxTrumpSuit";
            this.pictureBoxTrumpSuit.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxTrumpSuit.TabIndex = 11;
            this.pictureBoxTrumpSuit.TabStop = false;
            // 
            // labelTrump
            // 
            this.labelTrump.AutoSize = true;
            this.labelTrump.Location = new System.Drawing.Point(304, 247);
            this.labelTrump.Name = "labelTrump";
            this.labelTrump.Size = new System.Drawing.Size(57, 20);
            this.labelTrump.TabIndex = 12;
            this.labelTrump.Text = "TRUMP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 479);
            this.Controls.Add(this.labelTrump);
            this.Controls.Add(this.pictureBoxTrumpSuit);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.buttonTry);
            this.Controls.Add(this.pictureBoxRightCard);
            this.Controls.Add(this.pictureBoxLeftCard);
            this.Controls.Add(this.comboBoxValueRight);
            this.Controls.Add(this.comboBoxValueLeft);
            this.Controls.Add(this.comboBoxSuitRight);
            this.Controls.Add(this.comboBoxSuitLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrumpSuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxSuitLeft;
        private ComboBox comboBoxSuitRight;
        private ComboBox comboBoxValueRight;
        private ComboBox comboBoxValueLeft;
        private PictureBox pictureBoxLeftCard;
        private PictureBox pictureBoxRightCard;
        private Button buttonTry;
        private PictureBox pictureBoxResult;
        private Button buttonRandomize;
        private PictureBox pictureBoxTrumpSuit;
        private Label labelTrump;
    }
}