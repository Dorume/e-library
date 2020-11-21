using System.Drawing;
using System.Windows.Forms;

namespace e_library.Forms
{
    public partial class ReaderForm : Form
    {
        private readonly MainForm MainParent;
        public ReaderForm(string filename, string text, MainForm parent)
        {
            InitializeComponent();
            Text = filename;
            TextBox.Text = text;
            MdiParent = parent;
            MainParent = parent;
            MaximumSize = MainParent.MaxSize;
            parent.SizeChanged += Parent_SizeChanged;
        }

        private void Parent_SizeChanged(object sender, System.EventArgs e)
        {
            MaximumSize = MainParent.MaxSize;
        }

        private void ReaderForm_Move(object sender, System.EventArgs e)
        {
            if (this.Location.X <= MainParent.LeftPoint.X)
                Location = new Point(MainParent.LeftPoint.X, Location.Y);
        }
    }
}
