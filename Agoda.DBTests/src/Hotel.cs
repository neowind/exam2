using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Agoda.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public double LowestPrice { get; set; }
        public string Location { get; set; }
    }
}

