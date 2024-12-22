using System.Text.Json.Serialization;

namespace Rusuz.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Star { get; set; }
        [JsonIgnore]
        public IEnumerable<Sektion> Sekions { get; set; }
    }
}
