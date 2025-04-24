using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class City : BaseEntity
    {
        //Many to one relationship with country
        public Country? Country { get; set; }
        public int CountryId { get; set; } = 0;

        //One to many relationship with Town
        [JsonIgnore]
        public List<Town>? Towns { get; set; }
    }
}