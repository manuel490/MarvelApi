using CerebroApi.Resources.Marvel;
using Models.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Marvel
{
    public static class ThumbnailMapper
    {
        public static ThumbnailModel toThumbnailModel(this ThumbnailResource? thumbnailResource)
        {
            return new ThumbnailModel(thumbnailResource?.path, thumbnailResource?.extension);
        }

        public static ThumbnailResource toThumbnailResource(this ThumbnailModel? thumbnailModel)
        {
            return new ThumbnailResource(thumbnailModel?.path, thumbnailModel?.extension);
        }
    }
}
