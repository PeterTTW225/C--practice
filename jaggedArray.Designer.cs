namespace jaggedArray
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdBtnBoy = new System.Windows.Forms.RadioButton();
            this.rdBtnGirl = new System.Windows.Forms.RadioButton();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.grpProduct.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(66, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 22);
            this.txtName.TabIndex = 1;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.checkBox5);
            this.grpProduct.Controls.Add(this.checkBox4);
            this.grpProduct.Controls.Add(this.checkBox3);
            this.grpProduct.Controls.Add(this.checkBox2);
            this.grpProduct.Controls.Add(this.checkBox1);
            this.grpProduct.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpProduct.Location = new System.Drawing.Point(46, 96);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(212, 212);
            this.grpProduct.TabIndex = 2;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "商品";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(24, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "HTC ONE S";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(130, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "NEW HTC ONE";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(24, 98);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(94, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "IPHONE 5";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(24, 139);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(183, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "SAMESONE ANYCALL";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(24, 178);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(75, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "小米機";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdBtnGirl);
            this.grpGender.Controls.Add(this.rdBtnBoy);
            this.grpGender.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpGender.Location = new System.Drawing.Point(298, 52);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(201, 103);
            this.grpGender.TabIndex = 3;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "性別";
            // 
            // rdBtnBoy
            // 
            this.rdBtnBoy.AutoSize = true;
            this.rdBtnBoy.Checked = true;
            this.rdBtnBoy.Location = new System.Drawing.Point(19, 26);
            this.rdBtnBoy.Name = "rdBtnBoy";
            this.rdBtnBoy.Size = new System.Drawing.Size(58, 20);
            this.rdBtnBoy.TabIndex = 0;
            this.rdBtnBoy.TabStop = true;
            this.rdBtnBoy.Text = "男性";
            this.rdBtnBoy.UseVisualStyleBackColor = true;
            // 
            // rdBtnGirl
            // 
            this.rdBtnGirl.AutoSize = true;
            this.rdBtnGirl.Location = new System.Drawing.Point(19, 65);
            this.rdBtnGirl.Name = "rdBtnGirl";
            this.rdBtnGirl.Size = new System.Drawing.Size(58, 20);
            this.rdBtnGirl.TabIndex = 1;
            this.rdBtnGirl.TabStop = true;
            this.rdBtnGirl.Text = "女性";
            this.rdBtnGirl.UseVisualStyleBackColor = true;
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(46, 328);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(212, 24);
            this.lblShow.TabIndex = 4;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInput.Location = new System.Drawing.Point(317, 183);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(170, 31);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "輸入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnList.Location = new System.Drawing.Point(317, 224);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(170, 31);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "列表";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(317, 263);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 31);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnd.Location = new System.Drawing.Point(317, 306);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(170, 27);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtshow
            // 
            this.txtshow.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtshow.Location = new System.Drawing.Point(46, 367);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.ReadOnly = true;
            this.txtshow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtshow.Size = new System.Drawing.Size(441, 197);
            this.txtshow.TabIndex = 9;
            this.txtshow.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 595);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdBtnGirl;
        private System.Windows.Forms.RadioButton rdBtnBoy;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtshow;
    }
}

