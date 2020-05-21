using System;
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

        public string getAddressSumary(string[] address){
            return _rpcConnector.MakeRequest<string>(RpcMethods.getAddressSumary, address);
        }

        public string getBestBlockHash(){
            return _rpcConnector.MakeRequest<string>(RpcMethods.getBestBlockHash);
        }

        public string getBlockHash(int height){
            return _rpcConnector.MakeRequest<string>(RpcMethods.getBlockHash, height);
        }

        public string getMnListDiff(string baseBlockHash, string blockHash){
            return _rpcConnector.MakeRequest<string>(RpcMethods.getMnListDiff, baseBlockHash, blockHash);
        }

        public string getUTXO(string[] address, int from, int to, int fromHeight, int toHeight){
            return _rpcConnector.MakeRequest<string>(RpcMethods.getUTXO, address, from, to, fromHeight, toHeight);
        }

    }
}
