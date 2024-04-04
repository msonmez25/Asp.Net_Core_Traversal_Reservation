using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    public class DetailDestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        private readonly UserManager<AppUser> _userManager;

        public DetailDestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;

            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.kullaniciID = value.Id;

            var values = destinationManager.TGetDestinationWithGuide(id);
            return View(values);
        }
    }
}
