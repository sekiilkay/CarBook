﻿
namespace UdemyCarBook.Dtos.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int CarCount { get; set; }
        public int LocationCount { get; set; }
        public int AuthorCount { get; set; }
        public int BlogCount { get; set; }
        public int BrandCount { get; set; }
        public decimal AvgPriceForDaily { get; set; }
        public decimal AvgRentPriceForWeekl { get; set; }
        public decimal AvgRentPriceForMonthly { get; set; }
        public int CarCountByTranmissionIsAuto { get; set; }
        public int CarCountByKmSmallerThen1000 { get; set; }
        public int CarCountByFuelGasolineOrDiesel { get; set; }
        public int CarCountByFuelElectric { get; set; }
        public string CarBrandAndModelByRentPriceDailyMax { get; set; }
        public string CarBrandAndModelByRentPriceDailyMin { get; set; }
        public string BrandNameByMaxCar { get; set; }
        public string BlogTitleByMaxBlogComment { get; set; }
    }
}
