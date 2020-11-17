using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Chair
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}