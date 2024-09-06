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
            UpdateInputText(message);
            reset = true;
            ButtonOnOff(ButtonState.OFF);
        }

        public void UpdateCalculateBox()
        {
            if (reset && op == Operator.END)
                calBox.Text = String.Format("{0} {1}", Double.Parse(value.String).ToString(), '=');
            else if (op == Operator.END)
                calBox.Text = string.Format("{0}", lValueStr);
            else if (option && !isLeft)
                calBox.Text = string.Format("{0} {1} {2}", lValueStr, operatorStr, rValueStr);
            else if (!isLeft)
                calBox.Text = string.Format("{0} {1}", lValueStr, operatorStr);

            //if (operatorStr == "")
            //    calBox.Text = string.Format("{0}", lValueStr);
            //else if (isLeft)
            //    calBox.Text = string.Format("{0} {1}", lValueStr, operatorStr);
            //else
            //    calBox.Text = string.Format("{0} {1} {2}", lValueStr, operatorStr, rValueStr);
        }
        public void UpdateInputText(string text)
        {
            InputText.Text = text;
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
            lValueStr = "";
            rValueStr = "";
            operatorStr = "";
            op = Operator.END;

            reset = false;
            input = true;
            isLeft = true;
            option = false;

            value.Clear();
            calBox.Text = "";
            InputText.Text = "";
            UpdateInputText("0");
            ButtonOnOff(ButtonState.ON);
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

            Plus.Enabled = state;
            Minus.Enabled = state;
            Divided.Enabled = state;
            Multiply.Enabled = state;
            Dot.Enabled = state;
            Percentage.Enabled = state;
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



    }

}

