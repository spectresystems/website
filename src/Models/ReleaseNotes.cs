using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

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
        public string Author { get; set; }
        [JsonProperty("author_github")]
        public string AuthorGitHub { get; set; }

        public int SortOrder 
        {
            get 
            {
                if(Kind.Equals("feature", StringComparison.OrdinalIgnoreCase))
                {
                    return 0;
                }
                else if(Kind.Equals("improvement", StringComparison.OrdinalIgnoreCase))
                {
                    return 1;
                }
                else if(Kind.Equals("bug", StringComparison.OrdinalIgnoreCase))
                {
                    return 2;
                }
                else {
                    return 3;
                }
            }
        }
    }
}
