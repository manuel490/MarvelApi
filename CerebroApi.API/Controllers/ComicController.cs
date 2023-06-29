
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace CerebroApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController : ControllerBase
    {
        private string _baseurl = "https://gateway.marvel.com:443/v1/public/comics";


        /*
        // GET: api/Comic
        [HttpGet]
        public async Task<IEnumerable<Comic>> GetComics()
        {
            //Recoger la informacion de la peticion
            var responseJSON = await IService.SendRequest(_baseurl);
            var result = responseJSON["data"]["results"];
            return ICreate<Comic>.CreateItems(result);
        }


        // GET: api/Comic/5

        [HttpGet("{id}")]

        public async Task<Comic> GetComic(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id);
            var item = responseJSON["data"]["results"][0];

            return ICreate<Comic>.CreateItem(item);
        }


        // GET: api/Character/5/characters

        [HttpGet("{id}/characters")]

        public async Task<IEnumerable<Character>> GetCharactersComic(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/characters");
            var result = responseJSON["data"]["results"];

            return ICreate<Character>.CreateItems(result);

        }

        // GET: api/Character/5/creators

        [HttpGet("{id}/creators")]

        public async Task<IEnumerable<Creator>> GetCreatorsComic(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/creators");
            var result = responseJSON["data"]["results"];

            return ICreate<Creator>.CreateItems(result);

        }


        // GET: api/Character/5/events

        [HttpGet("{id}/events")]

        public async Task<IEnumerable<Event>> GetEventsComic(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/events");
            var result = responseJSON["data"]["results"];

            return ICreate<Event>.CreateItems(result);

        }

        // GET: api/Character/5/stories

        [HttpGet("{id}/stories")]

        public async Task<IEnumerable<Storie>> GetStoriesComic(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/stories");
            var result = responseJSON["data"]["results"];

            return ICreate<Storie>.CreateItems(result);

        }*/

    }
}
