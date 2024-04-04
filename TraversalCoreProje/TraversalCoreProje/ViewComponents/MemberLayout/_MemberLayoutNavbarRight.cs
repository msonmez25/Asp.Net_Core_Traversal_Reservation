using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbarRight : ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;

        public _MemberLayoutNavbarRight(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);            
            ViewBag.ImageUrl = values.ImageUrl;
            ViewBag.user = values.Name + " " + values.Surname;
            return View();
        }
    }
}
