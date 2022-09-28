namespace ASPColoradoBestCars.Models
{
    public class CarProperty
    {
        public int Year { get; set; }
        public string? Model { get; set; }
        public string? Make { get; set; }
        public string? Type { get; set; }

        public List<string> options { get; set; } = new List<string>() { "TOYOTA", "FORD", "CHEVY", "SUBARU" }; 
        public string? PicturePath {get; set;}
    }

}
