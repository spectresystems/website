using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Statiq.Common;
using Statiq.Core;

namespace Site
{
    public class ReleaseNotesPipeline : Pipeline
    {
        public ReleaseNotesPipeline()
        {
            InputModules = new ModuleList
            {
                new ExecuteConfig(
                    Config.FromContext(ctx => {
                        return new ReadWeb("https://raw.githubusercontent.com/spectresystems/ghostly/master/release-notes.json");
                    }))
            };

            ProcessModules = new ModuleList
            {
                new ExecuteConfig(
                    Config.FromDocument(async (doc, ctx) =>
                    {
                        var json = await doc.GetContentStringAsync();
                        var obj = JsonConvert.DeserializeObject<ReleaseNotes>(json);

                        var content = new List<IDocument>();
                        content.Add(obj.ToDocument("ReleaseNotes"));

                        return doc.Clone(new MetadataDictionary
                        {
                            ["ReleaseNotes"] = content
                        });
                    }))
            };
        }
    }
}