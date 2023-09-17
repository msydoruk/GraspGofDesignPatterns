using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CalculatorServiceReference;

namespace FacadePattern
{
    public class Calculator : ICalculator
    {
        private readonly CalculatorSoapClient client = new(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);

        public int Add(int intA, int intB)
        {
            return client.Add(intA, intB);
        }

        public int Subtract(int intA, int intB)
        {
            return client.Subtract(intA, intB);
        }

        public int Multiply(int intA, int intB)
        {
            return client.Multiply(intA, intB);
        }

        public int Divide(int intA, int intB)
        {
            return client.Divide(intA, intB);
        }
    }
}
