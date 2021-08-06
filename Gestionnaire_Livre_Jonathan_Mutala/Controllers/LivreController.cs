using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestionnaire_Livre_Jonathan_Mutala.Models;
using System.Data.Entity; 

namespace Gestionnaire_Livre_Jonathan_Mutala.Controllers
{
    public class LivreController : Controller
    {
        // GET: Livre
        public ActionResult Index()
        {
            

            using(Livre_Database livre_Database = new Livre_Database())
            {
                return View(livre_Database.LivreTable.ToList());
            }
        }
        public ActionResult GetAllLivreToBuy()
        {
            using (Livre_Database livre_Database = new Livre_Database())
            {
                return View(livre_Database.LivreTable.Where(val => val.SouhaiterAcheter == true).ToList());
            }
        }
        public ActionResult GetAllLivrePosseder()
        {
            using (Livre_Database livre_Database = new Livre_Database())
            {
                return View(livre_Database.LivreTable.Where(val => val.LivrePosseder == true).ToList());
            }
        }

        // GET: Livre/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Livre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livre/Create
        [HttpPost]
        public ActionResult Create(LivreTable livreTable)
        {
            using(Livre_Database livre_Database = new Livre_Database())
            {
                livre_Database.LivreTable.Add(livreTable);
                livre_Database.SaveChanges();   
            }
            return RedirectToAction("Index", "Livre");
        }

        // GET: Livre/Edit/5
        public ActionResult Edit(int id)
        {
            using (Livre_Database livre_Database = new Livre_Database())
            {
                LivreTable livreTable = livre_Database.LivreTable.Find(id);
                if (livreTable == null)
                    return RedirectToAction("Index", "Livre");
                return View(livreTable); 
            }
        }

        // POST: Livre/Edit/5
        [HttpPost]
        public ActionResult Edit(LivreTable livreTable)
        {
           using(Livre_Database livre_Database = new Livre_Database())
            {
                livre_Database.Entry(livreTable).State = EntityState.Modified;
                livre_Database.SaveChanges();
                return RedirectToAction("Index","Livre"); 
            }
           
        }

        // GET: Livre/Delete/5
        public ActionResult Delete(int id)
        {
            using (Livre_Database livre_Database = new Livre_Database())
            {
                return View(livre_Database.LivreTable.Where(val => val.Id == id).FirstOrDefault());

            }
        }

        // POST: Livre/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, LivreTable livreTable)
        {
            using (Livre_Database livre_Database = new Livre_Database())
            {
                livreTable = livre_Database.LivreTable.Where(val => val.Id == id).FirstOrDefault();
                livre_Database.LivreTable.Remove(livreTable);
                livre_Database.SaveChanges();
                return RedirectToAction("Index", "Livre"); 
            }
        }
       
    }
}
