using GetAPISunset.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GetAPISunset.Services
{
    public class CityNameFromName
    {
        //public async Task<CityFromName> GetCityFromCityAsync(string chosenCity)
        public async Task<Results> GetCityFromCityAsync()
        {
            var _client = new HttpClient();
            string cityUrlFromName = $"https://api.geoapify.com/v1/geocode/search?text=ljusne&format=json&apiKey=d548c5ed24604be6a9dd0d989631f783";
            var response = await _client.GetAsync(cityUrlFromName);
            response.EnsureSuccessStatusCode();

            //Root cnll = await response.Content.ReadFromJsonAsync<Root>();

            var ddd = new Results();
            //{
            //    lat = cnll.results.lat,
            //    lon = cnll.results.lon,
            //    city = cnll.results.city

            //};
  
            return ddd;
        }
    }
}
