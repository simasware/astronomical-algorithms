namespace AstronomicalAlgorithmsApi.Shared.Models
{
    public class AstroDateModel
    {
        public int Year { get; set; }
        public DateTime EventDate { get; set; }
        public string AstroDateName { get; set; } = String.Empty;

        public AstroDateModel(int year, DateTime date, string astroDateName)
        {
            this.Year = year;
            this.EventDate = date;
            this.AstroDateName = astroDateName;
        }
    }
}
