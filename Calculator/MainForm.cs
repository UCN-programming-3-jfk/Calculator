using Calculator.Controller;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtFirstNumber.Text, out float firstValue)
               && float.TryParse(txtSecondNumber.Text, out float secondValue))
            {
                txtResult.Text = CalculationController.Subtraction(firstValue, secondValue).ToString();
            }
            else
            {
                ShowErrorParsing();
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtFirstNumber.Text, out float firstValue)
                && float.TryParse(txtSecondNumber.Text, out float secondValue))
            {
                txtResult.Text = CalculationController.Addition(firstValue, secondValue).ToString();
            }
            else
            {
                ShowErrorParsing();
            }
        }

        
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtFirstNumber.Text, out float firstValue)
               && float.TryParse(txtSecondNumber.Text, out float secondValue))
            {
                txtResult.Text = CalculationController.Multiplication(firstValue, secondValue).ToString();
            }
            else
            {
                ShowErrorParsing();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtFirstNumber.Text, out float firstValue)
               && float.TryParse(txtSecondNumber.Text, out float secondValue))
            {
                txtResult.Text = CalculationController.Division(firstValue, secondValue).ToString();
            }
            else
            {
                ShowErrorParsing();
            }
        }

        private void ShowErrorParsing()
        {
            MessageBox.Show("Unable to parse first or second number. \nPlease check your input.", "Error", MessageBoxButtons.OK);
        }

    }
}
