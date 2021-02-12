using Api_intro.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Api_intro
{
    public class FinalSpaceClient
    {
        private readonly HttpClient _client;

        public FinalSpaceClient(HttpClient client)
        {
            _client = client;
        }


        public async Task<IEnumerable<QuotesResponseModel>> GetAllQuotes()
        {
            return await GetAsync<IEnumerable<QuotesResponseModel>>("/api/v0/quote/");
        }

        public async Task<IEnumerable<EpisodeResponseModel>> GetAllEpisodes()
        {
            return await GetAsync<IEnumerable<EpisodeResponseModel>>("/api/v0/episode/");
        }

        public async Task<CharacterResponseModel> GetSingleCharacter(string id)
        {
            return await GetAsync<CharacterResponseModel>($"/api/v0/character/{id}");
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
}
