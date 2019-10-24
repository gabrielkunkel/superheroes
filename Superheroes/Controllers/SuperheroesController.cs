using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext dbContext;

        public SuperheroesController()
        {
            dbContext = new ApplicationDbContext();
        }

        // GET: Superheroes
        public ActionResult Index()
        {
            var superheroes = dbContext.Superheroes;

            if (superheroes != null)
            {
                return View(superheroes);
            }
            else
            {
                return RedirectToRoute("index", "home");
            }
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = dbContext.Superheroes.Find(id);

            if (superhero == null)
            {
                return HttpNotFound();
            }

            return View(superhero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                dbContext.Superheroes.Add(superhero);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = dbContext.Superheroes.Find(id);
            return View(superhero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {

            try
            {
                Superhero superheroToEdit = dbContext.Superheroes.Find(id);
                dbContext.Superheroes.Attach(superheroToEdit);
                superheroToEdit.name = superhero.name;
                superheroToEdit.primaryAbility = superhero.primaryAbility;
                superheroToEdit.alterEgo = superhero.alterEgo;
                superheroToEdit.catchPhrase = superhero.catchPhrase;
                dbContext.SaveChanges();
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
