using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerebroApi.Resources.Marvel
{
    public class CharacterResource
    {
        public CharacterResource(string id, string name, string description, string modified, ThumbnailResource thumbnail)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.modified = modified;
            this.thumbnail = thumbnail;
        }

        public string id { get; set; }
        public string? name { get; set; }

        public string? description { get; set; }

        public string? modified { get; set; }

        public ThumbnailResource? thumbnail { get; set; }
    }
}
