using CustomerOrderManagmentSystem.Data;
using CustomerOrderManagmentSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerOrderManagmentSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly App_dbContext db;

        public CustomerController(App_dbContext _db)
        {
            db = _db;
        }

        // GET: CustomerController//table
        public ActionResult Index()
        {

            var data = db.customers.ToList();
            return View(data);
        }

        // GET: CustomerController/Details/5
        // show detail customer and his orders
        public ActionResult Details(int id)
        {
            //var data = db.customers.Where(c => c.CustomerId == id).FirstOrDefault();

            var data = db.customers.Find(id);

            return View(data);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            {
                db.customers.Add(c);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = db.customers.Find(id);

            return View(data);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer c)
        {
            try
            {
                db.customers.Update(c);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = db.customers.Find(id);

            return View(data);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer c)
        {
            try
            {
                db.customers.Remove(c);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult ShowAllOrder(int id)
        {
           var data= db.orders.Where(o=>o.CustomerId==id).ToList();

            return View(data);
        }


    }
}
