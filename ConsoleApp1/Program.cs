using Countries;
using System;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

Countries.CountryRepository.GetCountries();
List<Country> CountriesRest = new List<Country>();

string json = CountryRepository.GetCountries();
JArray json2 = JArray.Parse(json);

Console.WriteLine("broj:"+json2.Count);
foreach (JObject item in json2)
{
    if (item != null && item.GetValue("area")!=null)
    { string kod = (string)item.GetValue("code");

        string ime = (string)item.GetValue("name");
        string kapital = (string)item.GetValue("capital");
        int populacija = (int)item.GetValue("population");
        float area = (float)item.GetValue("area");
        string regija = (string)item.GetValue("region");
        CountriesRest.Add(new Country(kod, ime, kapital, populacija, area, regija));
    };

}


for (int i = 0; i < CountriesRest.Count; i++)
{
    Console.WriteLine(CountriesRest[i].Name + ' ' + CountriesRest[i].Capital);
}
