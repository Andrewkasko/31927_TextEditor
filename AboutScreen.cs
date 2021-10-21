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
    public partial class AboutScreen : Form
    {
        public bool Disable { get; set; }
        public string Username { get; set; }
        public AboutScreen(bool disable, string username)
        {
            InitializeComponent();
            Disable = disable;
            Username = username;
        }


        private void AboutScreen_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var textEditorScreen = new TextEditorScreen(Disable, Username);
            textEditorScreen.Show();
            this.Hide();
        }
    }
}
