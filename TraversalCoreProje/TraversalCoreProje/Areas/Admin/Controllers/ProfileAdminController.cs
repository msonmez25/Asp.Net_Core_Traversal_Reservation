using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;
using TraversalCoreProje.Areas.Member.Models;
using Microsoft.AspNetCore.Authorization;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProfileAdminController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public ProfileAdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }




        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;
            userEditViewModel.imageurl = values.ImageUrl;
            userEditViewModel.gender = values.Gender;
            userEditViewModel.username = values.UserName;
            return View(userEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var userlar = await _userManager.FindByNameAsync(User.Identity.Name);
            //if (p.Image != null)
            //{
            //    var resourse = Directory.GetCurrentDirectory();
            //    var extension = Path.GetExtension(p.Image.FileName);
            //    var imagename = Guid.NewGuid() + extension;
            //    var savelocation = resourse + "/wwwroot/userimages/" + imagename;
            //    var stream = new FileStream(savelocation, FileMode.Create);
            //    await p.Image.CopyToAsync(stream);
            //    userlar.ImageUrl = imagename;
            //}

            userlar.Name = p.name;
            userlar.Surname = p.surname;
            userlar.ImageUrl = p.imageurl;
            userlar.PhoneNumber = p.phonenumber;

            userlar.PasswordHash = _userManager.PasswordHasher.HashPassword(userlar, p.password);

            var result = await _userManager.UpdateAsync(userlar);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }


    }
}
