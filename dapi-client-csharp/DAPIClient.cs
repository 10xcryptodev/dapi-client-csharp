using dapi_client_csharp.Models;
using dapi_client_csharp.RPC;
using Newtonsoft.Json.Linq;
using Grpc.Core;
using Grpc.Net.Client;
using static Org.Dash.Platform.Dapi.V0.Core;
using static Org.Dash.Platform.Dapi.V0.Platform;
using static Org.Dash.Platform.Dapi.V0.TransactionsFilterStream;
using Org.Dash.Platform.Dapi.V0;

namespace dapi_client_csharp
{
    public class DAPIClient
    {   
        string gRPCServer = "http://seed.evonet.networks.dash.org:3010";
        protected readonly IRpcConnector _rpcConnector;
        GrpcChannel channel;
        PlatformClient platformClient;
        CoreClient coreClient;
        TransactionsFilterStreamClient transactionsFilterStreamClient;

        public DAPIClient(){
            _rpcConnector = new RpcConnector();
            channel = GrpcChannel.ForAddress(gRPCServer);
            coreClient = new CoreClient(channel);
            platformClient = new PlatformClient(channel);
            transactionsFilterStreamClient = new TransactionsFilterStreamClient(channel);
        }

        //JSON-RPC Endpoints
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


        //gRPC Endpoints
        //Core gRPC Endpoints
        //Platform gRPC Endpoints
        public ApplyStateTransitionResponse applyStateTransition(ApplyStateTransitionRequest request){
            return platformClient.applyStateTransition(request);
        }
        //Transaction Streaming gRPC Endpoints
    }
}
