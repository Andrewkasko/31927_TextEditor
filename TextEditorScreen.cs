using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void LoadFile() {
                // Create an OpenFileDialog to request a file to open.
                OpenFileDialog openFile1 = new OpenFileDialog();

                // Initialize the OpenFileDialog to look for RTF files.
                openFile1.DefaultExt = "*.rtf";
                openFile1.Filter = "RTF Files|*.rtf";

                // Determine whether the user selected a file from the OpenFileDialog.
                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   openFile1.FileName.Length > 0)
                {
                // Load the contents of the file into the RichTextBox.
                try
                {
                    textArea.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
                }
                catch (Exception obj) {
                    MessageBox.Show(obj.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                textArea.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
    }
}
