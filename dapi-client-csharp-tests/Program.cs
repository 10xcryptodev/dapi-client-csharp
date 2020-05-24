using System;
using System.Threading.Tasks;
using dapi_client_csharp;
using dapi_client_csharp.Models;

namespace tests
{
    class Program
    {
        static DAPIClient dapi;
        static void Main(string[] args)
        {
            dapi = new DAPIClient();
            
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

            //Example getStatus
            Console.WriteLine("getStatus: " + dapi.getStatus());

            //Example getBlock
            GetBlockParameter paramGetBlock = new GetBlockParameter();
            paramGetBlock.height = 1;
            Console.WriteLine("getBlock: " + dapi.getBlock(paramGetBlock));

            //Example sendTransaction
            SendTransactionParameter paramSendTransaction = new SendTransactionParameter();
            paramSendTransaction.transaction = "020000000123c52118bfc5da0222a569d379ce3e3a9ca18976175785fd45b3f8990341768b000000006b483045022100a3952306ccb38e1eb22d9956ab40744b79e3072621e634e19225ad8a15603e3102201a3724cb9a8216e78139793c953245b0890c207e13af86bb02735f50a5bccad9012103439cfc2b5fab7fe05c0fbf8fa9217707a5bf5badb7c7e6db05bd0fb1231c5c8bfeffffff0200e1f505000000001976a91468b39aad690ffb710b4ba522d742670b763b501988ac1ec34f95010000001976a91445ada709129f7b6381559c8a16f1ec83c0b3ca8c88acb4240000";
            try{
                Console.WriteLine("sendTransaction: " + dapi.sendTransaction(paramSendTransaction));
            }catch(Exception e){
                Console.WriteLine("sendTransaction: " + e.Message);
            }

            //Example getTransaction
            string id = "29b68163a22d89c14e24f1281cb4608b8dc7be05bc2604e2cecf8a85b1dede0d";
            try{
                Console.WriteLine("getTransaction: " + dapi.getTransaction(id));
            }catch(Exception e){
                Console.WriteLine("getTransaction: " + e.Message);
            }

            //Example applyStateTransition            
            string stateTransition = "pmR0eXBlAmdhY3Rpb25zgQFpZG9jdW1lbnRzgaZkJHJldgFlJHR5cGVocHJlb3JkZXJnJHVzZXJJZHgsR0pNVm51UzdYVFhkaWtnalFyRDR0TjVaSkNYem02eE12R0dyNVNkdGVjcDFoJGVudHJvcHl4InlVOXVta1Q0QnZjQWpQSmpGRVRGNW9CbUgzdEEyU3FKS2drJGNvbnRyYWN0SWR4LDJLZk1jTXhrdEtpbUp4QVpVZVp3WWtGVXNFY0FaaERLRXBRczhHTW5wVXNlcHNhbHRlZERvbWFpbkhhc2h4XjU2MmQ4Y2Q1YTQ1Nzg4ZWU0MWM3YzNiYWNhZGU5ODMwNGY0MTk0MzkyOTA4NDgxMzljOWZiZDU2MTI3NDY1NzM3NDJlNzQ2ODY1NzA2ODY1N2EzMzJlNjQ2MTczNjhpc2lnbmF0dXJleFhIMkxxMW5pM1cyR0Q0TXlqK3lzSHdOMExKRXdHSjExMTRaTHExL0dTalJxakliY2Z0VzcvUkpZVFozeFhnOW0wTTJ4SnVJSEwvMzVGUFVUdUkxUUFBSTg9b3Byb3RvY29sVmVyc2lvbgB0c2lnbmF0dXJlUHVibGljS2V5SWQB";
            try{
                Console.WriteLine("applyStateTransition: " + dapi.applyStateTransition(stateTransition));
            }catch(Exception e){
                Console.WriteLine("applyStateTransition: " + e.Message);
            }

            //Example getIdentity
            string identity = "JCaTiRxm4dRN1GJqoNkpowmvisC7BbgPW48pJ6roLSgw";
            try{
                Console.WriteLine("getIdentity: " + dapi.getIdentity(identity));
            }catch(Exception e){
                Console.WriteLine("getIdentity: " + e.Message);
            }

            //Example getDataContract
            string dataContractId = "5wpZAEWndYcTeuwZpkmSa8s49cHXU5q2DhdibesxFSu8";
            try{
                Console.WriteLine("getDataContract: " + dapi.getDataContract(dataContractId));
            }catch(Exception e){
                Console.WriteLine("getDataContract: " + e.Message);
            }

            //Example getDocuments
            GetDocumentsParameter paramGetDocuments = new GetDocumentsParameter();
            paramGetDocuments.DataContractId = "5wpZAEWndYcTeuwZpkmSa8s49cHXU5q2DhdibesxFSu8";
            paramGetDocuments.DocumentType = "note";
            paramGetDocuments.Limit = 1;
            try{
                Console.WriteLine("getDocuments: " + dapi.getDocuments(paramGetDocuments));
            }catch(Exception e){
                Console.WriteLine("getDocuments: " + e.Message);
            }

            //Example subscribeToTransactionsWithProofs
            SubscribeToTransactionsWithProofsParameter paramSubscribe = new SubscribeToTransactionsWithProofsParameter();
            paramSubscribe.n_hash_funcs = 11;
            paramSubscribe.v_data = "";
            paramSubscribe.n_tweak = 0;
            paramSubscribe.n_flags = 0;
            paramSubscribe.FromBlockHeight = 1;
            paramSubscribe.Count = 1;
            try{
                printSubscribeToTransactionsWithProofs(paramSubscribe);
                Console.Read();
            }catch(Exception e){
                Console.WriteLine("subscribeToTransactionsWithProofs: " + e.Message);
            }

        }

        async static void printSubscribeToTransactionsWithProofs(SubscribeToTransactionsWithProofsParameter paramSubscribe){
            while (await dapi.subscribeToTransactionsWithProofs(paramSubscribe).MoveNextAsync())
            {
                Console.WriteLine("subscribeToTransactionsWithProofs: " + dapi.subscribeToTransactionsWithProofs(paramSubscribe).Current);   
            }  
        }
        
    }
}
