namespace Rusuz.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SektionId { get; set; }  
        public Sektion Sektion { get; set; }
    }
}