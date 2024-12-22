using System.Text.Json.Serialization;

namespace Rusuz.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string English { get; set; }
        public string EnglishTrans { get; set; }
        public string Uzbek { get; set; }
        public string WordPicture { get; set; }
        public string ExampleEng { get; set; }
        public string ExampleUz { get; set; }
        public int SektionId { get; set; }
        [JsonIgnore]
        public Sektion Sektion { get; set; }
    }
}
