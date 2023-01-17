namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuote = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.searchQuotes = new System.Windows.Forms.Label();
            this.viewQuotes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addQuote.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuote.Location = new System.Drawing.Point(30, 36);
            this.addQuote.Name = "addQuote";
            this.addQuote.Size = new System.Drawing.Size(200, 50);
            this.addQuote.TabIndex = 0;
            this.addQuote.Text = "Add New Quote";
            this.addQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addQuote.Click += new System.EventHandler(this.addQuote_Click);
            // 
            // exit
            // 
            this.exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(30, 283);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(200, 50);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchQuotes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchQuotes.Location = new System.Drawing.Point(30, 200);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(200, 50);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewQuotes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewQuotes.Location = new System.Drawing.Point(30, 119);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(200, 50);
            this.viewQuotes.TabIndex = 3;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MegaDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.addQuote);
            this.Name = "MegaDesk";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MegaDesk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label addQuote;
        private Label exit;
        private Label searchQuotes;
        private Label viewQuotes;
        private PictureBox pictureBox1;
    }
}