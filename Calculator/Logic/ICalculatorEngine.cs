using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    public interface ICalculatorEngine
    {
            string Evaluate(string expression);
    }
}
