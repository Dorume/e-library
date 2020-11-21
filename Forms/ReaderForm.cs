using System.Drawing;
using System.Windows.Forms;

namespace e_library.Forms
{
    public partial class ReaderForm : Form
    {
        private readonly MainForm MainParent;
        private Point LastLeftPoint;

        public ReaderForm(string filename, string text, MainForm parent)
        {
            InitializeComponent();
            Text = filename;
            TextBox.Text = text;
            MdiParent = parent;
            MainParent = parent;
            MaximumSize = MainParent.MaxSize;
            parent.SizeChanged += Parent_SizeChanged;
            LastLeftPoint = Location;
        }

        private void Parent_SizeChanged(object sender, System.EventArgs e)
        {
            MaximumSize = MainParent.MaxSize;
        }

        private void ReaderForm_Move(object sender, System.EventArgs e)
        {

        }
    }
}
