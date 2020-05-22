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

        public JObject getMnListDiff(GetMnListDiffParameter parameter){
            return _rpcConnector.MakeRequest<JObject>(RpcMethods.getMnListDiff, parameter);
        }

        public JObject getUTXO(GetUTXOParameter parameter){
            return _rpcConnector.MakeRequest<JObject>(RpcMethods.getUTXO, parameter);
        }

    }
}
