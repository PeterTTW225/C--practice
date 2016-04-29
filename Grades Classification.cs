using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grades_Classification
{
    public partial class FiveNumbers : Form
    {
        public FiveNumbers()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            int pass = 0;
            int A = 0, B = 0, C = 0, D = 0, E = 0;
            int grade;
            int sum = 0;

            grade = Convert.ToInt32(txtNum1.Text);
            if (grade >= 60) pass++;
            if (grade >= 90) A++;
            else if (grade >= 80) B++;
            else if (grade >= 70) C++;
            else if (grade >= 60) D++;
            else E++;
            sum += grade;

            grade = Convert.ToInt32(txtNum2.Text);
            if (grade >= 60) pass++;
            if (grade >= 90) A++;
            else if (grade >= 80) B++;
            else if (grade >= 70) C++;
            else if (grade >= 60) D++;
            else E++;
            sum += grade;

            grade = Convert.ToInt32(txtNum3.Text);
            if (grade >= 60) pass++;
            if (grade >= 90) A++;
            else if (grade >= 80) B++;
            else if (grade >= 70) C++;
            else if (grade >= 60) D++;
            else E++;
            sum += grade;

            grade = Convert.ToInt32(txtNum4.Text);
            if (grade >= 60) pass++;
            if (grade >= 90) A++;
            else if (grade >= 80) B++;
            else if (grade >= 70) C++;
            else if (grade >= 60) D++;
            else E++;
            sum += grade;

            grade = Convert.ToInt32(txtNum5.Text);
            if (grade >= 60) pass++;
            if (grade >= 90) A++;
            else if (grade >= 80) B++;
            else if (grade >= 70) C++;
            else if (grade >= 60) D++;
            else E++;
            sum += grade;

            txtOutput.Text = ("及格人數:" + pass + "人") + "\r\n" + ("等級A:" + A + "人") + "\r\n" + ("等級B:" + B + "人") + "\r\n" + ("等級C:" + C + "人") + "\r\n" + ("等級D:" + D + "人") + "\r\n" + ("等級E:" + E + "人") + "\r\n" + ("平均:" + sum / 5 + "分");




        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
