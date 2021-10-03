using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PeruStars_2.Domain.Models;
using PeruStars_2.Domain.Services;
using PeruStars_2.Resources;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Controllers
{
    [Route("api/hobbyists/{hobbyistId}/reports")]
    [Produces("application/json")]
    [ApiController]
    public class HobbyistReportsController : ControllerBase
    {
        private readonly IClaimTicketService _claimTicketService;
        private readonly IMapper _mapper;

        public HobbyistReportsController(IClaimTicketService claimTicketService, IMapper mapper)
        {
            _claimTicketService = claimTicketService;
            _mapper = mapper;
        }

        [SwaggerOperation(
           Summary = "Get All Reports By Hobbyist Id",
           Description = "Get All Reports By Hobbyist Id",
           OperationId = "GetAllReportsByHobbyistId")]
        [SwaggerResponse(200, "Get All Reports By Hobbyist Id", typeof(IEnumerable<HobbyistResource>))]

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ClaimTicketResource>), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        public async Task<IEnumerable<ClaimTicketResource>> GetAllReportsByArtistIdAsync(long hobbyistId)
        {
            var claimTicket = await _claimTicketService.ListAsyncByReportedPersonId(hobbyistId);
            var resources = _mapper.Map<IEnumerable<ClaimTicket>, IEnumerable<ClaimTicketResource>>(claimTicket);
            return resources;
        }
    }
}
