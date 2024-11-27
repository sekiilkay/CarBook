namespace UdemyCarBook.Dtos.CarDtos
{
    public record ResultLast5CarsWithBrandsDto(int Id, int BrandId, string BrandName, string Model, string CoverImageUrl, int Km, string Transmission, byte Seat, byte Luggage, string Fuel, string BigImageUrl, decimal Price);
}
