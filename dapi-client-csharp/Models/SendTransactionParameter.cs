namespace dapi_client_csharp.Models
{
    public class SendTransactionParameter
    {
        public string transaction { get; set; }
        public bool allow_high_fees { get; set; }
        public bool bypass_limits { get; set; }
    }
}