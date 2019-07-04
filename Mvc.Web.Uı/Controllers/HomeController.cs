using Mvc.Web.Uı.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Web.Uı.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            

            return View(_context.Products.Where(i=>i.IsHome==true && i.IsApproved==true).ToList());
        }

        public ActionResult List()
        {
            return View(_context.Products.Where(i =>i.IsApproved == true).ToList());
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id==id).FirstOrDefault());
        }
    }
}