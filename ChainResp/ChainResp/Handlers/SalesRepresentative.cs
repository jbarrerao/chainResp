using ChainResp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResp.Handlers
{
    /// <summary>
    /// Manejador concreto 6
    /// </summary>
    public class SalesRepresentative : IOrderHandler
    {
        protected IOrderHandler succesor;

        public IOrderHandler GetSucesor()
        {
            return succesor;
        }

        public void Request(string description, int price)
        {
            if (price > 50000 && price <= 100000)
            {
                Console.Write(string.Format("La petición {0} es manejada por el representante de ventas.", description));
            }
            else
            {
                succesor.Request(description, price);
            }
        }

        public void SetSucesor(IOrderHandler handler)
        {
            this.succesor = handler;
        }
    }
}
