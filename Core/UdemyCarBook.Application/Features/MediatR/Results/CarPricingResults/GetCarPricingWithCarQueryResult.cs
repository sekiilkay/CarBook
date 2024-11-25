﻿namespace UdemyCarBook.Application.Features.MediatR.Results.CarPricingResults
{
    public class GetCarPricingWithCarQueryResult
    {
        public int CarId { get; set; }
        public int CarPricingId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Amount { get; set; }
        public string CoverImageUrl { get; set; }
        public string PricingName { get; set; }
    }
}
