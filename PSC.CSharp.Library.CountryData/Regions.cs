using System;
using System.Text.Json.Serialization;

namespace PSC.CSharp.Library.CountryData
{
    /// <summary>
    /// Class Regions.
    /// </summary>
    public class Regions
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the short code.
        /// </summary>
        /// <value>The short code.</value>
        [JsonPropertyName("shortCode")]
        public string? ShortCode { get; set; }
    }
}