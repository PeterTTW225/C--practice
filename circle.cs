using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace area_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {


            string r1, r2, r3;                      //先宣告會有什麼東西出現(類似以X,Y來代表某數的意思)
            double R1, R2, R3;                      //宣告變數
            double output1, output2, output3;       //宣告變數
            double circumference1, circumference2, circumference3;
            const double PI=3.1415;                 //定義常數

            Console.Write("請輸入r1:");             //要求主控台顯示"......"
            r1 = Console.ReadLine();                //要求程式讀取輸入的數字
            R1 = Convert.ToDouble(r1);              //將讀取到的數字轉換為變數R1

            Console.Write("請輸入r2:");
            r2 = Console.ReadLine();
            R2 = Convert.ToDouble(r2);

            Console.Write("請輸入r3:");
            r3 = Console.ReadLine();
            R3 = Convert.ToDouble(r3);

            output1 = R1 * R1 * PI;                 //計算
            output2 = R2 * R2 * PI;
            output3 = R3 * R3 * PI;

            circumference1 = 2 * PI * R1;
            circumference2 = 2 * PI * R2;
            circumference3 = 2 * PI * R3;

            Console.WriteLine("r1：半徑{0} , 圓周長:{1} , 圓面積:{2}", R1, circumference1, output1);       //顯示出計算的內容
            Console.WriteLine("r2：半徑{0} , 圓周長:{1} , 圓面積:{2}", R2, circumference2, output2);       //{}內由0開始(1.2.3......)，後面的變數就會出現在{}的位置
            Console.WriteLine("r3：半徑{0} , 圓周長:{1} , 圓面積:{2}", R3, circumference3, output3);
            Console.ReadLine();
        }
    }
}
