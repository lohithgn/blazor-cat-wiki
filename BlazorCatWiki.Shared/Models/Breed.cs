using System.Text.Json.Serialization;

namespace BlazorCatWiki.Shared.Models
{
    public class Breed
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        [JsonPropertyName("cfa_url")]
        public string CfaUrl { get; set; }
        
        [JsonPropertyName("vetstreet_url")]
        public string VetStreetUrl { get; set; }
        
        [JsonPropertyName("vcahospitals_url")]
        public string VcaHospitalsUrl { get; set; }
        public string Temperament { get; set; }
        public string Origin { get; set; }
        
        [JsonPropertyName("country_codes")]
        public string CountryCodes { get; set; }
        
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        public string Description { get; set; }
        
        [JsonPropertyName("life_span")]
        public string LifeSpan { get; set; }
        public int Indoor { get; set; }
        public int Lap { get; set; }
        
        [JsonPropertyName("alt_names")]
        public string AltNames { get; set; }
        public int Adaptability { get; set; }
        
        [JsonPropertyName("affection_level")]
        public int AffectionLevel { get; set; }
        
        [JsonPropertyName("child_friendly")]
        public int ChildFriendly { get; set; }
        
        [JsonPropertyName("dog_friendly")]
        public int DogFriendly { get; set; }
        
        [JsonPropertyName("energy_level")]
        public int EnergyLevel { get; set; }
        public int Grooming { get; set; }
        
        [JsonPropertyName("health_issues")]
        public int HealthIssues { get; set; }
        public int Intelligence { get; set; }
        
        [JsonPropertyName("shedding_level")]
        public int SheddingLevel { get; set; }
        
        [JsonPropertyName("social_needs")]
        public int SocialNeeds { get; set; }
        
        [JsonPropertyName("stranger_friendly")]
        public int StrangerFriendly { get; set; }
        public int Vocalisation { get; set; }
        public int Experimental { get; set; }
        public int Hairless { get; set; }
        public int Natural { get; set; }
        public int Rare { get; set; }
        public int Rex { get; set; }

        [JsonPropertyName("suppressed_tail")]
        public int SuppressedTail { get; set; }
        
        [JsonPropertyName("short_legs")]
        public int ShortLegs { get; set; }
        
        [JsonPropertyName("wikipedia_url")]
        public string WikipediaUrl { get; set; }
        public int Hypoallergenic { get; set; }
        
        [JsonPropertyName("reference_image_id")]
        public string ReferenceImageId { get; set; }
        public Image Image { get; set; }
        public Weight Weight { get; set; }
    }

    public class Weight
    {
        public string Imperial { get; set; }
        public string Metric { get; set; }
    }
}
