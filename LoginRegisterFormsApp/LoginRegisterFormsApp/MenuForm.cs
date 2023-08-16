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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginRegisterFormsApp
{
    public partial class MenuForm : Form
    {
        private string userIdInformation = "";
        private string userNameInformation = "";
        private string userSurnameInformation = "";
        private string userDateInformation = "";
        private string userSexInformation = "";
        private string userLoginInformation = "";
        private string userPasswordInformation = "";
        private string userPhoneInformation = "";

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
        public void UserInfo(string loginUser)
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @l", dataBase.getConnection());
            command.Parameters.AddWithValue("@l", loginUser);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                userIdInformation = $"{reader.GetInt32("id")}";
                userNameInformation = $"{reader.GetString("name")}";
                userSurnameInformation = $"{reader.GetString("surname")}";
                userDateInformation = $"{reader.GetMySqlDateTime("dateOfBirth")}";
                userSexInformation = $"{reader.GetString("sex")}";
                userLoginInformation = $"{reader.GetString("login")}";
                userPhoneInformation = $"{reader.GetInt32("telephone")}";
                userPasswordInformation = $"********";

                userIdInformationLabel.Text = userIdInformation;
                userNameInformationLabel.Text = userNameInformation;
                userSurnameInformationLabel.Text = userSurnameInformation;
                userDateInformationLabel.Text = userDateInformation;
                userSexInformationLabel.Text = userSexInformation;
                userLoginInformationLabel.Text = userLoginInformation;
                userPhoneInformationLabel.Text = userPhoneInformation;
                userPasswordInformationLabel.Text = userPasswordInformation;              
            }
            dataBase.closedConnection();
        }

        private void changeTabsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void nameButtonNext_Click(object sender, EventArgs e)
        {
            userNameTextBox.ReadOnly = false;
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            userNameTextBox.ReadOnly = true;
        }

        private void userPasswordInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void userSexInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void userPhoneInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void userLoginInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void userDateInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void BasicInformationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void surnameButtonNext_Click(object sender, EventArgs e)
        {

        }

        private void saveButton2_Click(object sender, EventArgs e)
        {
            userSurnameTextBox.ReadOnly = true;
        }

        private void tabsRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userIdInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameChangeButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.ReadOnly = false;
        }

        private void surnameChangeButton_Click(object sender, EventArgs e)
        {
            userSurnameTextBox.ReadOnly = false;
        }
    }
}
