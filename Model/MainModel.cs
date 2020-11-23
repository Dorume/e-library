using e_library.Files;
using System.IO;
using System.Windows.Forms;

namespace e_library.Model
{
    internal static class MainModel
    {
        public static TextFiles History { get; set; }
        public static MainForm MainForm;

        public delegate void HistoryChanged();
        public static event HistoryChanged HistoryChangedEvent;

        public static void OpenFile (OpenFileDialog fileDialog)
        {
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var file = GetTextFileType(fileDialog.FileName);
            AddToHistory(file);
            Registrator.AddForm(file, MainForm);
        }

        public static void OpenFile(string path)
        {
            var file = GetTextFileType(path);
            AddToHistory(file);
            Registrator.AddForm(file, MainForm);
        }

        public static void FormClosing()
        {
            FileHistory.FileHandler = new XMLFileHandler();
            FileHistory.Save(History);
        }
        public static void FormLoad()
        {
            FileHistory.FileHandler = new XMLFileHandler();
            History = FileHistory.Load() ?? new TextFiles();
            HistoryChangedEvent?.Invoke();
        }

        /// <summary>
        /// Добавляє елемент в історію
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        private static void AddToHistory(TextFile file)
        {
            if(!CheckForRepeat(file))
            {
                History.FilesList.Add(file);
                if (History.FilesList.Count > 10)
                    History.FilesList.RemoveAt(0);
                HistoryChangedEvent?.Invoke();
            }
        }
        public static void RemoveFromHistory(TextFile file)
        {
            foreach (TextFile item in History.FilesList)
            {
                if (file.Path == item.Path)
                {
                    History.FilesList.Remove(item);
                    HistoryChangedEvent?.Invoke();
                    return;
                }       
            }
        }

        public static void CanEditchanged(bool checkBool)
        {
            Registrator.EditMode = checkBool;
        }

        private static TextFile GetTextFileType(string path)
        {
            return new TextFile(Path.GetFileNameWithoutExtension(path), path);
        }

        /// <summary>
        /// Визначає, входить елемент в історію чи ні
        /// </summary>
        /// <param name="file"></param>
        /// <returns>повертає true, якщо елемент повторюється</returns>
        private static bool CheckForRepeat(TextFile file)
        {
            foreach (TextFile item in History.FilesList)
            {
                if (file.Path == item.Path)
                    return true;
            }
            return false;
        }
    }
}
