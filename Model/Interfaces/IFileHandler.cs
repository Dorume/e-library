using e_library.Files;

namespace e_library.Model.Interfaces
{
    public interface IFileHandler
    {
        public void Save(TextFiles textFile);
        public TextFiles Load();
    }
}
