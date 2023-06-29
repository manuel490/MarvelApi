using CerebroApi.Models.Marvel;
using CerebroApi.Resources.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Marvel
{
    public static class StorieMapper
    {
        public static StorieModel toStorieModel (this StorieResource storieResource)
        {
            return new StorieModel(storieResource.id, storieResource.title, storieResource.description, storieResource.type, storieResource.modified, storieResource.thumbnail.toThumbnailModel());
        }

        public static IEnumerable<StorieModel> toStorieModel(this IEnumerable<StorieResource> storieResource)
        {
            foreach (StorieResource? item in storieResource)
            {
                if (item is not null)
                {
                    yield return item.toStorieModel();
                }
            }
        }

        public static StorieResource toStorieResource(this StorieModel storieModel)
        {
            return new StorieResource(storieModel.id, storieModel.title, storieModel.description, storieModel.type, storieModel.modified, storieModel.thumbnail.toThumbnailResource());
        }

        public static IEnumerable<StorieResource> toStorieResource(this IEnumerable<StorieModel> storieModels)
        {
            foreach (StorieModel? item in storieModels)
            {
                if (item is not null)
                {
                    yield return item.toStorieResource();
                }
            }
        }
    }
}
