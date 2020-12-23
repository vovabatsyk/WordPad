using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleWordPad
{
    public partial class MainForm : Form
    {
        private string appName = " | WordPad 2020";
        private bool isFileExist;
        private bool isFileChanged;
        private string currentFileName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutTextEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tText Editor\nCreated by Volodymyr Batsyk\n\tLviv 2020", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Do you wont to save your changes?", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveFile();
                        ClearEditor();
                        break;
                    case DialogResult.No:
                        ClearEditor();
                        break;
                }

            }
            else
            {
                ClearEditor();
            }



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                    RichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

                if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                    RichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                this.Text = Path.GetFileName(openFileDialog.FileName) + appName;

                isFileExist = true;
                isFileChanged = false;
                currentFileName = openFileDialog.FileName;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (isFileExist)
            {
                if (Path.GetExtension(currentFileName) == ".txt")
                    RichTextBox.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);

                if (Path.GetExtension(currentFileName) == ".rtf")
                    RichTextBox.SaveFile(currentFileName, RichTextBoxStreamType.RichText);

                isFileChanged = false;
            }
            else
            {
                if (isFileChanged)
                {
                    SaveAsFile();
                }
                else
                {
                    ClearEditor();
                }
            }
        }

        private void ClearEditor()
        {
            RichTextBox.Clear();
            this.Text = "Untitled" + appName;
            isFileChanged = false;
            isFileExist = false;
            currentFileName = "";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void SaveAsFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                    RichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);

                if (Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                    RichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                this.Text = Path.GetFileName(saveFileDialog.FileName) + appName;

                isFileExist = true;
                isFileChanged = false;
                currentFileName = saveFileDialog.FileName;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            isFileExist = false;
            isFileChanged = false;
            currentFileName = "";
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            isFileChanged = true;
        }
    }
}
