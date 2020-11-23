using e_library.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace e_library.Forms
{
    public partial class ReaderForm : Form
    {
        public readonly string Filename;
        public readonly string Path;
        public string FileText;
        public string NewText;

        public ReaderForm(string filename, string path, string text, bool checkMode, Form parent)
        {
            InitializeComponent();
            FileText = text;
            Text = filename;
            Filename = filename;
            Path = path;
            TextBox.Text = text;
            TextBox.ReadOnly = !checkMode;
            MdiParent = parent;
            Registrator.ModeChangedEvent += ModeChanged;
        }

        private void ModeChanged(bool checkMode)
        {
            TextBox.ReadOnly = !checkMode;
        }

        private void ReaderForm_Activated(object sender, System.EventArgs e)
        {
            Registrator.CurrFormChanged(this);
        }

        private void ReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(TextBox.Text != FileText)
            {
                DialogResult result = DisplayTextChangedDialog();
                if (result == DialogResult.Yes)
                {
                    NewText = TextBox.Text;
                    e.Cancel = !Registrator.CloseFormAndSave(this); //Save as
                }
                else if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
            Registrator.ModeChangedEvent -= this.ModeChanged;

        }

        private DialogResult DisplayTextChangedDialog()
        {
            return MessageBox.Show($"Зберегти зміни в файлі '{Text}'?", Text,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void TextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (TextBox.Text != FileText)
            {
                Text = Filename + "*";
            }
        }

        public void TextBoxInvokeChange()
        {
            TextBox.Text = FileText;
        }
    }
}
