
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CerebroApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private string _baseurl = "https://gateway.marvel.com:443/v1/public/events";

        /*
        // GET: api/Event
        [HttpGet]
        public async Task<IEnumerable<Event>> GetEvents()
        {
            //Recoger la informacion de la peticion
            var responseJSON = await IService.SendRequest(_baseurl);
            var result = responseJSON["data"]["results"];

            return ICreate<Event>.CreateItems(result);
        }

        // GET: api/Event/5

        [HttpGet("{id}")]

        public async Task<Event> GetEvent(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id);
            var item = responseJSON["data"]["results"][0];

            return ICreate<Event>.CreateItem(item); 
        }



        // GET: api/Event/5/characters

        [HttpGet("{id}/characters")]

        public async Task<IEnumerable<Character>> GetCharactersEvent(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/characters");
            var result = responseJSON["data"]["results"];

            return ICreate<Character>.CreateItems(result);

        }

        // GET: api/Event/5/comics

        [HttpGet("{id}/comics")]

        public async Task<IEnumerable<Comic>> GetComicsEvent(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/comics");
            var result = responseJSON["data"]["results"];

            return ICreate<Comic>.CreateItems(result);

        }

        // GET: api/Event/5/creators

        [HttpGet("{id}/creators")]

        public async Task<IEnumerable<Creator>> GetCreatorsEvent(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/creators");
            var result = responseJSON["data"]["results"];

            return ICreate<Creator>.CreateItems(result);

        }


        // GET: api/Event/5/series

        [HttpGet("{id}/series")]

        public async Task<IEnumerable<Serie>> GetSeriesEvent(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/series");
            var result = responseJSON["data"]["results"];

            return ICreate<Serie>.CreateItems(result);

        }


        // GET: api/Event/5/stories

        [HttpGet("{id}/stories")]

        public async Task<IEnumerable<Storie>> GetStoriesEvent(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/stories");
            var result = responseJSON["data"]["results"];

            return ICreate<Storie>.CreateItems(result);

        }*/
    }
}
