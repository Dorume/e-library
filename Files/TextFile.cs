using System;
using System.Windows.Forms;

namespace e_library.Serialize
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

        public TextFile(OpenFileDialog fileDialog)
        {
            Path = fileDialog.FileName;
            Filename = System.IO.Path.GetFileNameWithoutExtension(Path);
        }
    }
}
