using mvc_vue_ts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_vue_ts.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult GetProducts()
        {
            var products = new List<ProductModel>()
            {
                new ProductModel("Product_name_1", "img", "url1","url2"),
                new ProductModel("Product_name_2", "img", "url1", "url2"),
                new ProductModel("Product_name_3", "img", "url1", "url2"),
                new ProductModel("Product_name_4", "img", "url1", "url2"),
                new ProductModel("Product_name_5", "img", "url1", "url2")
            };
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}