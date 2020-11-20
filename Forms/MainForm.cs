using e_library.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace e_library
{
    public partial class MainForm : Form
    {
        private List<ReaderForm> ReaderForms = new List<ReaderForm>();
        private int border;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            string filetext = System.IO.File.ReadAllText(filename);
            CreateNewReader(filename, filename, filetext);
        }

        private void CreateNewReader(string filename, string path, string text)
        {
            ReaderForm form = new ReaderForm(filename, path, text, this);
            ReaderForms.Add(form);
            form.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            border = CollectionBooks.Width;
        }
    }
}
