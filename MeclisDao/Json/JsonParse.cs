using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisEntities.Entities
namespace MeclisDao.Json
{
  public  class JsonParse
    {

        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader("http://fatihsoysal.com/file.json"))
            {
                string json = r.ReadToEnd();
                List<BelgeNo> items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
    }
}
