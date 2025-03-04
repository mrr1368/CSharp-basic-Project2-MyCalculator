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
        private readonly ButtonHandler _buttonHandler;
        private readonly KeyboardHandler _keyboardHandler;

        public InputHandler(Form form, ICalculatorEngine calculatorEngine, TextBox txtCalculator, TextBox txtResult)
        {
            var displayManager = new DisplayManager(txtCalculator, txtResult);

            _buttonHandler = new ButtonHandler(displayManager, calculatorEngine);
            _keyboardHandler = new KeyboardHandler(form, displayManager);
        }

        public void Initialize(IEnumerable<Button> buttons)
        {
            _buttonHandler.InitializeButtons(buttons);
            _keyboardHandler.RegisterKeyEvents();
        }
    }

}

