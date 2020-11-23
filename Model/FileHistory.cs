using e_library.Files;
using e_library.Model.Interfaces;

namespace e_library.Model
{
    public static class FileHistory
    {
        public static IFileHandler FileHandler { get; set; }

        public static void Save(TextFiles textFiles)
        {
            FileHandler.Save(textFiles);
        }

        public static TextFiles Load()
        {
            return FileHandler.Load();
        }
    }
}
