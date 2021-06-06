using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models {
    public class Car {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        [DataType(DataType.Date)]
        public DateTime ModelYear { get; set; }
        public decimal Price { get; set; }
    }
}