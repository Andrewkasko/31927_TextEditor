﻿using _31927_TextEditor.Interface;
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
        

        public LoginScreen()
        {
            InitializeComponent();

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
            var textEditorScreen = new TextEditorScreen();

            textEditorScreen.Show();
            this.Hide();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            var createUserScreen = new CreateUserScreen();
            createUserScreen.Show();
            this.Hide();
        }
    }
}
