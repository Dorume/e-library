using System;
namespace e_library.Files
{
    [Serializable]
    public class TextFile
    {
        public string Filename { get; set; }
        public string Path { get; set; }

        public TextFile() { }

        public TextFile(string filename, string path)
        {
            Filename = filename;
            Path = path;
        }
    }
}
