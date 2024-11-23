namespace UdemyCarBook.Dtos.CarDtos
{
    public record ResultCarWithBrandDto(int Id, int BrandId, string BrandName, string Model, string CoverImageUrl, int Km, string Transmission, byte Seat, byte Luggage, string Fuel, string BigImageUrl);
}
