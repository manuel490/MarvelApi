
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CerebroApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatorController : ControllerBase
    {
        private string _baseurl = "https://gateway.marvel.com:443/v1/public/creators";

        /*
        // GET: api/Creator
        [HttpGet]
        public async Task<IEnumerable<Creator>> GetCreators()
        {
            //Recoger la informacion de la peticion
            var responseJSON = await IService.SendRequest(_baseurl);
            var result = responseJSON["data"]["results"];

            return ICreate<Creator>.CreateItems(result);
        }

        // GET: api/Creator/5

        [HttpGet("{id}")]

        public async Task<Creator> GetCreator(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id);
            var item = responseJSON["data"]["results"][0];

            return ICreate<Creator>.CreateItem(item);
        }



        // GET: api/Creator/5/comics

        [HttpGet("{id}/comics")]

        public async Task<IEnumerable<Comic>> GetComicsCreator(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/comics");
            var result = responseJSON["data"]["results"];

            return ICreate<Comic>.CreateItems(result);

        }

        // GET: api/Creator/5/events

        [HttpGet("{id}/events")]

        public async Task<IEnumerable<Event>> GetEventsCreator(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/events");
            var result = responseJSON["data"]["results"];

            return ICreate<Event>.CreateItems(result);

        }

        // GET: api/Creator/5/series

        [HttpGet("{id}/series")]

        public async Task<IEnumerable<Serie>> GetSeriesCreator(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/series");
            var result = responseJSON["data"]["results"];

            return ICreate<Serie>.CreateItems(result);

        }


        // GET: api/Creator/5/stories

        [HttpGet("{id}/stories")]

        public async Task<IEnumerable<Storie>> GetStoriesCreator(int id)
        {
            //Recoger la informacion de la peticion

            var responseJSON = await IService.SendRequest(_baseurl + "/" + id + "/stories");
            var result = responseJSON["data"]["results"];

            return ICreate<Storie>.CreateItems(result);

        }*/
    }
}
