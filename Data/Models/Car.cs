
namespace Cars.Data.Models
{
    public class Car
    {
        public int Id{ get; set; }
        public string? Name { get; set; }
        public string ?Description { get; set; }
        public bool isSold { get; set; }
        public DateTime ? SoldTime { get; set; }
        public int Rate { get; set; }
        public string ?Country { get; set; }
        public string? Brand { get; set; }
        public string? URL { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
