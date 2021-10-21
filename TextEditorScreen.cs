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
            Clipboard.SetText(textArea.SelectedText);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textArea.SelectedText);
        }

        private void toolStripPaste_Click(object sender, EventArgs e)
        {
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a Text File";
            ofd.Filter = "*.RTF | All Files(*.*)";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK) {
                string fileName = ofd.FileName;
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void changeFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            DialogResult dr = fontDialog.ShowDialog();

            if (dr == DialogResult.OK) {

                string fontName;
                FontStyle fontStyle;
                float fontSize;

                //textArea.Font.Style = fontDialog.Font.Name;

                fontName = fontDialog.Font.Name;
                fontStyle = fontDialog.Font.Style;
                fontSize = fontDialog.Font.Size;

                MessageBox.Show("Fontname: " + fontName + "\nFontStyle: " + fontStyle.ToString() + "\nFont Size: " + fontSize.ToString());

                textArea.SelectionFont = new Font(fontDialog.Font.Name, fontDialog.Font.Size, fontDialog.Font.Style);
            }

        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            //textArea.Font = 20;
        }
    }
}
