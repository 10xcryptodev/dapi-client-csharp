using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace dapi_client_csharp.RPC
{
    public class JsonRpcRequest
    {
        public JsonRpcRequest(int id, string method, params object[] parameters)
        {
            Id = id;
            Method = method;
            Parameters = parameters?.ToList() ?? new List<object>();
        }

        [JsonProperty(PropertyName = "method", Order = 0)]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "jsonrpc", Order = 2)]
        public string JsonRPC { 
            get
            {
                return "2.0";
            } 
            set
            {
                JsonRPC = value;
            }
        }

        [JsonProperty(PropertyName = "params", Order = 3)]
        public IList<object> Parameters { get; set; }

        public byte[] GetBytes()
        {
            var json = JsonConvert.SerializeObject(this);
            return Encoding.UTF8.GetBytes(json);
        }        
    }
}