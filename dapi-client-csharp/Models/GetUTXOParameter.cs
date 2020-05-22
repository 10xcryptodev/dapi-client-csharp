namespace dapi_client_csharp.Models
{
    public class GetUTXOParameter
    {
        public string[] address { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public int fromHeight { get; set; }
        public int toHeight { get; set; }
    }
}