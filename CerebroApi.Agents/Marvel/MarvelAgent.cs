using CerebroApi.Commons.Constants;
using CerebroApi.Infraestructure.Agent;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CerebroApi.Agents.Marvel
{
    public class MarvelAgent: IMarvelAgent
    {
        private string _url;
        private readonly IConfiguration _config;
        private string _privateKey;
        private string _publicKey;
        private HttpClient _httpClient;
        private long _ts;
        private MD5 _md5;

        public MarvelAgent()
        {
            _md5 = MD5.Create();
            _httpClient = new HttpClient();
            _ts = DateTimeOffset.Now.ToUnixTimeSeconds();
            _privateKey = ApiMarvelConstant.privateKey;
            _publicKey = ApiMarvelConstant.publicKey;
        }
        private string CreateQuery(string md5, int limit, int offset)
        {
            return $"?apikey={_publicKey}&ts={_ts}&hash={md5}&limit={limit}&offset={offset}";
        }

        private string CreateHash()
        {
            string parameters = _ts + _privateKey + _publicKey;
            byte[] parametersBytes = Encoding.UTF8.GetBytes(parameters);
            byte[] parametersMd5 = _md5.ComputeHash(parametersBytes);
            string md5Text = BitConverter.ToString(parametersMd5).Replace("-", "").ToLower();
            return md5Text;
        }

        private string CreateURL(string parameters) => _url + parameters;

        private async Task<JObject> GetResponse(string url)
        {
            var response = await _httpClient.GetStringAsync(url);
            var responseJSON = JObject.Parse(response);
            return responseJSON;
        }
        public async Task<JObject> SendRequest(string url, int offset = 0, int limit = 20)
        {
            _url = url;

            string md5Text = CreateHash();
            string fullUrl = CreateURL(CreateQuery(md5Text, limit, offset));

            var response = await GetResponse(fullUrl);

            return response;

        }
    }
}
