

using SingletonDesingPattern;

var countries = await CountryProvider.Instance.GetCountriesAsync();

foreach (var country in countries)
{
	Console.WriteLine(country.CountryName);
}

//baska servisten çağrılırsa
var country1 = await CountryProvider.Instance.GetCountriesAsync();
Console.WriteLine(country1);
