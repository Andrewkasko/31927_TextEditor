using _31927_TextEditor.Interface;
using _31927_TextEditor.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31927_TextEditor
{
    public partial class LoginScreen : Form
    {

        public UserRepository userRepository { get; set; }

        public LoginScreen()
        {
            InitializeComponent();
            userRepository = new UserRepository();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string permission= userRepository.CheckPermission(UsernameTxtbox.Text, PasswordTxtbox.Text);
            bool disable;
            if (permission != "")
            {
                if (permission == "Edit")
                {
                    disable = false;
                }
                else 
                {
                    disable = true;
                }
                var textEditorScreen = new TextEditorScreen(disable, UsernameTxtbox.Text);
                textEditorScreen.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("The credentials that were entered are incorrect!", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            var createUserScreen = new CreateUserScreen();
            createUserScreen.Show();
            this.Hide();
        }

        private void ExitApplicationBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
