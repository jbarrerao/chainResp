using ChainResp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResp.Handlers
{
    /// <summary>
    /// Manejador concreto 4
    /// </summary>
    public class Director : IOrderHandler
    {
        protected IOrderHandler succesor;

        public IOrderHandler GetSucesor()
        {
            return succesor;
        }

        public void Request(string description, int price)
        {
            if (price > 500000)
            {
                Console.Write(string.Format("La petición {0} es manejada por el director.", description));
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
