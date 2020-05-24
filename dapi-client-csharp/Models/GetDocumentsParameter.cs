namespace dapi_client_csharp.Models
{
    public class GetDocumentsParameter
    {
        public string DataContractId { get; set; }
        public string DocumentType { get; set; }
        public string Where { get; set; }
        public string OrderBy { get; set; }
        public uint Limit { get; set; } 
        public uint StartAt { get; set; }
        public uint StartAfter { get; set; }
    }
}