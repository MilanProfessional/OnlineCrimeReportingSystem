using OnlineCrimeReportingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineCrimeReportingSystem.Controllers
{
    public class RetrieveCrimeReportController : Controller
    {
        private DB_A44DBC_milanadhikari09Entities context = new DB_A44DBC_milanadhikari09Entities();
        // GET: AdminRetrieveCrimeReport
        // GET: RetrieveCrimeReport
        public ActionResult RetrieveCrimeReportView()
        {
            var model = context.Crimes.Where(p => p.Email == User.Identity.Name).ToList();
            return View(model);
        }
    }
}

---------------------------------------


var query2 = from b in db.TotalProduct

             join c in db.Rice

             on b.RiceId equals c.RiceId

             select new TotalProduct
             {
                 ProductId = b.ProductId,
                 ProductName = b.ProductName,
                 ProductPrice = b.ProductPrice,
                 Stock = b.Stock,
                 ProductDescription = b.ProductDescription,
                 Manufacture = b.Manufacture,
                 Expire = b.Expire,
                 RiceId = c.RiceId,
                 CategoryName = c.CategoryName
             };

// select * from bikes 

List<TotalProduct> produ = query2.ToList();  // ORM EF Core
            return View(produ);

-----------------------------------------

var partialResult = (from c in db.TotalProduct
                     join o in db.Rice

                     on c.RiceID equals o.RiceId
                     select new
                     {
                         ProductId = b.ProductId,
                         ProductName = b.ProductName,
                         ProductPrice = b.ProductPrice,
                         Stock = b.Stock,
                         ProductDescription = b.ProductDescription,
                         Manufacture = b.Manufacture,
                         Expire = b.Expire,
                         RiceId = c.RiceId,
                         CategoryName = c.CategoryName
                     };

var finalResult = from c in db.Customers
                  orderby c.name
                  select new
                  {
                      name = c.name,
                      list = (from r in partialResult where c.name == r.name select r.order_total).ToList()

                  };

            foreach (var item in finalResult)
            {

                Console.WriteLine(item.name);
                if (item.list.Count == 0)
                {
                    Console.WriteLine("No orders");
                }
                else
                {
                    foreach (var i in item.list)
                    {
                        Console.WriteLine(i);
                    }
                }
            }