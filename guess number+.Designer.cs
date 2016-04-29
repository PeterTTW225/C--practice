namespace GUESS_NUMBER_
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "猜!!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(36, 37);
            this.txtmin.Name = "txtmin";
            this.txtmin.ReadOnly = true;
            this.txtmin.Size = new System.Drawing.Size(125, 27);
            this.txtmin.TabIndex = 1;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(200, 37);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(115, 27);
            this.txtGuess.TabIndex = 2;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(377, 37);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(117, 27);
            this.txtMax.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "<";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "<";
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Location = new System.Drawing.Point(318, 103);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(40, 16);
            this.lblTry.TabIndex = 6;
            this.lblTry.Text = "剩餘";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "次機會!";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(360, 103);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(24, 16);
            this.lblK.TabIndex = 8;
            this.lblK.Text = "10";
            this.lblK.Click += new System.EventHandler(this.lblK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 146);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "猜猜猜!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblK;
    }
}

