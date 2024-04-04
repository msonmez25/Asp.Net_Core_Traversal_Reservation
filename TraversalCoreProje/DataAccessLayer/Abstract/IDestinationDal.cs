using EntityLayer.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal : IGenericDal<Destination>
    {
        public List<Destination> GetPopular8RoteList();
        public Destination GetDestinationWithGuide(int id);

        public List<Destination> GetLast4RoteList();

        public List<Destination> ActiveRoteList();
        public List<Destination> PasiveRoteList();

    }
}
