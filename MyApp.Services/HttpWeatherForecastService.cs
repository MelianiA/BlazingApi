using Microsoft.Extensions.Options;
using MyApp.Models;
using MyApp.Models.Opts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class HttpWeatherForecastService : IWeatherForecastService
    {

        private readonly HttpClient client;

        public HttpWeatherForecastService(HttpClient client )
        {
            this.client = client;
        }

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            try
            {
                var response = await client.GetAsync("WeatherForecast");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var jsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    return System.Text.Json.JsonSerializer.Deserialize<WeatherForecast[]>(jsonData, jsonOptions);

                }
            }
            catch (Exception ex)
            {

               //je loggue
            }
            return new WeatherForecast[0];
        }
    }
}
