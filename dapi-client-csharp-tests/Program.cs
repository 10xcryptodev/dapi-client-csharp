using System;
using dapi_client_csharp;
using dapi_client_csharp.Models;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            DAPIClient dapi = new DAPIClient();
            
            //Example getAddressSummary
            GetAddressSummaryParameter param = new GetAddressSummaryParameter();
            string[] address = new string[2]{"yVs4HGmHgzP4t3gZ7KrpxRzCmkQcvZmczd","ySnJVXXx9FtKUBTkovPaPPqCkTMNzDLPCu"};
            param.address = address;
            Console.WriteLine("getAddressSummary: " + dapi.getAddressSummary(param).ToString());
            
            //Example getBestBlockHash
            Console.WriteLine("getBestBlockHash: " + dapi.getBestBlockHash());

            //Example getBlockHash
            GetBlockHashParameter paramBlockHash = new GetBlockHashParameter();
            paramBlockHash.height = 1;
            Console.WriteLine("getBlockHash: " + dapi.getBlockHash(paramBlockHash));
            
            //Example getMnListDiff
            string baseBlockHash = "5ad690bcbedeb8be47e840cd869485d802c9331488604d57a5a14e8e5db3129d";
            string blockHash = "0000018b02092f8b21ebbed244784191af95edd75a3b39262ff5e975c4addb2e";
            Console.WriteLine("getMnListDiff: " + dapi.getMnListDiff(baseBlockHash,blockHash));

            //Example getUTXO
            string[] addressUTXO = new string[2]{"yeVomBV7cQgdEqUsm3vWxQsLgrwqw7viRH","yN7E9PWBT9c5NBJnzHBU3ZfwzFpQZG9Wpe"};
            int from = 0;
            int to = 5;
            int fromHeight = 5000;
            int toHeight = 20000;
            Console.WriteLine("getUTXO: " + dapi.getUTXO(addressUTXO, from, to, fromHeight, toHeight));

        }
    }
}
