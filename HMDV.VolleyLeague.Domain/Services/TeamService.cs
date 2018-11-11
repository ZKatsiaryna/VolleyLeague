using System;
using HMDV.VolleyLeague.Domain.Interfaces;
using HMDV.VolleyLeague.Domain.Models;

namespace HMDV.VolleyLeague.Domain.Services
{
    public class TeamService : ITeamService
    {
        private ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            this._teamRepository = teamRepository;
        }

        public TeamModel GetTeam(Guid id)
        {
            return this._teamRepository.GetTeam(id);
        }
    }
}