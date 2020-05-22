﻿using dapi_client_csharp.Models;
using dapi_client_csharp.RPC;
using Newtonsoft.Json.Linq;
using Grpc.Net.Client;
using Org.Dash.Platform.Dapi.V0;
using static Org.Dash.Platform.Dapi.V0.Platform;

namespace dapi_client_csharp
{
    public class DAPIClient
    {   
        string gRPCServer = "seed.evonet.networks.dash.org:3010";
        protected readonly IRpcConnector _rpcConnector;
        GrpcChannel channel;
        PlatformClient client;

        public DAPIClient(){
            _rpcConnector = new RpcConnector();
            channel = GrpcChannel.ForAddress(gRPCServer);
            client = new Platform.PlatformClient(channel);
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
