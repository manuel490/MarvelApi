using Models.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerebroApi.Models.Marvel
{
    public class EventModel
    {
        public EventModel()
        {
        }

        public EventModel(int id, string title, string? description, string? modified, string? start, string? end, ThumbnailModel? thumbnail)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.modified = modified;
            this.start = start;
            this.end = end;
            this.thumbnail = thumbnail;
        }

        public int id { get; set; }
        public string title { get; set; }
        public string? description { get; set; }
        public string? modified { get; set; }

        public string? start { get; set; }
        public string? end { get; set; }

        public ThumbnailModel? thumbnail { get; set; }
    }
}
