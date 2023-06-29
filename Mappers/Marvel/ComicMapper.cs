using CerebroApi.Models.Marvel;
using CerebroApi.Resources.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Marvel
{
    public static  class ComicMapper
    {
        public static ComicModel toComicModel (this ComicResource comicResource)
        {
            return new ComicModel(comicResource.id, comicResource.title, comicResource.issueNumber, comicResource.description, comicResource.modified, comicResource.isbn, comicResource.pageCount, comicResource.thumbnail.toThumbnailModel());
        }

        public static IEnumerable<ComicModel> toComicModel(this IEnumerable<ComicResource> comicResources)
        {
            foreach (ComicResource? item in comicResources)
            {
                if (item is not null)
                {
                    yield return item.toComicModel();
                }   
            }
        }


        public static ComicResource toComicResourcel(this ComicModel comicModel)
        {
            return new ComicResource(comicModel.id, comicModel.title, comicModel.issueNumber, comicModel.description, comicModel.modified, comicModel.isbn, comicModel.pageCount, comicModel.thumbnail.toThumbnailResource());
        }

        public static IEnumerable<ComicResource> toComicResourcel(this IEnumerable<ComicModel> comicModels)
        {
            foreach (ComicModel? item in comicModels)
            {
                if (item is not null)
                {
                    yield return item.toComicResourcel();
                }
            }
        }
    }
}
