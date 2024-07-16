# Country Data library for NET8

![countrydata_library](https://github.com/erossini/CSharpCountryData/assets/9497415/27b1d1ed-bc87-4d49-a7fd-89eaf1d0304b)

A simple cross-platform offline .NET library for getting country data. The library is based on the ISO-3166-1 standard.
Based on the operating system, using *Unicode*, you can display the flag of the country. On Windows, the _emoji_ displays the shortcode of the country, not the flag.

The library has the flags of the countries in SVG format. The flags can be displayed in two different types: `Square` and `Wide`.

## Install Library

To install the library in your project, open the *Package Manager* and type the following command:

```cSharp
Install-Package PSC.CSharp.Library.CountryData
```

Also, you can use the .NET CLI to install the library. Type the following command:

```cSharp
dotnet add package PSC.CSharp.Library.CountryData
```

## Usage

Here is an example how to use the library in your project.

### Initialize the CountryData

```cSharp
// loads all Country Data via the constructor (You can initialize this once as a singleton)
var countryHelper = new CountryHelper();
```

### Get the list of countries 

```cSharp
foreach (var country in countries) 
    Console.WriteLine(country);
```

### Get the list of regions in a country by country code

```cSharp
var regions = countryHelper.GetRegionByCountryCode("IT");
foreach (var region in regions)
    Console.WriteLine(region.Name);
```

### Using lambda for custom queries

`GetCountryData()` returns an `IEnumerable<Country>` which can be queried with Lambda for a more flexible usage.

```cSharp
var data = countryHelper.GetCountryData();
```

### Get the list of countries by their Names

This code displays the name of the countries using a `foreach`.

```cSharp
var countries = data.Select(c => c.CountryName).ToList();
foreach (var country in countries)
    Console.WriteLine(country);
```

Here the code to use `Linq` to filter the list.

```cSharp
data.Where(x => x.CountryShortCode == "US")
    .Select(r=>r.Regions).FirstOrDefault()
    .ToList();
```

### Get the flag for a country

In the library, I added a method to get the flag of a country. The flags are in SVG format. The type of the flag can be `Square` or `Wide`.

```cSharp
var flag = helper.GetFlagByCountryCode("GB", FlagType.Square);
```

## List of supported ISO-3166-1 country codes

Here is the list of supported ISO-3166-1 country codes, their code point pairs and `Emoji` flags. Based on the operating system, you see different _Emoji_.
In Windows, you see the short name of the country. In iOS and Android, the flag of the correspondent country is displayed.

| ISO | Emoji | Unicode         | Name                                         |
|-----|-------|-----------------|----------------------------------------------|
| AD  | 🇦🇩  | U+1F1E6 U+1F1E9 | Andorra                                      |
| AE  | 🇦🇪  | U+1F1E6 U+1F1EA | United Arab Emirates                         |
| AF  | 🇦🇫  | U+1F1E6 U+1F1EB | Afghanistan                                  |
| AG  | 🇦🇬  | U+1F1E6 U+1F1EC | Antigua and Barbuda                          |
| AI  | 🇦🇮  | U+1F1E6 U+1F1EE | Anguilla                                     |
| AL  | 🇦🇱  | U+1F1E6 U+1F1F1 | Albania                                      |
| AM  | 🇦🇲  | U+1F1E6 U+1F1F2 | Armenia                                      |
| AO  | 🇦🇴  | U+1F1E6 U+1F1F4 | Angola                                       |
| AQ  | 🇦🇶  | U+1F1E6 U+1F1F6 | Antarctica                                   |
| AR  | 🇦🇷  | U+1F1E6 U+1F1F7 | Argentina                                    |
| AS  | 🇦🇸  | U+1F1E6 U+1F1F8 | American Samoa                               |
| AT  | 🇦🇹  | U+1F1E6 U+1F1F9 | Austria                                      |
| AU  | 🇦🇺  | U+1F1E6 U+1F1FA | Australia                                    |
| AW  | 🇦🇼  | U+1F1E6 U+1F1FC | Aruba                                        |
| AX  | 🇦🇽  | U+1F1E6 U+1F1FD | Åland Islands                                |
| AZ  | 🇦🇿  | U+1F1E6 U+1F1FF | Azerbaijan                                   |
| BA  | 🇧🇦  | U+1F1E7 U+1F1E6 | Bosnia and Herzegovina                       |
| BB  | 🇧🇧  | U+1F1E7 U+1F1E7 | Barbados                                     |
| BD  | 🇧🇩  | U+1F1E7 U+1F1E9 | Bangladesh                                   |
| BE  | 🇧🇪  | U+1F1E7 U+1F1EA | Belgium                                      |
| BF  | 🇧🇫  | U+1F1E7 U+1F1EB | Burkina Faso                                 |
| BG  | 🇧🇬  | U+1F1E7 U+1F1EC | Bulgaria                                     |
| BH  | 🇧🇭  | U+1F1E7 U+1F1ED | Bahrain                                      |
| BI  | 🇧🇮  | U+1F1E7 U+1F1EE | Burundi                                      |
| BJ  | 🇧🇯  | U+1F1E7 U+1F1EF | Benin                                        |
| BL  | 🇧🇱  | U+1F1E7 U+1F1F1 | Saint Barthélemy                             |
| BM  | 🇧🇲  | U+1F1E7 U+1F1F2 | Bermuda                                      |
| BN  | 🇧🇳  | U+1F1E7 U+1F1F3 | Brunei Darussalam                            |
| BO  | 🇧🇴  | U+1F1E7 U+1F1F4 | Bolivia                                      |
| BQ  | 🇧🇶  | U+1F1E7 U+1F1F6 | Bonaire, Sint Eustatius and Saba             |
| BR  | 🇧🇷  | U+1F1E7 U+1F1F7 | Brazil                                       |
| BS  | 🇧🇸  | U+1F1E7 U+1F1F8 | Bahamas                                      |
| BT  | 🇧🇹  | U+1F1E7 U+1F1F9 | Bhutan                                       |
| BV  | 🇧🇻  | U+1F1E7 U+1F1FB | Bouvet Island                                |
| BW  | 🇧🇼  | U+1F1E7 U+1F1FC | Botswana                                     |
| BY  | 🇧🇾  | U+1F1E7 U+1F1FE | Belarus                                      |
| BZ  | 🇧🇿  | U+1F1E7 U+1F1FF | Belize                                       |
| CA  | 🇨🇦  | U+1F1E8 U+1F1E6 | Canada                                       |
| CC  | 🇨🇨  | U+1F1E8 U+1F1E8 | Cocos (Keeling) Islands                      |
| CD  | 🇨🇩  | U+1F1E8 U+1F1E9 | Congo                                        |
| CF  | 🇨🇫  | U+1F1E8 U+1F1EB | Central African Republic                     |
| CG  | 🇨🇬  | U+1F1E8 U+1F1EC | Congo                                        |
| CH  | 🇨🇭  | U+1F1E8 U+1F1ED | Switzerland                                  |
| CI  | 🇨🇮  | U+1F1E8 U+1F1EE | Côte D'Ivoire                                |
| CK  | 🇨🇰  | U+1F1E8 U+1F1F0 | Cook Islands                                 |
| CL  | 🇨🇱  | U+1F1E8 U+1F1F1 | Chile                                        |
| CM  | 🇨🇲  | U+1F1E8 U+1F1F2 | Cameroon                                     |
| CN  | 🇨🇳  | U+1F1E8 U+1F1F3 | China                                        |
| CO  | 🇨🇴  | U+1F1E8 U+1F1F4 | Colombia                                     |
| CR  | 🇨🇷  | U+1F1E8 U+1F1F7 | Costa Rica                                   |
| CU  | 🇨🇺  | U+1F1E8 U+1F1FA | Cuba                                         |
| CV  | 🇨🇻  | U+1F1E8 U+1F1FB | Cape Verde                                   |
| CW  | 🇨🇼  | U+1F1E8 U+1F1FC | Curaçao                                      |
| CX  | 🇨🇽  | U+1F1E8 U+1F1FD | Christmas Island                             |
| CY  | 🇨🇾  | U+1F1E8 U+1F1FE | Cyprus                                       |
| CZ  | 🇨🇿  | U+1F1E8 U+1F1FF | Czech Republic                               |
| DE  | 🇩🇪  | U+1F1E9 U+1F1EA | Germany                                      |
| DJ  | 🇩🇯  | U+1F1E9 U+1F1EF | Djibouti                                     |
| DK  | 🇩🇰  | U+1F1E9 U+1F1F0 | Denmark                                      |
| DM  | 🇩🇲  | U+1F1E9 U+1F1F2 | Dominica                                     |
| DO  | 🇩🇴  | U+1F1E9 U+1F1F4 | Dominican Republic                           |
| DZ  | 🇩🇿  | U+1F1E9 U+1F1FF | Algeria                                      |
| EC  | 🇪🇨  | U+1F1EA U+1F1E8 | Ecuador                                      |
| EE  | 🇪🇪  | U+1F1EA U+1F1EA | Estonia                                      |
| EG  | 🇪🇬  | U+1F1EA U+1F1EC | Egypt                                        |
| EH  | 🇪🇭  | U+1F1EA U+1F1ED | Western Sahara                               |
| ER  | 🇪🇷  | U+1F1EA U+1F1F7 | Eritrea                                      |
| ES  | 🇪🇸  | U+1F1EA U+1F1F8 | Spain                                        |
| ET  | 🇪🇹  | U+1F1EA U+1F1F9 | Ethiopia                                     |
| FI  | 🇫🇮  | U+1F1EB U+1F1EE | Finland                                      |
| FJ  | 🇫🇯  | U+1F1EB U+1F1EF | Fiji                                         |
| FK  | 🇫🇰  | U+1F1EB U+1F1F0 | Falkland Islands (Malvinas)                  |
| FM  | 🇫🇲  | U+1F1EB U+1F1F2 | Micronesia                                   |
| FO  | 🇫🇴  | U+1F1EB U+1F1F4 | Faroe Islands                                |
| FR  | 🇫🇷  | U+1F1EB U+1F1F7 | France                                       |
| GA  | 🇬🇦  | U+1F1EC U+1F1E6 | Gabon                                        |
| GB  | 🇬🇧  | U+1F1EC U+1F1E7 | United Kingdom                               |
| GD  | 🇬🇩  | U+1F1EC U+1F1E9 | Grenada                                      |
| GE  | 🇬🇪  | U+1F1EC U+1F1EA | Georgia                                      |
| GF  | 🇬🇫  | U+1F1EC U+1F1EB | French Guiana                                |
| GG  | 🇬🇬  | U+1F1EC U+1F1EC | Guernsey                                     |
| GH  | 🇬🇭  | U+1F1EC U+1F1ED | Ghana                                        |
| GI  | 🇬🇮  | U+1F1EC U+1F1EE | Gibraltar                                    |
| GL  | 🇬🇱  | U+1F1EC U+1F1F1 | Greenland                                    |
| GM  | 🇬🇲  | U+1F1EC U+1F1F2 | Gambia                                       |
| GN  | 🇬🇳  | U+1F1EC U+1F1F3 | Guinea                                       |
| GP  | 🇬🇵  | U+1F1EC U+1F1F5 | Guadeloupe                                   |
| GQ  | 🇬🇶  | U+1F1EC U+1F1F6 | Equatorial Guinea                            |
| GR  | 🇬🇷  | U+1F1EC U+1F1F7 | Greece                                       |
| GS  | 🇬🇸  | U+1F1EC U+1F1F8 | South Georgia                                |
| GT  | 🇬🇹  | U+1F1EC U+1F1F9 | Guatemala                                    |
| GU  | 🇬🇺  | U+1F1EC U+1F1FA | Guam                                         |
| GW  | 🇬🇼  | U+1F1EC U+1F1FC | Guinea-Bissau                                |
| GY  | 🇬🇾  | U+1F1EC U+1F1FE | Guyana                                       |
| HK  | 🇭🇰  | U+1F1ED U+1F1F0 | Hong Kong                                    |
| HM  | 🇭🇲  | U+1F1ED U+1F1F2 | Heard Island and Mcdonald Islands            |
| HN  | 🇭🇳  | U+1F1ED U+1F1F3 | Honduras                                     |
| HR  | 🇭🇷  | U+1F1ED U+1F1F7 | Croatia                                      |
| HT  | 🇭🇹  | U+1F1ED U+1F1F9 | Haiti                                        |
| HU  | 🇭🇺  | U+1F1ED U+1F1FA | Hungary                                      |
| ID  | 🇮🇩  | U+1F1EE U+1F1E9 | Indonesia                                    |
| IE  | 🇮🇪  | U+1F1EE U+1F1EA | Ireland                                      |
| IL  | 🇮🇱  | U+1F1EE U+1F1F1 | Israel                                       |
| IM  | 🇮🇲  | U+1F1EE U+1F1F2 | Isle of Man                                  |
| IN  | 🇮🇳  | U+1F1EE U+1F1F3 | India                                        |
| IO  | 🇮🇴  | U+1F1EE U+1F1F4 | British Indian Ocean Territory               |
| IQ  | 🇮🇶  | U+1F1EE U+1F1F6 | Iraq                                         |
| IR  | 🇮🇷  | U+1F1EE U+1F1F7 | Iran                                         |
| IS  | 🇮🇸  | U+1F1EE U+1F1F8 | Iceland                                      |
| IT  | 🇮🇹  | U+1F1EE U+1F1F9 | Italy                                        |
| JE  | 🇯🇪  | U+1F1EF U+1F1EA | Jersey                                       |
| JM  | 🇯🇲  | U+1F1EF U+1F1F2 | Jamaica                                      |
| JO  | 🇯🇴  | U+1F1EF U+1F1F4 | Jordan                                       |
| JP  | 🇯🇵  | U+1F1EF U+1F1F5 | Japan                                        |
| KE  | 🇰🇪  | U+1F1F0 U+1F1EA | Kenya                                        |
| KG  | 🇰🇬  | U+1F1F0 U+1F1EC | Kyrgyzstan                                   |
| KH  | 🇰🇭  | U+1F1F0 U+1F1ED | Cambodia                                     |
| KI  | 🇰🇮  | U+1F1F0 U+1F1EE | Kiribati                                     |
| KM  | 🇰🇲  | U+1F1F0 U+1F1F2 | Comoros                                      |
| KN  | 🇰🇳  | U+1F1F0 U+1F1F3 | Saint Kitts and Nevis                        |
| KP  | 🇰🇵  | U+1F1F0 U+1F1F5 | North Korea                                  |
| KR  | 🇰🇷  | U+1F1F0 U+1F1F7 | South Korea                                  |
| KW  | 🇰🇼  | U+1F1F0 U+1F1FC | Kuwait                                       |
| KY  | 🇰🇾  | U+1F1F0 U+1F1FE | Cayman Islands                               |
| KZ  | 🇰🇿  | U+1F1F0 U+1F1FF | Kazakhstan                                   |
| LA  | 🇱🇦  | U+1F1F1 U+1F1E6 | Lao People's Democratic Republic             |
| LB  | 🇱🇧  | U+1F1F1 U+1F1E7 | Lebanon                                      |
| LC  | 🇱🇨  | U+1F1F1 U+1F1E8 | Saint Lucia                                  |
| LI  | 🇱🇮  | U+1F1F1 U+1F1EE | Liechtenstein                                |
| LK  | 🇱🇰  | U+1F1F1 U+1F1F0 | Sri Lanka                                    |
| LR  | 🇱🇷  | U+1F1F1 U+1F1F7 | Liberia                                      |
| LS  | 🇱🇸  | U+1F1F1 U+1F1F8 | Lesotho                                      |
| LT  | 🇱🇹  | U+1F1F1 U+1F1F9 | Lithuania                                    |
| LU  | 🇱🇺  | U+1F1F1 U+1F1FA | Luxembourg                                   |
| LV  | 🇱🇻  | U+1F1F1 U+1F1FB | Latvia                                       |
| LY  | 🇱🇾  | U+1F1F1 U+1F1FE | Libya                                        |
| MA  | 🇲🇦  | U+1F1F2 U+1F1E6 | Morocco                                      |
| MC  | 🇲🇨  | U+1F1F2 U+1F1E8 | Monaco                                       |
| MD  | 🇲🇩  | U+1F1F2 U+1F1E9 | Moldova                                      |
| ME  | 🇲🇪  | U+1F1F2 U+1F1EA | Montenegro                                   |
| MF  | 🇲🇫  | U+1F1F2 U+1F1EB | Saint Martin (French Part)                   |
| MG  | 🇲🇬  | U+1F1F2 U+1F1EC | Madagascar                                   |
| MH  | 🇲🇭  | U+1F1F2 U+1F1ED | Marshall Islands                             |
| MK  | 🇲🇰  | U+1F1F2 U+1F1F0 | Macedonia                                    |
| ML  | 🇲🇱  | U+1F1F2 U+1F1F1 | Mali                                         |
| MM  | 🇲🇲  | U+1F1F2 U+1F1F2 | Myanmar                                      |
| MN  | 🇲🇳  | U+1F1F2 U+1F1F3 | Mongolia                                     |
| MO  | 🇲🇴  | U+1F1F2 U+1F1F4 | Macao                                        |
| MP  | 🇲🇵  | U+1F1F2 U+1F1F5 | Northern Mariana Islands                     |
| MQ  | 🇲🇶  | U+1F1F2 U+1F1F6 | Martinique                                   |
| MR  | 🇲🇷  | U+1F1F2 U+1F1F7 | Mauritania                                   |
| MS  | 🇲🇸  | U+1F1F2 U+1F1F8 | Montserrat                                   |
| MT  | 🇲🇹  | U+1F1F2 U+1F1F9 | Malta                                        |
| MU  | 🇲🇺  | U+1F1F2 U+1F1FA | Mauritius                                    |
| MV  | 🇲🇻  | U+1F1F2 U+1F1FB | Maldives                                     |
| MW  | 🇲🇼  | U+1F1F2 U+1F1FC | Malawi                                       |
| MX  | 🇲🇽  | U+1F1F2 U+1F1FD | Mexico                                       |
| MY  | 🇲🇾  | U+1F1F2 U+1F1FE | Malaysia                                     |
| MZ  | 🇲🇿  | U+1F1F2 U+1F1FF | Mozambique                                   |
| NA  | 🇳🇦  | U+1F1F3 U+1F1E6 | Namibia                                      |
| NC  | 🇳🇨  | U+1F1F3 U+1F1E8 | New Caledonia                                |
| NE  | 🇳🇪  | U+1F1F3 U+1F1EA | Niger                                        |
| NF  | 🇳🇫  | U+1F1F3 U+1F1EB | Norfolk Island                               |
| NG  | 🇳🇬  | U+1F1F3 U+1F1EC | Nigeria                                      |
| NI  | 🇳🇮  | U+1F1F3 U+1F1EE | Nicaragua                                    |
| NL  | 🇳🇱  | U+1F1F3 U+1F1F1 | Netherlands                                  |
| NO  | 🇳🇴  | U+1F1F3 U+1F1F4 | Norway                                       |
| NP  | 🇳🇵  | U+1F1F3 U+1F1F5 | Nepal                                        |
| NR  | 🇳🇷  | U+1F1F3 U+1F1F7 | Nauru                                        |
| NU  | 🇳🇺  | U+1F1F3 U+1F1FA | Niue                                         |
| NZ  | 🇳🇿  | U+1F1F3 U+1F1FF | New Zealand                                  |
| OM  | 🇴🇲  | U+1F1F4 U+1F1F2 | Oman                                         |
| PA  | 🇵🇦  | U+1F1F5 U+1F1E6 | Panama                                       |
| PE  | 🇵🇪  | U+1F1F5 U+1F1EA | Peru                                         |
| PF  | 🇵🇫  | U+1F1F5 U+1F1EB | French Polynesia                             |
| PG  | 🇵🇬  | U+1F1F5 U+1F1EC | Papua New Guinea                             |
| PH  | 🇵🇭  | U+1F1F5 U+1F1ED | Philippines                                  |
| PK  | 🇵🇰  | U+1F1F5 U+1F1F0 | Pakistan                                     |
| PL  | 🇵🇱  | U+1F1F5 U+1F1F1 | Poland                                       |
| PM  | 🇵🇲  | U+1F1F5 U+1F1F2 | Saint Pierre and Miquelon                    |
| PN  | 🇵🇳  | U+1F1F5 U+1F1F3 | Pitcairn                                     |
| PR  | 🇵🇷  | U+1F1F5 U+1F1F7 | Puerto Rico                                  |
| PS  | 🇵🇸  | U+1F1F5 U+1F1F8 | Palestinian Territory                        |
| PT  | 🇵🇹  | U+1F1F5 U+1F1F9 | Portugal                                     |
| PW  | 🇵🇼  | U+1F1F5 U+1F1FC | Palau                                        |
| PY  | 🇵🇾  | U+1F1F5 U+1F1FE | Paraguay                                     |
| QA  | 🇶🇦  | U+1F1F6 U+1F1E6 | Qatar                                        |
| RE  | 🇷🇪  | U+1F1F7 U+1F1EA | Réunion                                      |
| RO  | 🇷🇴  | U+1F1F7 U+1F1F4 | Romania                                      |
| RS  | 🇷🇸  | U+1F1F7 U+1F1F8 | Serbia                                       |
| RU  | 🇷🇺  | U+1F1F7 U+1F1FA | Russia                                       |
| RW  | 🇷🇼  | U+1F1F7 U+1F1FC | Rwanda                                       |
| SA  | 🇸🇦  | U+1F1F8 U+1F1E6 | Saudi Arabia                                 |
| SB  | 🇸🇧  | U+1F1F8 U+1F1E7 | Solomon Islands                              |
| SC  | 🇸🇨  | U+1F1F8 U+1F1E8 | Seychelles                                   |
| SD  | 🇸🇩  | U+1F1F8 U+1F1E9 | Sudan                                        |
| SE  | 🇸🇪  | U+1F1F8 U+1F1EA | Sweden                                       |
| SG  | 🇸🇬  | U+1F1F8 U+1F1EC | Singapore                                    |
| SH  | 🇸🇭  | U+1F1F8 U+1F1ED | Saint Helena, Ascension and Tristan Da Cunha |
| SI  | 🇸🇮  | U+1F1F8 U+1F1EE | Slovenia                                     |
| SJ  | 🇸🇯  | U+1F1F8 U+1F1EF | Svalbard and Jan Mayen                       |
| SK  | 🇸🇰  | U+1F1F8 U+1F1F0 | Slovakia                                     |
| SL  | 🇸🇱  | U+1F1F8 U+1F1F1 | Sierra Leone                                 |
| SM  | 🇸🇲  | U+1F1F8 U+1F1F2 | San Marino                                   |
| SN  | 🇸🇳  | U+1F1F8 U+1F1F3 | Senegal                                      |
| SO  | 🇸🇴  | U+1F1F8 U+1F1F4 | Somalia                                      |
| SR  | 🇸🇷  | U+1F1F8 U+1F1F7 | Suriname                                     |
| SS  | 🇸🇸  | U+1F1F8 U+1F1F8 | South Sudan                                  |
| ST  | 🇸🇹  | U+1F1F8 U+1F1F9 | Sao Tome and Principe                        |
| SV  | 🇸🇻  | U+1F1F8 U+1F1FB | El Salvador                                  |
| SX  | 🇸🇽  | U+1F1F8 U+1F1FD | Sint Maarten (Dutch Part)                    |
| SY  | 🇸🇾  | U+1F1F8 U+1F1FE | Syrian Arab Republic                         |
| SZ  | 🇸🇿  | U+1F1F8 U+1F1FF | Swaziland                                    |
| TC  | 🇹🇨  | U+1F1F9 U+1F1E8 | Turks and Caicos Islands                     |
| TD  | 🇹🇩  | U+1F1F9 U+1F1E9 | Chad                                         |
| TF  | 🇹🇫  | U+1F1F9 U+1F1EB | French Southern Territories                  |
| TG  | 🇹🇬  | U+1F1F9 U+1F1EC | Togo                                         |
| TH  | 🇹🇭  | U+1F1F9 U+1F1ED | Thailand                                     |
| TJ  | 🇹🇯  | U+1F1F9 U+1F1EF | Tajikistan                                   |
| TK  | 🇹🇰  | U+1F1F9 U+1F1F0 | Tokelau                                      |
| TL  | 🇹🇱  | U+1F1F9 U+1F1F1 | Timor-Leste                                  |
| TM  | 🇹🇲  | U+1F1F9 U+1F1F2 | Turkmenistan                                 |
| TN  | 🇹🇳  | U+1F1F9 U+1F1F3 | Tunisia                                      |
| TO  | 🇹🇴  | U+1F1F9 U+1F1F4 | Tonga                                        |
| TR  | 🇹🇷  | U+1F1F9 U+1F1F7 | Turkey                                       |
| TT  | 🇹🇹  | U+1F1F9 U+1F1F9 | Trinidad and Tobago                          |
| TV  | 🇹🇻  | U+1F1F9 U+1F1FB | Tuvalu                                       |
| TW  | 🇹🇼  | U+1F1F9 U+1F1FC | Taiwan                                       |
| TZ  | 🇹🇿  | U+1F1F9 U+1F1FF | Tanzania                                     |
| UA  | 🇺🇦  | U+1F1FA U+1F1E6 | Ukraine                                      |
| UG  | 🇺🇬  | U+1F1FA U+1F1EC | Uganda                                       |
| UM  | 🇺🇲  | U+1F1FA U+1F1F2 | United States Minor Outlying Islands         |
| US  | 🇺🇸  | U+1F1FA U+1F1F8 | United States                                |
| UY  | 🇺🇾  | U+1F1FA U+1F1FE | Uruguay                                      |
| UZ  | 🇺🇿  | U+1F1FA U+1F1FF | Uzbekistan                                   |
| VA  | 🇻🇦  | U+1F1FB U+1F1E6 | Vatican City                                 |
| VC  | 🇻🇨  | U+1F1FB U+1F1E8 | Saint Vincent and The Grenadines             |
| VE  | 🇻🇪  | U+1F1FB U+1F1EA | Venezuela                                    |
| VG  | 🇻🇬  | U+1F1FB U+1F1EC | Virgin Islands, British                      |
| VI  | 🇻🇮  | U+1F1FB U+1F1EE | Virgin Islands, U.S.                         |
| VN  | 🇻🇳  | U+1F1FB U+1F1F3 | Viet Nam                                     |
| VU  | 🇻🇺  | U+1F1FB U+1F1FA | Vanuatu                                      |
| WF  | 🇼🇫  | U+1F1FC U+1F1EB | Wallis and Futuna                            |
| WS  | 🇼🇸  | U+1F1FC U+1F1F8 | Samoa                                        |
| YE  | 🇾🇪  | U+1F1FE U+1F1EA | Yemen                                        |
| YT  | 🇾🇹  | U+1F1FE U+1F1F9 | Mayotte                                      |
| ZA  | 🇿🇦  | U+1F1FF U+1F1E6 | South Africa                                 |
| ZM  | 🇿🇲  | U+1F1FF U+1F1F2 | Zambia                                       |
| ZW  | 🇿🇼  | U+1F1FF U+1F1FC | Zimbabwe                                     |

## Functions

| Function               | Return               | Description                                                 |
|------------------------|----------------------|-------------------------------------------------------------|
| GetCountries()         | IEnumerable<string>  | Gets the list of all countries in the world                 |
| GetCountryByCode       | Country              | Returns a single Country Data by ShortCode                  |
| GetCountryData()       | IEnumerable<Country> | Gets the list of all countries in the world with their data |
| GetCountryEmojiFlag    | string               | Returns the Emoji Flag of a country by ShortCode            |
| GetRegionByCountryCode | List<Regions>        | Returns the Regions of a country by ShortCode               |
| GetJsonData            | string               | Returns the JSON Data of all countries in the world         |

### Flags

| Function               | Return               | Description                                                 |
|------------------------|----------------------|-------------------------------------------------------------|
| GetFlagByCountryCode   | string               | Returns the Flag of a country by ShortCode                  |
| GetFlagData            | FlagModel            | Return the `FlagModel` of one country by ShortCode          |
| GetNameByCountryCode   | string               | Returns the Name of a country by ShortCode                  |

### Get a full SVG

The `GetFlagByCountryCode` returns only the content of the SVG file. What it doesn't have is the `XML` declaration and the `DOCTYPE` declaration. 
If you want to get the full SVG file, you can use the `GetFullSVG` function in the `SVGFlags` static class.

```csharp
var svgFlag = SVGFlags.GetFullSVG(SVGFlags.lgbt_1, "300", "300");
```

---
    
## PureSourceCode.com

[PureSourceCode.com](https://www.puresourcecode.com/) is my personal blog where I publish posts about technologies and in particular source code and projects in [.NET](https://www.puresourcecode.com/category/dotnet/). 

In the last few months, I created a lot of components for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/).

My name is Enrico Rossini and you can contact me via:
- [Personal Twitter](https://twitter.com/erossiniuk)
- [LinkedIn](https://www.linkedin.com/in/rossiniuk)
- [Facebook](https://www.facebook.com/puresourcecode)

## Blazor Components

| Component name | Forum | NuGet | Website | Description |
|---|---|---|---|---|
| [AnchorLink]() | [Forum](https://puresourcecode.com/forum/anchorlink/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.AnchorLink) | | An anchor link is a web link that allows users to leapfrog to a specific point on a website page. It saves them the need to scroll and skim read and makes navigation easier. This component is for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Autocomplete for Blazor](https://www.puresourcecode.com/dotnet/net-core/autocomplete-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/autocomplete-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Autocomplete) | | Simple and flexible autocomplete type-ahead functionality for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.BrowserDetect) | [Demo](https://browserdetect.puresourcecode.com) | Browser detect for Blazor WebAssembly and Blazor Server |
| [ChartJs for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/chart-js-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Chartjs) | [Demo](https://chartjs.puresourcecode.com/) | Add beautiful graphs based on ChartJs in your Blazor application |
| [Clippy for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/clippy/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Clippy) | [Demo](https://clippy.puresourcecode.com/) | Do you miss Clippy? Here the implementation for Blazor |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CodeSnippet) | | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CopyToClipboard) | | Add a button to copy text in the clipboard | 
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.DataTable) | [Demo](https://datatable.puresourcecode.com/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Google Tag Manager]() | [Forum]() | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.GoogleTagManager) | [Demo](https://datatable.puresourcecode.com/) | Adds Google Tag Manager to the application and manages communication with GTM JavaScript (data layer). |
| [Icons and flags for Blazor](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Icons) | | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| [ImageSelect for Blazor]() | [Forum](https://puresourcecode.com/forum/imageselect/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ImageSelect) | | This is a Blazor component to display a dropdown list with images based on ms-Dropdown by Marghoob Suleman. This component is built with NET7 for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.MarkdownEditor) | [Demo](https://markdown.puresourcecode.com/) | This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ModalDialog) | | Simple Modal Dialog for Blazor WebAssembly |
| [Modal windows for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Modals) | | Modal Windows for Blazor WebAssembly |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Quill) | | Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [ScrollTabs](https://www.puresourcecode.com/dotnet/blazor/scrolltabs-component-for-blazor/) | | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ScrollTabs) | | Tabs with nice scroll (no scrollbar) and responsive |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Segments) | | This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tabs) | | This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [Timeline for Blazor](https://www.puresourcecode.com/dotnet/blazor/timeline-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/timeline/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Timeline) | | This is a new responsive timeline  for Blazor Web Assembly and Blazor Server |
| [Toast for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Toast) | | Toast notification for Blazor applications |
| [Tours for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tours) | | Guide your users in your Blazor applications |
| [TreeView for Blazor]() | [Forum](https://puresourcecode.com/forum/treeview/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.TreeView) | | This component is a native Blazor TreeView component for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/). The component is built with .NET7. |
| [WorldMap for Blazor](https://puresourcecode.com/dotnet/blazor/world-map-component-for-blazor) | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.WorldMap) | [Demo](https://worldmap.puresourcecode.com/) | Show world maps with your data |

## C# libraries for .NET6

| Component name | Forum | NuGet | Description |
|---|---|---|---|
| [PSC.Evaluator](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Evaluator) | PSC.Evaluator is a mathematical expressions evaluator library written in C#. Allows to evaluate mathematical, boolean, string and datetime expressions. |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Extensions) | A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |

## C# libraries for .NET8
| Component name | Forum | NuGet | Description |
|---|---|---|---|
| [PSC.CSharp.Library.CountryData](https://puresourcecode.com/dotnet/net8/country-data-library-for-net8/) | | ![NuGet badge](https://img.shields.io/nuget/v/PSC.CSharp.Library.CountryData) | A simple cross platform offline .NET library for getting country data. |
| PSC.CSharp.Library.LanguageData | | ![NuGet badge](https://img.shields.io/nuget/v/PSC.CSharp.Library.LanguageData) | This library is a comprehensive language code information, consisting of ISO 639-1, ISO 639-2 and IETF language types for C#. |

## More examples and documentation

### Blazor
*   [Write a reusable Blazor component](https://www.puresourcecode.com/dotnet/blazor/write-a-reusable-blazor-component/)
*   [Getting Started With C# And Blazor](https://www.puresourcecode.com/dotnet/net-core/getting-started-with-c-and-blazor/)
*   [Setting Up A Blazor WebAssembly Application](https://www.puresourcecode.com/dotnet/blazor/setting-up-a-blazor-webassembly-application/)
*   [Working With Blazor Component Model](https://www.puresourcecode.com/dotnet/blazor/working-with-blazors-component-model/)
*   [Secure Blazor WebAssembly With IdentityServer4](https://www.puresourcecode.com/dotnet/blazor/secure-blazor-webassembly-with-identityserver4/)
*   [Blazor Using HttpClient With Authentication](https://www.puresourcecode.com/dotnet/blazor/blazor-using-httpclient-with-authentication/)
*   [InputSelect component for enumerations in Blazor](https://www.puresourcecode.com/dotnet/blazor/inputselect-component-for-enumerations-in-blazor/)
*   [Use LocalStorage with Blazor WebAssembly](https://www.puresourcecode.com/dotnet/blazor/use-localstorage-with-blazor-webassembly/)
*   [Modal Dialog component for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/)
*   [Create Tooltip component for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-tooltip-component-for-blazor/)
*   [Consume ASP.NET Core Razor components from Razor class libraries | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-5.0&tabs=visual-studio)
*   [ChartJs component for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/)
*   [Labels and OnClickChart for ChartJs](https://www.puresourcecode.com/dotnet/blazor/labels-and-onclickchart-for-chartjs/)

### Blazor & NET8
* [Custom User Management with NET8 and Blazor (1st part)](https://puresourcecode.com/dotnet/blazor/custom-user-management-with-net8-and-blazor/)
* [NET8, Blazor and Custom User Management (2nd part)](https://puresourcecode.com/dotnet/blazor/net8-blazor-and-custom-user-management/)
