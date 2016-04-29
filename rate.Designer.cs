namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblN5 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBxFail = new System.Windows.Forms.CheckBox();
            this.chkBx = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(505, 32);
            this.txtN5.Name = "txtN5";
            this.txtN5.Size = new System.Drawing.Size(45, 22);
            this.txtN5.TabIndex = 19;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(392, 32);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(45, 22);
            this.txtN4.TabIndex = 18;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(270, 32);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(45, 22);
            this.txtN3.TabIndex = 17;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(148, 32);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(45, 22);
            this.txtN2.TabIndex = 16;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(43, 32);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(45, 22);
            this.txtN1.TabIndex = 15;
            // 
            // lblN5
            // 
            this.lblN5.AutoSize = true;
            this.lblN5.Location = new System.Drawing.Point(467, 35);
            this.lblN5.Name = "lblN5";
            this.lblN5.Size = new System.Drawing.Size(32, 12);
            this.lblN5.TabIndex = 14;
            this.lblN5.Text = "智晟:";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Location = new System.Drawing.Point(354, 38);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(32, 12);
            this.lblN4.TabIndex = 13;
            this.lblN4.Text = "柏辰:";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(232, 35);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(32, 12);
            this.lblN3.TabIndex = 12;
            this.lblN3.Text = "麒淞:";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(110, 35);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(32, 12);
            this.lblN2.TabIndex = 11;
            this.lblN2.Text = "禹辰:";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(5, 35);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(32, 12);
            this.lblN1.TabIndex = 10;
            this.lblN1.Text = "芷茜:";
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(392, 301);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(211, 58);
            this.btnshow.TabIndex = 20;
            this.btnshow.Text = "計算";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBxFail);
            this.groupBox1.Controls.Add(this.chkBx);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(401, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 145);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績統計";
            // 
            // chkBxFail
            // 
            this.chkBxFail.AutoSize = true;
            this.chkBxFail.Location = new System.Drawing.Point(17, 99);
            this.chkBxFail.Name = "chkBxFail";
            this.chkBxFail.Size = new System.Drawing.Size(107, 20);
            this.chkBxFail.TabIndex = 1;
            this.chkBxFail.Text = "不及格科數";
            this.chkBxFail.UseVisualStyleBackColor = true;
            // 
            // chkBx
            // 
            this.chkBx.AutoSize = true;
            this.chkBx.Location = new System.Drawing.Point(17, 45);
            this.chkBx.Name = "chkBx";
            this.chkBx.Size = new System.Drawing.Size(155, 20);
            this.chkBx.TabIndex = 0;
            this.chkBx.Text = "成績由小到大排列";
            this.chkBx.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutput.Location = new System.Drawing.Point(15, 86);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(371, 273);
            this.txtOutput.TabIndex = 22;
            this.txtOutput.TabStop = false;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 388);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblN5);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblN5;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBxFail;
        private System.Windows.Forms.CheckBox chkBx;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

