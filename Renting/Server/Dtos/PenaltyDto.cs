using Lab9.App.DAL.Entities;

namespace Renting.Server.Dtos
{
    public class PenaltyDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal? Price { get; set; }
        //public RentDto Rent { get; set; }
    }
}
