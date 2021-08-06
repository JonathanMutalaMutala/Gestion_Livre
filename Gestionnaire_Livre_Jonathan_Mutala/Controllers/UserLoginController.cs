using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestionnaire_Livre_Jonathan_Mutala.Models; 

namespace Gestionnaire_Livre_Jonathan_Mutala.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Index()
        {
            return View();
        }

       
        // GET: UserLogin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserLogin/Create
        [HttpPost]
        public ActionResult Create(UserTab userTab)
        {
            using (Livre_Database livre_Database = new Livre_Database())
            {
                livre_Database.UserTab.Add(userTab);
                livre_Database.SaveChanges();
            }
            return RedirectToAction("Index", "Livre");
        }
        public ActionResult Seconnecter()
        {
            return View();
        }

        // POST: UserLogin/Create
        [HttpPost]
        public ActionResult SeConnecter(UserTab userTab)
        {
            using (Livre_Database livre_Database = new Livre_Database())
            {
                var valEmail = livre_Database.UserTab.First(val => val.email == userTab.email);
                var valPassword = livre_Database.UserTab.First(val => val.password == userTab.password);
                if (valEmail == valPassword)
                {
                    return RedirectToAction("Index", "Livre");
                }
                else
                {
                    return RedirectToAction("Create", "UserLogin");
                }

            }
        }



    }
}
