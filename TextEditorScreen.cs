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
    public partial class TextEditorScreen : Form
    {
        public TextEditorScreen()
        {
            InitializeComponent();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            var aboutScreen = new AboutScreen();
            aboutScreen.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            var loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox.SelectedText);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox.SelectedText);
        }

        private void toolStripPaste_Click(object sender, EventArgs e)
        {
        }
    }
}
