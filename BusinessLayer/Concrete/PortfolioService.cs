using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public interface PortfolioService
    {
        List<Portfolio> List();

        Portfolio GetByPortfolioID(int id);
        void PortfolioDelete(Portfolio portfolio);
        void PortfolioAdd(Portfolio portfolio);
        void PortfolioUpdate(Portfolio portfolio);
        void PortfolioImageUpdate(Portfolio portfolio);


        List<Portfolio> GetList(int id);
    }
}
