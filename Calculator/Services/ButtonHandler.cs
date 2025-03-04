using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Logic;

namespace Calculator.Services
{
    public class ButtonHandler
    {
        private readonly DisplayManager _displayManager;
        private readonly ICalculatorEngine _calculatorEngine;

        public ButtonHandler(DisplayManager displayManager, ICalculatorEngine calculatorEngine)
        {
            _displayManager = displayManager;
            _calculatorEngine = calculatorEngine;
        }

        public void InitializeButtons(IEnumerable<Button> buttons)
        {
            foreach (Button btn in buttons)
            {
                if (char.IsDigit(btn.Text[0]) || btn.Text == ".")
                {
                    btn.Click += (sender, e) => _displayManager.AddCharacter(btn.Text);
                }
                else if (btn.Text == "=")
                {
                    btn.Click += (sender, e) => Evaluate();
                }
                else if (btn.Text == "C")
                {
                    btn.Click += (sender, e) => _displayManager.Clear();
                }
                else if (btn.Text == "->")
                {
                    btn.Click += (sender, e) => _displayManager.Backspace();
                }
                else
                {
                    btn.Click += (sender, e) => _displayManager.AddCharacter(btn.Text);
                }
            }
        }

        private void Evaluate()
        {
            try
            {
                string expression = _displayManager.GetExpression(); // دریافت مقدار واقعی ورودی
                string result = _calculatorEngine.Evaluate(expression).ToString();
                _displayManager.ShowResult(result);
            }
            catch
            {
                _displayManager.ShowError();
            }
        }
    }
}
