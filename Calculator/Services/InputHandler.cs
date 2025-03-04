using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Logic;

namespace Calculator.Services
{
    public class InputHandler
    {
        private readonly ICalculatorEngine _calculatorEngine;

        private readonly TextBox _txtCalculator;
        private readonly TextBox _txtResult;

        private readonly Form _form;

        public InputHandler(Form form, ICalculatorEngine calculatorEngine, TextBox txtCalculator, TextBox txtResult)
        {
            _calculatorEngine = calculatorEngine;
            _txtCalculator = txtCalculator;
            _txtResult = txtResult;
            _form = form;
        }

        public void InitializeButtons(IEnumerable<Button> buttons)
        {
            foreach (Button btn in buttons)
            {
                if (char.IsDigit(btn.Text[0]) || btn.Text == ".")
                {
                    btn.Click += Number_Click;
                }
                else if (btn.Text == "=")
                {
                    btn.Click += Equal_Click;
                }
                else if (btn.Text == "C")
                {
                    btn.Click += Clear_Click;
                }
                else if (btn.Text == "->")
                {
                    btn.Click += Backspace_Click;
                }
                else
                {
                    btn.Click += Operator_Click;
                }
            }
        }

        private void AddCharacter(string character)
        {
            if (character == "." && _txtCalculator.Text.Contains(".")) return;
            if (_txtCalculator.Text.Length >= 20) return;

            _txtCalculator.Text += character;
        }

        private void Number_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                AddCharacter(btn.Text);
            }
        }

        private void Equal_Click(object? sender, EventArgs e)
        {
            try
            {
                _txtResult.Text = "= " + _calculatorEngine.Evaluate(_txtCalculator.Text).ToString();
            }
            catch (Exception)
            {
                _txtResult.Text = "Error";
            }
        }

        private void Clear_Click(object? sender, EventArgs e)
        {
            _txtCalculator.Clear();
            _txtResult.Clear();
        }

        private void Backspace_Click(object? sender, EventArgs e)
        {
            if (_txtCalculator.Text.Length > 0)
            {
                _txtCalculator.Text = _txtCalculator.Text.Remove(_txtCalculator.Text.Length - 1);
            }
        }

        private void Operator_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                AddCharacter(btn.Text);
            }
        }

        public void HandleKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) _form.Close();
        }

        public void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                AddCharacter(((char)e.KeyCode).ToString());
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                AddCharacter(((char)(e.KeyCode - Keys.NumPad0 + '0')).ToString());
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                AddCharacter(".");
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (_txtCalculator.Text.Length > 0)
                {
                    _txtCalculator.Text = _txtCalculator.Text.Remove(_txtCalculator.Text.Length - 1);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Equal_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Clear_Click(null, null);
            }
            else if (e.KeyCode == Keys.Add)
            {
                AddCharacter("+");
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                AddCharacter("-");
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                AddCharacter("*");
            }
            else if (e.KeyCode == Keys.Divide)
            {
                AddCharacter("/");
            }
        }
    }

}

