using environ_variables.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace environ_variables.Services
{
    public class SWAPIClient
    {
        private readonly HttpClient _client;

        public SWAPIClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<PersonResponseModel> GetSinglePerson(string id)
        {
            var response = await _client.GetAsync($"people/{id}/");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStreamAsync();

                var model = await JsonSerializer.DeserializeAsync<PersonResponseModel>(content);

                return model;
            }
            else
            {
                throw new HttpRequestException("final SWAPI returned a bad response");
            }

        }
    }
}
