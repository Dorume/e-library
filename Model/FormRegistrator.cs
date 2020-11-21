using e_library.Forms;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace e_library.Model
{
    static class FormRegistrator
    {
        private static List<ReaderForm> Forms { get; set; } = new List<ReaderForm>();
        public static List<string> Filenames { get; private set; } = new List<string>();
        public static List<string> Pathes { get; private set; } = new List<string>();

        static FormRegistrator()
        {
            Parse(XmlHandler.Load());
        }
        public static void AddForm(OpenFileDialog open, Form sender)
        {
            string path = open.FileName;
            string filename = Path.GetFileNameWithoutExtension(path);
            string text = File.ReadAllText(path);

            if(!Filenames.Contains(path))
            {
                Pathes.Add(path);
                Filenames.Add(filename);
            }

            ReaderForm form = new ReaderForm(filename, path, text, sender);
            Forms.Add(form);
            form.Show();
        }

        private static void Parse(FilesForSave saved)
        {
            foreach (var file in saved.Files)
            {
                Pathes.Add(file);
                Filenames.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        public static void Save() => XmlHandler.Save(new FilesForSave(Pathes));
    }
}
