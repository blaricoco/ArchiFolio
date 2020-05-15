using ArchiFolioWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.ProfileProcessor;

namespace ArchiFolioWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewProfiles()
        {
            ViewBag.Message = "Profile list";

            var data = LoadProfiles();

            List<ProfileModel> profiles = new List<ProfileModel>();
            foreach(var row in data)
            {
                profiles.Add(new ProfileModel
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    Description = row.Description,
                    ConfirmEmail = row.EmailAddress,
                    ImagePath = row.ImagePath,
                    Profession = row.Profession
                });
            }

            return View(profiles);
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Profile Sign Up";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(ProfileModel model)
        {
            // in case javascript fails to check data
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateProfile(model.FirstName,
                    model.LastName,
                    model.EmailAddress,
                    model.Description,
                    model.ImagePath,
                    model.Profession);
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Profile Sign Up";

            return View();
        }
    }
}