using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitAprroval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByLast(int id);
        List<Reservation> GetListWithReservationByUser(int id);
        List<Reservation> GetUserReservation();

        List<Reservation> GetUserReservationDestination(int id);

        void ReservationStatusChangeApproved(int id);
        void ReservationStatusChangeCanceled(int id);

    }
}
