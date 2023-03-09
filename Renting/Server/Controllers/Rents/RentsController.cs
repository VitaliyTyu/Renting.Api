using System.Threading;
using System.Threading.Tasks;

using Lab9.App.DAL.Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Renting.Server.Controllers.Rents.Services;
using Renting.Server.Dtos;

namespace Renting.Server.Controllers.Rents
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class RentsController : ControllerBase
    {
        private readonly IRentsService _rentsService;

        public RentsController(IRentsService rentsService)
        {
            _rentsService = rentsService;
        }

        [HttpGet]
        public async Task<RentDto> Get([FromQuery] int id, CancellationToken ct)
        {
            return await _rentsService.Get(id, ct);
        }
    }
}
