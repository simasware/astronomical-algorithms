using Microsoft.AspNetCore.Mvc;
using AstronomicalAlgorithmsApi.Shared;
using AstronomicalAlgorithmsApi.Shared.Models;
namespace AstronomicalAlgorithmsApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AstroDatesController : Controller
    {
        private AstroDateService astroDateService = new AstroDateService();
        [HttpGet(Name = "easter")]
        public IActionResult Easter([FromQuery(Name = "year")] int year)
        {
            AstroDateModel easterDayModel = this.astroDateService.getEasterDay(year);
            return Json(easterDayModel);
        }

        [HttpGet(Name = "carnaval")]
        public IActionResult Carnaval([FromQuery(Name = "year")] int year)
        {
            AstroDateModel easterDayModel = this.astroDateService.getCarnavalDay(year);
            return Json(easterDayModel);
        }

        [HttpGet(Name = "corpusChristi")]
        public IActionResult CorpusChristi([FromQuery(Name = "year")] int year)
        {
            AstroDateModel easterDayModel = this.astroDateService.getCorpusChristiDay(year);
            return Json(easterDayModel);
        }
    }
}
