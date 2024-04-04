using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RoleAssingRoleController : Controller
    {

        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleAssingRoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }


        [HttpGet]
        public async Task<IActionResult> AssingRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["UserId"] = user.Id;
            ViewBag.Name = user.Name + " " + user.Surname;

            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);

            List<RoleAssingRoleViewModel> roleAssingRoleViewModels = new List<RoleAssingRoleViewModel>();
            foreach (var item in roles)
            {
                RoleAssingRoleViewModel model = new RoleAssingRoleViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssingRoleViewModels.Add(model);
            }
            return View(roleAssingRoleViewModels);
        }



        [HttpPost]
        public async Task<IActionResult> AssingRole(List<RoleAssingRoleViewModel> roleAssignViewModel)
        {
            var userid = (int)TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach (var item in roleAssignViewModel)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("RoleAssingRole","Admin");
        }




    }
}
