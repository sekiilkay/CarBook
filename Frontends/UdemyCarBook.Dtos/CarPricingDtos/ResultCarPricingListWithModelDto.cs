﻿namespace UdemyCarBook.Dtos.CarPricingDtos
{
    public class ResultCarPricingListWithModelDto
    {
        public string Model { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal WeeklyAmount { get; set; }
        public decimal MonthlyAmount { get; set; }
        public string CoverImageUrl { get; set; }
        public string Brand { get; set; }
    }
}
