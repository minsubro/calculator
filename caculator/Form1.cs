using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace caculator
{
    public partial class Form1 : Form
    {
        public Value value;

        public double lValue;
        public double rValue;
        public double result;
        public Operator op;

        public string lValueStr;
        public string rValueStr;
        public string operatorStr;
        public string resultStr;

        public bool isLeft;
        public bool isOption;
        public bool isError;
        public bool isReset;
        public bool isInput;


        public Form1()
        {
            InitializeComponent();

            value = new Value();
            Reset();
        }

        public void NumberInput(string num)
        {
            if (isReset)
                Reset();
            if (!isInput)
                value.Clear();
            if (isOption)
            {
                value.Clear();
                isOption = false;
            }
            if ((value.Length > 9 && !value.dot) || (value.Length > 10 && value.dot))
                return;
            value.String += num;
            value.RemoveLeadingZeros();
            isInput = true;
            if (isLeft)
            {
                lValueStr = value.String;
                lValue = double.Parse(lValueStr);
            }
            else
            {
                rValueStr = value.String;
                rValue = double.Parse(rValueStr);
            }
            if (isOption)
                UpdateCalculateBox();
            UpdateInputText(value.String);
        }

        public void OperatorInput(Operator n)
        {
            try
            {
                if (isLeft && isInput)
                {
                    rValue = lValue;
                    rValueStr = rValue.ToString();
                    isLeft = false;
                }
                else if (isInput)
                {
                    result = Calculator.Calculate(rValue, lValue, op);
                    resultStr = result.ToString();
                    lValue = result;
                    lValueStr = lValue.ToString();
                    rValueStr = "";
                    value.String = resultStr;
                    UpdateInputText(value.String);
                }
                
                op = n;
                operatorStr = GetSimbol(n);
                isInput = false;
                isReset = false;
                isOption = false;
                UpdateCalculateBox();
            }
            catch (Exception e)
            {
                Error(e.Message);
            }
        }
       
        private void Numpad_Click(object sender, EventArgs a)
        {
            NumberInput(((Button)sender).Text);
        }

        private void Operator_Click(object sender, EventArgs s)
        {
            OperatorInput((Operator)int.Parse(((Button)sender).Tag.ToString()));
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!value.dot)
            {
                value.String += '.';
                value.dot = true;
                UpdateInputText(value.String);
            }
        }

        private void ClearEnter_Click(object sender, EventArgs e)
        {
            if (isReset)
                Reset();
            else
            {
                value.Clear();
                if (isLeft)
                {
                    lValueStr = "";
                    lValue = 0;
                }
                else
                {
                    rValueStr = "";
                    rValue = 0;
                }
                if (isOption)
                {
                    isOption = false;
                    UpdateCalculateBox();
                }
            }
            UpdateInputText(value.String);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (isReset)
                Reset();
            else if (isInput)
            {
                value.Del();
                if (isLeft)
                {
                    lValueStr = value.String;
                    lValue = double.Parse(lValueStr);
                }
                else
                {
                    rValueStr = value.String;
                    rValue = double.Parse(rValueStr);
                }
                UpdateInputText(value.String);
            }
        }

        private void Equal_Click(object sender, EventArgs s)
        {
            try
            {
                isInput = false;
                isReset = true;
                if (op == Operator.END)
                {
                    operatorStr = "=";
                    UpdateCalculateBox();
                }
                else
                {
                    calBox.Text = string.Format("{0} {1} {2} =", lValueStr, operatorStr, rValueStr);
                    lValue = Calculator.Calculate(lValue, value.Double, op);
                    lValueStr = resultStr = lValue.ToString();
                    InputText.Text = resultStr;
                    UpdateInputText(resultStr);
                }
                
            }
            catch(Exception e)
            {
                Error(e.Message);
            }
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            if (isReset)
            {
                string tmp = resultStr;
                Reset();
                lValueStr = value.String = tmp;
                lValue = Double.Parse(lValueStr);

            }
            if (isLeft)
                lValueStr = string.Format("negate({0})", lValueStr);
            else
                rValueStr = string.Format("negate({0})", rValueStr);
            isOption = true;
            value.Negate();
            UpdateCalculateBox();
            UpdateInputText(value.String);
        }

        private void Reciprocal_Click(object sender, EventArgs e)
        {
            if (isReset)
            {
                string tmp = resultStr;
                Reset();
                lValueStr = value.String = tmp;
                lValue = Double.Parse(lValueStr);
            }
            if (isLeft)
                lValueStr = string.Format("1/({0})", lValueStr);
            else
                rValueStr = string.Format("1/({0})", rValueStr);

            if (value.Double == 0)
                Error("0으로 나눌 수 없습니다.");
            else
            {
                isOption = true;
                value.String = Calculator.Reciprocal(double.Parse(value.String)).ToString();
                UpdateCalculateBox();
                UpdateInputText(value.String);
            }
            
        }

        private void Square_Click(object sender, EventArgs e)
        {
            if (isReset)
            {
                string tmp = resultStr;
                Reset();
                lValueStr = value.String = tmp;
                lValue = Double.Parse(lValueStr);
            }
            if (isLeft)
                lValueStr = string.Format("sqr({0})", lValueStr);
            else
                rValueStr = string.Format("sqr({0})", rValueStr);
            try
            {
                isOption = true;
                value.String = Calculator.Pow(double.Parse(value.String)).ToString();
                UpdateCalculateBox();
                UpdateInputText(value.String);
            }
            catch (Exception a)
            {
                Error(a.Message);
            }
        }

        private void Root_Click(object sender, EventArgs e)
        {
            if (isReset)
            {
                string tmp = resultStr;
                Reset();
                lValueStr = value.String = tmp;
                lValue = Double.Parse(lValueStr);
            }
            if (isLeft)
                lValueStr = string.Format("√({0})", lValueStr);
            else
                rValueStr = string.Format("√({0})", rValueStr);
            try
            {
                isOption = true;
                value.String = Calculator.Square(double.Parse(value.String)).ToString();
                UpdateCalculateBox();
                UpdateInputText(value.String);
            }
            catch (Exception a)
            {
                Error(a.Message);
            }
        }
    }
}