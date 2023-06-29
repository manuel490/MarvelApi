
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CerebroApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorieController : ControllerBase
    {
        private string _baseurl = "https://gateway.marvel.com:443/v1/public/stories";
        /*
        // GET: api/Storie
        [HttpGet]
        public async Task<IEnumerable<Storie>> GetStorie()
        {
            //Recoger la informacion de la peticion
            var responseJSON = await IService.SendRequest(_baseurl);
            var result = responseJSON["data"]["results"];

            return ICreate<Storie>.CreateItems(result);
        }

        // GET: api/Storie/5

        [HttpGet("{id}")]

        public async Task<Storie> GetStorie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id);
            var item = responseJSON["data"]["results"][0];

            return ICreate<Storie>.CreateItem(item); 
        }





        // GET: api/Storie/5/characters

        [HttpGet("{id}/characters")]

        public async Task<IEnumerable<Character>> GetCharactersStorie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/characters");
            var result = responseJSON["data"]["results"];

            return ICreate<Character>.CreateItems(result);

        }

        // GET: api/Storie/5/comics

        [HttpGet("{id}/comics")]

        public async Task<IEnumerable<Comic>> GetComicsStorie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/comics");
            var result = responseJSON["data"]["results"];

            return ICreate<Comic>.CreateItems(result);

        }

        // GET: api/Storie/5/creators

        [HttpGet("{id}/creators")]

        public async Task<IEnumerable<Creator>> GetCreatorsStorie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/creators");
            var result = responseJSON["data"]["results"];

            return ICreate<Creator>.CreateItems(result);

        }


        // GET: api/Storie/5/events

        [HttpGet("{id}/events")]

        public async Task<IEnumerable<Event>> GetEventsStorie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/events");
            var result = responseJSON["data"]["results"];

            return ICreate<Event>.CreateItems(result);

        }


        // GET: api/Storie/5/series

        [HttpGet("{id}/series")]

        public async Task<IEnumerable<Serie>> GetSeriesStorie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/series");
            var result = responseJSON["data"]["results"];

            return ICreate<Serie>.CreateItems(result);

        }*/
    }
}
