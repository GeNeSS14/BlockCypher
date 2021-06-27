using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCypher.Objects
{
    public class HDWallet : BaseObject
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("hd")]
        public bool HD { get; set; }
        [JsonProperty("extended_public_key")]
        public string ExtendedPublicKey { get; set; }
        [JsonProperty("chains")]
        public IList<HDChain> Chains { get; set; }
        [JsonProperty("subchain_indexes")]
        public IList<int> SubChains { get; set; }
    }
}
