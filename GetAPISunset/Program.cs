using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using GetAPISunset.Services;
using GetAPISunset.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace GetAPISunset
{
    //sajbRMwINr1Lt5aJ00BGOA==YiUuGpbzfb7QuFqP
    //https://api.bigdatacloud.net/data/reverse-geocode-client?latitude=37.42159&longitude=-122.0837&localityLanguage=en
    
    class Program
    {
        static async Task Main(string[] args)
        {
            double latitude = 60.67452;
            double longitude = 17.14174;
            //string chosenCiy = "Ljusne";

            var _cityClient = new CityNameClient();
            //var _cityNamell = new CityNameFromName();

            var resultFromCity = await _cityClient.GetCityAsync(latitude, longitude);
            //var resultCityNameFromCity = await _cityNamell.GetCityFromCityAsync(chosenCiy);
            //var resultCityNameFromCity = await _cityNamell.GetCityFromCityAsync();

            Console.WriteLine(resultFromCity.city.ToString());
            //Console.WriteLine($"Latitude: {resultCityNameFromCity.Latitude} Longitude: {resultCityNameFromCity.Longitude} Ortsma; {resultCityNameFromCity.NameLLN}");
        }
    }
}