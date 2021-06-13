using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Assignment1.Models;

namespace Assignment1.Services
{
    class CategoryServices
    {
        private Adapters.Adapter _adapter = Adapters.Adapter.GetAdapter();
        public async Task<Category> getCategory(int id)
        {
            HttpClient httpclient = new HttpClient();
            var response = await httpclient.GetAsync(_adapter.GetCategoryApi + id);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var stringcontent = await response.Content.ReadAsStringAsync();
                Category category = JsonConvert.DeserializeObject<Category>(stringcontent);
                return category;
            }
            return null;
        }
    }
}
