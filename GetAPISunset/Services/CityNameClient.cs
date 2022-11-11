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
    public class CityNameClient
    {
        public async Task<City> GetCityAsync(double lat, double lon)
        {
            var _client = new HttpClient();
            string cityUrl = $"https://api.bigdatacloud.net/data/reverse-geocode-client?latitude={lat}&longitude={lon}&localityLanguage=en";
            var response = await _client.GetAsync(cityUrl);
            response.EnsureSuccessStatusCode();

            City cn = await response.Content.ReadFromJsonAsync<City>();
            var city = new City()
            {
                city = cn.city
            };
            return city;
        }
    }
}
//https://api.geoapify.com/v1/geocode/search?text=ljusne&format=json&apiKey=d548c5ed24604be6a9dd0d989631f783