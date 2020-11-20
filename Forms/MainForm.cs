using e_library.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace e_library
{
    public partial class MainForm : Form
    {
        private ReaderForm ActiveReaderForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CreateNewReaderForm();
        }

        private void CreateNewReaderForm()
        {
            ReaderForm readerForm = new ReaderForm()
            {
                Text = "Book",
                MdiParent = this,
                Dock = DockStyle.Fill,
            };
            readerForm.Show();
            ActiveReaderForm = readerForm;
        }

        private void CanEditToolStripMenuItem_Click(object sender, EventArgs e) => ActiveReaderForm.IsReadOnly = !CanEditToolStripMenuItem.Checked;
    }
}
