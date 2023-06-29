using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerebroApi.Infraestructure.Agent
{
    public interface IMarvelAgent
    {
        Task<JObject> SendRequest(string url, int offset = 0, int limit = 20);
    }
}
