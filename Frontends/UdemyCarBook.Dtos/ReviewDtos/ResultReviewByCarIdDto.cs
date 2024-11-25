﻿namespace UdemyCarBook.Dtos.ReviewDtos
{
    public class ResultReviewByCarIdDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string Comment { get; set; }
        public int RaytingValue { get; set; }
        public DateTime ReviewDate { get; set; }
        public int CarId { get; set; }
    }
}