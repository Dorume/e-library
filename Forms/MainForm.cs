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
            MainModel.MainForm = this;
        }

        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

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
    }
}
