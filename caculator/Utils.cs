using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace caculator
{
    public partial class Form1 : Form
    {
        public void Error(string message)
        {
            ButtonOnOff(OnOff.OFF);
            isReset = true;
            isError = true;
            UpdateInputText(message);
        }

        public void UpdateCalculateBox()
        {
            if (isReset && op == Operator.END)
                calBox.Text = String.Format("{0} {1}", Double.Parse(value.String).ToString(), '=');
            else if (op == Operator.END)
                calBox.Text = string.Format("{0}", lValueStr);
            else if (isOption && !isLeft)
                calBox.Text = string.Format("{0} {1} {2}", lValueStr, operatorStr, rValueStr);
            else if (!isLeft)
                calBox.Text = string.Format("{0} {1}", lValueStr, operatorStr);
        }

        public void UpdateInputText(string text)
        {
            if (isError)
                InputText.Text = text;
            else
                InputText.Text = FormatWithCommas(text);
            CustomFontSize();
        }

        public string GetSimbol(Operator code)
        {
            const string simbol = "+-*/";
            return simbol[((int)code)].ToString();
        }

        public void Reset()
        {
            lValue = 0;
            rValue = 0;
            lValueStr = "0";
            rValueStr = "0";
            operatorStr = "";
            op = Operator.END;
            selectIndex = -1;

            isReset = false;
            isInput = true;
            isLeft = true;
            isOption = false;
            isError = false;
            
            value.Clear();
            calBox.Text = "";
            InputText.Text = "";
            UpdateInputText("0");
            ButtonOnOff(OnOff.ON);
        }

        public void CustomFontSize()
        {
            Graphics g = InputText.CreateGraphics();
            SizeF textSize = g.MeasureString(InputText.Text, InputText.Font);
            float scale = Math.Min(InputText.Width / textSize.Width, InputText.Height / textSize.Height);
            float fontSize = InputText.Font.Size * scale;
            InputText.Font = new Font(InputText.Font.FontFamily, fontSize, InputText.Font.Style);
        }

        public void ButtonOnOff(bool state)
        {
            Plus.Enabled        = state;
            Minus.Enabled       = state;
            Divided.Enabled     = state;
            Multiply.Enabled    = state;
            Dot.Enabled         = state;
            Percentage.Enabled  = state;
            Reciprocal.Enabled  = state;
            Square.Enabled      = state;
            Root.Enabled        = state;
            Negate.Enabled      = state;
            MemoryPlus.Enabled  = state;
            MemoryMinus.Enabled = state;
            MemorySave.Enabled  = state;
            SelectItemMinus.Enabled = state;
            SelectItemPlus.Enabled = state;

            if (state == OnOff.ON && MemoryList.Items.Count > 0)
            {
                MemoryClear.Enabled = state;
                MemoryRead.Enabled = state;
            }
            else
            {
                MemoryClear.Enabled = OnOff.OFF;
                MemoryRead.Enabled = OnOff.OFF;
            }
                
        }

        //키보드 이벤트
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue.ToString());
            if (e.KeyValue > 95 && 106 > e.KeyValue) // 키패드 숫자키
                NumberInput((e.KeyValue - 96).ToString());
            else if (e.KeyValue > 47 && 58 > e.KeyValue) // 숫자키
                NumberInput((e.KeyValue - 48).ToString());
            else if (e.KeyValue == ((int)KeyCode.NUMPADPLUS) || e.KeyValue == ((int)KeyCode.OEMPLUS)) // 더하기
                OperatorInput(Operator.PLUS);
            else if (e.KeyValue == ((int)KeyCode.NUMPADMINUS) || e.KeyValue == ((int)KeyCode.OEMMINUS)) // 빼기
                OperatorInput(Operator.MINUS);
            else if (e.KeyValue == ((int)KeyCode.NUMPADMUL)) // 곱하기
                OperatorInput(Operator.MUL);
            else if (e.KeyValue == ((int)KeyCode.NUMPADDIV) || e.KeyValue == ((int)KeyCode.OEMDIV)) // 나누기
                OperatorInput(Operator.DIV);
            else if (e.KeyValue == ((int)KeyCode.NUMPADDOT) || e.KeyValue == ((int)KeyCode.OEMDOT)) // .
                Dot_Click(null, null);
            else if (e.KeyValue == ((int)KeyCode.BACK))
                Delete_Click(null, null);
            else if (e.KeyValue == ((int)KeyCode.ESC))
                Clear_Click(null, null);

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Equal_Click(null, null);
                return true; // 기본 처리 방지
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public string FormatWithCommas(string s)
        {
            int pos = s.IndexOf('.');
            string integerPart = pos == -1 ? s : s.Substring(0, pos);
            string decimalPart = pos == -1 ? "" : s.Substring(pos);
            string tmp = "";
            integerPart = new string(integerPart.Reverse().ToArray());
            for (int i = 0; i < integerPart.Length; i++)
            {
                if (i > 0 && i % 3 == 0)
                    tmp += ',';
                tmp += integerPart[i];
            }
            tmp = new string(tmp.Reverse().ToArray());
            return tmp + decimalPart;
        }

        public Operator getOperator(string simbol)
        {
            if (simbol == "+")
                return Operator.PLUS;
            else if (simbol == "-")
                return Operator.MINUS;
            else if (simbol == "*")
                return Operator.MUL;
            else
                return Operator.DIV;
        }
    }
}

