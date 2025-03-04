using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class KeyboardHandler
    {
        private readonly DisplayManager _displayManager;
        private readonly Form _form;

        public KeyboardHandler(Form form, DisplayManager displayManager)
        {
            _form = form;
            _displayManager = displayManager;
        }

        public void RegisterKeyEvents()
        {
            _form.KeyDown += HandleKeyDown;
            _form.KeyUp += HandleKeyUp;
            _form.KeyPreview = true;
        }

        private void HandleKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) _form.Close();
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                _displayManager.AddCharacter(((char)e.KeyCode).ToString());
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                _displayManager.AddCharacter(((char)(e.KeyCode - Keys.NumPad0 + '0')).ToString());
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                _displayManager.AddCharacter(".");
            }
            else if (e.KeyCode == Keys.Back)
            {
                _displayManager.Backspace();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                _displayManager.Clear();
            }
            else if (e.KeyCode == Keys.Add)
            {
                _displayManager.AddCharacter("+");
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                _displayManager.AddCharacter("-");
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                _displayManager.AddCharacter("*");
            }
            else if (e.KeyCode == Keys.Divide)
            {
                _displayManager.AddCharacter("/");
            }
        }
    }
}
