
using CerebroApi.Infraestructure.Services;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CerebroApi.Infraestructure.Agent;
using CerebroApi.Resources.Marvel;
using Models.Marvel;
using Mappers.Marvel;
using CerebroApi.Models.Marvel;

namespace CerebroApi.Services
{
    public  class CharacterService:ICharacterService
    {
        private readonly string _url = "https://gateway.marvel.com:443/v1/public/characters";
        private IMarvelAgent _marvelAgent;


        public CharacterService(IMarvelAgent marvelAgent)
        {
            _marvelAgent = marvelAgent;
        }
        public async Task<CharacterModel> GetCharacter(int id)
        {
            var response = await _marvelAgent.SendRequest($"{_url}/{id}");
            var item = response["data"]["results"][0];
            var resource = JsonConvert.DeserializeObject<CharacterResource>(JsonConvert.SerializeObject(item));
            var model = resource.toCharacterModel();
            return model;
        }

        public async Task<IEnumerable<CharacterModel>> GetCharacters()
        {
            var response = await _marvelAgent.SendRequest(_url);
            var item = response["data"]["results"];
            var resources = JsonConvert.DeserializeObject<IEnumerable<CharacterResource>>(JsonConvert.SerializeObject(item));
            var models = resources.toCharacterModel();
            return models;
        }

        public async Task<IEnumerable<CharacterModel>> GetCharacters(int offset, int limit)
        {
            var response = await _marvelAgent.SendRequest(_url, offset, limit);
            var item = response["data"]["results"];
            var resources = JsonConvert.DeserializeObject<IEnumerable<CharacterResource>>(JsonConvert.SerializeObject(item));
            var models = resources.toCharacterModel();
            return models;
        }

        public async Task<IEnumerable<ComicModel>> GetComicsCharacter(int id)
        {
            var response = await _marvelAgent.SendRequest($"{_url}/{id}/comics");
            var item = response["data"]["results"];
            var resources = JsonConvert.DeserializeObject<IEnumerable<ComicResource>>(JsonConvert.SerializeObject(item));
            var models = resources.toComicModel();
            return models;

        }

        public async Task<IEnumerable<EventModel>> GetEventsCharacter(int id)
        {
            var response = await _marvelAgent.SendRequest($"{_url}/{id}/events");
            var item = response["data"]["results"];
            var resources = JsonConvert.DeserializeObject<IEnumerable<EventResource>>(JsonConvert.SerializeObject(item));
            var models = resources.toEventModel();
            return models;
        }

        public async Task<IEnumerable<SerieModel>> GetSeriesCharacter(int id)
        {
            var response = await _marvelAgent.SendRequest($"{_url}/{id}/series");
            var item = response["data"]["results"];
            var resources = JsonConvert.DeserializeObject<IEnumerable<SerieResource>>(JsonConvert.SerializeObject(item));
            var models = resources.toSerieModel();
            return models;
        }

        public async Task<IEnumerable<StorieModel>> GetSeriesStories(int id)
        {
            var response = await _marvelAgent.SendRequest($"{_url}/{id}/stories");
            var item = response["data"]["results"];
            var resources = JsonConvert.DeserializeObject<IEnumerable<StorieResource>>(JsonConvert.SerializeObject(item));
            var models = resources.toStorieModel();
            return models;
        }
    }
}
