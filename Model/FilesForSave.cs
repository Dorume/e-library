using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace e_library.Model
{
    [Serializable]
    public class FilesForSave
    {
        public List<string> Files { get; set; } = new List<string>();

        public FilesForSave()
        {

        }

        public FilesForSave(List<string> files) => Files = files;
    }
}
