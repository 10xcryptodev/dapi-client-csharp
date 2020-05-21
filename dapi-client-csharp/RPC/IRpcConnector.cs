namespace dapi_client_csharp.RPC
{ 
    public interface IRpcConnector
    {
        T MakeRequest<T>(RpcMethods method, object parameters);
    }
}