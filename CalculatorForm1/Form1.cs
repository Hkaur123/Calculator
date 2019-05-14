using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm1
{
    public partial class Calculator : Form
    {
        
        string inputNumber;
        string operatorValue;
        double resultValue = 0;
        bool isOperationPerformed = false;
        string[] operators = new string[4] { "+", "*", "%", "/" };
        List<string> userInputs = new List<string>();

        public Calculator()
        {
            InitializeComponent();
        }

        private void numberButton_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((textBox_Results.Text == "0") || (isOperationPerformed))
            {
                textBox_Results.Clear();
            }
            isOperationPerformed = false;

            if (button.Text != ".")
            {
                inputNumber = inputNumber + button.Text;
            }
            else
            if ((button.Text == ".") && (!inputNumber.Contains(".")))
            {
                inputNumber = inputNumber + button.Text;
            }
            
            if ((button.Text != ".") || (!textBox_Results.Text.Contains(".")))
            {
                textBox_Results.Text = textBox_Results.Text + button.Text;
            }
        }

        private void operatorButton_click(object sender, EventArgs e)
        {
            userInputs.Add(inputNumber);
            inputNumber = "";
            Button button = (Button)sender;
            string lastCharacter = textBox_Results.Text[textBox_Results.Text.Length - 1].ToString();
            if (operators.Contains(lastCharacter))
            {
                textBox_Results.Text = textBox_Results.Text.Remove(textBox_Results.Text.Length - 1);
            }
            textBox_Results.Text = textBox_Results.Text + button.Text;
            operatorValue = button.Text;
            userInputs.Add(operatorValue);

            textBox_Results.Text = textBox_Results.Text.Remove(textBox_Results.Text.Length - 1);
            label1.Text = label1.Text + textBox_Results.Text + button.Text;
            isOperationPerformed = true;
        }
        public void calculate_button_click(object sender, EventArgs e)
        {
            string number1;
            string number2;

            if (inputNumber=="")
            {
                number1 = userInputs[0];
                   number2 = number1;
                userInputs.Add(number2);
            }
            else
            {
                userInputs.Add(inputNumber);
            }
          number1 = userInputs[0];
      
            for (int i = 1; i < userInputs.Count; )
            {
                operatorValue = userInputs[i];
                number2 = userInputs[i + 1];
                i = i + 2;
                resultValue = global::Calculator.Bussiness.Calculator.PerformOperation(Convert.ToDouble(number1), Convert.ToDouble(number2), operatorValue);
                number1 = resultValue.ToString();
            }
            textBox_Results.Text = resultValue.ToString();
            userInputs.Clear();
            inputNumber = resultValue.ToString();
            label1.Text = "";
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            inputNumber = null;
            operatorValue = null;
            resultValue = 0;
            isOperationPerformed = false;
            userInputs.Clear();
            textBox_Results.Text = "0";
            label1.Text = "";
        }
    }
}

