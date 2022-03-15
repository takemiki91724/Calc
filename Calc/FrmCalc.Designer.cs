namespace Calc
{
    partial class FrmCalc
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEq = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(338, 40);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn7.Location = new System.Drawing.Point(12, 79);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 80);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn8.Location = new System.Drawing.Point(98, 79);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 80);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn9.Location = new System.Drawing.Point(184, 79);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 80);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDiv.Location = new System.Drawing.Point(270, 79);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(80, 80);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnArithmetic_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn4.Location = new System.Drawing.Point(12, 165);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 80);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn5.Location = new System.Drawing.Point(98, 165);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 80);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn6.Location = new System.Drawing.Point(184, 165);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 80);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMult.Location = new System.Drawing.Point(270, 165);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(80, 80);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "×";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnArithmetic_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn1.Location = new System.Drawing.Point(12, 251);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 80);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn2.Location = new System.Drawing.Point(98, 251);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 80);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn3.Location = new System.Drawing.Point(184, 251);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 80);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSub.Location = new System.Drawing.Point(270, 251);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(80, 80);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnArithmetic_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn0.Location = new System.Drawing.Point(12, 337);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 80);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(98, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 80);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEq
            // 
            this.btnEq.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEq.Location = new System.Drawing.Point(184, 337);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(80, 80);
            this.btnEq.TabIndex = 1;
            this.btnEq.Text = "=";
            this.btnEq.UseVisualStyleBackColor = true;
            this.btnEq.Click += new System.EventHandler(this.btnEq_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.Location = new System.Drawing.Point(270, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnArithmetic_Click);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 434);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEq);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResult);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "電卓";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEq;
        private System.Windows.Forms.Button btnAdd;
    }
}

