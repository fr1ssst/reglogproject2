namespace LoginRegisterFormsApp.Login
{
    partial class LoginForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.loginUserWriteTextBox = new System.Windows.Forms.TextBox();
            this.passwordUserWriteTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.showHideCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(717, 12);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Реєстрація";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginUserWriteTextBox
            // 
            this.loginUserWriteTextBox.Location = new System.Drawing.Point(306, 174);
            this.loginUserWriteTextBox.Name = "loginUserWriteTextBox";
            this.loginUserWriteTextBox.PlaceholderText = "Логін (адреса електронної пошти)";
            this.loginUserWriteTextBox.Size = new System.Drawing.Size(222, 23);
            this.loginUserWriteTextBox.TabIndex = 1;
            this.loginUserWriteTextBox.TextChanged += new System.EventHandler(this.loginUserWriteTextBox_TextChanged);
            // 
            // passwordUserWriteTextBox
            // 
            this.passwordUserWriteTextBox.Location = new System.Drawing.Point(306, 203);
            this.passwordUserWriteTextBox.Name = "passwordUserWriteTextBox";
            this.passwordUserWriteTextBox.PlaceholderText = "Пароль";
            this.passwordUserWriteTextBox.Size = new System.Drawing.Size(222, 23);
            this.passwordUserWriteTextBox.TabIndex = 2;
            this.passwordUserWriteTextBox.UseSystemPasswordChar = true;
            this.passwordUserWriteTextBox.TextChanged += new System.EventHandler(this.passwordUserWriteTextBox_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(382, 232);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Вхід";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // showHideCheckBox
            // 
            this.showHideCheckBox.AutoSize = true;
            this.showHideCheckBox.Location = new System.Drawing.Point(534, 207);
            this.showHideCheckBox.Name = "showHideCheckBox";
            this.showHideCheckBox.Size = new System.Drawing.Size(15, 14);
            this.showHideCheckBox.TabIndex = 4;
            this.showHideCheckBox.UseVisualStyleBackColor = true;
            this.showHideCheckBox.CheckedChanged += new System.EventHandler(this.showHideCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.showHideCheckBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordUserWriteTextBox);
            this.Controls.Add(this.loginUserWriteTextBox);
            this.Controls.Add(this.registerButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button registerButton;
        private TextBox loginUserWriteTextBox;
        private TextBox passwordUserWriteTextBox;
        private Button loginButton;
        private CheckBox showHideCheckBox;
    }
}