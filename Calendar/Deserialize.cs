using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public static class Deserialize
    {
        public static void Serialization<T>(T models)
        {
            string json = JsonConvert.SerializeObject(models);
            File.WriteAllText("Calendar.json", json);
        }

        public static T DeserializeObj<T>()
        {
            string json = File.ReadAllText("Calendar.json");
            T models = JsonConvert.DeserializeObject<T>(json);
            return models;
        }
    }
}
