using Org.Dash.Platform.Dapi.V0;

namespace dapi_client_csharp.Models
{
    public class SubscribeToTransactionsWithProofsParameter
    {
        public string v_data { get; set; }
        public uint n_hash_funcs { get; set; }
        public uint n_tweak { get; set; }
        public uint n_flags { get; set; }
        public string FromBlockHash { get; set; }
        public uint FromBlockHeight { get; set; }
        public uint Count { get; set; }
        public bool SendTransactionHashes { get; set; }
        

    }
}