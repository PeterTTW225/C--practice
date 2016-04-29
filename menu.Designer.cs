namespace WindowsFormsApplicationPractice_List
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
            this.grBhp = new System.Windows.Forms.GroupBox();
            this.chkpizzab = new System.Windows.Forms.CheckBox();
            this.chkpizzas = new System.Windows.Forms.CheckBox();
            this.chkchicken = new System.Windows.Forms.CheckBox();
            this.chkfish = new System.Windows.Forms.CheckBox();
            this.grB1 = new System.Windows.Forms.GroupBox();
            this.rdBtnfriesb = new System.Windows.Forms.RadioButton();
            this.rdBtnfriess = new System.Windows.Forms.RadioButton();
            this.chkfries = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdBtntea = new System.Windows.Forms.RadioButton();
            this.rdBtncoffee = new System.Windows.Forms.RadioButton();
            this.rdBtncoke = new System.Windows.Forms.RadioButton();
            this.chkdrink = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblshow = new System.Windows.Forms.Label();
            this.grBhp.SuspendLayout();
            this.grB1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBhp
            // 
            this.grBhp.Controls.Add(this.chkpizzab);
            this.grBhp.Controls.Add(this.chkpizzas);
            this.grBhp.Controls.Add(this.chkchicken);
            this.grBhp.Controls.Add(this.chkfish);
            this.grBhp.Location = new System.Drawing.Point(34, 32);
            this.grBhp.Name = "grBhp";
            this.grBhp.Size = new System.Drawing.Size(181, 217);
            this.grBhp.TabIndex = 0;
            this.grBhp.TabStop = false;
            this.grBhp.Text = "漢堡/披薩";
            // 
            // chkpizzab
            // 
            this.chkpizzab.AutoSize = true;
            this.chkpizzab.Location = new System.Drawing.Point(21, 167);
            this.chkpizzab.Name = "chkpizzab";
            this.chkpizzab.Size = new System.Drawing.Size(87, 16);
            this.chkpizzab.TabIndex = 3;
            this.chkpizzab.Text = "大披薩 $429";
            this.chkpizzab.UseVisualStyleBackColor = true;
            // 
            // chkpizzas
            // 
            this.chkpizzas.AutoSize = true;
            this.chkpizzas.Location = new System.Drawing.Point(21, 128);
            this.chkpizzas.Name = "chkpizzas";
            this.chkpizzas.Size = new System.Drawing.Size(87, 16);
            this.chkpizzas.TabIndex = 2;
            this.chkpizzas.Text = "小披薩 $259";
            this.chkpizzas.UseVisualStyleBackColor = true;
            // 
            // chkchicken
            // 
            this.chkchicken.AutoSize = true;
            this.chkchicken.Location = new System.Drawing.Point(21, 85);
            this.chkchicken.Name = "chkchicken";
            this.chkchicken.Size = new System.Drawing.Size(105, 16);
            this.chkchicken.TabIndex = 1;
            this.chkchicken.Text = "勁辣雞腿堡 $69";
            this.chkchicken.UseVisualStyleBackColor = true;
            // 
            // chkfish
            // 
            this.chkfish.AutoSize = true;
            this.chkfish.Location = new System.Drawing.Point(21, 43);
            this.chkfish.Name = "chkfish";
            this.chkfish.Size = new System.Drawing.Size(93, 16);
            this.chkfish.TabIndex = 0;
            this.chkfish.Text = "麥香魚堡 $59";
            this.chkfish.UseVisualStyleBackColor = true;
            // 
            // grB1
            // 
            this.grB1.Controls.Add(this.rdBtnfriesb);
            this.grB1.Controls.Add(this.rdBtnfriess);
            this.grB1.Controls.Add(this.chkfries);
            this.grB1.Location = new System.Drawing.Point(249, 32);
            this.grB1.Name = "grB1";
            this.grB1.Size = new System.Drawing.Size(198, 101);
            this.grB1.TabIndex = 1;
            this.grB1.TabStop = false;
            // 
            // rdBtnfriesb
            // 
            this.rdBtnfriesb.AutoSize = true;
            this.rdBtnfriesb.Location = new System.Drawing.Point(15, 64);
            this.rdBtnfriesb.Name = "rdBtnfriesb";
            this.rdBtnfriesb.Size = new System.Drawing.Size(68, 16);
            this.rdBtnfriesb.TabIndex = 2;
            this.rdBtnfriesb.TabStop = true;
            this.rdBtnfriesb.Text = "大薯 $35";
            this.rdBtnfriesb.UseVisualStyleBackColor = true;
            // 
            // rdBtnfriess
            // 
            this.rdBtnfriess.AutoSize = true;
            this.rdBtnfriess.Location = new System.Drawing.Point(15, 33);
            this.rdBtnfriess.Name = "rdBtnfriess";
            this.rdBtnfriess.Size = new System.Drawing.Size(68, 16);
            this.rdBtnfriess.TabIndex = 1;
            this.rdBtnfriess.TabStop = true;
            this.rdBtnfriess.Text = "小薯 $25";
            this.rdBtnfriess.UseVisualStyleBackColor = true;
            this.rdBtnfriess.CheckedChanged += new System.EventHandler(this.rdBtnfriess_CheckedChanged);
            // 
            // chkfries
            // 
            this.chkfries.AutoSize = true;
            this.chkfries.Location = new System.Drawing.Point(39, 0);
            this.chkfries.Name = "chkfries";
            this.chkfries.Size = new System.Drawing.Size(48, 16);
            this.chkfries.TabIndex = 0;
            this.chkfries.Text = "薯條";
            this.chkfries.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdBtntea);
            this.groupBox3.Controls.Add(this.rdBtncoffee);
            this.groupBox3.Controls.Add(this.rdBtncoke);
            this.groupBox3.Controls.Add(this.chkdrink);
            this.groupBox3.Location = new System.Drawing.Point(249, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // rdBtntea
            // 
            this.rdBtntea.AutoSize = true;
            this.rdBtntea.Location = new System.Drawing.Point(15, 78);
            this.rdBtntea.Name = "rdBtntea";
            this.rdBtntea.Size = new System.Drawing.Size(68, 16);
            this.rdBtntea.TabIndex = 3;
            this.rdBtntea.TabStop = true;
            this.rdBtntea.Text = "紅茶 $20";
            this.rdBtntea.UseVisualStyleBackColor = true;
            // 
            // rdBtncoffee
            // 
            this.rdBtncoffee.AutoSize = true;
            this.rdBtncoffee.Location = new System.Drawing.Point(15, 49);
            this.rdBtncoffee.Name = "rdBtncoffee";
            this.rdBtncoffee.Size = new System.Drawing.Size(68, 16);
            this.rdBtncoffee.TabIndex = 2;
            this.rdBtncoffee.TabStop = true;
            this.rdBtncoffee.Text = "咖啡 $30";
            this.rdBtncoffee.UseVisualStyleBackColor = true;
            // 
            // rdBtncoke
            // 
            this.rdBtncoke.AutoSize = true;
            this.rdBtncoke.Location = new System.Drawing.Point(15, 21);
            this.rdBtncoke.Name = "rdBtncoke";
            this.rdBtncoke.Size = new System.Drawing.Size(68, 16);
            this.rdBtncoke.TabIndex = 1;
            this.rdBtncoke.TabStop = true;
            this.rdBtncoke.Text = "可樂 $25";
            this.rdBtncoke.UseVisualStyleBackColor = true;
            // 
            // chkdrink
            // 
            this.chkdrink.AutoSize = true;
            this.chkdrink.Location = new System.Drawing.Point(39, 0);
            this.chkdrink.Name = "chkdrink";
            this.chkdrink.Size = new System.Drawing.Size(48, 16);
            this.chkdrink.TabIndex = 0;
            this.chkdrink.Text = "飲料";
            this.chkdrink.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(75, 269);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "點餐";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(182, 274);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(32, 12);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "金額:";
            // 
            // lblshow
            // 
            this.lblshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblshow.Location = new System.Drawing.Point(220, 269);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(161, 28);
            this.lblshow.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 327);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grB1);
            this.Controls.Add(this.grBhp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBhp.ResumeLayout(false);
            this.grBhp.PerformLayout();
            this.grB1.ResumeLayout(false);
            this.grB1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBhp;
        private System.Windows.Forms.GroupBox grB1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkpizzas;
        private System.Windows.Forms.CheckBox chkchicken;
        private System.Windows.Forms.CheckBox chkfish;
        private System.Windows.Forms.CheckBox chkpizzab;
        private System.Windows.Forms.RadioButton rdBtnfriesb;
        private System.Windows.Forms.RadioButton rdBtnfriess;
        private System.Windows.Forms.CheckBox chkfries;
        private System.Windows.Forms.CheckBox chkdrink;
        private System.Windows.Forms.RadioButton rdBtntea;
        private System.Windows.Forms.RadioButton rdBtncoffee;
        private System.Windows.Forms.RadioButton rdBtncoke;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblshow;
    }
}

