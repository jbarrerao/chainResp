using ChainResp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResp.Handlers
{
    /// <summary>
    /// Manejador concreto 3
    /// </summary>
    public class Company : IOrderHandler
    {
        protected IOrderHandler succesor;

        public IOrderHandler GetSucesor()
        {
            return succesor;
        }

        public void Request(string description, int price)
        {
            Assistant assistant = new Assistant();
            SetSucesor(assistant);

            BusinessAdvisor businessAdvisor = new BusinessAdvisor();
            assistant.SetSucesor(businessAdvisor);

            SalesRepresentative salesRepresentative = new SalesRepresentative();
            businessAdvisor.SetSucesor(salesRepresentative);

            Manager manager = new Manager();
            salesRepresentative.SetSucesor(manager);

            Director director = new Director();
            manager.SetSucesor(director);

            succesor.Request(description, price);
        }

        public void SetSucesor(IOrderHandler handler)
        {
            this.succesor = handler;
        }
    }
}
