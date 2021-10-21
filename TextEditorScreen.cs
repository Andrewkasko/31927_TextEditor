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
        public bool Disable { get; set; }
        public string Username { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public int FontSize { get; set; }


        public TextEditorScreen(bool disable, string username)
        {
            Disable = disable;
            Username = username;
            InitializeComponent();
            DisableControls();
            InitialSetup();

        }

        private void InitialSetup() {
            UserNameLabel.Text = UserNameLabel.Text + Username;
            Bold = false;
            Italic = false;
            Underline = false;
            FontSize = 12;
            textArea.SelectionFont = new Font(textArea.SelectionFont.ToString(), 12, textArea.SelectionFont.Style);
        }

        private void DisableControls() {
            if (Disable == true) {
                toolStripNewDoc.Enabled = false;
                newToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                toolStripNewDoc.Enabled = false;
                toolStripSave.Enabled = false;
                toolStripSaveAs.Enabled = false;
                toolStripUnderline.Enabled = false;
                toolStripItalic.Enabled = false;
                toolStripBold.Enabled = false;
                ChangeFont.Enabled = false;
                toolStripFontComboBox.Enabled = false;
                toolStripButtonCutBtn.Enabled = false;
                toolStripPaste.Enabled = false;
                toolStripCopy.Enabled = false;
                textArea.ReadOnly = true;
            }

        }

        public void DisplayAboutScreen() {
            var aboutScreen = new AboutScreen(Disable, Username);
            aboutScreen.Show();
            this.Hide();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            DisplayAboutScreen();
        }


        public void Logout() {
            var loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void toolStripCopy_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        public void CutText()
        {
            // Ensure that text is currently selected in the text box.   
            if (textArea.SelectedText != "")
            {
                // Cut the selected text in the control and paste it into the Clipboard.
                textArea.Cut();
            }   
        }


        public void CopyText()
        {
            // Ensure that text is currently selected in the text box.   
            if (textArea.SelectedText != "")
            {
                // Copy the selected text in the control and paste it into the Clipboard.
                textArea.Copy();
            }
        }

        public void PasteText()
        {
            // Copy the selected text in the control and paste it into the Clipboard.
            textArea.Paste();
        }

        private void toolStripPaste_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        public void OpenFile() {
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
                    MessageBox.Show("The File has loaded successfully", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception obj)
                {
                    MessageBox.Show(obj.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        public void NewDocument() {

            if (textArea.Text == "" || textArea.Text == null) {
                MessageBox.Show("New Document Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Please make sure you have saved your work!", "Have you saved?", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)
                {
                    //do something
                    textArea.Text = "";
                }

            }
        }

        public void ChangeFontDialog() {
            FontDialog fontDialog = new FontDialog();

            DialogResult dr = fontDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {

                string fontName;
                FontStyle fontStyle;
                float fontSize;

                //textArea.Font.Style = fontDialog.Font.Name;

                fontName = fontDialog.Font.Name;
                fontStyle = fontDialog.Font.Style;
                fontSize = fontDialog.Font.Size;

                MessageBox.Show("Fontname: " + fontName + "\nFontStyle: " + fontStyle.ToString() + "\nFont Size: " + fontSize.ToString(), "Font Changed");

                textArea.SelectionFont = new Font(fontDialog.Font.Name, fontDialog.Font.Size, fontDialog.Font.Style);
            }

        }

        private void changeFont_Click(object sender, EventArgs e)
        {
            ChangeFontDialog();
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            //textArea.Font = 20;
        }

        public void LoadFile() {
            OpenFile();
        }

        public void SaveAsRTF() {
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
                MessageBox.Show("File saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsRTF();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void toolStripButtonCutBtn_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void toolStripNewDoc_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        

        private void ChangeFont_Click_1(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            DialogResult dr = fontDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {

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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAboutScreen();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBold_Click(object sender, EventArgs e)
        {
            if (Bold == false)
            {
                Bold = true;
                toolStripBold.Checked = true;
                textArea.SelectionFont = new Font(textArea.SelectionFont, FontStyle.Bold);
            }
            else {
                Bold = false;
                toolStripBold.Checked = false;
                textArea.SelectionFont = new Font(textArea.SelectionFont, FontStyle.Regular);
            }
        }

        private void toolStripItalic_Click(object sender, EventArgs e)
        {
            if (Italic == false)
            {
                Italic = true;
                toolStripItalic.Checked = true;
                textArea.SelectionFont = new Font(textArea.SelectionFont, FontStyle.Italic);
            }
            else
            {
                Italic = false;
                toolStripItalic.Checked = false;
                textArea.SelectionFont = new Font(textArea.SelectionFont, FontStyle.Regular);
            }
        }

        private void toolStripUnderline_Click(object sender, EventArgs e)
        {
            if (Underline == false)
            {
                Underline = true;
                toolStripUnderline.Checked = true;
                textArea.SelectionFont = new Font(textArea.SelectionFont, FontStyle.Underline);
            }
            else
            {
                Underline = false;
                toolStripUnderline.Checked = false;
                textArea.SelectionFont = new Font(textArea.SelectionFont, FontStyle.Regular);
            }
        }

        private void toolStripFontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fontSize = Int32.Parse(toolStripFontComboBox.Text);
            textArea.SelectionFont = new Font(textArea.SelectionFont.ToString(), fontSize, textArea.SelectionFont.Style);
        }
    }
}
