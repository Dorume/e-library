using System.Windows.Forms;

namespace e_library.Forms
{
    public partial class ReaderForm : Form
    {
        public bool IsReadOnly
        { 
            get => TextBox.ReadOnly; 
            set => TextBox.ReadOnly = value; 
        }

        public string Path { get; }


        public ReaderForm(string filename, string path, string text, Form parent)
        {
            InitializeComponent();
            Text = filename;
            Path = path;
            TextBox.Text = text;
            MdiParent = parent;
            Dock = DockStyle.Fill;
           
        }
    }
}
