using Calculator.Controller;
using System;
using System.Windows.Forms;

namespace Calculator;

public partial class MainForm : Form
{
    #region Variables and constructor
    private float _firstNumberAsFloat, _secondNumberAsFloat;
    public MainForm() { InitializeComponent(); }
    #endregion

    #region Event handling
    private void btnSubtraction_Click(object sender, EventArgs e) { Subtract(); }
    private void btnAddition_Click(object sender, EventArgs e) { Add(); }
    private void btnMultiplication_Click(object sender, EventArgs e) { Multiply(); }
    private void btnDivision_Click(object sender, EventArgs e) { Divide(); }

    #endregion

    #region Functionality
    private void Subtract()
    {
        if (!ValidateInput()) { ShowErrorParsing(); return; };
        txtResult.Text = CalculationController.Subtraction(_firstNumberAsFloat, _secondNumberAsFloat).ToString();
    }
    private void Add()
    {
        if (!ValidateInput()) { ShowErrorParsing(); return; };
        txtResult.Text = CalculationController.Addition(_firstNumberAsFloat, _secondNumberAsFloat).ToString();
    }
    private void Multiply()
    {
        if (!ValidateInput()) { ShowErrorParsing(); return; };
        txtResult.Text = CalculationController.Multiplication(_firstNumberAsFloat, _secondNumberAsFloat).ToString();
    }
    private void Divide()
    {
        if (!ValidateInput()) { ShowErrorParsing(); return; };
        txtResult.Text = CalculationController.Division(_firstNumberAsFloat, _secondNumberAsFloat).ToString();
    }

    private bool ValidateInput()
    {
        return float.TryParse(txtFirstNumber.Text, out _firstNumberAsFloat)
                   && float.TryParse(txtSecondNumber.Text, out _secondNumberAsFloat);
    }
    private void ShowErrorParsing()
    {
        MessageBox.Show("Unable to parse first or second number. \nPlease check your input.", "Error", MessageBoxButtons.OK);
    } 
    #endregion
}