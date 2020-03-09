using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductModel
    {
        int id { get; set; }
        string product_name { get; set; }
        bool availability { get; set; }
        int price { get; set; }
        int category_id { get; set; }
        string info { get; set; }
        string description { get; set; }
        int seller { get; set; }
        int sku { get; set; }
        int stars { get; set; }
        DateTime added_at { get; set; }
        int numberOfSoldPieces { get; set; }
        bool sale { get; set; }
        bool isWished { get; set; }
    }
}