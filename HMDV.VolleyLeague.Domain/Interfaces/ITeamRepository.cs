using System;
using HMDV.VolleyLeague.Domain.Models;

namespace HMDV.VolleyLeague.Domain.Interfaces
{
    public interface ITeamRepository
    {
         TeamModel GetTeam(Guid id);
    }
}