using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SuperHeroApp.Models;
using System.Diagnostics;
using System.Net.Http.Headers;
namespace SuperHeroApp.Controllers
{
    public class DisplayHeroController : Controller
    {
        public async Task<IActionResult> Index(string name)
        {
            using (var clientApi = new HttpClient())
            {
                string token = "3263049927250542";
                name = name.ToLower().Replace(" ", "-");
                clientApi.BaseAddress = new Uri($"https://superheroapi.com/api/{token}/search/{name}");
                clientApi.DefaultRequestHeaders.Accept.Clear();
                clientApi.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage getData = await clientApi.GetAsync(clientApi.BaseAddress);
                if (getData.IsSuccessStatusCode)
                {
                    SuperHeroModel data = await getData.Content.ReadAsAsync<SuperHeroModel>();
                    ViewBag.user = data;
                }
                else
                {
                    Console.WriteLine("Error Fetching The data");
                }
            }
            return View();
        }
    }
}
