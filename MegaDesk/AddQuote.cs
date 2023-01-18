namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label widthLabel;
        private TextBox deskWidthBox;
        private Label depthLabel;
        private Label drawersLabel;
        private Label surfaceLabel;
        private Label rushLabel;
        private NumericUpDown drawersNumericUpDown;
        private Button getQuoteButton;
        private Button closeButton;
        private ComboBox materialComboBox;
        private ComboBox rushComboBox;
        private TextBox deskDepthBox;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.deskWidthBox = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.deskDepthBox = new System.Windows.Forms.TextBox();
            this.surfaceLabel = new System.Windows.Forms.Label();
            this.rushLabel = new System.Windows.Forms.Label();
            this.drawersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.rushComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawersNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(228, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 32);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(157, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Customer Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthLabel
            // 
            this.widthLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthLabel.Location = new System.Drawing.Point(12, 88);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(185, 23);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Desk Width (inches):";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deskWidthBox
            // 
            this.deskWidthBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deskWidthBox.Location = new System.Drawing.Point(228, 84);
            this.deskWidthBox.Name = "deskWidthBox";
            this.deskWidthBox.Size = new System.Drawing.Size(300, 32);
            this.deskWidthBox.TabIndex = 3;
            // 
            // depthLabel
            // 
            this.depthLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depthLabel.Location = new System.Drawing.Point(12, 146);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(185, 23);
            this.depthLabel.TabIndex = 4;
            this.depthLabel.Text = "Desk Depth (inches):";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drawersLabel
            // 
            this.drawersLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawersLabel.Location = new System.Drawing.Point(12, 208);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(126, 23);
            this.drawersLabel.TabIndex = 5;
            this.drawersLabel.Text = "# of Drawers:";
            this.drawersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deskDepthBox
            // 
            this.deskDepthBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deskDepthBox.Location = new System.Drawing.Point(228, 142);
            this.deskDepthBox.Name = "deskDepthBox";
            this.deskDepthBox.Size = new System.Drawing.Size(300, 32);
            this.deskDepthBox.TabIndex = 7;
            // 
            // surfaceLabel
            // 
            this.surfaceLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surfaceLabel.Location = new System.Drawing.Point(12, 266);
            this.surfaceLabel.Name = "surfaceLabel";
            this.surfaceLabel.Size = new System.Drawing.Size(167, 23);
            this.surfaceLabel.TabIndex = 8;
            this.surfaceLabel.Text = "Desktop Material:";
            this.surfaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rushLabel
            // 
            this.rushLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rushLabel.Location = new System.Drawing.Point(12, 319);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(210, 23);
            this.rushLabel.TabIndex = 9;
            this.rushLabel.Text = "Order Processing Time:";
            this.rushLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drawersNumericUpDown
            // 
            this.drawersNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawersNumericUpDown.Location = new System.Drawing.Point(228, 205);
            this.drawersNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersNumericUpDown.Name = "drawersNumericUpDown";
            this.drawersNumericUpDown.Size = new System.Drawing.Size(300, 32);
            this.drawersNumericUpDown.TabIndex = 12;
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.BackColor = System.Drawing.Color.Green;
            this.getQuoteButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getQuoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.getQuoteButton.Location = new System.Drawing.Point(12, 375);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(225, 33);
            this.getQuoteButton.TabIndex = 13;
            this.getQuoteButton.Text = "Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = false;
            this.getQuoteButton.Click += new System.EventHandler(this.getQuoteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(283, 375);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(225, 33);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // materialComboBox
            // 
            this.materialComboBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialComboBox.Location = new System.Drawing.Point(228, 262);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(300, 33);
            this.materialComboBox.TabIndex = 15;
            // 
            // rushComboBox
            // 
            this.rushComboBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rushComboBox.FormattingEnabled = true;
            this.rushComboBox.Items.AddRange(new object[] {
            "Standard 14 days",
            "Rush 7 days",
            "Rush 5 days",
            "Rush 3 days"});
            this.rushComboBox.Location = new System.Drawing.Point(228, 315);
            this.rushComboBox.MaxDropDownItems = 4;
            this.rushComboBox.Name = "rushComboBox";
            this.rushComboBox.Size = new System.Drawing.Size(300, 33);
            this.rushComboBox.TabIndex = 16;
            // 
            // AddQuote
            // 
            this.ClientSize = new System.Drawing.Size(587, 439);
            this.Controls.Add(this.rushComboBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.drawersNumericUpDown);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.surfaceLabel);
            this.Controls.Add(this.deskDepthBox);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.deskWidthBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.drawersNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            DisplayQuote openDisplayQuote = new DisplayQuote();
            openDisplayQuote.Tag = this;
            openDisplayQuote.Show(this);
            Hide();
        }
    }
}