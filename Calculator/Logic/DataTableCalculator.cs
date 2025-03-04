using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    public class DataTableCalculator : ICalculatorEngine
    {
        public string Evaluate(string expression)
        {
            try
            {
                return new DataTable().Compute(expression, null)?.ToString() ?? "Error";
            }
            catch
            {
                return "Error";
            }
        }
    }
}
