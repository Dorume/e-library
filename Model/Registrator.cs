using e_library.Forms;
using e_library.Serialize;
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

        #region Методи збереження
        public static void Save(ListView listView)
        {
            TextFiles files = new TextFiles();

            foreach (ListViewItem item in listView.Items)
            {
                files.FilesList.Add((TextFile)item.Tag);
            }
            SerializeXML(files);
        }

        private static void SerializeXML(TextFiles files)
        {
            XmlSerializer xml = new XmlSerializer(typeof(TextFiles));

            using (FileStream fs = new FileStream("TextFiles.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, files);
            };
        }

        public static IEnumerable<ListViewItem> Load()
        {
            TextFiles files = DeserializeXML();
            foreach (TextFile file in files.FilesList)
            {
                ListViewItem item = new ListViewItem(file.Filename)
                {
                    Tag = file
                };
                yield return item;
            }
        }

        private static TextFiles DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(TextFiles));

            using (FileStream fs = new FileStream("TextFiles.xml", FileMode.OpenOrCreate))
            {
                return (TextFiles)xml.Deserialize(fs);
            };
        }
        #endregion
    }
}
