using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_vue_ts.Models;

namespace mvc_vue_ts.Controllers
{
    public class ProductsJQController : Controller
    {
        // GET: ProductsJQ
        public ActionResult Index()
        {
            var products = new List<ProductModel>()
            {
                new ProductModel("0","Creative BlasterX Siege M04", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_18_12_9_18_350.jpg", "url1","url2", "mouse", "true", "false", "false"),
                new ProductModel("1","Creative BlasterX Vanguard K08", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_18_12_58_29_76.jpg", "url1", "url2", "keyboard", "false", "false", "true"),
                new ProductModel("2","Zestaw torba + antywirus + zaślepka kamery", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/1/pr_2019_1_18_11_50_53_662_00.jpg", "url1", "url2", "bag", "false", "true", "true"),
                new ProductModel("3","Logitech M171 czarna", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_19_14_26_33_640.jpg", "url1", "url2", "mouse", "false", "true", "false"),
                new ProductModel("4","Microsoft 1850 Wireless Mobile Mouse Czarna + Magenta Pink", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/2/pr_2019_2_12_9_15_16_358_00.jpg", "url1", "url2", "mouse", "false", "false", "false")
            };
            return View(products);
        }

        public ActionResult Product(string id)
        {
            var products = new List<ProductModel>()
            {
                new ProductModel("0","Creative BlasterX Siege M04", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_18_12_9_18_350.jpg", "url1","url2", "mouse", "true", "false", "false"),
                new ProductModel("1","Creative BlasterX Vanguard K08", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_18_12_58_29_76.jpg", "url1", "url2", "keyboard", "false", "false", "true"),
                new ProductModel("2","Zestaw torba + antywirus + zaślepka kamery", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/1/pr_2019_1_18_11_50_53_662_00.jpg", "url1", "url2", "bag", "false", "true", "true"),
                new ProductModel("3","Logitech M171 czarna", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2017/7/pr_2017_7_19_14_26_33_640.jpg", "url1", "url2", "mouse", "false", "true", "false"),
                new ProductModel("4","Microsoft 1850 Wireless Mobile Mouse Czarna + Magenta Pink", "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/2/pr_2019_2_12_9_15_16_358_00.jpg", "url1", "url2", "mouse", "false", "false", "false")
            };
            return View(products.First(x=> x.Id == id));
        }
    }
}