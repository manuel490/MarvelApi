using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Marvel
{
    public class ThumbnailModel
    {
        public ThumbnailModel() { }
        public ThumbnailModel(string path, string extension)
        {
            this.path = path;
            this.extension = extension;
        }
        public string path { get; set; }
        public string extension { get; set; }
    }
}
