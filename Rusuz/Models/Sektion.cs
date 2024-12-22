namespace Rusuz.Models
{
    public class Sektion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Word> Words { get; set; }
    }
}