using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_vue_ts.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string UrlPdf1 { get; set; }
        public string UrlPdf2 { get; set; }

        public ProductModel(string name, string image, string urlPdf1, string urlPdf2)
        {
            Name = name;
            Image = image;
            UrlPdf1 = urlPdf1;
            UrlPdf2 = urlPdf2;
        }
    }
}