using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class PortfolioManager : PortfolioService
    {
        Repository<Portfolio> repoportfolyo = new Repository<Portfolio>();
        DbContext db = new DbContext();
        public Portfolio GetByPortfolioID(int id)
        {
           return repoportfolyo.GetByID(id);
        }

        public List<Portfolio> GetList(int id)
        {
            return repoportfolyo.GetList(x => x.Id == id);
        }

        public List<Portfolio> List()
        {
            return repoportfolyo.List();
        }

        public void PortfolioAdd(Portfolio portfolio)
        {
            repoportfolyo.Insert(portfolio);
        }

        public void PortfolioDelete(Portfolio portfolio)
        {
            var delete = repoportfolyo.GetByID(portfolio.Id);
            repoportfolyo.Delete(delete);
        }

        public void PortfolioImageUpdate(Portfolio portfolio)
        {
            var update = repoportfolyo.GetByID(portfolio.Id);
            update.Image = portfolio.Image;

            repoportfolyo.Update(update);
        }

        public void PortfolioUpdate(Portfolio portfolio)
        {
            var update = repoportfolyo.GetByID(portfolio.Id);
            update.Name = portfolio.Name;
           
            repoportfolyo.Update(update);
        }
    }
}
