﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CommentModel
    {
        int id { get; set; }
        int product_id { get; set; }
        string content { get; set; }
        int user_id { get; set; }
    }
}