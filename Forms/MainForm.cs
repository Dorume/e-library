using e_library.Files;
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
            MainModel.MainForm = this;
            MainModel.HistoryChangedEvent += DisplayHistory;
        }

        private void DisplayHistory()
        {
            LastFilesToolStripMenuItem.DropDownItems.Clear();
            TextFiles history = MainModel.History;
            List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();
            foreach (var item in history.FilesList)
            {
                ToolStripMenuItem menuitem = new ToolStripMenuItem(item.Path);
                menuitem.Click += HistoryItem_Click;
                menuItems.Add(menuitem);
            }
            LastFilesToolStripMenuItem.DropDownItems.AddRange(menuItems.ToArray());
        }

        private void HistoryItem_Click(object sender, EventArgs e)
        {
            MainModel.OpenFile(sender.ToString());
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainModel.OpenFile(openFileDialog);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainModel.FormClosing();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainModel.FormLoad();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Resources\E-LibraryHelp.chm");
        }

        private void CanEditToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            MainModel.CanEditchanged(CanEditToolStripMenuItem.Checked);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrator.SaveChanges();
        }
    }
}
