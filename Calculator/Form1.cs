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

        private void Number_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                txtCalculator.Text += btn.Text; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (char.IsDigit(btn.Text[0]))
                {
                    btn.Click += Number_Click; 
                }
            }
        }
    }
}
