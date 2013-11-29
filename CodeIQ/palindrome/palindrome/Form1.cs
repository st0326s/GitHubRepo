using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



//10進数、2進数、8進数のいずれで表現しても回文数となる数のうち、
//10進数の10以上で最小の値を求めてください。
//※回文数は逆から数字を読んでも同じ数になる数のことです。

//例）9(10進数)＝1001(2進数)＝11(8進数)

//【解答方法】
//解答フォームの1行目に答えを記入してください。（例：9）
//2行目以降は、あなたが求めた方法を記入してください。プログラムを書いた場合はコードを貼り付けてください。

        private void button1_Click(object sender, EventArgs e)
        {
            int nowNum = 10;
            bool endCalc = false;


            while (endCalc == false)
            {

                //int befConvertNum = int.Parse(numString);

                //string byteString = Convert.ToString(befConvertNum, 2);

                //char[] reversed = byteString.ToCharArray().Reverse().ToArray();

//                string byteStringReverse = new string(reversed);

                // 10進数　回文
                string decimalStr = nowNum.ToString();
                char[] reverseStr = decimalStr.ToCharArray().Reverse().ToArray();
                string decimalRevStr = new string(reverseStr);

                // 2進数　回文
                string byteStr = Convert.ToString(nowNum, 2);
                reverseStr = byteStr.ToCharArray().Reverse().ToArray();
                string byteRevStr = new string(reverseStr);

                // 8進数　回文
                string octStr = Convert.ToString(nowNum, 8);
                reverseStr = octStr.ToCharArray().Reverse().ToArray();
                string octRevStr = new string(reverseStr);


                //'出力ウインドウに出力される
                System.Diagnostics.Debug.WriteLine(decimalStr);
                System.Diagnostics.Debug.WriteLine(decimalRevStr);
                System.Diagnostics.Debug.WriteLine(byteStr);
                System.Diagnostics.Debug.WriteLine(byteRevStr);
                System.Diagnostics.Debug.WriteLine(octStr);
                System.Diagnostics.Debug.WriteLine(octRevStr);

                if ((decimalStr == decimalRevStr) &&
                    (byteStr == byteRevStr) &&
                    (octStr == octRevStr)
                   )
                {
                    endCalc = true;
                }
                nowNum++;

            }


        }
    }
}
