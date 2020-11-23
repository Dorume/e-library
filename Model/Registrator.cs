using e_library.Files;
using e_library.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace e_library.Model
{
    static class Registrator
    {
        private static List<ReaderForm> Forms { get; set; } = new List<ReaderForm>();
        private static ReaderForm CurrForm;

        public static void AddForm(TextFile file, MainForm sender)
        {
            if (Streamer.FileExitst(file))
            {
                ReaderForm form = new ReaderForm(file.Filename, Streamer.GetText(file), sender);
                form.Show();
                CurrFormChanged(form);
                Forms.Add(form);
            }
            else
                FileNotFoundError(file.Filename);
        }

        public static void CurrFormChanged(ReaderForm sender)
        {
            CurrForm = sender;
        }

        private static void FileNotFoundError(string name)
        {
            MessageBox.Show($"Файл {name} не найден!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
