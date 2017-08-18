using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LiquorInventory.DAL;
using LiquorInventory.Models;

namespace LiquorInventory.Controllers
{
    public class LiquorsController : Controller
    {
        private LiquorContext db = new LiquorContext();

        // GET: Liquors
        public ActionResult Index()
        {
            return View(db.Liquors.ToList());
        }

        // GET: Liquors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Liquor liquor = db.Liquors.Find(id);
            if (liquor == null)
            {
                return HttpNotFound();
            }
            return View(liquor);
        }

        // GET: Liquors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Liquors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "liquorId,liquorName,liquorCost,liquorInventory,liquorInventoryCost")] Liquor liquor)
        {
            if (ModelState.IsValid)
            {
                db.Liquors.Add(liquor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(liquor);
        }

        // GET: Liquors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Liquor liquor = db.Liquors.Find(id);
            if (liquor == null)
            {
                return HttpNotFound();
            }
            return View(liquor);
        }

        // POST: Liquors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "liquorId,liquorName,liquorCost,liquorInventory,liquorInventoryCost")] Liquor liquor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(liquor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(liquor);
        }

        // GET: Liquors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Liquor liquor = db.Liquors.Find(id);
            if (liquor == null)
            {
                return HttpNotFound();
            }
            return View(liquor);
        }

        // POST: Liquors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Liquor liquor = db.Liquors.Find(id);
            db.Liquors.Remove(liquor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        
    }
}
