using System;
using HMDV.VolleyLeague.Domain.Interfaces;
using HMDV.VolleyLeague.Domain.Models;

namespace HMDV.VolleyLeague.DataAccess.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public TeamModel GetTeam(Guid id)
        {
            return new TeamModel
            { 
                Id = id,
                Name = "Mock team"
            };
        }
    }
}
