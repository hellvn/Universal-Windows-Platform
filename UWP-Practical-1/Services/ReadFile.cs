using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UWP_Practical_1.Services
{
    class ReadFile
    {

        public static async void WriteFile(string fileName, string content)
        {
            var storage = ApplicationData.Current.LocalFolder;
            var Jsonfile = await storage.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(Jsonfile, content);
        }

        public async Task<Models.Employee> ReadJson(string fileName)
        {
            var storage = ApplicationData.Current.LocalFolder;
            var EmpJson = await storage.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);
            var Jsontext = await FileIO.ReadTextAsync(EmpJson);
            Models.Employee employee = JsonConvert.DeserializeObject<Models.Employee>(Jsontext);
            return employee;
        }

        
    }
}
