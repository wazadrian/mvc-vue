﻿using mvc_vue_ts.Models;
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

        public ActionResult GetProducts(string category)
        {
            var products = new List<ProductModel>()
            {
                new ProductModel("Creative BlasterX Siege M04", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_18_12_9_18_350.jpg", "url1","url2", "mouse", "true", "false", "false"),
                new ProductModel("Creative BlasterX Vanguard K08", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_18_12_58_29_76.jpg", "url1", "url2", "keyboard", "false", "false", "true"),
                new ProductModel("Zestaw torba + antywirus + zaślepka kamery", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/1/pr_2019_1_18_11_50_53_662_00.jpg", "url1", "url2", "bag", "false", "true", "true"),
                new ProductModel("Logitech M171 czarna", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_19_14_26_33_640.jpg", "url1", "url2", "mouse", "false", "true", "false"),
                new ProductModel("Microsoft 1850 Wireless Mobile Mouse Czarna + Magenta Pink", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/2/pr_2019_2_12_9_15_16_358_00.jpg", "url1", "url2", "mouse", "false", "false", "false")
            };
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}