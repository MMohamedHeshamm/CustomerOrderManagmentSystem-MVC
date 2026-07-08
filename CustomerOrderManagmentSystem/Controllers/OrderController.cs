using CustomerOrderManagmentSystem.Data;
using CustomerOrderManagmentSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerOrderManagmentSystem.Controllers
{
    public class OrderController : Controller
    {
        private readonly App_dbContext db;
        public OrderController(App_dbContext _db)
        {
            db = _db;
        }

        // GET: OrderController
        public ActionResult Index()
        {
            var data = db.orders.Include(a=>a.Customer).ToList();
            return View(data);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            //var data = db.customers.Where(c => c.CustomerId == id).FirstOrDefault();

            var data = db.orders.Find(id);

            return View(data);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order o)
        {
            try
            {
                db.orders.Add(o);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = db.orders.Find(id);

            return View(data);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order o)
        {
            try
            {
                db.orders.Update(o);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = db.orders.Find(id);

            return View(data);
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Order o)
        {
            try
            {
                db.orders.Remove(o);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
