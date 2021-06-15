using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Entities;
using Newtonsoft.Json;

namespace MeclisDao.Json
{
    public class JsonParse
    {
      

        //public static void LoadJson()
        //{
        //    using (StreamReader r = new StreamReader("~\Meclis\MeclisDao\Json\belgeno.json"))
        //    {
        //        string json = r.ReadToEnd();
        //        List<BelgeNo> items = JsonConvert.DeserializeObject<List<Item>>(json);
        //    }
        //}

        public static List<BelgeNo> JsonLoad(BelgeNo data)
        {
            using (StreamReader r = new StreamReader("~\\Meclis\\MeclisDao\\Json\\BelgeNo.json"))
            {
                string json = r.ReadToEnd();
                List<BelgeNo> items = JsonConvert.DeserializeObject<List<BelgeNo>>(json);
                return items;
            }


        }

        public static  void JsonSave(BelgeNo data)
        {
            //using (StreamWriter w=new StreamWriter(@"~/Meclis/MeclisDao/Json/BelgeNo.json"))
            //{
            //    dynamic array = JsonConvert.SerializeObject(data);
            //    foreach (var item in array)
            //    {
            //        Console.WriteLine("{0} {1}", item.temp, item.vcc);
            //    }

            //}
        
        }

      

        //public static void JsonSave(BelgeNo no)
        //{
        //    JsonSave(no);
        //}
    }
}
