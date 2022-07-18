using AstronomicalAlgorithmsApi.Shared.Models;
using AstronomicalAlgorithmsApi.Shared.Classes;
namespace AstronomicalAlgorithmsApi.Shared
{    
    public class AstroDateService
    {
        public AstroDateModel getEasterDay(int year)
        {
            EasterDayClass easter = new EasterDayClass(year);            
            DateTime easterDate = easter.EasterDay();
            return new AstroDateModel(year, easterDate, "Páscoa");
        }

        public AstroDateModel getCarnavalDay(int year)
        {
            EasterDayClass easter = new EasterDayClass(year);
            DateTime easterDate = easter.EasterDay();
            return new AstroDateModel(year, easterDate.AddDays(-47), "Carnaval");
        }

        public AstroDateModel getCorpusChristiDay(int year)
        {
            EasterDayClass easter = new EasterDayClass(year);
            DateTime easterDate = easter.EasterDay();
            return new AstroDateModel(year, easterDate.AddDays(60), "Corpus Christi");
        }
    }
}
