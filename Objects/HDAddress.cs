using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Objects
{
    public class HDAddress : BaseObject
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("public")]
        public string Public { get; set; }
    }
}
