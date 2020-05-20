namespace dapi_client_csharp.RPC
{
    //  Note: Do not alter the capitalization of the enum members as they are being cast as-is to the RPC server
    public enum RpcMethods
    {
        //Level 1
        getAddressSummary, 	//Returns summary information for provided address(es)
        getBestBlockHash, 	//Returns block hash of the chaintip
        getBlockHash, 	//Returns block hash of the requested block
        getMnListDiff, 	//Returns masternode list diff for the provided block hashes
        getUTXO, 	//Returns unspent transaction outputs for a given address
    }
}