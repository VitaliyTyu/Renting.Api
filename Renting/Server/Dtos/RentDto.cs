using Lab9.App.DAL.Entities;
using System.Collections.Generic;
using System;

namespace Renting.Server.Dtos
{
    public class RentDto
    {
        public DateTime StartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public CustomerDto Customer { get; set; }
        public ItemDto Item { get; set; }
        public List<PenaltyDto> Penalties { get; set; } = new List<PenaltyDto>();
    }
}
