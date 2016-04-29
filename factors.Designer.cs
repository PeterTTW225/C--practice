namespace WindowsFormsApplicationFactor
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblshow = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(21, 60);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(49, 22);
            this.txtN.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(88, 63);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 12);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "的所有正因數有";
            // 
            // lblshow
            // 
            this.lblshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblshow.Location = new System.Drawing.Point(198, 59);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(197, 23);
            this.lblshow.TabIndex = 2;
            this.lblshow.Text = "                       ";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(157, 112);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "Answer";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 168);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Button btn;
    }
}

