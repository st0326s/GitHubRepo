using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace time2convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //期間は、前回の東京オリンピック(1964年10月10日)から、
            //次回の東京オリンピック(2020年7月24日予定)とします。
            //例）1966年7年13日の場合

            //● YYYYMMDDのフォーマット：
            // 19660713
            //● 2進数に変換：
            // 1001010111111111110101001
            //● 2進数を逆から並べる：
            // 100101011111
            // 1
            // 111110101001
            //● 逆から並べた2進数を10進数に戻す：
            // 19660713
            // ↓
            // 1966年7月13日になる

            // 日付と時刻を格納するための変数を宣言する
            DateTime dtNow = DateTime.Parse("1964/10/10");


            while (dtNow.ToShortDateString() != "2020/07/24")
            {
                // 1 日加算する
                dtNow = dtNow.AddDays(1);
                string numString = dtNow.ToShortDateString();

                numString = numString.Substring(0, 4) + 
                                  numString.Substring(5, 2) + 
                                    numString.Substring(8, 2);

                int befConvertNum = int.Parse(numString);

                string byteString = Convert.ToString(befConvertNum, 2);

                char[] reversed = byteString.ToCharArray().Reverse().ToArray();

                string byteStringReverse = new string(reversed);



                //System.Diagnostics.Debug.WriteLine(dtNow.ToShortDateString());
                //System.Diagnostics.Debug.WriteLine(byteString);
                //System.Diagnostics.Debug.WriteLine(byteStringReverse);

                if (byteString.Equals(byteStringReverse) == true)
                {
                    System.Diagnostics.Debug.WriteLine(dtNow.ToShortDateString());
                }

            }



        }
    }
}
