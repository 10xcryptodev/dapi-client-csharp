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
            GetMnListDiffParameter paramGetMn = new GetMnListDiffParameter();
            paramGetMn.baseBlockHash = "5ad690bcbedeb8be47e840cd869485d802c9331488604d57a5a14e8e5db3129d";
            paramGetMn.blockHash = "0000018b02092f8b21ebbed244784191af95edd75a3b39262ff5e975c4addb2e";
            Console.WriteLine("getMnListDiff: " + dapi.getMnListDiff(paramGetMn));

            //Example getUTXO
            GetUTXOParameter paramGetUTXO = new GetUTXOParameter();
            paramGetUTXO.address = new string[2]{"yeVomBV7cQgdEqUsm3vWxQsLgrwqw7viRH","yN7E9PWBT9c5NBJnzHBU3ZfwzFpQZG9Wpe"};
            paramGetUTXO.from = 0;
            paramGetUTXO.to = 5;
            paramGetUTXO.fromHeight = 5000;
            paramGetUTXO.toHeight = 20000;
            Console.WriteLine("getUTXO: " + dapi.getUTXO(paramGetUTXO));

        }
    }
}
