using dapi_client_csharp.Models;
using dapi_client_csharp.RPC;
using Newtonsoft.Json.Linq;
using Grpc.Core;
using Grpc.Net.Client;
using static Org.Dash.Platform.Dapi.V0.Core;
using static Org.Dash.Platform.Dapi.V0.Platform;
using static Org.Dash.Platform.Dapi.V0.TransactionsFilterStream;
using Org.Dash.Platform.Dapi.V0;
using Google.Protobuf;

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
            System.AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
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
        public GetStatusResponse getStatus(){
            GetStatusRequest request = new GetStatusRequest();
            return coreClient.getStatus(request);
        }

        public GetBlockResponse getBlock(GetBlockParameter parameter){
            GetBlockRequest request = new GetBlockRequest();
            if(!string.IsNullOrEmpty(parameter.hash)){
                request.Hash = parameter.hash;
            }
            request.Height = parameter.height;
            return coreClient.getBlock(request);
        }

        public SendTransactionResponse sendTransaction(SendTransactionParameter parameter){
            SendTransactionRequest request = new SendTransactionRequest();
            request.Transaction = ByteString.CopyFromUtf8(parameter.transaction);
            request.AllowHighFees = parameter.allow_high_fees;
            request.BypassLimits = parameter.bypass_limits;
            return coreClient.sendTransaction(request);
        }

        public GetTransactionResponse getTransaction(string id){
            GetTransactionRequest request = new GetTransactionRequest();
            request.Id = id;
            return coreClient.getTransaction(request);
        }

        //Platform gRPC Endpoints
        public ApplyStateTransitionResponse applyStateTransition(string stateTransition){
            ApplyStateTransitionRequest request = new ApplyStateTransitionRequest();
            request.StateTransition = ByteString.FromBase64(stateTransition);
            return platformClient.applyStateTransition(request);
        }
        //Transaction Streaming gRPC Endpoints
    }
}
