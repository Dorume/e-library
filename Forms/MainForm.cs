using e_library.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace e_library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            FormRegistrator.AddForm(openFileDialog, this);
            RefreshCollectionOFBooks();
        }

        private void RefreshCollectionOFBooks()
        {
            CollectionBooks.Items.Clear();
            CollectionBooks.DataSource = FormRegistrator.Filenames;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormRegistrator.Save();
        }
    }
}
