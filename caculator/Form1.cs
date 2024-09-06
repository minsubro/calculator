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

        public bool reset;
        public bool input;

        public double lValue;
        public double rValue;
        public double result;
        public Operator op;

        public string lValueStr;
        public string rValueStr;
        public string operatorStr;
        public string resultStr;

        public bool isLeft;
        public bool netage;
        public bool option;
        

        public Form1()
        {
            InitializeComponent();

            value = new Value();
            Reset();
        }

        public void NumberInput(string num)
        {
            if (reset)
                Reset();
            if (!input)
                value.Clear();
            if (option)
            {
                value.Clear();
                option = false;
            }
            if ((value.Length > 9 && !value.dot) || (value.Length > 10 && value.dot))
                return;
            value.String += num;
            value.RemoveLeadingZeros();
            input = true;
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
            if (option)
                UpdateCalculateBox();
            UpdateInputText(value.String);
        }

        public void OperatorInput(Operator n)
        {
            try
            {
                if (isLeft && input)
                {
                    rValue = lValue;
                    rValueStr = rValue.ToString();
                    isLeft = false;
                }
                else if (input)
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
                input = false;
                reset = false;
                option = false;
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
            if (reset)
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
                if (option)
                {
                    option = false;
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
            if (reset)
                Reset();
            else if (input)
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
                input = false;
                reset = true;
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
            if (reset)
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
            option = true;
            value.Negate();
            UpdateCalculateBox();
            UpdateInputText(value.String);
        }
    }
}