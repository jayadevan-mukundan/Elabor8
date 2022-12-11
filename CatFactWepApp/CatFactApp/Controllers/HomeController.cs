using CatFactApp.Models;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;

namespace CatFactApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<Models.CatFactDetailView> catFactList = new List<Models.CatFactDetailView>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(catFactList);
        }

        public async Task<IActionResult> GetCatFacts()
        {
            catFactList = await GetFacts();
            return View("Index", catFactList);
        }

        public async Task<IActionResult> GetCatFactsSummary()
        {
            catFactList = GetFacts().GetAwaiter().GetResult();

            var downloadCatFactList = catFactList
               .GroupBy(c => c.User.FullName)
               .Select(s => new { User = s.Key, TotalVotes = s.Sum(v => v.Votes) })
               .OrderByDescending(o => o.TotalVotes).ToList();

            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream))
                {
                    using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                    {
                        csvWriter.WriteRecords(downloadCatFactList);
                        streamWriter.Flush();
                        return File(memoryStream.ToArray(), "text/csv", "Summary.csv");
                    }
                }
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task<List<Models.CatFactDetailView>> GetFacts()
        {
            List<Models.CatFactDetailView> catFactList = new List<Models.CatFactDetailView>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5272/api/facts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dynamic allFacts = JsonConvert.DeserializeObject(apiResponse);
                    catFactList = JsonConvert.DeserializeObject<List<Models.CatFactDetailView>>(allFacts.all.ToString());
                }
            }
            return catFactList;
        }
    }
}