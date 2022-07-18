namespace AstronomicalAlgorithmsApi.Shared.Classes
{
    public class EasterDayClass
    {
        private int year = 0;
        public EasterDayClass(int year)
        {
            this.year = year;
        }


        /*
         * This algorithm was based on Astronomical Algorithms book by Jean Meeus         
         */

        public DateTime EasterDay()
        {
            int a = (this.year % 19);
            int b = (this.year / 100);
            int c = (this.year % 100);
            int d = (b / 4);
            int e = (b % 4);
            int f = ((b + 8) / 25);
            int g = ((b - f + 1) / 3);
            int h = (((19 * a) + b - d - g + 15) % 30);
            int i = (c / 4);
            int k = (c % 4);
            int l = ((32 + (2 * e) + (2 * i) - h - k) % 7);
            int m = ((a + (11 * h) + (22 * l)) / 451);
            int n = ((h + l - (7 * m) + 114) / 31);
            int p = ((h + l - (7 * m) + 114) % 31);
            return new DateTime(this.year, n, p + 1);
        }
    }
}
