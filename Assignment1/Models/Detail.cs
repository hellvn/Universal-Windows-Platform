using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    class Detail
    {
        public string message { get; set; }
        public Itemdetail data { get; set; }
    }
    public class Itemdetail
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }
}
