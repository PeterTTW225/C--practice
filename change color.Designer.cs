namespace HW1_11301415
{
    partial class Form_HW1
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnBackyellow = new System.Windows.Forms.Button();
            this.btnRedword = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInput.Location = new System.Drawing.Point(43, 42);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(109, 21);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "輸入文字:";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInput.Location = new System.Drawing.Point(177, 43);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(206, 27);
            this.txtInput.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(47, 191);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(54, 51);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "顯示";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnBackyellow
            // 
            this.btnBackyellow.BackColor = System.Drawing.Color.Yellow;
            this.btnBackyellow.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBackyellow.Location = new System.Drawing.Point(117, 191);
            this.btnBackyellow.Name = "btnBackyellow";
            this.btnBackyellow.Size = new System.Drawing.Size(54, 51);
            this.btnBackyellow.TabIndex = 4;
            this.btnBackyellow.Text = "黃底";
            this.btnBackyellow.UseVisualStyleBackColor = false;
            this.btnBackyellow.Click += new System.EventHandler(this.btnBackyellow_Click);
            // 
            // btnRedword
            // 
            this.btnRedword.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRedword.ForeColor = System.Drawing.Color.Red;
            this.btnRedword.Location = new System.Drawing.Point(187, 191);
            this.btnRedword.Name = "btnRedword";
            this.btnRedword.Size = new System.Drawing.Size(54, 51);
            this.btnRedword.TabIndex = 5;
            this.btnRedword.Text = "紅字";
            this.btnRedword.UseVisualStyleBackColor = true;
            this.btnRedword.Click += new System.EventHandler(this.btnRedword_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRecover.Location = new System.Drawing.Point(257, 191);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(54, 51);
            this.btnRecover.TabIndex = 6;
            this.btnRecover.Text = "還原";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.ForeColor = System.Drawing.Color.Blue;
            this.lblShow.Location = new System.Drawing.Point(46, 111);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(337, 40);
            this.lblShow.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(327, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_HW1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnRedword);
            this.Controls.Add(this.btnBackyellow);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form_HW1";
            this.Text = "HomeWork1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnBackyellow;
        private System.Windows.Forms.Button btnRedword;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button button1;
    }
}

