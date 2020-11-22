using e_library.Model.Interfaces;
using e_library.Serialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library.Model
{
    public class FileHistory
    {
        public static IFileHandler FileHandler { get; set; }
        public FileHistory(IFileHandler fileHandler) => FileHandler = fileHandler;

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
