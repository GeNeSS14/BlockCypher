using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Objects
{
    public class HDChain : BaseObject
    {
        [JsonProperty("chain_addresses")]
        public IList<HDAddress> Addresses { get; set; }
        [JsonProperty("index")]
        public int Index { get; set; }
    }
}
