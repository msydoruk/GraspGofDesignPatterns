using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public interface ICalculator
    {
        public int Add(int intA, int intB);
        public int Subtract(int intA, int intB);
        public int Multiply(int intA, int intB);
        public int Divide(int intA, int intB);
    }
}
