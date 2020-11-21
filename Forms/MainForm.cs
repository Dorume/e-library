using e_library.Model;
using System;
using System.Windows.Forms;

namespace e_library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormRegistrator.SettingsChanged += RefreshCollectionOFBooks;
        }

        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            FormRegistrator.AddForm(openFileDialog, this);
        }

        public void RefreshCollectionOFBooks()
        {
            CollectionBooks.Items.Clear();
            var books = Properties.Settings.Default.SettingsKey;
            foreach (var book in books)
            {
                CollectionBooks.Items.Add(book.ToString());
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
