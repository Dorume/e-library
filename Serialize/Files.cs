using System;
using System.Collections.Generic;

namespace e_library.Serialize
{
    [Serializable]
    public class Files
    {
        public List<File> FilesList { get; set; } = new List<File>;
    }
}
