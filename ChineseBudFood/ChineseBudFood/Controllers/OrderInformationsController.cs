using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ChineseBudFood.DatebaseContext;
using ChineseBudFood.Models;

namespace ChineseBudFood.Controllers
{
    public class OrderInformationsController : Controller
    {
        private OrderInformationDbContext db = new OrderInformationDbContext();

        // GET: OrderInformations
        public ActionResult Index()
        {
            return View(db.OrderInformations.ToList());
        }

        // GET: OrderInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderInformation orderInformation = db.OrderInformations.Find(id);
            if (orderInformation == null)
            {
                return HttpNotFound();
            }
            return View(orderInformation);
        }

        // GET: OrderInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderInformations/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Email,MealDate,Phone,Address,Time,Number")] OrderInformation orderInformation)
        {
            if (ModelState.IsValid)
            {
                db.OrderInformations.Add(orderInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderInformation);
        }

        // GET: OrderInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderInformation orderInformation = db.OrderInformations.Find(id);
            if (orderInformation == null)
            {
                return HttpNotFound();
            }
            return View(orderInformation);
        }

        // POST: OrderInformations/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Email,MealDate,Phone,Address,Time,Number")] OrderInformation orderInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderInformation);
        }

        // GET: OrderInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderInformation orderInformation = db.OrderInformations.Find(id);
            if (orderInformation == null)
            {
                return HttpNotFound();
            }
            return View(orderInformation);
        }

        // POST: OrderInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderInformation orderInformation = db.OrderInformations.Find(id);
            db.OrderInformations.Remove(orderInformation);
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
