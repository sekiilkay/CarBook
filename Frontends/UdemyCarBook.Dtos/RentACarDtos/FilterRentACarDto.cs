﻿namespace UdemyCarBook.Dtos.RentACarDtos
{
    public class FilterRentACarDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Amount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
