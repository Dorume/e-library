using e_library.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_library.Model
{
    internal static class Streamer
    {
        public static bool FileExitst(TextFile file)
        {
            if (File.Exists(file.Path))
                return true;
            return false;
        }

        public static string GetText(TextFile file)
        {
            return File.ReadAllText(file.Path);
        }

        public static void SaveText(TextFile file, string newText)
        {
            File.WriteAllText(file.Path, newText);
        }
    }
}
