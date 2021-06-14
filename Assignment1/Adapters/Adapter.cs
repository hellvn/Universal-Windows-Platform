using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Adapters
{
    class Adapter
    {
        private string baseURL = "https://foodgroup.herokuapp.com";

        private static Adapter instance;

        private Adapter()
        {

        }
        public static Adapter GetAdapter()
        {
            if (instance == null)
            {
                instance = new Adapter();
            }
            return instance;
        }
        public string GetHomeApi
        {
            get => String.Format(baseURL + "/api/today-special");
        }

        public string GetCategoryApi
        {
            get => String.Format(baseURL + "/api/category/");
        }

        public string GetDetailApi
        {
            get => String.Format(baseURL + "/api/food/");
        }
    }
}
