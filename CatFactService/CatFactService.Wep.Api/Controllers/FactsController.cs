using CatFactService.Data;
using CatFactService.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatFactService.Wep.Api.Controllers
{
    [ApiController]
    [Route("api/facts")]
    public class FactsController : Controller
    {
        private ICatService _service;

        public FactsController(ICatService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetFacts()
        {
            var facts = new { All = _service.GetFacts() };
            return Ok(facts);
        }

        [HttpGet]
        [Route("{catFactId:guid}")]
        public IActionResult GetFact([FromRoute] Guid catFactId)
        {
            var fact = _service.GetFactById(catFactId);
            return Ok(fact);
        }
    }
}
