using System;
using System.Threading;
using System.Threading.Tasks;

using Lab9.App.DAL;
using Lab9.App.DAL.Entities;

using Microsoft.EntityFrameworkCore;

using Renting.Server.Dtos;

namespace Renting.Server.Controllers.Rents.Services
{
    public interface IRentsService
    {
        Task<RentDto> Get(int id, CancellationToken ct);
    }

    public class RentsService : IRentsService
    {
        private readonly RentingDbContext _context;

        public RentsService(RentingDbContext context)
        {
            _context = context;
        }

        public async Task<RentDto> Get(int id, CancellationToken ct)
        {
            var rent = await _context.Rents
                .Include(x => x.Penalties)
                .Include(x => x.Item)
                .Include(x => x.Customer)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (rent == null)
                throw new ArgumentException("не найден"); // todo сделать кастомную ошибку ObjectNotFoundException

            return MapToDto(rent);
        }

        public RentDto MapToDto(Rent rent)
        {
            return new RentDto
            {
                ActualEndDate = rent.ActualEndDate,
                CustomerName = rent?.Customer?.Name,
                ExpectedEndDate = rent.ExpectedEndDate,
                ItemName = rent?.Item?.Name,
                StartDate = rent.StartDate,
            };
        }
    }
}
