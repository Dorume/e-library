using System;
using System.Collections.Generic;

namespace e_library.Files
{
    [Serializable]
    public class TextFiles
    {
        public List<TextFile> FilesList { get; set; } = new List<TextFile>();
    }
}
