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


        public Operator op;
        public string operatorStr;

        int selectIndex;
        

        // 리펙시 Value 클래스 수정해서 클래스로 정리
        public string lValueStr;
        public double lValue;
        public string rValueStr;
        public double rValue;
        public string resultStr;
        public double result;


        // bit flag로 정리
        public bool isLeft;
        public bool isOption;
        public bool isError;
        public bool isReset;
        public bool isInput;
        public ShowList showList;


        public Form1()
        {
            InitializeComponent();

            value = new Value();
            Reset();
            MemoryClear.Enabled = OnOff.OFF;
            MemoryRead.Enabled = OnOff.OFF;
            MemoryList.Visible = OnOff.OFF;
            Record.Enabled = OnOff.OFF;
            SelectItemPlus.Visible = OnOff.OFF;
            SelectItemMinus.Visible = OnOff.OFF;
            MemoryList.Items.Clear();
            RecordList.Items.Clear();
            showList = ShowList.RECORD;
            
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
                if (isLeft)
                    lValueStr = "";
                else
                    rValueStr = "";
                UpdateCalculateBox();
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
                    RecordList.Items.Insert(0, String.Format("{0} {1} {2} = {3}", lValueStr, operatorStr, rValueStr, resultStr));
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
            if (isError)
                return;
            OperatorInput((Operator)int.Parse(((Button)sender).Tag.ToString()));
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (isReset)
                Reset();
            if (isError)
                return;
            if (!value.dot)
            {
                value.String += '.';
                value.dot = true;
                UpdateInputText(value.String);
            }
        }

        private void Equal_Click(object sender, EventArgs s)
        {
            if (isError)
            {
                Reset();
                return;
            }
            try
            {
                isInput = false;
                isReset = true;
                if (op == Operator.END)
                {
                    operatorStr = "=";
                    RecordList.Items.Insert(0, String.Format("{0} =", lValueStr));
                    UpdateCalculateBox();
                }
                else
                {
                    calBox.Text = string.Format("{0} {1} {2} =", lValueStr, operatorStr, rValueStr);
                    result = Calculator.Calculate(lValue, rValue, op);
                    RecordList.Items.Insert(0, String.Format("{0} {1} {2} = {3}", lValueStr, operatorStr, rValueStr, result.ToString()));
                    lValue = result;
                    lValueStr = resultStr = result.ToString();
                    value.String = resultStr;
                    UpdateInputText(value.String);
                }
                
            }
            catch(Exception e)
            {
                Error(e.Message);
            }
        }

        #region 옵션버튼 이벤트
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
        private void Negate_Click(object sender, EventArgs e)
        {
            if (isError)
                return;
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
            if (isError)
                return;
            if (isReset)
            {
                string tmp = resultStr;
                Reset();
                lValueStr = value.String = tmp;
                lValue = Double.Parse(lValueStr);
            }

            try
            {
                isOption = true;
                value.String = Calculator.Reciprocal(double.Parse(value.String)).ToString();
                if (isLeft)
                {
                    lValueStr = string.Format("1/({0})", lValueStr);
                    lValue = double.Parse(value.String);
                }
                else
                {
                    rValueStr = string.Format("1/({0})", rValueStr);
                    rValue = double.Parse(value.String);
                }
                UpdateCalculateBox();
                UpdateInputText(value.String);
            }
            catch(Exception s)
            {
                Error(s.Message);
            }
        }
        private void Square_Click(object sender, EventArgs e)
        {
            if (isError)
                return;
            if (isReset)
            {
                string tmp = resultStr;
                Reset();
                lValueStr = value.String = tmp;
                lValue = Double.Parse(lValueStr);
            }

            try
            {
                isOption = true;
                value.String = Calculator.Pow(double.Parse(value.String)).ToString();
                if (isLeft)
                {
                    lValueStr = string.Format("sqr({0})", lValueStr);
                    lValue = double.Parse(value.String);
                }
                else
                {
                    rValueStr = string.Format("sqr({0})", rValueStr);
                    rValue = double.Parse(value.String);
                }
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
            if (isError)
                return;
            if (isReset)
            {
                string tmp = resultStr;
                Reset();
                lValueStr = value.String = tmp;
                lValue = Double.Parse(lValueStr);
            }
            try
            {
                isOption = true;
                value.String = Calculator.Square(double.Parse(value.String)).ToString();
                if (isLeft)
                {
                    lValueStr = string.Format("√({0})", lValueStr);
                    lValue = double.Parse(value.String);
                }
                else
                {
                    rValueStr = string.Format("√({0})", rValueStr);
                    rValue = double.Parse(value.String);
                }
                UpdateCalculateBox();
                UpdateInputText(value.String);
            }
            catch (Exception a)
            {
                Error(a.Message);
            }
        }
        #endregion

        #region 메모리 & 레코드 관련 버튼 이벤트
        private void Record_Click(object sender, EventArgs e)
        {
            showList = ShowList.RECORD;
            RecordList.Visible = true;
            Record.Enabled = false;
            MemoryList.Visible = false;
            Memory.Enabled = true;
            selectIndex = -1;
            SelectItemPlus.Visible = false;
            SelectItemMinus.Visible = false;
        }
        private void Memory_Click(object sender, EventArgs e)
        {
            showList = ShowList.MEMORY;
            RecordList.Visible = false;
            Record.Enabled = true;
            MemoryList.Visible = true;
            Memory.Enabled = false;
            selectIndex = -1;
            SelectItemPlus.Visible = true;
            SelectItemMinus.Visible = true;
        }
        private void MemorySave_Click(object sender, EventArgs e)
        {
            MemoryList.Items.Insert(0, value.Double);
            MemoryClear.Enabled = OnOff.ON;
            MemoryRead.Enabled = OnOff.ON;
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            MemoryList.Items.Clear();
            MemoryClear.Enabled = OnOff.OFF;
            MemoryRead.Enabled = OnOff.OFF;
        }

        private void MemoryRead_Click(object sender, EventArgs e)
        {
            if (isReset)
                Reset();
            if (isLeft)
            {
                value.String = MemoryList.Items[0].ToString();
                lValueStr = value.String;
                lValue = Double.Parse(lValueStr);
            }
            else
            {
                value.String = MemoryList.Items[0].ToString();
                lValueStr = value.String;
                lValue = Double.Parse(lValueStr);
            }
            isInput = false;
            isOption = false;
            UpdateInputText(value.String);

        }

        private void MemoryPlus_Click(object sender, EventArgs e)
        {
            if (MemoryList.Items.Count == 0)
            {
                MemoryList.Items.Add((0 + value.Double).ToString());
                MemoryClear.Enabled = OnOff.ON;
                MemoryRead.Enabled = OnOff.ON;
            }
            else
            {
                double tmp = Double.Parse((MemoryList.Items[0].ToString()));
                tmp += value.Double;
                MemoryList.Items[0] = tmp.ToString();
            }
        }

        private void MemoryMinus_Click(object sender, EventArgs e)
        {
            if (MemoryList.Items.Count == 0)
            {
                MemoryList.Items.Add((0 - value.Double).ToString());
                MemoryClear.Enabled = OnOff.ON;
                MemoryRead.Enabled = OnOff.ON;
            }
            else
            {
                double tmp = Double.Parse((MemoryList.Items[0].ToString()));
                tmp -= value.Double;
                MemoryList.Items[0] = tmp.ToString();
            }
        }

        #endregion


        private void ListClear_Click(object sender, EventArgs e)
        {
            if (showList == ShowList.RECORD)
                RecordList.Items.Clear();
            else
                MemoryClear_Click(null, null);
                
        }

        private void MemoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showList == ShowList.MEMORY)
                selectIndex = MemoryList.SelectedIndex;
            else
                selectIndex = RecordList.SelectedIndex;
        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            if (selectIndex == -1)
                return;
            if (showList == ShowList.MEMORY)
            {
                MemoryList.Items.RemoveAt(selectIndex);
                if (MemoryList.Items.Count == 0)
                {
                    MemoryClear.Enabled = OnOff.OFF;
                    MemoryRead.Enabled = OnOff.OFF;
                }
            }
            else
                RecordList.Items.RemoveAt(selectIndex);
            selectIndex = -1;
        }
    }
}