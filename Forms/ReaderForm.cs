using e_library.Model;
using System.Drawing;
using System.Windows.Forms;

namespace e_library.Forms
{
    public partial class ReaderForm : Form
    {
        private readonly string Path;
        private readonly string FileText;

        public ReaderForm(string filename, string path, string text, bool checkMode, Form parent)
        {
            InitializeComponent();
            Text = filename;
            Path = path;
            TextBox.Text = text;
            FileText = text;
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
                if (result == DialogResult.Cancel)
                {
                   e.Cancel = true;
                   return;
                }
            }
        }

        private DialogResult DisplayTextChangedDialog()
        {
            return MessageBox.Show($"Зберегти зміни в файлі '{Text}'?", Text,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
