using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Widget_Weather.Models;

namespace Widget_Weather.Controllers
{
    public class WeatherController: Controller
    {
        private readonly string apiKey = "yourApiKey";
        //static async Task CurrentWeather(string)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<IActionResult> Weather(string city)
        {
            HttpClient client = new HttpClient();
            if (string.IsNullOrEmpty(city))
                city = "Toulouse";
            
            {
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    HttpResponseMessage response = await client.GetAsync(string.Format("http://api.weatherbit.io/v2.0/current?city={0}&key={1}", city, apiKey));
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var jsonResponse = JsonSerializer.Deserialize<Root>(responseBody);

                        return View(jsonResponse);
                    }

                    throw new Exception("C'est cassé chef !");
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                    throw new Exception(e.Message);
                }
            }
            
        }
        
    }
}
