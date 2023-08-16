namespace LoginRegisterFormsApp.Register
{
    partial class RegisterForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerNameTextBox = new System.Windows.Forms.TextBox();
            this.registerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.nextButton1 = new System.Windows.Forms.Button();
            this.registerPanel1 = new System.Windows.Forms.Panel();
            this.registerPanel2 = new System.Windows.Forms.Panel();
            this.nextButton2 = new System.Windows.Forms.Button();
            this.registerSexGroupBox = new System.Windows.Forms.GroupBox();
            this.registerWomanRadioButton = new System.Windows.Forms.RadioButton();
            this.registerManRadioButton = new System.Windows.Forms.RadioButton();
            this.registerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registerPanel3 = new System.Windows.Forms.Panel();
            this.registerLoginTextBox = new System.Windows.Forms.TextBox();
            this.nextButton3 = new System.Windows.Forms.Button();
            this.registerPanel4 = new System.Windows.Forms.Panel();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.nextButton4 = new System.Windows.Forms.Button();
            this.registerPanel5 = new System.Windows.Forms.Panel();
            this.registerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.nextButton5 = new System.Windows.Forms.Button();
            this.privacyAndTermsPanel = new System.Windows.Forms.Panel();
            this.endRegisterButton = new System.Windows.Forms.Button();
            this.privacyAndTermsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.privacyAndTermsLabel1 = new System.Windows.Forms.Label();
            this.privacyAndTermsLabel2 = new System.Windows.Forms.Label();
            this.loginButton2 = new System.Windows.Forms.Button();
            this.registerPanel1.SuspendLayout();
            this.registerPanel2.SuspendLayout();
            this.registerSexGroupBox.SuspendLayout();
            this.registerPanel3.SuspendLayout();
            this.registerPanel4.SuspendLayout();
            this.registerPanel5.SuspendLayout();
            this.privacyAndTermsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerNameTextBox
            // 
            this.registerNameTextBox.Location = new System.Drawing.Point(3, 13);
            this.registerNameTextBox.Name = "registerNameTextBox";
            this.registerNameTextBox.PlaceholderText = "Ім\'я";
            this.registerNameTextBox.Size = new System.Drawing.Size(222, 23);
            this.registerNameTextBox.TabIndex = 0;
            this.registerNameTextBox.TextChanged += new System.EventHandler(this.registerNameTextBox_TextChanged);
            // 
            // registerSurnameTextBox
            // 
            this.registerSurnameTextBox.Location = new System.Drawing.Point(3, 42);
            this.registerSurnameTextBox.Name = "registerSurnameTextBox";
            this.registerSurnameTextBox.PlaceholderText = "Прізвище (необов’язково)";
            this.registerSurnameTextBox.Size = new System.Drawing.Size(222, 23);
            this.registerSurnameTextBox.TabIndex = 1;
            this.registerSurnameTextBox.TextChanged += new System.EventHandler(this.registerSurnameTextBox_TextChanged);
            // 
            // nextButton1
            // 
            this.nextButton1.Location = new System.Drawing.Point(141, 90);
            this.nextButton1.Name = "nextButton1";
            this.nextButton1.Size = new System.Drawing.Size(75, 23);
            this.nextButton1.TabIndex = 2;
            this.nextButton1.Text = "Далі";
            this.nextButton1.UseVisualStyleBackColor = true;
            this.nextButton1.Click += new System.EventHandler(this.nextButton1_Click);
            // 
            // registerPanel1
            // 
            this.registerPanel1.Controls.Add(this.registerNameTextBox);
            this.registerPanel1.Controls.Add(this.nextButton1);
            this.registerPanel1.Controls.Add(this.registerSurnameTextBox);
            this.registerPanel1.Location = new System.Drawing.Point(12, 12);
            this.registerPanel1.Name = "registerPanel1";
            this.registerPanel1.Size = new System.Drawing.Size(231, 116);
            this.registerPanel1.TabIndex = 1;
            this.registerPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel1_Paint);
            // 
            // registerPanel2
            // 
            this.registerPanel2.Controls.Add(this.nextButton2);
            this.registerPanel2.Controls.Add(this.registerSexGroupBox);
            this.registerPanel2.Controls.Add(this.registerDateTimePicker);
            this.registerPanel2.Location = new System.Drawing.Point(12, 134);
            this.registerPanel2.Name = "registerPanel2";
            this.registerPanel2.Size = new System.Drawing.Size(251, 159);
            this.registerPanel2.TabIndex = 2;
            this.registerPanel2.Visible = false;
            this.registerPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel2_Paint);
            // 
            // nextButton2
            // 
            this.nextButton2.Location = new System.Drawing.Point(173, 133);
            this.nextButton2.Name = "nextButton2";
            this.nextButton2.Size = new System.Drawing.Size(75, 23);
            this.nextButton2.TabIndex = 2;
            this.nextButton2.Text = "Далі";
            this.nextButton2.UseVisualStyleBackColor = true;
            this.nextButton2.Click += new System.EventHandler(this.nextButton2_Click);
            // 
            // registerSexGroupBox
            // 
            this.registerSexGroupBox.Controls.Add(this.registerWomanRadioButton);
            this.registerSexGroupBox.Controls.Add(this.registerManRadioButton);
            this.registerSexGroupBox.Location = new System.Drawing.Point(12, 57);
            this.registerSexGroupBox.Name = "registerSexGroupBox";
            this.registerSexGroupBox.Size = new System.Drawing.Size(200, 71);
            this.registerSexGroupBox.TabIndex = 1;
            this.registerSexGroupBox.TabStop = false;
            this.registerSexGroupBox.Text = "Стать";
            this.registerSexGroupBox.Enter += new System.EventHandler(this.registerSexGroupBox_Enter);
            // 
            // registerWomanRadioButton
            // 
            this.registerWomanRadioButton.AutoSize = true;
            this.registerWomanRadioButton.Location = new System.Drawing.Point(10, 47);
            this.registerWomanRadioButton.Name = "registerWomanRadioButton";
            this.registerWomanRadioButton.Size = new System.Drawing.Size(49, 19);
            this.registerWomanRadioButton.TabIndex = 1;
            this.registerWomanRadioButton.TabStop = true;
            this.registerWomanRadioButton.Text = "Жін.";
            this.registerWomanRadioButton.UseVisualStyleBackColor = true;
            this.registerWomanRadioButton.CheckedChanged += new System.EventHandler(this.registerWomanRadioButton_CheckedChanged);
            // 
            // registerManRadioButton
            // 
            this.registerManRadioButton.AutoSize = true;
            this.registerManRadioButton.Location = new System.Drawing.Point(10, 22);
            this.registerManRadioButton.Name = "registerManRadioButton";
            this.registerManRadioButton.Size = new System.Drawing.Size(50, 19);
            this.registerManRadioButton.TabIndex = 0;
            this.registerManRadioButton.TabStop = true;
            this.registerManRadioButton.Text = "Чол.";
            this.registerManRadioButton.UseVisualStyleBackColor = true;
            this.registerManRadioButton.CheckedChanged += new System.EventHandler(this.registerManRadioButton_CheckedChanged);
            // 
            // registerDateTimePicker
            // 
            this.registerDateTimePicker.Location = new System.Drawing.Point(12, 13);
            this.registerDateTimePicker.Name = "registerDateTimePicker";
            this.registerDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.registerDateTimePicker.TabIndex = 0;
            // 
            // registerPanel3
            // 
            this.registerPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.registerPanel3.Controls.Add(this.registerLoginTextBox);
            this.registerPanel3.Controls.Add(this.nextButton3);
            this.registerPanel3.Location = new System.Drawing.Point(9, 339);
            this.registerPanel3.Name = "registerPanel3";
            this.registerPanel3.Size = new System.Drawing.Size(251, 100);
            this.registerPanel3.TabIndex = 3;
            this.registerPanel3.Visible = false;
            this.registerPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel3_Paint);
            // 
            // registerLoginTextBox
            // 
            this.registerLoginTextBox.Location = new System.Drawing.Point(3, 21);
            this.registerLoginTextBox.Name = "registerLoginTextBox";
            this.registerLoginTextBox.PlaceholderText = "Логін (адреса електронної пошти)";
            this.registerLoginTextBox.Size = new System.Drawing.Size(222, 23);
            this.registerLoginTextBox.TabIndex = 1;
            this.registerLoginTextBox.TextChanged += new System.EventHandler(this.registerLoginTextBox_TextChanged);
            // 
            // nextButton3
            // 
            this.nextButton3.Location = new System.Drawing.Point(141, 74);
            this.nextButton3.Name = "nextButton3";
            this.nextButton3.Size = new System.Drawing.Size(75, 23);
            this.nextButton3.TabIndex = 0;
            this.nextButton3.Text = "Далі";
            this.nextButton3.UseVisualStyleBackColor = true;
            this.nextButton3.Click += new System.EventHandler(this.nextButton3_Click);
            // 
            // registerPanel4
            // 
            this.registerPanel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registerPanel4.Controls.Add(this.registerPasswordTextBox);
            this.registerPanel4.Controls.Add(this.nextButton4);
            this.registerPanel4.Location = new System.Drawing.Point(278, 339);
            this.registerPanel4.Name = "registerPanel4";
            this.registerPanel4.Size = new System.Drawing.Size(251, 100);
            this.registerPanel4.TabIndex = 4;
            this.registerPanel4.Visible = false;
            this.registerPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel4_Paint);
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(3, 17);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PlaceholderText = "Пароль";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(222, 23);
            this.registerPasswordTextBox.TabIndex = 1;
            this.registerPasswordTextBox.TextChanged += new System.EventHandler(this.registerPasswordTextBox_TextChanged);
            // 
            // nextButton4
            // 
            this.nextButton4.Location = new System.Drawing.Point(113, 62);
            this.nextButton4.Name = "nextButton4";
            this.nextButton4.Size = new System.Drawing.Size(75, 23);
            this.nextButton4.TabIndex = 0;
            this.nextButton4.Text = "Далі";
            this.nextButton4.UseVisualStyleBackColor = true;
            this.nextButton4.Click += new System.EventHandler(this.nextButton4_Click);
            // 
            // registerPanel5
            // 
            this.registerPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerPanel5.Controls.Add(this.registerPhoneTextBox);
            this.registerPanel5.Controls.Add(this.nextButton5);
            this.registerPanel5.Location = new System.Drawing.Point(541, 339);
            this.registerPanel5.Name = "registerPanel5";
            this.registerPanel5.Size = new System.Drawing.Size(251, 100);
            this.registerPanel5.TabIndex = 5;
            this.registerPanel5.Visible = false;
            this.registerPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPanel5_Paint);
            // 
            // registerPhoneTextBox
            // 
            this.registerPhoneTextBox.Location = new System.Drawing.Point(3, 17);
            this.registerPhoneTextBox.Name = "registerPhoneTextBox";
            this.registerPhoneTextBox.PlaceholderText = "Номер телефону";
            this.registerPhoneTextBox.Size = new System.Drawing.Size(222, 23);
            this.registerPhoneTextBox.TabIndex = 1;
            this.registerPhoneTextBox.TextChanged += new System.EventHandler(this.registerPhoneTextBox_TextChanged);
            // 
            // nextButton5
            // 
            this.nextButton5.Location = new System.Drawing.Point(122, 74);
            this.nextButton5.Name = "nextButton5";
            this.nextButton5.Size = new System.Drawing.Size(75, 23);
            this.nextButton5.TabIndex = 0;
            this.nextButton5.Text = "Далі";
            this.nextButton5.UseVisualStyleBackColor = true;
            this.nextButton5.Click += new System.EventHandler(this.nextButton5_Click);
            // 
            // privacyAndTermsPanel
            // 
            this.privacyAndTermsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.privacyAndTermsPanel.Controls.Add(this.endRegisterButton);
            this.privacyAndTermsPanel.Controls.Add(this.privacyAndTermsLinkLabel);
            this.privacyAndTermsPanel.Controls.Add(this.privacyAndTermsLabel1);
            this.privacyAndTermsPanel.Controls.Add(this.privacyAndTermsLabel2);
            this.privacyAndTermsPanel.Location = new System.Drawing.Point(278, 134);
            this.privacyAndTermsPanel.Name = "privacyAndTermsPanel";
            this.privacyAndTermsPanel.Size = new System.Drawing.Size(364, 156);
            this.privacyAndTermsPanel.TabIndex = 6;
            this.privacyAndTermsPanel.Visible = false;
            // 
            // endRegisterButton
            // 
            this.endRegisterButton.Location = new System.Drawing.Point(141, 118);
            this.endRegisterButton.Name = "endRegisterButton";
            this.endRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.endRegisterButton.TabIndex = 3;
            this.endRegisterButton.Text = "Прийняти";
            this.endRegisterButton.UseVisualStyleBackColor = true;
            this.endRegisterButton.Click += new System.EventHandler(this.endRegisterButton_Click);
            // 
            // privacyAndTermsLinkLabel
            // 
            this.privacyAndTermsLinkLabel.AutoSize = true;
            this.privacyAndTermsLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.privacyAndTermsLinkLabel.Location = new System.Drawing.Point(82, 84);
            this.privacyAndTermsLinkLabel.Name = "privacyAndTermsLinkLabel";
            this.privacyAndTermsLinkLabel.Size = new System.Drawing.Size(195, 17);
            this.privacyAndTermsLinkLabel.TabIndex = 2;
            this.privacyAndTermsLinkLabel.TabStop = true;
            this.privacyAndTermsLinkLabel.Text = "Загальні положення та умови";
            this.privacyAndTermsLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // privacyAndTermsLabel1
            // 
            this.privacyAndTermsLabel1.AutoSize = true;
            this.privacyAndTermsLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.privacyAndTermsLabel1.Location = new System.Drawing.Point(82, 15);
            this.privacyAndTermsLabel1.Name = "privacyAndTermsLabel1";
            this.privacyAndTermsLabel1.Size = new System.Drawing.Size(214, 21);
            this.privacyAndTermsLabel1.TabIndex = 0;
            this.privacyAndTermsLabel1.Text = "Конфіденційність і умови";
            this.privacyAndTermsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // privacyAndTermsLabel2
            // 
            this.privacyAndTermsLabel2.AutoSize = true;
            this.privacyAndTermsLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.privacyAndTermsLabel2.Location = new System.Drawing.Point(32, 50);
            this.privacyAndTermsLabel2.Name = "privacyAndTermsLabel2";
            this.privacyAndTermsLabel2.Size = new System.Drawing.Size(316, 34);
            this.privacyAndTermsLabel2.TabIndex = 1;
            this.privacyAndTermsLabel2.Text = "Щоб створити обліковий запис EcoITTechnology, \r\nпотрібно прийняти\r\n";
            this.privacyAndTermsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton2
            // 
            this.loginButton2.AllowDrop = true;
            this.loginButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton2.Location = new System.Drawing.Point(717, 12);
            this.loginButton2.Name = "loginButton2";
            this.loginButton2.Size = new System.Drawing.Size(75, 23);
            this.loginButton2.TabIndex = 7;
            this.loginButton2.Text = "Вхід";
            this.loginButton2.UseVisualStyleBackColor = true;
            this.loginButton2.Click += new System.EventHandler(this.loginButton2_Click);
            // 
            // RegisterForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.loginButton2);
            this.Controls.Add(this.privacyAndTermsPanel);
            this.Controls.Add(this.registerPanel5);
            this.Controls.Add(this.registerPanel4);
            this.Controls.Add(this.registerPanel3);
            this.Controls.Add(this.registerPanel2);
            this.Controls.Add(this.registerPanel1);
            this.Name = "RegisterForm1";
            this.Text = "RegisterForm1";
            this.Load += new System.EventHandler(this.RegisterForm1_Load);
            this.registerPanel1.ResumeLayout(false);
            this.registerPanel1.PerformLayout();
            this.registerPanel2.ResumeLayout(false);
            this.registerSexGroupBox.ResumeLayout(false);
            this.registerSexGroupBox.PerformLayout();
            this.registerPanel3.ResumeLayout(false);
            this.registerPanel3.PerformLayout();
            this.registerPanel4.ResumeLayout(false);
            this.registerPanel4.PerformLayout();
            this.registerPanel5.ResumeLayout(false);
            this.registerPanel5.PerformLayout();
            this.privacyAndTermsPanel.ResumeLayout(false);
            this.privacyAndTermsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public TextBox registerNameTextBox;
        public TextBox registerSurnameTextBox;
        public DateTimePicker registerDateTimePicker;
        public RadioButton registerWomanRadioButton;
        public RadioButton registerManRadioButton;
        public TextBox registerLoginTextBox;
        public TextBox registerPasswordTextBox;
        public TextBox registerPhoneTextBox;

        private GroupBox registerSexGroupBox;

        private Button nextButton1;
        private Button nextButton2;
        private Button nextButton3;
        private Button nextButton4;
        private Button nextButton5;

        private Panel registerPanel1;
        private Panel registerPanel2;
        private Panel registerPanel3;
        private Panel registerPanel4;
        private Panel registerPanel5;
        private Panel privacyAndTermsPanel;
        private Label privacyAndTermsLabel2;
        private Label privacyAndTermsLabel1;
        private LinkLabel privacyAndTermsLinkLabel;
        private Button endRegisterButton;
        private Button loginButton2;
    }
}