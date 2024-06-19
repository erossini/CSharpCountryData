using PSC.CSharp.Library.CountryData.SVGImages;
using System.Reflection;
using System.Text.Json;

namespace PSC.CSharp.Library.CountryData
{
    public class CountryHelper
    {
        #region Variables

        /// <summary>
        /// The string file name
        /// </summary>
        private const string strFileName = "PSC.CSharp.Library.CountryData.data.json";

        /// <summary>
        /// The countries
        /// </summary>
        private readonly IEnumerable<Country> _Countries;

        #endregion Variables

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryHelper"/> class.
        /// </summary>
        public CountryHelper()
        {
            var json = GetJsonData(strFileName);
            _Countries = JsonSerializer.Deserialize<List<Country>>(json);
            foreach (var country in _Countries)
            {
                country.CountryFlag = GetCountryEmojiFlag(country.CountryShortCode);
            }
        }

        /// <summary>
        /// Gets the list of all countries in the world
        /// </summary>
        /// <returns>IEnumerable<string> countries</returns>
        public IEnumerable<string> GetCountries() => _Countries.Select(c => c.CountryName);

        /// <summary>
        /// Returns a single Country Data by ShortCode
        /// </summary>
        /// <param name="ShortCode"></param>
        /// <returns>Country</returns>
        public Country GetCountryByCode(string shortCode)
        {
            return _Countries.SingleOrDefault(c => c.CountryShortCode == shortCode);
        }

        /// <summary>
        /// Returns All Country Data (Region, ShortCode, Country Name) and it is querable
        /// </summary>
        /// <returns>IEnumerable<Country></returns>
        public IEnumerable<Country> GetCountryData()
        {
            return _Countries;
        }

        /// <summary>
        /// Gets the flag of the country, in the form of an Emoji.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public string GetCountryEmojiFlag(string shortCode)
        {
            return string.Concat(shortCode.ToUpper().Select(x => char.ConvertFromUtf32(x + 0x1F1A5)));
        }

        /// <summary>
        /// Selects Regions in a Particular Country
        /// </summary>
        /// <param name="ShortCode"></param>
        /// <returns>List<Regions> a list of regions</returns>
        public List<Regions> GetRegionByCountryCode(string ShortCode)
        {
            return _Countries.Where(x => x.CountryShortCode == ShortCode)
                             .Select(r => r.Regions).FirstOrDefault()
                             .ToList();
        }

        /// <summary>
        /// Gets the json data.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>System.String.</returns>
        private string GetJsonData(string path)
        {
            string json = "";
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(path))
            {
                var reader = new StreamReader(stream);
                json = reader.ReadToEnd();
            }
            return json;
        }

        #region Flags

        /// <summary>
        /// Gets the flag by country code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="flagType">Type of the flag.</param>
        /// <returns></returns>
        public string GetFlagByCountryCode(string code, FlagType flagType)
        {
            string rtn = "";

            var fl = SVGFlags.FlagModels.Where(f => f.Code.ToLower() == code.ToLower()).FirstOrDefault();
            if (fl != null)
                rtn = flagType == FlagType.Square ? fl.FlagSquare : fl.FlagWide;
            else
                rtn = flagType == FlagType.Square ? SVGFlags.xx_1 : SVGFlags.xx_2;

            return rtn;
        }

        /// <summary>
        /// Gets the flag data.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns>System.Nullable&lt;FlagModel&gt;.</returns>
        public FlagModel? GetFlagData(string code)
        {
            return SVGFlags.FlagModels.Where(f => f.Code.ToLower() == code.ToLower()).FirstOrDefault();
        }

        /// <summary>
        /// Gets the name by country code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        public string GetNameByCountryCode(string code)
        {
            string rtn = "";

            var fl = SVGFlags.FlagModels.Where(f => f.Code.ToLower() == code.ToLower()).FirstOrDefault();
            if (fl != null)
                rtn = fl.Name;

            return rtn;
        }

        #endregion Flags
    }
}