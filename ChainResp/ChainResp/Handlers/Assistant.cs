using ChainResp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResp.Handlers
{
    public class Assistant : IOrderHandler
    {
        protected IOrderHandler succesor;

        public IOrderHandler GetSucesor()
        {
            return succesor;
        }

        public void Request(string description, int price)
        {
            if (price <= 20000)
            {
                Console.Write(string.Format("La petición {0} es manejada por el asistente.", description));
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
