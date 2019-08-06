using ChainResp.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResp
{
    /// <summary>
    /// Cliente.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string description = "Orden de útiles escolares ";
            int price = 700000;

            Company company = new Company();
            company.Request(description, price);

            Console.Read();
        }
    }
}
