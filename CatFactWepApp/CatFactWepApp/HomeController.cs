using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CatFactWepApp
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var httpClient = new HttpClient())
            {
                List<Models.CatFactDetailView> catFactList = new List<Models.CatFactDetailView>();
                using (var response = await httpClient.GetAsync("http://localhost:5272/api/facts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    catFactList = JsonConvert.DeserializeObject<List<Models.CatFactDetailView>>(apiResponse);
                }
            }
            return View(catFactList);
        }
    }
}
