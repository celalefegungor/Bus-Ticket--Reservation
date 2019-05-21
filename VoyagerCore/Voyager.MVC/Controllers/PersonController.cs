using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Voyager.DAL;
using Voyager.MVC.Models.EntityFramework;
using System.Data.Entity;

namespace Voyager.MVC.Controllers
{

    public class PersonController : Controller
    {
        VoyagerConnectionEntities db = new VoyagerConnectionEntities();  
        public ActionResult Index()
        {
            var model = db.People.ToList();
            return View(model);
        }

        public ActionResult New()
        {
            return View("PersonForm");
        }

        public ActionResult Save(Person person)
        {
            if (person.Id == 0)
            {
                db.People.Add(person);
            }
            else
            {
                db.Entry(person).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var editPerson = db.People.SingleOrDefault(x => x.Id == id);
            return View("PersonForm", editPerson);
        }

        public ActionResult Delete(int id)
        {
            var deletePerson = db.People.SingleOrDefault(x => x.Id == id);
            db.People.Remove(deletePerson);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}