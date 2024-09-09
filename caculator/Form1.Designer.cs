
namespace caculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Reciprocal = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.Divided = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.Negate = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ClearEnter = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.TextBox();
            this.calBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemDelete = new System.Windows.Forms.Button();
            this.SelectItemMinus = new System.Windows.Forms.Button();
            this.SelectItemPlus = new System.Windows.Forms.Button();
            this.ListClear = new System.Windows.Forms.Button();
            this.MemoryList = new System.Windows.Forms.ListBox();
            this.RecordList = new System.Windows.Forms.ListBox();
            this.Memory = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.MemoryRead = new System.Windows.Forms.Button();
            this.MemoryPlus = new System.Windows.Forms.Button();
            this.MemoryMinus = new System.Windows.Forms.Button();
            this.MemorySave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reciprocal
            // 
            this.Reciprocal.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reciprocal.Location = new System.Drawing.Point(12, 189);
            this.Reciprocal.Name = "Reciprocal";
            this.Reciprocal.Size = new System.Drawing.Size(85, 47);
            this.Reciprocal.TabIndex = 0;
            this.Reciprocal.Tag = "";
            this.Reciprocal.Text = "1/x";
            this.Reciprocal.UseVisualStyleBackColor = true;
            this.Reciprocal.Click += new System.EventHandler(this.Reciprocal_Click);
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Square.Location = new System.Drawing.Point(103, 189);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(85, 47);
            this.Square.TabIndex = 1;
            this.Square.Tag = "";
            this.Square.Text = "x²";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Root
            // 
            this.Root.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Root.Location = new System.Drawing.Point(194, 189);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(85, 47);
            this.Root.TabIndex = 2;
            this.Root.Tag = "";
            this.Root.Text = "√x";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.Root_Click);
            // 
            // Divided
            // 
            this.Divided.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Divided.Location = new System.Drawing.Point(285, 189);
            this.Divided.Name = "Divided";
            this.Divided.Size = new System.Drawing.Size(85, 47);
            this.Divided.TabIndex = 3;
            this.Divided.Tag = "3";
            this.Divided.Text = "÷";
            this.Divided.UseVisualStyleBackColor = true;
            this.Divided.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Multiply.Location = new System.Drawing.Point(285, 237);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(85, 47);
            this.Multiply.TabIndex = 7;
            this.Multiply.Tag = "2";
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Number9
            // 
            this.Number9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number9.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number9.Location = new System.Drawing.Point(194, 237);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(85, 47);
            this.Number9.TabIndex = 6;
            this.Number9.Tag = "";
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = false;
            this.Number9.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Number8
            // 
            this.Number8.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number8.Location = new System.Drawing.Point(103, 237);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(85, 47);
            this.Number8.TabIndex = 5;
            this.Number8.Tag = "";
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Number7
            // 
            this.Number7.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number7.Location = new System.Drawing.Point(12, 237);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(85, 47);
            this.Number7.TabIndex = 4;
            this.Number7.Tag = "";
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minus.Location = new System.Drawing.Point(285, 285);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(85, 47);
            this.Minus.TabIndex = 11;
            this.Minus.Tag = "1";
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Number6
            // 
            this.Number6.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number6.Location = new System.Drawing.Point(194, 285);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(85, 47);
            this.Number6.TabIndex = 10;
            this.Number6.Tag = "";
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Number5
            // 
            this.Number5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number5.Location = new System.Drawing.Point(103, 285);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(85, 47);
            this.Number5.TabIndex = 9;
            this.Number5.Tag = "";
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Number4
            // 
            this.Number4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number4.Location = new System.Drawing.Point(12, 285);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(85, 47);
            this.Number4.TabIndex = 8;
            this.Number4.Tag = "";
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Plus.Location = new System.Drawing.Point(285, 333);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(85, 47);
            this.Plus.TabIndex = 15;
            this.Plus.Tag = "0";
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Number3
            // 
            this.Number3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number3.Location = new System.Drawing.Point(194, 333);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(85, 47);
            this.Number3.TabIndex = 14;
            this.Number3.Tag = "";
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Number2
            // 
            this.Number2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number2.Location = new System.Drawing.Point(103, 333);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(85, 47);
            this.Number2.TabIndex = 13;
            this.Number2.Tag = "";
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Number1
            // 
            this.Number1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number1.Location = new System.Drawing.Point(12, 333);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(85, 47);
            this.Number1.TabIndex = 12;
            this.Number1.Tag = "";
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Equal.Location = new System.Drawing.Point(285, 381);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(85, 47);
            this.Equal.TabIndex = 19;
            this.Equal.Tag = "";
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dot.Location = new System.Drawing.Point(194, 381);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(85, 47);
            this.Dot.TabIndex = 18;
            this.Dot.Tag = "";
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Number0
            // 
            this.Number0.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number0.Location = new System.Drawing.Point(103, 381);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(85, 47);
            this.Number0.TabIndex = 17;
            this.Number0.Tag = "";
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // Negate
            // 
            this.Negate.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Negate.Location = new System.Drawing.Point(12, 381);
            this.Negate.Name = "Negate";
            this.Negate.Size = new System.Drawing.Size(85, 47);
            this.Negate.TabIndex = 16;
            this.Negate.Tag = "";
            this.Negate.Text = "+/-";
            this.Negate.UseVisualStyleBackColor = true;
            this.Negate.Click += new System.EventHandler(this.Negate_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete.Location = new System.Drawing.Point(285, 141);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(85, 47);
            this.Delete.TabIndex = 23;
            this.Delete.Tag = "";
            this.Delete.Text = "⌫";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Clear.Location = new System.Drawing.Point(194, 141);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(85, 47);
            this.Clear.TabIndex = 22;
            this.Clear.Tag = "";
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ClearEnter
            // 
            this.ClearEnter.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearEnter.Location = new System.Drawing.Point(103, 141);
            this.ClearEnter.Name = "ClearEnter";
            this.ClearEnter.Size = new System.Drawing.Size(85, 47);
            this.ClearEnter.TabIndex = 21;
            this.ClearEnter.Tag = "";
            this.ClearEnter.Text = "CE";
            this.ClearEnter.UseVisualStyleBackColor = true;
            this.ClearEnter.Click += new System.EventHandler(this.ClearEnter_Click);
            // 
            // Percentage
            // 
            this.Percentage.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Percentage.Location = new System.Drawing.Point(12, 141);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(85, 47);
            this.Percentage.TabIndex = 20;
            this.Percentage.Tag = "";
            this.Percentage.Text = "%";
            this.Percentage.UseVisualStyleBackColor = true;
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.Color.LightGray;
            this.InputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputText.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputText.Location = new System.Drawing.Point(12, 48);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.ReadOnly = true;
            this.InputText.Size = new System.Drawing.Size(358, 53);
            this.InputText.TabIndex = 24;
            this.InputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calBox
            // 
            this.calBox.BackColor = System.Drawing.Color.LightGray;
            this.calBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calBox.Font = new System.Drawing.Font("굴림", 11F);
            this.calBox.Location = new System.Drawing.Point(12, 12);
            this.calBox.Multiline = true;
            this.calBox.Name = "calBox";
            this.calBox.ReadOnly = true;
            this.calBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.calBox.Size = new System.Drawing.Size(358, 28);
            this.calBox.TabIndex = 25;
            this.calBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calBox.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ItemDelete);
            this.panel1.Controls.Add(this.SelectItemMinus);
            this.panel1.Controls.Add(this.SelectItemPlus);
            this.panel1.Controls.Add(this.ListClear);
            this.panel1.Controls.Add(this.MemoryList);
            this.panel1.Controls.Add(this.RecordList);
            this.panel1.Controls.Add(this.Memory);
            this.panel1.Controls.Add(this.Record);
            this.panel1.Location = new System.Drawing.Point(376, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 416);
            this.panel1.TabIndex = 26;
            // 
            // ItemDelete
            // 
            this.ItemDelete.FlatAppearance.BorderSize = 0;
            this.ItemDelete.Location = new System.Drawing.Point(176, 393);
            this.ItemDelete.Name = "ItemDelete";
            this.ItemDelete.Size = new System.Drawing.Size(54, 23);
            this.ItemDelete.TabIndex = 7;
            this.ItemDelete.Text = "삭제";
            this.ItemDelete.UseVisualStyleBackColor = true;
            this.ItemDelete.Click += new System.EventHandler(this.ItemDelete_Click);
            // 
            // SelectItemMinus
            // 
            this.SelectItemMinus.FlatAppearance.BorderSize = 0;
            this.SelectItemMinus.Location = new System.Drawing.Point(119, 393);
            this.SelectItemMinus.Name = "SelectItemMinus";
            this.SelectItemMinus.Size = new System.Drawing.Size(54, 23);
            this.SelectItemMinus.TabIndex = 6;
            this.SelectItemMinus.Text = "M-";
            this.SelectItemMinus.UseVisualStyleBackColor = true;
            // 
            // SelectItemPlus
            // 
            this.SelectItemPlus.FlatAppearance.BorderSize = 0;
            this.SelectItemPlus.Location = new System.Drawing.Point(62, 393);
            this.SelectItemPlus.Name = "SelectItemPlus";
            this.SelectItemPlus.Size = new System.Drawing.Size(54, 23);
            this.SelectItemPlus.TabIndex = 5;
            this.SelectItemPlus.Text = "M+";
            this.SelectItemPlus.UseVisualStyleBackColor = true;
            // 
            // ListClear
            // 
            this.ListClear.FlatAppearance.BorderSize = 0;
            this.ListClear.Location = new System.Drawing.Point(162, 16);
            this.ListClear.Name = "ListClear";
            this.ListClear.Size = new System.Drawing.Size(65, 23);
            this.ListClear.TabIndex = 4;
            this.ListClear.Text = "전체 삭제";
            this.ListClear.UseVisualStyleBackColor = true;
            this.ListClear.Click += new System.EventHandler(this.ListClear_Click);
            // 
            // MemoryList
            // 
            this.MemoryList.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemoryList.FormattingEnabled = true;
            this.MemoryList.ItemHeight = 19;
            this.MemoryList.Items.AddRange(new object[] {
            "text1",
            "text2",
            "1 * 2 = 3"});
            this.MemoryList.Location = new System.Drawing.Point(3, 44);
            this.MemoryList.Name = "MemoryList";
            this.MemoryList.Size = new System.Drawing.Size(224, 346);
            this.MemoryList.TabIndex = 3;
            this.MemoryList.SelectedIndexChanged += new System.EventHandler(this.MemoryList_SelectedIndexChanged);
            // 
            // RecordList
            // 
            this.RecordList.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecordList.FormattingEnabled = true;
            this.RecordList.ItemHeight = 19;
            this.RecordList.Items.AddRange(new object[] {
            "text1",
            "text2",
            "1 * 2 = 3"});
            this.RecordList.Location = new System.Drawing.Point(3, 44);
            this.RecordList.Name = "RecordList";
            this.RecordList.Size = new System.Drawing.Size(224, 346);
            this.RecordList.TabIndex = 2;
            this.RecordList.SelectedIndexChanged += new System.EventHandler(this.MemoryList_SelectedIndexChanged);
            // 
            // Memory
            // 
            this.Memory.FlatAppearance.BorderSize = 0;
            this.Memory.Location = new System.Drawing.Point(68, 16);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(65, 23);
            this.Memory.TabIndex = 1;
            this.Memory.Text = "메모리";
            this.Memory.UseVisualStyleBackColor = true;
            this.Memory.Click += new System.EventHandler(this.Memory_Click);
            // 
            // Record
            // 
            this.Record.FlatAppearance.BorderSize = 0;
            this.Record.Location = new System.Drawing.Point(3, 16);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(65, 23);
            this.Record.TabIndex = 0;
            this.Record.Text = "기록";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // MemoryClear
            // 
            this.MemoryClear.Location = new System.Drawing.Point(12, 107);
            this.MemoryClear.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(64, 32);
            this.MemoryClear.TabIndex = 3;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = true;
            this.MemoryClear.Click += new System.EventHandler(this.MemoryClear_Click);
            // 
            // MemoryRead
            // 
            this.MemoryRead.Location = new System.Drawing.Point(85, 107);
            this.MemoryRead.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryRead.Name = "MemoryRead";
            this.MemoryRead.Size = new System.Drawing.Size(64, 32);
            this.MemoryRead.TabIndex = 29;
            this.MemoryRead.Text = "MR";
            this.MemoryRead.UseVisualStyleBackColor = true;
            this.MemoryRead.Click += new System.EventHandler(this.MemoryRead_Click);
            // 
            // MemoryPlus
            // 
            this.MemoryPlus.Location = new System.Drawing.Point(161, 107);
            this.MemoryPlus.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryPlus.Name = "MemoryPlus";
            this.MemoryPlus.Size = new System.Drawing.Size(64, 32);
            this.MemoryPlus.TabIndex = 30;
            this.MemoryPlus.Text = "M+";
            this.MemoryPlus.UseVisualStyleBackColor = true;
            this.MemoryPlus.Click += new System.EventHandler(this.MemoryPlus_Click);
            // 
            // MemoryMinus
            // 
            this.MemoryMinus.Location = new System.Drawing.Point(234, 107);
            this.MemoryMinus.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryMinus.Name = "MemoryMinus";
            this.MemoryMinus.Size = new System.Drawing.Size(64, 32);
            this.MemoryMinus.TabIndex = 31;
            this.MemoryMinus.Text = "M-";
            this.MemoryMinus.UseVisualStyleBackColor = true;
            this.MemoryMinus.Click += new System.EventHandler(this.MemoryMinus_Click);
            // 
            // MemorySave
            // 
            this.MemorySave.Location = new System.Drawing.Point(306, 107);
            this.MemorySave.Margin = new System.Windows.Forms.Padding(0);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(64, 32);
            this.MemorySave.TabIndex = 32;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = true;
            this.MemorySave.Click += new System.EventHandler(this.MemorySave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(618, 447);
            this.Controls.Add(this.MemorySave);
            this.Controls.Add(this.MemoryMinus);
            this.Controls.Add(this.MemoryPlus);
            this.Controls.Add(this.MemoryRead);
            this.Controls.Add(this.MemoryClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calBox);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearEnter);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.Negate);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Divided);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Reciprocal);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "계산기";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reciprocal;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Divided;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button Negate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ClearEnter;
        private System.Windows.Forms.Button Percentage;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox calBox;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Memory;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.ListBox RecordList;
        private System.Windows.Forms.Button MemoryClear;
        private System.Windows.Forms.Button MemoryRead;
        private System.Windows.Forms.Button MemoryPlus;
        private System.Windows.Forms.Button MemoryMinus;
        private System.Windows.Forms.Button MemorySave;
        private System.Windows.Forms.ListBox MemoryList;
        private System.Windows.Forms.Button ListClear;
        private System.Windows.Forms.Button ItemDelete;
        private System.Windows.Forms.Button SelectItemMinus;
        private System.Windows.Forms.Button SelectItemPlus;
    }
}

