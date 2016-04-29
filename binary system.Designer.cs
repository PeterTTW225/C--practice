namespace binary_system
{
    partial class digitsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(digitsystem));
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb16 = new System.Windows.Forms.RadioButton();
            this.rdb8 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入10進位數:";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(34, 102);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(298, 35);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(62, 164);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(221, 45);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "進位數轉換";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(146, 25);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(186, 27);
            this.txtNumber.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb16);
            this.groupBox1.Controls.Add(this.rdb8);
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Location = new System.Drawing.Point(355, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "n進位數";
            // 
            // rdb16
            // 
            this.rdb16.AutoSize = true;
            this.rdb16.Location = new System.Drawing.Point(27, 136);
            this.rdb16.Name = "rdb16";
            this.rdb16.Size = new System.Drawing.Size(74, 20);
            this.rdb16.TabIndex = 5;
            this.rdb16.Text = "16進位";
            this.rdb16.UseVisualStyleBackColor = true;
            // 
            // rdb8
            // 
            this.rdb8.AutoSize = true;
            this.rdb8.Location = new System.Drawing.Point(27, 89);
            this.rdb8.Name = "rdb8";
            this.rdb8.Size = new System.Drawing.Size(66, 20);
            this.rdb8.TabIndex = 4;
            this.rdb8.Text = "8進位";
            this.rdb8.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Checked = true;
            this.rdb2.Location = new System.Drawing.Point(27, 42);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(66, 20);
            this.rdb2.TabIndex = 3;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2進位";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // digitsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "digitsystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "數字系統";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb16;
        private System.Windows.Forms.RadioButton rdb8;
        private System.Windows.Forms.RadioButton rdb2;
    }
}

