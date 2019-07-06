using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using POSSystem.Repository;
using POSSystem.Models;
using POSSystem.ServiceLayer.Models;

namespace POSSystem.Controllers
{
    public class ProductController : Controller
    {
        ServiceRepository serviceobj; 
        public ProductController()
        {
            serviceobj = new ServiceRepository();
        } 


        // GET: Product
        public ActionResult GetAllProducts()
        {
            try
            {
                HttpResponseMessage response = serviceobj.GetResponse("api/Product/GetAllProducts");
                response.EnsureSuccessStatusCode();
                var products = response.Content.ReadAsAsync<IEnumerable<ServiceLayer.Models.Products>>().Result;
                List<Product> listprod = new List<Product>();
                foreach (var prod in products)
                {
                    Product p1 = new Product()
                    {
                        ProductId = prod.ProductId,
                        ProductName = prod.ProductName,
                        CategoryId = prod.CategoryId,
                        Price = prod.Price

                    };
                    listprod.Add(p1);
                }
                return View(listprod);
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
