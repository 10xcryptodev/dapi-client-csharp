using System;
using dapi_client_csharp;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            DAPIClient dapi = new DAPIClient();
            dapi.getBestBlockHash();
        }
    }
}
