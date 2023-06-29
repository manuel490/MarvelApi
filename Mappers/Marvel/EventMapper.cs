using CerebroApi.Models.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CerebroApi.Resources.Marvel;

namespace Mappers.Marvel
{
    public static class EventMapper
    {
        public static EventModel toEventModel(this EventResource eventResource)
        {
            return new EventModel(eventResource.id, eventResource.title, eventResource.description, eventResource.modified, eventResource.start, eventResource.end, eventResource.thumbnail.toThumbnailModel());
        }


        public static IEnumerable<EventModel> toEventModel(this IEnumerable<EventResource> eventResources)
        {
            foreach (EventResource? item in eventResources)
            {
                if (item is not null)
                {
                    yield return item.toEventModel();
                }
            }
        }

        public static EventResource toEventResource(this EventModel eventModel)
        {
            return new EventResource(eventModel.id, eventModel.title, eventModel.description, eventModel.modified, eventModel.start, eventModel.end, eventModel.thumbnail.toThumbnailResource());
        }

        public static IEnumerable<EventResource> toEventResource(this IEnumerable<EventModel> eventModels)
        {
            foreach (EventModel? item in eventModels)
            {
                if (item is not null)
                {
                    yield return item.toEventResource();
                }
            }
        }
    }
}
