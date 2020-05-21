using System;

namespace dapi_client_csharp.RPC
{
    [Serializable]
    public class RpcResponseDeserializationException : Exception
    {
        public RpcResponseDeserializationException()
        {
        }

        public RpcResponseDeserializationException(string customMessage) : base(customMessage)
        {
        }

        public RpcResponseDeserializationException(string customMessage, Exception exception) : base(customMessage, exception)
        {
        }
    }
}