using e_library.Model;
using System.Drawing;
using System.Windows.Forms;

namespace e_library.Forms
{
    public partial class ReaderForm : Form
    {

        public ReaderForm(string filename, string text, Form parent)
        {
            InitializeComponent();
            Text = filename;
            TextBox.Text = text;
            MdiParent = parent;
        }

        private void ReaderForm_Activated(object sender, System.EventArgs e)
        {
            Registrator.CurrFormChanged(this);
        }

        private void ReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
