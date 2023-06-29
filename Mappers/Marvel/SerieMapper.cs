using CerebroApi.Models.Marvel;
using CerebroApi.Resources.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Marvel
{
    public static class SerieMapper
    {
        public static SerieModel toSerieModel(this SerieResource serieResource)
        {
            return new SerieModel(serieResource.id, serieResource.title, serieResource.description, serieResource.startYear, serieResource.endYear,serieResource.type,serieResource.modified, serieResource.thumbnail.toThumbnailModel());
        }

        public static IEnumerable<SerieModel> toSerieModel(this IEnumerable<SerieResource> serieResources)
        {
            foreach (SerieResource? item in serieResources)
            {
                if (item is not null)
                {
                    yield return item.toSerieModel();
                }
            }
        }

        public static SerieResource toSerieResource(this SerieModel serieModel)
        {
            return new SerieResource(serieModel.id, serieModel.title, serieModel.description, serieModel.startYear, serieModel.endYear, serieModel.type, serieModel.modified, serieModel.thumbnail.toThumbnailResource());
        }

        public static IEnumerable<SerieResource> toSerieResource(this IEnumerable<SerieModel> serieModels)
        {
            foreach (SerieModel? item in serieModels)
            {
                if (item is not null)
                {
                    yield return item.toSerieResource();
                }
            }
        }
    }
}
