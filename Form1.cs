using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalculatorVersion1 : Form
    {
        string currentExpression = "";

        public CalculatorVersion1()
        {
            InitializeComponent();

            KeyPreview = true;

            inputNumBox.ReadOnly = true;
            outputNumBox.ReadOnly = true;

            inputNumBox.BackColor = Color.White;
            outputNumBox.BackColor = Color.White;
        }

        private void inputNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        // 내부 수식을 화면용으로 변환
        private string ToDisplayExpression(string expr)
        {
            return expr.Replace("*", "X").Replace("/", "÷");
        }

        // 화면 갱신
        private void UpdateExpressionDisplay()
        {
            inputNumBox.Text = ToDisplayExpression(currentExpression);
        }

        // 숫자/기호 추가
        private void AppendToExpression(string value)
        {
            currentExpression += value;
            UpdateExpressionDisplay();
        }

        // 수식 계산
        private void EvaluateExpression()
        {
            if (string.IsNullOrWhiteSpace(currentExpression))
                return;

            try
            {
                DataTable dt = new DataTable();
                object result = dt.Compute(currentExpression, "");

                outputNumBox.Text = result.ToString();
                inputNumBox.Text = ToDisplayExpression(currentExpression) + " = " + result.ToString();

                lstHistory.Items.Add(inputNumBox.Text);

                currentExpression = result.ToString();
            }
            catch
            {
                MessageBox.Show("올바른 수식을 입력하세요.");
            }
        }

        // 현재 입력 중인 마지막 숫자의 부호 변경
        private void ToggleSign()
        {
            if (string.IsNullOrWhiteSpace(currentExpression))
                return;

            Match match = Regex.Match(currentExpression, @"(\(?-?\d+\)?)$");

            if (!match.Success)
                return;

            string lastPart = match.Value;
            string before = currentExpression.Substring(0, currentExpression.Length - lastPart.Length);

            if (lastPart.StartsWith("(-") && lastPart.EndsWith(")"))
            {
                // (-5) -> 5
                string numberOnly = lastPart.Substring(2, lastPart.Length - 3);
                currentExpression = before + numberOnly;
            }
            else if (lastPart.StartsWith("-"))
            {
                // -5 -> 5
                currentExpression = before + lastPart.Substring(1);
            }
            else
            {
                // 5 -> (-5)
                currentExpression = before + "(-" + lastPart + ")";
            }

            UpdateExpressionDisplay();
        }

        // 숫자 버튼
        private void btnNum1_Click(object sender, EventArgs e)
        {
            AppendToExpression("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            AppendToExpression("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            AppendToExpression("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            AppendToExpression("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            AppendToExpression("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            AppendToExpression("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            AppendToExpression("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            AppendToExpression("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            AppendToExpression("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            AppendToExpression("0");
        }

        // CE : 결과창만 지우기
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            outputNumBox.Text = "";
        }

        // C : 전체 초기화
        private void Clear_Click(object sender, EventArgs e)
        {
            currentExpression = "";
            inputNumBox.Text = "";
            outputNumBox.Text = "";
        }

        // Del : 마지막 한 글자 삭제
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentExpression.Length > 0)
            {
                currentExpression = currentExpression.Substring(0, currentExpression.Length - 1);
                UpdateExpressionDisplay();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            AppendToExpression("/");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AppendToExpression("*");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            AppendToExpression("-");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            AppendToExpression("+");
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            ToggleSign();
        }

        // 소수점 안 쓸 거라 비워둠
        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            EvaluateExpression();
        }

        // 괄호 버튼이 있으면 연결
        private void btnOpenBracket_Click(object sender, EventArgs e)
        {
            AppendToExpression("(");
        }

        private void btnCloseBracket_Click(object sender, EventArgs e)
        {
            AppendToExpression(")");
        }

        // 히스토리 초기화 버튼
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();

        }
        private void btnHistoryReset_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }
        // 키보드 입력 처리
        private void CalculatorVersion1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (char.IsDigit(key))
            {
                AppendToExpression(key.ToString());
                e.Handled = true;
            }
            else if (key == '+')
            {
                btnPlus_Click(null, null);
                e.Handled = true;
            }
            else if (key == '-')
            {
                btnSubtract_Click(null, null);
                e.Handled = true;
            }
            else if (key == '*')
            {
                btnMultiply_Click(null, null);
                e.Handled = true;
            }
            else if (key == '/')
            {
                btnDivide_Click(null, null);
                e.Handled = true;
            }
            else if (key == '(')
            {
                AppendToExpression("(");
                e.Handled = true;
            }
            else if (key == ')')
            {
                AppendToExpression(")");
                e.Handled = true;
            }
            else if (key == (char)Keys.Enter)
            {
                EvaluateExpression();
                e.Handled = true;
            }
            else if (key == (char)Keys.Back)
            {
                btnDel_Click(null, null);
                e.Handled = true;
            }
        }
    }
}