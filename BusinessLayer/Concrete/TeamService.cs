using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public interface TeamService
    {
        List<Team> List();

        Team GetByTeamID(int id);
        void TeamDelete(Team team);
        void TeamAdd(Team team);
        void TeamUpdate(Team team);
        void TeamImageUpdate(Team team);


        List<Team> GetList(int id);
    }
}
