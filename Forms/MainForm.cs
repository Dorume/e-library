using e_library.Model;
using e_library.Serialize;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace e_library
{
    public partial class MainForm : Form
    {
        public Size MaxSize { get; set; }
        public Point LeftPoint { get; set; }

        public MainForm()
        {
            InitializeComponent();
            NewMaxSize();
        }

        private void NewMaxSize()
        {
            MaxSize = Border.Size;
            LeftPoint = PointToClient(Border.Location);
        }

        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            TextFile file = new TextFile(openFileDialog);
            ListViewItem item = new ListViewItem(file.Filename)
            {
                Tag = file
            };
            CollectionOfFiles.Items.Add(item);
            Registrator.AddForm(file, this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Registrator.Save(CollectionOfFiles);
        }
        private void CollectionOfFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CollectionOfFiles.SelectedItems.Count == 1)
            {
                TextFile file = (TextFile)CollectionOfFiles.SelectedItems[0].Tag;
                Registrator.AddForm(file, this);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Registrator.Load())
            {
                CollectionOfFiles.Items.Add(item);
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            NewMaxSize();
        }
    }
}
