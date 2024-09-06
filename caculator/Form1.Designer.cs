
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 47);
            this.button1.TabIndex = 0;
            this.button1.Tag = "";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(103, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 47);
            this.button2.TabIndex = 1;
            this.button2.Tag = "";
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(194, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 47);
            this.button3.TabIndex = 2;
            this.button3.Tag = "";
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Divided
            // 
            this.Divided.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Multiply.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Multiply.Location = new System.Drawing.Point(285, 237);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(85, 47);
            this.Multiply.TabIndex = 7;
            this.Multiply.Tag = "2";
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Number9
            // 
            this.Number9.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number9.Location = new System.Drawing.Point(194, 237);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(85, 47);
            this.Number9.TabIndex = 6;
            this.Number9.Tag = "";
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
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
            this.Minus.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Plus.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Equal.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Negate.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Clear.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.ClearEnter.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Percentage.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.calBox.Font = new System.Drawing.Font("굴림", 15F);
            this.calBox.Location = new System.Drawing.Point(12, 25);
            this.calBox.Name = "calBox";
            this.calBox.ReadOnly = true;
            this.calBox.Size = new System.Drawing.Size(358, 23);
            this.calBox.TabIndex = 25;
            this.calBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(385, 447);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "계산기";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Divided;
        private System.Windows.Forms.Button Multiply;
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
    }
}

