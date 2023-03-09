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

        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        //public int? CustomerId { get; set; }
        //public Customer? Customer { get; set; }

        //public int? ItemId { get; set; }
        //public Item? Item { get; set; }

        //public List<Penalty> Penalties { get; set; } = new List<Penalty>();
    }
}
