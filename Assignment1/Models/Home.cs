using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    class Home
    {
        public string message { get; set; }
        public List<Food> data { get; set; }
    }
    class FoodDetail
    {
        public string message { get; set; }
        public Food data { get; set; }
    }
    class Category
    {
        public string message { get; set; }
        public CatData data { get; set; }

    }
    class Catitem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }
    class CatData
    {
        public Catitem category { get; set; }
        public List<Food> foods { get; set; }
    }
    class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }
}
