using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long befnum = 0;
            long nownum = 1;
            int nowMatchCnt = 0;

            while (nowMatchCnt < 10)
            {
                long fibo = befnum + nownum;
                int fiboLen = fibo.ToString().Length;
                int divideNum = 0;

                while (fiboLen > 0)
                {
                    divideNum = divideNum + int.Parse( fibo.ToString().Substring(fiboLen-1, 1));
                    fiboLen--;
                    
                    
                }

//                System.Diagnostics.Debug.WriteLine("divideNum=" + divideNum.ToString());

                if (fibo > 1)
                {
                    if (fibo % divideNum == 0)
                    {
                        nowMatchCnt++;
                        System.Diagnostics.Debug.WriteLine("nowMatchCnt=" + nowMatchCnt.ToString());
                        System.Diagnostics.Debug.WriteLine("fibo=" + fibo.ToString());
                    }
                }

                befnum = nownum;
                nownum = fibo;


            }


        }
    }
}
