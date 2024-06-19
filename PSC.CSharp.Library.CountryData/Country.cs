using PSC.CSharp.Library.CountryData.SVGImages;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PSC.CSharp.Library.CountryData
{
    /// <summary>
    /// Class Country.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Gets or sets the country flag.
        /// </summary>
        /// <value>The country flag.</value>
        [JsonPropertyName("countryFlag")]
        public string? CountryFlag { get; set; }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        /// <value>The name of the country.</value>
        [JsonPropertyName("countryName")]
        public string? CountryName { get; set; }

        /// <summary>
        /// Gets or sets the country short code.
        /// </summary>
        /// <value>The country short code.</value>
        [JsonPropertyName("countryShortCode")]
        public string? CountryShortCode { get; set; }

        /// <summary>
        /// Gets or sets the regions.
        /// </summary>
        /// <value>The regions.</value>
        [JsonPropertyName("regions")]
        public List<Regions>? Regions { get; set; }

        /// <summary>
        /// Gets or sets the flags.
        /// </summary>
        /// <value>The flags.</value>
        [JsonPropertyName("flags")]
        public FlagModel? Flags { get; set; }
    }
}