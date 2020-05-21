using System;
using dapi_client_csharp.RPC;

namespace dapi_client_csharp
{
    public class DAPIClient
    {   
        protected readonly IRpcConnector _rpcConnector;

        public DAPIClient(){
            _rpcConnector = new RpcConnector();
        }

        public string getAddressSumary(){
            return "";
        }

        public string getBestBlockHash(){
            return _rpcConnector.MakeRequest<string>(RpcMethods.getBestBlockHash);
        }

    }
}
