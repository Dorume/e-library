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


        private void ReaderForm_Move(object sender, System.EventArgs e)
        {

        }
    }
}
