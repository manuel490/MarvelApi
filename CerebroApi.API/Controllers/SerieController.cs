
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CerebroApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        private string _baseurl = "https://gateway.marvel.com:443/v1/public/series";
        /*
        // GET: api/Serie
        [HttpGet]
        public async Task<IEnumerable<Serie>> GetSeries()
        {
            //Recoger la informacion de la peticion
            var responseJSON = await IService.SendRequest(_baseurl);
            var result = responseJSON["data"]["results"];

            return ICreate<Serie>.CreateItems(result);
        }

        // GET: api/Serie/5

        [HttpGet("{id}")]

        public async Task<Serie> GetSerie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id);
            var item = responseJSON["data"]["results"][0];

            return ICreate<Serie>.CreateItem(item);
        }





        // GET: api/Serie/5/characters

        [HttpGet("{id}/characters")]

        public async Task<IEnumerable<Character>> GetCharactersSerie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/characters");
            var result = responseJSON["data"]["results"];

            return ICreate<Character>.CreateItems(result);

        }

        // GET: api/Serie/5/comics

        [HttpGet("{id}/comics")]

        public async Task<IEnumerable<Comic>> GetComicsSerie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/comics");
            var result = responseJSON["data"]["results"];

            return ICreate<Comic>.CreateItems(result);

        }

        // GET: api/Serie/5/creators

        [HttpGet("{id}/creators")]

        public async Task<IEnumerable<Creator>> GetCreatorsSerie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/creators");
            var result = responseJSON["data"]["results"];

            return ICreate<Creator>.CreateItems(result);

        }


        // GET: api/Serie/5/events

        [HttpGet("{id}/events")]

        public async Task<IEnumerable<Event>> GetEventsSerie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/events");
            var result = responseJSON["data"]["results"];

            return ICreate<Event>.CreateItems(result);

        }


        // GET: api/Serie/5/stories

        [HttpGet("{id}/stories")]

        public async Task<IEnumerable<Storie>> GetStoriesSerie(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/stories");
            var result = responseJSON["data"]["results"];

            return ICreate<Storie>.CreateItems(result);

        }*/
    }
}
