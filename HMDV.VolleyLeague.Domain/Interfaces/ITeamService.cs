using System;
using HMDV.VolleyLeague.Domain.Models;

namespace HMDV.VolleyLeague.Domain.Interfaces
{
    public interface ITeamService
    {
        TeamModel GetTeam(Guid id);
    }
}