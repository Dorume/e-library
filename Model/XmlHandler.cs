using System.IO;
using System.Xml.Serialization;

namespace e_library.Model
{
    internal static class XmlHandler
    {
        public static void Save(FilesForSave files)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FilesForSave));
            using (FileStream fs = new FileStream("files.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, files);
            }
        }

        public static FilesForSave Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FilesForSave));
            using (FileStream fs = new FileStream("files.xml", FileMode.OpenOrCreate))
            {
                return (FilesForSave)serializer.Deserialize(fs);
            }
        }
    }
}
