﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}