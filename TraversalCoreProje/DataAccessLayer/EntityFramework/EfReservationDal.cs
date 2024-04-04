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
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "ONAYLANDI" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByLast(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "İPTAL EDİLDİ" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByUser(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(y=>y.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "ONAY BEKLİYOR" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetUserReservation()
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(y => y.Destination).Include(x => x.AppUser).ToList();
            }
        }

        public List<Reservation> GetUserReservationDestination(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Where(z=>z.ReservationID == id).Include(y => y.Destination).Include(x => x.AppUser).ToList();
            }
        }

        public void ReservationStatusChangeApproved(int id)
        {
            var context = new Context();
            var values = context.Reservations.Find(id);
            values.Status = "ONAYLANDI";
            context.SaveChanges();
        }

        public void ReservationStatusChangeCanceled(int id)
        {
            var context = new Context();
            var values = context.Reservations.Find(id);
            values.Status = "İPTAL EDİLDİ";
            context.SaveChanges();
        }
    }
}
