using System;

namespace dapi_client_csharp.RPC
{
    [Serializable]
    public class RpcRequestTimeoutException : Exception
    {
        public RpcRequestTimeoutException()
        {
        }

        public RpcRequestTimeoutException(string customMessage) : base(customMessage)
        {
        }

        public RpcRequestTimeoutException(string customMessage, Exception exception) : base(customMessage, exception)
        {
        }
    }
}