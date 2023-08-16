using LoginRegisterFormsApp.Register;
using MySql.Data.MySqlClient;
using System.Data;
using LoginRegisterFormsApp;

namespace LoginRegisterFormsApp.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm1 registerForm1 = new RegisterForm1();
            Hide();
            registerForm1.ShowDialog();
            Close();
        }

        private void loginUserWriteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordUserWriteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            GetHashedPassword getHashedPassword = new GetHashedPassword();
            MenuForm menuForm = new MenuForm();

            string loginUser = loginUserWriteTextBox.Text;
            string passwordUser = passwordUserWriteTextBox.Text;

            string hashedPasswordFromDatabase = getHashedPassword.GetHashedPasswordFromDatabase(loginUser);

            if (!string.IsNullOrEmpty(hashedPasswordFromDatabase))
            {
                bool passwordMatches = BCrypt.Net.BCrypt.Verify(passwordUser, hashedPasswordFromDatabase);

                if (passwordMatches)
                {
                    MessageBox.Show("Вхід виконано успішно.");
                    Hide();
                    menuForm.UserInfo(loginUser);
                    menuForm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Пароль невірний.");
                }
            }
            else
            {
                MessageBox.Show("Користувача з таким ім'ям не знайдено.");
            }
            dataBase.closedConnection();
        }

        private void showHideCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordUserWriteTextBox.UseSystemPasswordChar = !showHideCheckBox.Checked;
        }
    }
}
