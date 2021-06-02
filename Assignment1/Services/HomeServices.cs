using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Assignment1.Services
{
    class HomeServices
    {
        private Adapters.Adapter _adapter = Adapters.Adapter.GetAdapter();

        public async Task<Models.Home> GetHome()
        {
            HttpClient httpClient = new HttpClient(); //get data form API
            var response = await httpClient.GetAsync(_adapter.GetHomeApi);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var stringcontent = await response.Content.ReadAsStringAsync(); //string async (get content response)
                //convert json to object menu
                Models.Home home = JsonConvert.DeserializeObject<Models.Home>(stringcontent);
                return home;

            }
            return null;
        }
    }
}
