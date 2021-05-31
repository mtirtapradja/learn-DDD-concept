using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace pertemuan_4.Utils
{
    public class JsonHandler
    {
        private static JavaScriptSerializer jss = new JavaScriptSerializer();

        // Object -> JSON
        public static string Encode(object data)
        {
            return JsonConvert.SerializeObject(data);
        }

        // JSON -> Object
        public static T Decode<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}