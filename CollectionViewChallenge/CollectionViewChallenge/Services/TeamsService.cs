using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.Services
{
    public class TeamsService : ITeamsService
    {
        public Task<IEnumerable<Team>> GetTeams()
        {
            var teams = new List<Team>
            {
                new Team{ Acronym="hou", Name="Houston Rockets", Image="https://ssl.gstatic.com/onebox/media/sports/logos/zhO6MIB1UzZmtXLHkJQBmg_96x96.png"},
                new Team{ Acronym="phi", Name="Philadelphia 76ers", Image="https://ssl.gstatic.com/onebox/media/sports/logos/US6KILZue2D5766trEf0Mg_96x96.png"},
                new Team{ Acronym="orl", Name="Orlando Magic", Image="https://ssl.gstatic.com/onebox/media/sports/logos/p69oiJ4LDsvCJUDQ3wR9PQ_96x96.png"},
                new Team{ Acronym="pho", Name="Phoenix Suns",Image="https://ssl.gstatic.com/onebox/media/sports/logos/pRr87i24KHWH0UuAc5EamQ_96x96.png"},
                new Team{ Acronym="okc", Name="Oklahoma City Thunder", Image="https://ssl.gstatic.com/onebox/media/sports/logos/b4bJ9zKFBDykdSIGUrbWdw_96x96.png"},
                new Team{ Acronym="ind", Name="Indiana Pacers",Image="https://ssl.gstatic.com/onebox/media/sports/logos/andumiE_wrpDpXvUgqCGYQ_96x96.png"},
                new Team{ Acronym="bro", Name="Brooklyn Nets",Image="https://ssl.gstatic.com/onebox/media/sports/logos/iishUmO7vbJBE7iK2CZCdw_96x96.png"},
                new Team{ Acronym="gsw", Name="Golden State Warriors",Image="https://ssl.gstatic.com/onebox/media/sports/logos/XD2v321N_-vk7paF53TkAg_96x96.png"},
                new Team{ Acronym="mem", Name="Memphis Grizzlies",Image="https://ssl.gstatic.com/onebox/media/sports/logos/3ho45P8yNw-WmQ2m4A4TIA_96x96.png"}
            };

            return Task.FromResult(teams.AsEnumerable());
        }
    }
}
