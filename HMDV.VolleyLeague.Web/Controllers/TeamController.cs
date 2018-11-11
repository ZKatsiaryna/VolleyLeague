using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMDV.VolleyLeague.Domain.Interfaces;
using HMDV.VolleyLeague.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMDV.VolleyLeague.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            this._teamService = teamService;
        }

        // GET api/team/5
        [HttpGet("{id}")]
        public TeamModel GetTeam(string id)
        {
            Guid parsedId = Guid.Parse(id);

            return this._teamService.GetTeam(parsedId);
        }
    }
}
