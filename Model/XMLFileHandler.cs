using e_library.Model.Interfaces;
using e_library.Serialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace e_library.Model
{
    class XMLFileHandler : IFileHandler
    {
        public TextFiles Load()
        {
            XmlSerializer xml = new XmlSerializer(typeof(TextFiles));

            using (FileStream fs = new FileStream("TextFiles.xml", FileMode.OpenOrCreate))
            {
                return (TextFiles)xml.Deserialize(fs);
            };
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
