namespace Multi_1DArray
{
    partial class Multi_1DArray
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpSata = new System.Windows.Forms.GroupBox();
            this.chkCourseAvg = new System.Windows.Forms.CheckBox();
            this.chkRank = new System.Windows.Forms.CheckBox();
            this.chkFailNum = new System.Windows.Forms.CheckBox();
            this.chkAvg = new System.Windows.Forms.CheckBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSata.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(428, 238);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.WordWrap = false;
            // 
            // grpSata
            // 
            this.grpSata.Controls.Add(this.chkCourseAvg);
            this.grpSata.Controls.Add(this.chkRank);
            this.grpSata.Controls.Add(this.chkFailNum);
            this.grpSata.Controls.Add(this.chkAvg);
            this.grpSata.Location = new System.Drawing.Point(446, 12);
            this.grpSata.Name = "grpSata";
            this.grpSata.Size = new System.Drawing.Size(200, 194);
            this.grpSata.TabIndex = 1;
            this.grpSata.TabStop = false;
            this.grpSata.Text = "成績統計";
            // 
            // chkCourseAvg
            // 
            this.chkCourseAvg.AutoSize = true;
            this.chkCourseAvg.Location = new System.Drawing.Point(30, 156);
            this.chkCourseAvg.Name = "chkCourseAvg";
            this.chkCourseAvg.Size = new System.Drawing.Size(91, 20);
            this.chkCourseAvg.TabIndex = 3;
            this.chkCourseAvg.Text = "各科平均";
            this.chkCourseAvg.UseVisualStyleBackColor = true;
            // 
            // chkRank
            // 
            this.chkRank.AutoSize = true;
            this.chkRank.Location = new System.Drawing.Point(30, 118);
            this.chkRank.Name = "chkRank";
            this.chkRank.Size = new System.Drawing.Size(91, 20);
            this.chkRank.TabIndex = 2;
            this.chkRank.Text = "每人名次";
            this.chkRank.UseVisualStyleBackColor = true;
            // 
            // chkFailNum
            // 
            this.chkFailNum.AutoSize = true;
            this.chkFailNum.Location = new System.Drawing.Point(30, 80);
            this.chkFailNum.Name = "chkFailNum";
            this.chkFailNum.Size = new System.Drawing.Size(139, 20);
            this.chkFailNum.TabIndex = 1;
            this.chkFailNum.Text = "每人不及格科數";
            this.chkFailNum.UseVisualStyleBackColor = true;
            // 
            // chkAvg
            // 
            this.chkAvg.AutoSize = true;
            this.chkAvg.Location = new System.Drawing.Point(30, 42);
            this.chkAvg.Name = "chkAvg";
            this.chkAvg.Size = new System.Drawing.Size(91, 20);
            this.chkAvg.TabIndex = 0;
            this.chkAvg.Text = "每人平均";
            this.chkAvg.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(446, 212);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(197, 38);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "計算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(222, 275);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 27);
            this.txtName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(424, 265);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜尋成績";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "搜尋學生姓名:";
            // 
            // Multi_1DArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.grpSata);
            this.Controls.Add(this.txtOutput);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Multi_1DArray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成績處理";
            this.Load += new System.EventHandler(this.Multi_1DArray_Load);
            this.grpSata.ResumeLayout(false);
            this.grpSata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox grpSata;
        private System.Windows.Forms.CheckBox chkCourseAvg;
        private System.Windows.Forms.CheckBox chkRank;
        private System.Windows.Forms.CheckBox chkFailNum;
        private System.Windows.Forms.CheckBox chkAvg;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}

