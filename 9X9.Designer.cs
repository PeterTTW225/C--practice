namespace _9X9
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btn99 = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "列數(1~9)";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(159, 421);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 2;
            // 
            // btn99
            // 
            this.btn99.Location = new System.Drawing.Point(111, 474);
            this.btn99.Name = "btn99";
            this.btn99.Size = new System.Drawing.Size(126, 36);
            this.btn99.TabIndex = 3;
            this.btn99.Text = "99乘法表";
            this.btn99.UseVisualStyleBackColor = true;
            this.btn99.Click += new System.EventHandler(this.btn99_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(358, 426);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "顯示";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(54, 37);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShow.Size = new System.Drawing.Size(406, 368);
            this.txtShow.TabIndex = 5;
            this.txtShow.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 535);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btn99);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btn99;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtShow;
    }
}

