using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public List<Destination> ActiveRoteList()
        {
            using var context = new Context();
            var values = context.Destinations.Where(x => x.Status == true).ToList();
            return values;
        }

        public Destination GetDestinationWithGuide(int id)
        {
            using var context = new Context();
            var values = context.Destinations.Where(x => x.DestinationID == id).Include(y => y.Guide).FirstOrDefault();
            return values;
        }

        public List<Destination> GetLast4RoteList()
        {
            using var context = new Context();
            var values = context.Destinations.OrderBy(x => x.DestinationID).OrderByDescending(y=>y.DestinationID).Take(4).ToList();
            return values;
        }

        public List<Destination> GetPopular8RoteList()
        {
            using var context = new Context();
            var values = context.Destinations.OrderBy(x => x.DestinationID).Take(8).ToList();
            return values;
        }

        public List<Destination> PasiveRoteList()
        {
            using var context = new Context();
            var values = context.Destinations.Where(x => x.Status == false).ToList();
            return values;
        }
    }
}
