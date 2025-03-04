using System.Data;
using System.Linq;
using Calculator.Logic;
using Calculator.Services;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private readonly ICalculatorEngine _calculator;
        private readonly InputHandler _inputHandler;

        public Form1(ICalculatorEngine calculator)
        {
            InitializeComponent();
            _calculator = calculator;
            _inputHandler = new InputHandler(calculator, txtCalculator, txtResult);
        }

        private void Equal_Click(object? sender, EventArgs? e)
        {
            txtResult.Text = "= " + _calculator.Evaluate(txtCalculator.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _inputHandler.InitializeButtons(this.Controls.OfType<Button>());
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
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
                if (txtCalculator.Text.Length > 0)
                {
                    txtCalculator.Text = txtCalculator.Text.Remove(txtCalculator.Text.Length - 1);
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }        
    }
}
    

