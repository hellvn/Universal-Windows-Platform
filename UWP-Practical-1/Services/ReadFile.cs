using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;

namespace UWP_Practical_1.Services
{
    class ReadFile
    {
        public async Task<Models.Employee> ReadJson()
        {
            var storage = ApplicationData.Current.LocalFolder;
            var EmpJson = await storage.CreateFileAsync("employee.json", CreationCollisionOption.OpenIfExists);
            var Jsontext = await FileIO.ReadTextAsync(EmpJson);
            Models.Employee employee = JsonConvert.DeserializeObject<Models.Employee>(Jsontext);
            return employee;
         }
    }
}
