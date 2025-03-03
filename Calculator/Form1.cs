using System.Linq;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool isOperationPerformed = false;

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
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
               AddCharacter(btn.Text);
            }
        }

        private void AddCharacter(string character)
        {
            if(character == "." && txtCalculator.Text.Contains(".")) return;

            txtCalculator.Text += character;          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                AddCharacter(((char)e.KeyCode).ToString());
            }
        }
    }
}
