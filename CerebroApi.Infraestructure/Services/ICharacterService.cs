using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CerebroApi.Models.Marvel;
using Models.Marvel;

namespace CerebroApi.Infraestructure.Services
{
    public interface ICharacterService
    {
        public Task<IEnumerable<CharacterModel>> GetCharacters();

        public Task<IEnumerable<CharacterModel>> GetCharacters(int offset, int limit);

        public Task<CharacterModel> GetCharacter(int id);

        public Task<IEnumerable<ComicModel>> GetComicsCharacter(int id);

        public Task<IEnumerable<EventModel>> GetEventsCharacter(int id);

        public Task<IEnumerable<SerieModel>> GetSeriesCharacter(int id);

        public Task<IEnumerable<StorieModel>> GetSeriesStories(int id);
    }
}
