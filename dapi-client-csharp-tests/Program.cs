using System;
using dapi_client_csharp;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            DAPIClient dapi = new DAPIClient();
            //Example getBestBlockHash
            Console.WriteLine("getBestBlockHash: " + dapi.getBestBlockHash());

            //Example getBlockHash
            int height = 1;
            Console.WriteLine("getBlockHash: " + dapi.getBlockHash(height));
            
            //Example getMnListDiff
            string baseBlockHash = "5ad690bcbedeb8be47e840cd869485d802c9331488604d57a5a14e8e5db3129d";
            string blockHash = "0000018b02092f8b21ebbed244784191af95edd75a3b39262ff5e975c4addb2e";
            Console.WriteLine("getMnListDiff: " + dapi.getMnListDiff(baseBlockHash,blockHash));
        }
    }
}
