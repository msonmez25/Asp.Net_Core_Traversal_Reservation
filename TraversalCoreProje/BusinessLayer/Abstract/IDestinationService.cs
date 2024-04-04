using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public List<Destination> TGetPopular8RoteList();
        public Destination TGetDestinationWithGuide(int id);

        public List<Destination> TGetLast4RoteList();

        public List<Destination> TActiveRoteList();
        public List<Destination> TPasiveRoteList();
    }
}
