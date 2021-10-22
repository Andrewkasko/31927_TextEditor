using _31927_TextEditor.Interface;
using _31927_TextEditor.Model;
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
    public partial class CreateUserScreen : Form
    {

        public UserRepository userRepository { get; set; }
        public CreateUserScreen()
        {
            InitializeComponent();
            userRepository = new UserRepository();
            
        }

     

        private void backBtn_Click(object sender, EventArgs e)
        {
            var loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
                if ((UsernameTxtbox.Text != "" && UsernameTxtbox.Text != null) &&
                (PasswordTxtbox.Text != "" && PasswordTxtbox.Text != null) &&
                (FirstNameTxtbox.Text != "" && FirstNameTxtbox.Text != null) &&
                (LastNameTxtbox.Text != "" && LastNameTxtbox.Text != null) &&
                (UserTypeList.Text != "" && UserTypeList.Text != null) &&
                (DOBDatePicker.Text != "" && DOBDatePicker.Text != null) &&
                (PasswordTxtbox.Text == ConfirmPasswordTxtbox.Text))
            {
                var newUser = new UserModel();
                newUser.Username = UsernameTxtbox.Text;
                newUser.Password = PasswordTxtbox.Text;
                newUser.FirstName = FirstNameTxtbox.Text;
                newUser.LastName = LastNameTxtbox.Text;
                newUser.Permission = UserTypeList.Text;
                newUser.DOB = DOBDatePicker.Text;

                bool created = userRepository.CreateUser(newUser);
                if (created)
                {
                    MessageBox.Show("User has been created successfully", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var loginScreen = new LoginScreen();
                    loginScreen.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Username already exists", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {

                MessageBox.Show("Please fill in all fields, and make sure the Password and Confirm Password match!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    
    }
}
