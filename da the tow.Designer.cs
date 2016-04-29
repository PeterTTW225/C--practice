namespace da_the_tow
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.txtNum6 = new System.Windows.Forms.TextBox();
            this.btnCaculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.ReadOnly = true;
            this.txtNum1.Size = new System.Drawing.Size(32, 23);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(62, 12);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.ReadOnly = true;
            this.txtNum2.Size = new System.Drawing.Size(32, 23);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(112, 12);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.ReadOnly = true;
            this.txtNum3.Size = new System.Drawing.Size(32, 23);
            this.txtNum3.TabIndex = 2;
            // 
            // txtNum4
            // 
            this.txtNum4.Location = new System.Drawing.Point(162, 12);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.ReadOnly = true;
            this.txtNum4.Size = new System.Drawing.Size(32, 23);
            this.txtNum4.TabIndex = 3;
            // 
            // txtNum5
            // 
            this.txtNum5.Location = new System.Drawing.Point(212, 12);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.ReadOnly = true;
            this.txtNum5.Size = new System.Drawing.Size(32, 23);
            this.txtNum5.TabIndex = 4;
            // 
            // txtNum6
            // 
            this.txtNum6.Location = new System.Drawing.Point(262, 12);
            this.txtNum6.Name = "txtNum6";
            this.txtNum6.ReadOnly = true;
            this.txtNum6.Size = new System.Drawing.Size(32, 23);
            this.txtNum6.TabIndex = 5;
            // 
            // btnCaculate
            // 
            this.btnCaculate.Location = new System.Drawing.Point(302, 12);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(65, 23);
            this.btnCaculate.TabIndex = 6;
            this.btnCaculate.Text = "開始~";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 47);
            this.Controls.Add(this.btnCaculate);
            this.Controls.Add(this.txtNum6);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Font = new System.Drawing.Font("新細明體", 10F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "da the tow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.TextBox txtNum6;
        private System.Windows.Forms.Button btnCaculate;
    }
}

