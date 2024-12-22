using System.Text.Json.Serialization;

namespace Rusuz.Models
{
    public class Sektion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SectionPicture { get; set; }  
        public int Star { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        public IEnumerable<Word> Words { get; set; }
    }
}