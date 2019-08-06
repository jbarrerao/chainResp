using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResp.Interface
{
    /// <summary>
    /// Manejador
    /// </summary>
   public interface IOrderHandler
    {
        void SetSucesor(IOrderHandler handler);

        IOrderHandler GetSucesor();

        void Request(string description, int price);
    }
}
