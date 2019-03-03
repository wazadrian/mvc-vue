using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_vue_ts.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string UrlPdf1 { get; set; }
        public string UrlPdf2 { get; set; }
        public string Category { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }


        public ProductModel(string id, string name, string image, string urlPdf1, string urlPdf2, string category, string f1, string f2, string f3)
        {
            Id = id;
            Name = name;
            Image = image;
            UrlPdf1 = urlPdf1;
            UrlPdf2 = urlPdf2;
            Category = category;
            F1 = f1;
            F2 = f2;
            F3 = f3;
        }
    }
}