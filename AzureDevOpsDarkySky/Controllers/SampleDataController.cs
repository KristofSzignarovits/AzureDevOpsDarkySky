using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AzureDevOpsDarkySky.Models;

namespace AzureDevOpsDarkySky.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {

        private static string _url = "https://api.darksky.net/forecast/9841c4b2b003457c4a1c89477f8eba7b/47.4984,19.0405/";

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //public void Index()
        //{
        //    
        //}
        //
        [HttpGet("[action]")]
        public ActionResult<MainModel> Index()
        {
            MainModel mm = new MainModel();
            mm = JsonConvert.DeserializeObject<MainModel>(ExecuteQuery());
            mm.Currently.Temperature = (mm.Currently.Temperature-32)/1.8;
            return mm;
        }

        private string ExecuteQuery()
        {
            string queryResult = null;
            HttpResponseMessage httpResponseMessage = null;
            try
            {
                httpResponseMessage = GetHttpResponseAsync(_url).Result;
                var stream = httpResponseMessage.Content.ReadAsStreamAsync().Result;
                if (httpResponseMessage.IsSuccessStatusCode && stream != null)
                {
                    var responseReader = new StreamReader(stream);
                    queryResult = responseReader.ReadLine();
                }
                //httpResponseMessage.Dispose();
            }
            catch (Exception)
            {
                if (httpResponseMessage != null)
                {
                    httpResponseMessage.Dispose();
                }
            }
            return queryResult;
        }

        private async Task<HttpResponseMessage> GetHttpResponseAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.
                                        SendAsync(new HttpRequestMessage(HttpMethod.Get, url))
                                        .ConfigureAwait(false);
            }
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
