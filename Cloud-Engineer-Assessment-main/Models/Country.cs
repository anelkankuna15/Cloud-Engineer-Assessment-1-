using Newtonsoft.Json;
using System.Collections.Generic;

namespace Palota.Assessment.Countries.Models
{
    
    public class Country
    {
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iso3code")]
        public string Iso3Code { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("population")]
        public string Population { get; set; }

        [JsonProperty("location")]
        public IList<string> Location { get; set; }

        [JsonProperty("demonym")]
        public string Demonym { get; set; }

        [JsonProperty("nativeName")]
        public string NativeName { get; set; }

        [JsonProperty("numericCode")]
        public string NumericCode { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }
}


