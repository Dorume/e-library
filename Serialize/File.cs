using System;

namespace e_library.Serialize
{
    [Serializable]
    public class File
    {
        public string Filename { get; set; }
        public string Path { get; set; }

        public File() { }

        public File(string filename, string path)
        {
            Filename = filename;
            Path = path;
        }
    }
}
