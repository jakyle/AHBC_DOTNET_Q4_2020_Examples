using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Make_your_own_api
{
    public class StarWarsAPIClient
    {
        private readonly HttpClient _client;

        public StarWarsAPIClient(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<StarWarsPersonAPIResponse> GetSinglePerson(string id)
        {
            return await GetAsync<StarWarsPersonAPIResponse>($"/api/people/{id}/");
        }

        private async Task<T> GetAsync<T>(string endPoint)
        {
            // Post    -  Insert    -  Create
            // Get     -  Select    -  Read
            // Put     -  Update    -  Update
            // Delete  -  Delete    -  Delete


            var response = await _client.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStreamAsync();

                // var jsonOptions = new JsonSerializerOptions();

                var model = await JsonSerializer.DeserializeAsync<T>(content);

                return model;
            }
            else
            {
                throw new HttpRequestException("Final Space API returned bad response");
            }
        }

    }


    public class StarWarsPersonAPIResponse
    {
        public string birth_year { get; set; }
        public string eye_color { get; set; }
        public string[] films { get; set; }
        public string gender { get; set; }
        public string hair_color { get; set; }
        public string height { get; set; }
        public string homeworld { get; set; }
        public string mass { get; set; }
        public string name { get; set; }
        public string skin_color { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string[] species { get; set; }
        public string[] starships { get; set; }
        public string url { get; set; }
        public string[] vehicles { get; set; }
    }

}
