namespace Countries
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public float Area { get; set; }
        public string Region { get; set; }

        public Country(string _code, string _name, string _capital, int _population, float _area, string _region)
        {
            Code = _code;
            Name = _name;
            Capital = _capital;
            Population = _population;
            Area = _area;
            Region = _region;
        }
    }
}
