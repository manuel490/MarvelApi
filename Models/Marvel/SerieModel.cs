using Models.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerebroApi.Models.Marvel
{
    public class SerieModel
    {
        public SerieModel()
        {
        }

        public SerieModel(int id, string title, string? description, int? startYear, int? endYear, string? type, string? modified, ThumbnailModel? thumbnail)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.startYear = startYear;
            this.endYear = endYear;
            this.type = type;
            this.modified = modified;
            this.thumbnail = thumbnail;
        }

        public int id { get; set; }
        public string title { get; set; }

        public string? description { get; set; }
        public int? startYear { get; set; }

        public int? endYear { get; set; }

        public string? type { get; set; }

        public string? modified { get; set; }

        public ThumbnailModel? thumbnail { get; set; }
    }
}
