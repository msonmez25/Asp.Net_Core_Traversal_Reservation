using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _MemberStatistic : ViewComponent
    {
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
        private readonly UserManager<AppUser> _userManager;

        public _MemberStatistic(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }



        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.Name + " " + values.Surname;
            ViewBag.memberSurName = values.Surname;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberMail = values.Email;
            ViewBag.memberGender = values.Gender;

            using var c = new Context();
            ViewBag.GuideCount = c.Guides.Count();
            ViewBag.DestinationCount = c.Destinations.Count();
            ViewBag.Onayda = reservationManager.TGetListWithReservationByWaitAprroval(values.Id).Count();

            ViewBag.Aktif = reservationManager.TGetListWithReservationByAccepted(values.Id).Count();

            ViewBag.Gecmis = reservationManager.TGetListWithReservationByLast(values.Id).Count();

            return View();
        }
    }
}
