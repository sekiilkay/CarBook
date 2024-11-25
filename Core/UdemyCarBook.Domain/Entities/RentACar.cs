namespace UdemyCarBook.Domain.Entities
{
    public class RentACar
    {
        public int Id { get; set; }
        public bool Available { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
