using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager:IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public List<Destination> TActiveRoteList()
        {
            return _destinationDal.ActiveRoteList();
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetByID(int id)
        {
            return _destinationDal.GetByID(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetLast4RoteList()
        {
            return _destinationDal.GetLast4RoteList();
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.Getlist();
        }

        public List<Destination> TGetPopular8RoteList()
        {
            return _destinationDal.GetPopular8RoteList();
        }

        public List<Destination> TPasiveRoteList()
        {
            return _destinationDal.PasiveRoteList();
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
