using Models.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerebroApi.Models.Marvel
{
    public class ComicModel
    {
        public ComicModel()
        {
        }

        public ComicModel(int id, string title, int? issueNumber, string? description, string? modified, string? isbn, int? pageCount, ThumbnailModel? thumbnail)
        {
            this.id = id;
            this.title = title;
            this.issueNumber = issueNumber;
            this.description = description;
            this.modified = modified;
            this.isbn = isbn;
            this.pageCount = pageCount;
            this.thumbnail = thumbnail;
        }

        public int id { get; set; }
        public string title { get; set; }
        public int? issueNumber { get; set; }
        public string? description { get; set; }
        public string? modified { get; set; }

        public string? isbn { get; set; }

        public int? pageCount { get; set; }

        public ThumbnailModel? thumbnail { get; set; }
    }
}
