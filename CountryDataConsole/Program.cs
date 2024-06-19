using PSC.CSharp.Library.CountryData;
using PSC.CSharp.Library.CountryData.SVGImages;

var helper = new CountryHelper();
var data = helper.GetCountryData();

//get list of countries by their Names
var countries = data.Select(c => c.CountryName).ToList();
foreach (var country in countries)
    Console.WriteLine(country);

Console.WriteLine("");
Console.WriteLine("Regions for a country");

var regions = helper.GetRegionByCountryCode("IT");
foreach (var region in regions)
    Console.WriteLine(region.Name);

Console.WriteLine("");
Console.WriteLine("Flag for a country");

var flag = helper.GetFlagByCountryCode("IT", FlagType.Square);
Console.WriteLine(flag);

Console.WriteLine("");
Console.WriteLine("Emoji for a country");

var emoji = helper.GetCountryEmojiFlag("IT");
Console.WriteLine(emoji);