using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using Lab9.App.DAL;
using Lab9.App.DAL.Entities;

using Microsoft.EntityFrameworkCore;

using Renting.Server.Dtos;

namespace Renting.Server.Controllers.Rents.Services
{
    public interface IRentsService
    {
        Task<RentDto> GetRent(int id, CancellationToken ct);
        Task<List<RentDto>> GetRents(CancellationToken ct);
    }

    public class RentsService : IRentsService
    {
        private readonly RentingDbContext _context;
        private readonly IMapper _mapper;

        public RentsService(RentingDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RentDto> GetRent(int id, CancellationToken ct)
        {
            var rent = await _context.Rents
                .Include(x => x.Penalties)
                .Include(x => x.Item)
                .Include(x => x.Customer)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (rent == null)
                throw new ArgumentException("не найден"); // todo сделать кастомную ошибку ObjectNotFoundException

            return _mapper.Map<RentDto>(rent);
        }

        public async Task<List<RentDto>> GetRents(CancellationToken ct)
        {
            var rents = await _context.Rents
                .Include(x => x.Penalties)
                .Include(x => x.Item)
                .Include(x => x.Customer)
                .ToListAsync();
            
            return _mapper.Map<List<RentDto>>(rents);
        }
    }
}
