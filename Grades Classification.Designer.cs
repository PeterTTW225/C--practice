namespace Grades_Classification
{
    partial class FiveNumbers
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(94, 310);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(112, 31);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "成績計算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(138, 37);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(148, 27);
            this.txtNum1.TabIndex = 1;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(50, 37);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(60, 16);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "成績一:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(138, 91);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(148, 27);
            this.txtNum2.TabIndex = 3;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(138, 145);
            this.txtNum3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(148, 27);
            this.txtNum3.TabIndex = 4;
            // 
            // txtNum4
            // 
            this.txtNum4.Location = new System.Drawing.Point(138, 199);
            this.txtNum4.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(148, 27);
            this.txtNum4.TabIndex = 5;
            // 
            // txtNum5
            // 
            this.txtNum5.Location = new System.Drawing.Point(138, 253);
            this.txtNum5.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(148, 27);
            this.txtNum5.TabIndex = 6;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(50, 93);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(60, 16);
            this.lblNum2.TabIndex = 7;
            this.lblNum2.Text = "成績二:";
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Location = new System.Drawing.Point(50, 149);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(60, 16);
            this.lblNum3.TabIndex = 8;
            this.lblNum3.Text = "成績三:";
            // 
            // lblNum4
            // 
            this.lblNum4.AutoSize = true;
            this.lblNum4.Location = new System.Drawing.Point(50, 205);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(60, 16);
            this.lblNum4.TabIndex = 9;
            this.lblNum4.Text = "成績四:";
            // 
            // lblNum5
            // 
            this.lblNum5.AutoSize = true;
            this.lblNum5.Location = new System.Drawing.Point(50, 261);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(60, 16);
            this.lblNum5.TabIndex = 10;
            this.lblNum5.Text = "成績五:";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Aqua;
            this.txtOutput.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold);
            this.txtOutput.Location = new System.Drawing.Point(315, 37);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(256, 304);
            this.txtOutput.TabIndex = 11;
            this.txtOutput.WordWrap = false;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // FiveNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 375);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblNum5);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnCompute);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FiveNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五個成績";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

