﻿using e_library.Forms;
using e_library.Serialize;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace e_library.Model
{
    static class Registrator
    {
        private static List<ReaderForm> Forms { get; set; } = new List<ReaderForm>();
        public static void AddForm(TextFile file, Form sender)
        {
            string text = File.ReadAllText(file.Path);
            ReaderForm form = new ReaderForm(file.Filename, file.Path, text, sender);
            form.Show();
            Forms.Add(form);
        }

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

            using (FileStream fs = new FileStream("Files.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, files);
            };
        }

        public static ListView Load()
        {
            ListView listView = new ListView();
            TextFiles files = DeserializeXML();
            foreach (TextFile file in files.FilesList)
            {
                ListViewItem item = new ListViewItem(file.Filename)
                {
                    Tag = file
                };
                listView.Items.Add(item);
            }
            return listView;
        }

        private static TextFiles DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(TextFiles));

            using (FileStream fs = new FileStream("Files.xml", FileMode.OpenOrCreate))
            {
                return (TextFiles)xml.Deserialize(fs);
            };
        }
    }
}
