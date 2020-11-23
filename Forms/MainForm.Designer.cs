namespace e_library
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.HelpProvider = new System.Windows.Forms.HelpProvider();
            this.Border = new System.Windows.Forms.Panel();
            this.fsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ReferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator2,
            this.LastFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "&Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "&Відкрити";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "&Зберегти";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LastFilesToolStripMenuItem
            // 
            this.LastFilesToolStripMenuItem.Name = "LastFilesToolStripMenuItem";
            this.LastFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LastFilesToolStripMenuItem.Text = "&Останні файли";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Ви&хід";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CanEditToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.EditToolStripMenuItem.Text = "&Правка";
            // 
            // CanEditToolStripMenuItem
            // 
            this.CanEditToolStripMenuItem.CheckOnClick = true;
            this.CanEditToolStripMenuItem.Name = "CanEditToolStripMenuItem";
            this.CanEditToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.CanEditToolStripMenuItem.Text = "Редагування";
            this.CanEditToolStripMenuItem.CheckedChanged += new System.EventHandler(this.CanEditToolStripMenuItem_CheckedChanged);
            // 
            // ReferencesToolStripMenuItem
            // 
            this.ReferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramToolStripMenuItem});
            this.ReferencesToolStripMenuItem.Name = "ReferencesToolStripMenuItem";
            this.ReferencesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ReferencesToolStripMenuItem.Text = "&Довідка";
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.AboutProgramToolStripMenuItem.Text = "Д&овідковий посібник";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text files(*.txt)|*.txt";
            this.openFileDialog.Title = "Оберіть файл";
            // 
            // HelpProvider
            // 
            this.HelpProvider.HelpNamespace = "Help.chm";
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.SystemColors.GrayText;
            this.Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Border.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Border.Location = new System.Drawing.Point(0, 24);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(784, 387);
            this.Border.TabIndex = 6;
            this.Border.Visible = false;
            // 
            // fsdfToolStripMenuItem
            // 
            this.fsdfToolStripMenuItem.Name = "fsdfToolStripMenuItem";
            this.fsdfToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = global::e_library.Properties.Resources.Icon;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 60);
            this.Name = "MainForm";
            this.Text = "E-Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CanEditToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.HelpProvider HelpProvider;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.ToolStripMenuItem LastFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fsdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

