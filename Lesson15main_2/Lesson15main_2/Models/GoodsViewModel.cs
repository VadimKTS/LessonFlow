namespace Lesson15main_2.Models
{
    public class GoodsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }

        public GoodsViewModel(int id, string name, int count, string country, string category) 
        {
            Id = id;
            Name = name;
            Count = count;
            Country = country;
            Category = category;
        }
    }
}