using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class DisplayManager
    {
        private readonly TextBox _txtCalculator;
        private readonly TextBox _txtResult;

        public DisplayManager(TextBox txtCalculator, TextBox txtResult)
        {
            _txtCalculator = txtCalculator;
            _txtResult = txtResult;
        }
        public string GetExpression()
        {
            return _txtCalculator.Text;
        }

        public void AddCharacter(string character)
        {
            if (character == "." && _txtCalculator.Text.Contains(".")) return;
            if (_txtCalculator.Text.Length >= 20) return;

            _txtCalculator.Text += character;
        }

        public void Clear()
        {
            _txtCalculator.Clear();
            _txtResult.Clear();
        }

        public void Backspace()
        {
            if (_txtCalculator.Text.Length > 0)
            {
                _txtCalculator.Text = _txtCalculator.Text.Remove(_txtCalculator.Text.Length - 1);
            }
        }

        public void ShowResult(string result)
        {
            _txtResult.Text = "= " + result;
        }

        public void ShowError()
        {
            _txtResult.Text = "Error";
        }
    }
}
