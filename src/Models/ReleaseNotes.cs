using System;
using System.Collections.Generic;
using System.Text;

namespace Site
{
    public sealed class ReleaseNotes
    {
        public List<ReleaseNote> Releases { get; set; }
    }

    public sealed class ReleaseNote
    {
        public Version Version { get; set; }
        public string Date { get; set; }
        public List<ReleaseEntry> Entries { get; set; }
    }

    public sealed class ReleaseEntry
    {
        public string Kind { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
