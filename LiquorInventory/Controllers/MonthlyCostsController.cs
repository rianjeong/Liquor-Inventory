using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LiquorInventory.DAL;

namespace LiquorInventory.Models
{
    public class MonthlyCostsController : Controller
    {
        private LiquorContext db = new LiquorContext();

        // GET: MonthlyCosts
        public ActionResult Index()
        {
            return View(db.MonthlyCosts.ToList());
        }

        // GET: MonthlyCosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonthlyCost monthlyCost = db.MonthlyCosts.Find(id);
            if (monthlyCost == null)
            {
                return HttpNotFound();
            }
            return View(monthlyCost);
        }

        // GET: MonthlyCosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonthlyCosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MonthlyCostId,Month,CurrentInventoryCost,PreviousMonth,PreviousInventoryCost,MonthlySales,Difference,PourCost")] MonthlyCost monthlyCost)
        {
            if (ModelState.IsValid)
            {
                db.MonthlyCosts.Add(monthlyCost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(monthlyCost);
        }

        // GET: MonthlyCosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonthlyCost monthlyCost = db.MonthlyCosts.Find(id);
            if (monthlyCost == null)
            {
                return HttpNotFound();
            }
            return View(monthlyCost);
        }

        // POST: MonthlyCosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MonthlyCostId,Month,CurrentInventoryCost,PreviousMonth,PreviousInventoryCost,MonthlySales,Difference,PourCost")] MonthlyCost monthlyCost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monthlyCost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(monthlyCost);
        }

        // GET: MonthlyCosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonthlyCost monthlyCost = db.MonthlyCosts.Find(id);
            if (monthlyCost == null)
            {
                return HttpNotFound();
            }
            return View(monthlyCost);
        }

        // POST: MonthlyCosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MonthlyCost monthlyCost = db.MonthlyCosts.Find(id);
            db.MonthlyCosts.Remove(monthlyCost);
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
