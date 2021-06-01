using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace projek_WebService.Handlers
{
    public class JsonHandler
    {
        private static JavaScriptSerializer jss = new JavaScriptSerializer();

        public static string Encode(object data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public static T Decode<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}