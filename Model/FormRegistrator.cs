using e_library.Forms;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace e_library.Model
{
    static class FormRegistrator
    {
        private static List<ReaderForm> Forms { get; set; } = new List<ReaderForm>();

        public delegate void EventHandler();

        public static event EventHandler SettingsChanged;

        public static void AddForm(OpenFileDialog open, Form sender)
        {
            string path = open.FileName;
            string filename = Path.GetFileNameWithoutExtension(path);
            string text = File.ReadAllText(path);

            ReaderForm form = new ReaderForm(filename, path, text, sender);
            Forms.Add(form);
            form.Show();

            SaveInSettings(filename, path);
        }

        private static void SaveInSettings(string filename, string path)
        {
            Properties.Settings.Default.Context.Add(filename, path);
            Properties.Settings.Default.Save();
            SettingsChanged?.Invoke();
        }
    }
}
