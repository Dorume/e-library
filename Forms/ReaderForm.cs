using System.Windows.Forms;

namespace e_library.Forms
{
    public partial class ReaderForm : Form
    {
        public bool IsReadOnly { get => TextBox.ReadOnly; set => TextBox.ReadOnly = value; }

        public ReaderForm()
        {
            InitializeComponent();
        }
    }
}
