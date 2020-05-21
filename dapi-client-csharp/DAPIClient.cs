using dapi_client_csharp.Models;
using dapi_client_csharp.RPC;
using Newtonsoft.Json.Linq;

namespace dapi_client_csharp
{
    public class DAPIClient
    {   
        protected readonly IRpcConnector _rpcConnector;

        public DAPIClient(){
            _rpcConnector = new RpcConnector();
        }

        public JObject getAddressSummary(GetAddressSummaryParameter parameter){
            return _rpcConnector.MakeRequest<JObject>(RpcMethods.getAddressSummary, parameter);
        }

        public string getBestBlockHash(){
            return _rpcConnector.MakeRequest<string>(RpcMethods.getBestBlockHash, new object());
        }

        public string getBlockHash(GetBlockHashParameter parameter){
            return _rpcConnector.MakeRequest<string>(RpcMethods.getBlockHash, parameter);
        }

        public string getMnListDiff(string baseBlockHash, string blockHash){
            return "";//_rpcConnector.MakeRequest<string>(RpcMethods.getMnListDiff, baseBlockHash, blockHash);
        }

        public string getUTXO(string[] address, int from, int to, int fromHeight, int toHeight){
            return "";//_rpcConnector.MakeRequest<string>(RpcMethods.getUTXO, address, from, to, fromHeight, toHeight);
        }

    }
}
