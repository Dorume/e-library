using e_library.Files;
using e_library.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace e_library.Model
{
    class XMLFileHandler : IFileHandler
    {

        //Якщо вибрати FileMode.OpenOrCreate, то буде створений новий xml файл але
        //він буде пустий, тому я відмовився від даного варіанта
        public TextFiles Load()
        {
            XmlSerializer xml = new XmlSerializer(typeof(TextFiles));

            using (FileStream fs = new FileStream("TextFiles.xml", FileMode.Open))
            {
                if (fs.CanRead)
                    return (TextFiles)xml.Deserialize(fs);
            };
            return null;
        }

        public void Save(TextFiles textFiles)
        {
            XmlSerializer xml = new XmlSerializer(typeof(TextFiles));

            using (FileStream fs = new FileStream("TextFiles.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, textFiles);
            };
        }
    }
}
