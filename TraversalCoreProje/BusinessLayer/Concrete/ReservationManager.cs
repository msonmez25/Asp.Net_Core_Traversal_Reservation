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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> TGetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> TGetListWithReservationByLast(int id)
        {
            return _reservationDal.GetListWithReservationByLast(id);
        }

        public List<Reservation> TGetListWithReservationByWaitAprroval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitAprroval(id);
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation TGetByID(int id)
        {
            return _reservationDal.GetByID(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.Getlist();
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }

        public List<Reservation> TGetListWithReservationByUser(int id)
        {
            return _reservationDal.GetListWithReservationByUser(id);
        }

        public List<Reservation> TGetUserReservation()
        {
            return _reservationDal.GetUserReservation();
        }

        public void TReservationStatusChangeApproved(int id)
        {
            _reservationDal.ReservationStatusChangeApproved(id);
        }

        public void TReservationStatusChangeCanceled(int id)
        {
            _reservationDal.ReservationStatusChangeCanceled(id);
        }

        public List<Reservation> TGetUserReservationDestination(int id)
        {
            return _reservationDal.GetUserReservationDestination(id);
        }
    }
}
