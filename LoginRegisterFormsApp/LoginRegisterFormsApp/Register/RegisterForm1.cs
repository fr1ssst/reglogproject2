using LoginRegisterFormsApp.Login;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterFormsApp.Register
{
    public partial class RegisterForm1 : Form
    {
        DifferentComponents differentComponents = new DifferentComponents();
        LoginForm loginForm = new LoginForm();

        public DateTime selectedDate;
        public string nameInput = "";
        public string surnameInput = "";
        public string userChoice = "";
        public string loginInput = "";
        public string passwordInput = "";
        public int phoneInput = 0;
        public RegisterForm1()
        {
            InitializeComponent();
        }

        private void RegisterForm1_Load(object sender, EventArgs e)
        {

        }      
        ///
        /// Button
        ///  
        private void nextButton1_Click(object sender, EventArgs e)
        {
            if (differentComponents.IsTextBoxEmptyOrWhiteSpace(registerNameTextBox))
            {
                MessageBox.Show("Текст в одному з полів відсутній.");
            }
            else if (differentComponents.TextBoxContainsSpace(registerNameTextBox))
            {
                MessageBox.Show("Текст в одному з полів містить пробіли.");
            }
            else
            {
                nameInput = registerNameTextBox.Text;
                surnameInput = registerSurnameTextBox.Text;

                registerPanel1.Visible = false;
                registerPanel2.Visible = true;
            }
        }
        private void nextButton2_Click(object sender, EventArgs e)
        {
            if (!registerManRadioButton.Checked && !registerWomanRadioButton.Checked)
            {
                MessageBox.Show("Не вибрано жодного варіанту.");
            }
            else
            {
                /*int dayInput = (int)registerDayNumericUpDown.Value;
                int monthInput = (int)registerMonthNumericUpDown.Value;
                int yearInput = (int)registerYearNumericUpDown.Value;

                DateTime date1 = new DateTime(yearInput, monthInput, dayInput);
                DateTime dateOnly = date1.Date;*/
                selectedDate = registerDateTimePicker.Value;

                if (registerManRadioButton.Checked)
                {
                    userChoice = registerManRadioButton.Text;
                }
                else if (registerWomanRadioButton.Checked)
                {
                    userChoice = registerWomanRadioButton.Text;
                }
                else
                {
                    MessageBox.Show("Виберіть стать.");
                }
                registerPanel2.Visible = false;
                registerPanel3.Visible = true;
            }
        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lU", dataBase.getConnection());
            command.Parameters.Add("@lU", MySqlDbType.VarChar).Value = registerLoginTextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий логін уже існує, введіть інший!");
            }
            else
            {
                if (differentComponents.IsTextBoxEmptyOrWhiteSpace(registerLoginTextBox))
                {
                    MessageBox.Show("Текст в цьому полі відсутній.");
                }
                else if (differentComponents.TextBoxContainsSpace(registerLoginTextBox))
                {
                    MessageBox.Show("Текст в цьому полі містить пробіли.");
                }
                else
                {
                    loginInput = registerLoginTextBox.Text;

                    registerPanel3.Visible = false;
                    registerPanel4.Visible = true;
                }
            }
        }

        private void nextButton4_Click(object sender, EventArgs e)
        {
            if (differentComponents.IsTextBoxEmptyOrWhiteSpace(registerPasswordTextBox))
            {
                MessageBox.Show("Текст в цьому полі відсутній.");
            }
            else if (differentComponents.TextBoxContainsSpace(registerPasswordTextBox))
            {
                MessageBox.Show("Текст в цьому полі містить пробіли.");
            }
            else
            {
                registerPanel4.Visible = false;
                registerPanel5.Visible = true;
            }
        }

        private void nextButton5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(registerPhoneTextBox.Text, out int phoneInputSave))
            {
                phoneInput = phoneInputSave;
                registerPanel5.Visible = false;

                privacyAndTermsPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Невірний формат числа.");
            }
        }
        private void endRegisterButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            nameInput = registerNameTextBox.Text;
            surnameInput = registerSurnameTextBox.Text;
            loginInput = registerLoginTextBox.Text;
            passwordInput = registerPasswordTextBox.Text;

            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordInput, salt);

            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `dateOfBirth`, `sex`, `login`, `password`, `telephone`) VALUES (@namePlug, @surnamePlug, @dateOfBirthPlug, @sexPlug, @loginPlug, @passwordPlug, @telephonePlug);", dataBase.getConnection());

            mySqlCommand.Parameters.AddWithValue("@namePlug", nameInput);
            mySqlCommand.Parameters.AddWithValue("@surnamePlug", surnameInput);

            if (registerManRadioButton.Checked)
            {
                mySqlCommand.Parameters.AddWithValue("@sexPlug", userChoice);
            }
            else if (registerWomanRadioButton.Checked)
            {
                mySqlCommand.Parameters.AddWithValue("@sexPlug", userChoice);
            }

            mySqlCommand.Parameters.Add("@dateOfBirthPlug", MySqlDbType.Date).Value = registerDateTimePicker.Value;
            mySqlCommand.Parameters.AddWithValue("@loginPlug", loginInput);
            mySqlCommand.Parameters.AddWithValue("@passwordPlug", hashedPassword);
            mySqlCommand.Parameters.Add("@telephonePlug", MySqlDbType.Int32).Value = registerPhoneTextBox.Text;

            dataBase.openConnection();

            privacyAndTermsPanel.Visible = false;
            loginButton2.Visible = false;

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Реєстрація була успішною!");
                Hide();
                loginForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Реєстрація була не виконана!");
                return;
            }

            dataBase.closedConnection();
        }
        ///
        /// TextBox
        /// 
        public void registerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void registerSurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void registerLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void registerPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void registerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        ///
        /// RadioButton
        /// 
        private void registerManRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void registerWomanRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        ///
        /// GroupBox
        ///       
        private void registerSexGroupBox_Enter(object sender, EventArgs e)
        {

        }
        ///
        /// Panel
        /// 
        private void registerPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void registerPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void registerPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void registerPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void registerPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
        ///
        ///
        ///
        ///
        ///
        private void loginButton2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
            Close();
        }
    }
}
