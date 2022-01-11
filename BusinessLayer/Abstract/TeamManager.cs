using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class TeamManager : TeamService
    {
        Repository<Team> repoteam = new Repository<Team>();
        public Team GetByTeamID(int id)
        {
            return repoteam.GetByID(id);
        }

        public List<Team> GetList(int id)
        {
            return repoteam.GetList(x => x.Id == id);
        }

        public List<Team> List()
        {
            return repoteam.List();
        }

        public void TeamAdd(Team team)
        {
            repoteam.Insert(team);
        }

        public void TeamDelete(Team team)
        {
            var delete = repoteam.GetByID(team.Id);

            repoteam.Delete(delete);
        }

        public void TeamImageUpdate(Team team)
        {
            var update = repoteam.GetByID(team.Id);
            update.Image = team.Image;

            repoteam.Update(team);
        }

        public void TeamUpdate(Team team)
        {
            var update = repoteam.GetByID(team.Id);
            update.Fullname = team.Fullname;
            update.Unvan = team.Unvan;
            
            repoteam.Update(team);
        }
    }
}
