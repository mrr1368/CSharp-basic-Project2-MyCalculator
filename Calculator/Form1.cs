using System.Data;
using System.Linq;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button btn in this.Controls.OfType<Button>())
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
            if (character == "." && txtCalculator.Text.Contains(".")) return;

            txtCalculator.Text += character;
        }

        private void Number_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                AddCharacter(btn.Text);
            }
        }

        private void Equal_Click(object? sender, EventArgs? e)
        {
            try
            {
                var result = new DataTable().Compute(txtCalculator.Text, null);
                txtResult.Text = "= " + result.ToString();
            }
            catch (Exception)
            {
                txtResult.Text = "Error";
            }
        }

        private void Clear_Click(object? sender, EventArgs? e)
        {
            txtCalculator.Clear();
            txtResult.Clear();
        }

        private void Backspace_Click(object? sender, EventArgs e)
        {
            if (txtCalculator.Text.Length > 0)
            {
                txtCalculator.Text = txtCalculator.Text.Remove(txtCalculator.Text.Length - 1);
            }
        }

        private void Operator_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                AddCharacter(btn.Text);
            }
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
    

