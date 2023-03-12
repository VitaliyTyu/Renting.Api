using Lab9.App.DAL.Entities;
using System.Collections.Generic;

namespace Renting.Server.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public double? ShoeSizeRu { get; set; }
        public double? ClothingSizeRu { get; set; }

        //public List<Rent> Rents { get; set; } = new List<Rent>();
    }
}
