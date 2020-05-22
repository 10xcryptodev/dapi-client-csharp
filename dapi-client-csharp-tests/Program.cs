using System;
using dapi_client_csharp;
using dapi_client_csharp.Models;
using Google.Protobuf;
using Org.Dash.Platform.Dapi.V0;

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

            //Example applyStateTransition
            ApplyStateTransitionRequest request = new ApplyStateTransitionRequest();
            request.StateTransition = ByteString.FromBase64("pmR0eXBlAmdhY3Rpb25zgQFpZG9jdW1lbnRzgaZkJHJldgFlJHR5cGVocHJlb3JkZXJnJHVzZXJJZHgsR0pNVm51UzdYVFhkaWtnalFyRDR0TjVaSkNYem02eE12R0dyNVNkdGVjcDFoJGVudHJvcHl4InlVOXVta1Q0QnZjQWpQSmpGRVRGNW9CbUgzdEEyU3FKS2drJGNvbnRyYWN0SWR4LDJLZk1jTXhrdEtpbUp4QVpVZVp3WWtGVXNFY0FaaERLRXBRczhHTW5wVXNlcHNhbHRlZERvbWFpbkhhc2h4XjU2MmQ4Y2Q1YTQ1Nzg4ZWU0MWM3YzNiYWNhZGU5ODMwNGY0MTk0MzkyOTA4NDgxMzljOWZiZDU2MTI3NDY1NzM3NDJlNzQ2ODY1NzA2ODY1N2EzMzJlNjQ2MTczNjhpc2lnbmF0dXJleFhIMkxxMW5pM1cyR0Q0TXlqK3lzSHdOMExKRXdHSjExMTRaTHExL0dTalJxakliY2Z0VzcvUkpZVFozeFhnOW0wTTJ4SnVJSEwvMzVGUFVUdUkxUUFBSTg9b3Byb3RvY29sVmVyc2lvbgB0c2lnbmF0dXJlUHVibGljS2V5SWQB");
            Console.WriteLine("applyStateTransition: " + dapi.applyStateTransition(request));

        }
    }
}
