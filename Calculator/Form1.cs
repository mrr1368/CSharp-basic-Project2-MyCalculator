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

            _inputHandler = new InputHandler(this, calculator, txtCalculator, txtResult);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _inputHandler.InitializeButtons(this.Controls.OfType<Button>());
            this.KeyDown += _inputHandler.HandleKeyDown;
            this.KeyUp += _inputHandler.HandleKeyUp;
        }



        

         
    }
}
    

