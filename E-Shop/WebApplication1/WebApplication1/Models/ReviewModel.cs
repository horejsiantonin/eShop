using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ReviewModel
    {
        int id { get; set; }
        int product_id { get; set; }
        int stars { get; set; }
        string content { get; set; }
        int user_id { get; set; }
    }
}