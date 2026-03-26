using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalculatorVersion1 : Form
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int result = 0;
        string op = "";
        bool isOperatorClicked = false;

        public CalculatorVersion1()
        {
            InitializeComponent();
        }

        private void inputNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputNumber(string number)
        {
            if (isOperatorClicked)
            {
                outputNumBox.Text = "";
                isOperatorClicked = false;
            }

            outputNumBox.Text += number;

            if (op == "")
            {
                inputNumBox.Text = outputNumBox.Text;
            }
            else
            {
                inputNumBox.Text = firstNumber.ToString() + " " + op + " " + outputNumBox.Text;
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            InputNumber("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            InputNumber("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            InputNumber("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            InputNumber("4");
        }


        private void btnNum5_Click(object sender, EventArgs e)
        {
            InputNumber("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            InputNumber("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            InputNumber("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            InputNumber("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            InputNumber("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            InputNumber("0");
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }


        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (outputNumBox.Text == "") return;

            firstNumber = int.Parse(outputNumBox.Text);
            op = "+";
            isOperatorClicked = true;

            inputNumBox.Text = firstNumber.ToString() + " " + op;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (outputNumBox.Text == "" || op == "") return;

            secondNumber = int.Parse(outputNumBox.Text);
            result = firstNumber + secondNumber;

            inputNumBox.Text = firstNumber.ToString() + " " + op + " " + secondNumber.ToString() + " = " + result.ToString();
            outputNumBox.Text = result.ToString();

            op = "";
            isOperatorClicked = true;
        }

        private void inputNumBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
