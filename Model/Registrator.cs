using e_library.Files;
using e_library.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace e_library.Model
{
    static class Registrator
    {
        private static List<ReaderForm> Forms { get; set; } = new List<ReaderForm>();

        public static void AddForm(TextFile file, MainForm sender)
        {
            string text = File.ReadAllText(file.Path);
            ReaderForm form = new ReaderForm(file.Filename, text, sender);
            form.Show();
            Forms.Add(form);
        }
    }
}
