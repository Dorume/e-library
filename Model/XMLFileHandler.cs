using e_library.Files;
using e_library.Model.Interfaces;
using System;
using System.IO;
using System.Xml.Serialization;

namespace e_library.Model
{
    class XMLFileHandler : IFileHandler
    {
        public string NameOfFile = "TextFiles.xml";
        public TextFiles Load()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TextFiles));
                using (Stream fs = File.Open(NameOfFile, FileMode.Open))
                {
                    TextFiles item = (TextFiles)serializer.Deserialize(fs);
                    return item;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //NewXmlDocument();
                return null;
            }
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
