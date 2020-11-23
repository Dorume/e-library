using e_library.Files;
using e_library.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace e_library.Model
{
    static class Registrator
    {
        private static List<ReaderForm> Forms { get; set; } = new List<ReaderForm>();
        private static ReaderForm CurrForm;

        public delegate void ModeChanged(bool checkMode);
        public static event ModeChanged ModeChangedEvent;


        private static bool _editMode;
        public static bool EditMode 
        { 
            get => _editMode;
            set
            {
                _editMode = value;
                ModeChangedEvent?.Invoke(value);
            }
        }

        public static void AddForm(TextFile file, MainForm sender)
        {
            if (Streamer.FileExitst(file))
            {
                ReaderForm form = new ReaderForm(file.Filename, file.Path, Streamer.GetText(file), _editMode, sender);
                form.Show();
                CurrFormChanged(form);
                Forms.Add(form);
            }
            else
            {
                MainModel.RemoveFromHistory(file);
                FileNotFoundError(file.Filename);
            }
        }

        public static void CurrFormChanged(ReaderForm sender)
        {
            CurrForm = sender;
        }
        private static void FileNotFoundError(string name)
        {
            MessageBox.Show($"Файл '{name}' не найден!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
