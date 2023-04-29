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
            // Простите, София Алексеевна, получается только через полный путь, не получается через относительный
            File.WriteAllText("C:\\Users\\paulscriptum\\source\\repos\\Calendar\\Calendar\\json\\Calendar.json", json);
        }

        public static T DeserializeObj<T>()
        {
            string json = File.ReadAllText("C:\\Users\\paulscriptum\\source\\repos\\Calendar\\Calendar\\json\\Calendar.json");
            T models = JsonConvert.DeserializeObject<T>(json);
            return models;
        }
    }
}
