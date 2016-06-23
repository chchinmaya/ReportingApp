using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Customfunction
{
    public class JsonFormatData
    {
        public static string GetData()
        {
            Zipcodes obj = new Zipcodes();
            obj.ZipCode = "10001";
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public class Zipcodes
        {
            public string ZipCode { get; set; }
        }
    }
}
