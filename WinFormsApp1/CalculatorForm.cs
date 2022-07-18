using CalculatorLibrary;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            comboBoxOperator.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal left = numericUpDownLeftValue.Value;
            decimal right = numericUpDownRightValue.Value;

            char operationOperator = comboBoxOperator.SelectedItem.ToString()[0];

            try
            {
                var result = CalculatorHelper.Calculate(left, right, operationOperator);
                textBoxResult.Text = $"{result}";
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
