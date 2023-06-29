using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using CerebroApi.Infraestructure.Services;
using CerebroApi.Models.Marvel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Marvel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CerebroApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private string _baseurl = "https://gateway.marvel.com:443/v1/public/characters";


       
        private readonly ICharacterService _characterService;
            
        public CharacterController(ICharacterService characterService) 
        {
            _characterService = characterService;
           
        }

        // GET: api/Character
        [HttpGet]
        public async Task<IEnumerable<CharacterModel>> GetCharacters()
        {
           
            var items = await _characterService.GetCharacters();
            return items;
        }
        
        // GET: api/Character/20/20
        [HttpGet("{offset}/{limit}")]
        public async Task<IEnumerable<CharacterModel>> GetCharacters(int offset, int limit)
        {
            var items = await _characterService.GetCharacters(offset, limit);
            return items;
        }

        
        // GET: api/Character/5

        [HttpGet("{id}")]
        
        public async Task<CharacterModel> GetCharacter( int id)
        {
            var item = await _characterService.GetCharacter(id);
            return item;
        }
        
        

        // GET: api/Character/5/comics
        
        [HttpGet("{id}/comics")]

        public async Task<IEnumerable<ComicModel>> GetComicsCharacter(int id)
        {
            var item = await _characterService.GetComicsCharacter(id);
            return item;

        }

        // GET: api/Character/5/events

        [HttpGet("{id}/events")]

        public async Task<IEnumerable<EventModel>> GetEventsCharacter(int id)
        {
            var item = await _characterService.GetEventsCharacter(id);
            return item;
        }


        // GET: api/Character/5/series

        [HttpGet("{id}/series")]

        public async Task<IEnumerable<SerieModel>> GetSeriesCharacter(int id)
        {
            var item = await _characterService.GetSeriesCharacter(id);
            return item;
        }

        // GET: api/Character/5/stories

        [HttpGet("{id}/stories")]

        public async Task<IEnumerable<StorieModel>> GetStoriesCharacter(int id)
        {
            var item = await _characterService.GetSeriesStories(id);
            return item;
        }
       
    }
}
