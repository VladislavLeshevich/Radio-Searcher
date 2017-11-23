﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadioSearcher.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string ProductLink { get; set; }
        public float Cost { get; set; }
        public bool IsAvailable { get; set; }
    }
}