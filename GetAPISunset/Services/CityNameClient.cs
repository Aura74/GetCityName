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
        public async Task<City> GetDayAsync(double lat, double lon)
        {
            var _client = new HttpClient();
            string uri = $"https://api.bigdatacloud.net/data/reverse-geocode-client?latitude={lat}&longitude={lon}&localityLanguage=en";
            var response = await _client.GetAsync(uri);
            response.EnsureSuccessStatusCode();

            City wd = await response.Content.ReadFromJsonAsync<City>();

            string WithCity = wd.city;

            var city = new City()
            {
                city = wd.city
            };
            return city;


        }
    }
}
