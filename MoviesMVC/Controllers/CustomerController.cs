using MoviesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesMVC.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext context;

        public CustomerController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = context.Customers.ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

      
    }
}