using e_library.Files;
using e_library.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace e_library.Model
{
    class XMLFileHandler : IFileHandler
    {
        public string NameOfFile = "TextFiles.xml";
        public TextFiles Load()
        {
            XmlSerializer xml = new XmlSerializer(typeof(TextFiles));

            if (File.Exists(NameOfFile))
                using (FileStream fs = new FileStream(NameOfFile, FileMode.Open))
                {
                    return (TextFiles)xml.Deserialize(fs);
                };
            NewXmlDocument();
            return null;
        }
        private void NewXmlDocument()
        {
            XDocument XmlDoc = new XDocument();
            XmlDoc.Add(new XElement(NameOfFile));
            XmlDoc.Save(NameOfFile);
        }
        public void Save(TextFiles textFiles)
        {
            XmlSerializer xml = new XmlSerializer(typeof(TextFiles));

            using (FileStream fs = new FileStream(NameOfFile, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, textFiles);
            };
        }
    }
}
