using CerebroApi.Resources.Marvel;
using Models.Marvel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Marvel
{
    public static class CharacterMapper
    {
        public static CharacterModel toCharacterModel(this CharacterResource characterResource)
        {
            return new CharacterModel(characterResource.id, characterResource.name, characterResource.description, characterResource.modified, characterResource.thumbnail.toThumbnailModel());
        }

        public static IEnumerable<CharacterModel> toCharacterModel(this IEnumerable<CharacterResource> characterResources)
        {
            foreach (CharacterResource? item in characterResources)
            {
                if (item is not null)
                {
                    yield return item.toCharacterModel();
                }
            }
        }

        public static CharacterResource toCharacterResource(this CharacterModel characterModel)
        {
            return new CharacterResource(characterModel.id, characterModel.name, characterModel.description, characterModel.modified, characterModel.thumbnail.toThumbnailResource());
        }

        public static IEnumerable<CharacterResource> toCharacterResource(this IEnumerable<CharacterModel> characterModels)
        {
            foreach (CharacterModel? item in characterModels)
            {
                if (item is not null)
                {
                    yield return item.toCharacterResource();
                }
            }
        }
    }
}
