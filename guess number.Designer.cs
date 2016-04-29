namespace guess_Number
{
    partial class guessNumber
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnNewNumber = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(18, 16);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(278, 280);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.WordWrap = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.txtAnswer.Location = new System.Drawing.Point(148, 309);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(148, 27);
            this.txtAnswer.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(15, 312);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(118, 16);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "你的答案(0~99):";
            // 
            // btnNewNumber
            // 
            this.btnNewNumber.Location = new System.Drawing.Point(315, 16);
            this.btnNewNumber.Name = "btnNewNumber";
            this.btnNewNumber.Size = new System.Drawing.Size(99, 40);
            this.btnNewNumber.TabIndex = 3;
            this.btnNewNumber.Text = "產生數字";
            this.btnNewNumber.UseVisualStyleBackColor = true;
            this.btnNewNumber.Click += new System.EventHandler(this.btnNewNumber_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(315, 93);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(99, 40);
            this.btnAnswer.TabIndex = 4;
            this.btnAnswer.Text = "答案";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(315, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "結束";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(315, 247);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(99, 40);
            this.btnInput.TabIndex = 6;
            this.btnInput.Text = "輸入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // guessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 349);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnNewNumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtMessage);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "guessNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "猜數字遊戲";
            this.Load += new System.EventHandler(this.guessNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnNewNumber;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInput;
    }
}

