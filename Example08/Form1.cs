using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
            Game game = new Game();
            game.answer = game.CreateNumbers();
            List<int> userAnswer = game.CreateNumbers();

            Console.WriteLine(game.GetResult(userAnswer));
*/

namespace Example08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<int> answer = new List<int>();

        /*
        private bool IsInAnswer(int number)
        {
            for (int index = 0; index < answer.Count; index++)
            {
                if (number == answer[index])
                {
                    return true;
                }
            }
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //建立題目
            Game game = new Game();
            game.answer = game.CreateNumbers();
            label3.Text = game.ConvertNumbersToString(game.answer);

            int i = int.Parse(num.Text);
            int j = 0;

            int A0 = 0;
            int A1 = 0;
            int A2 = 0;
            int A3 = 0;
            int A4 = 0;

            int B0 = 0;
            int B1 = 0;
            int B2 = 0;
            int B3 = 0;
            int B4 = 0;

            //開始檢查判斷
            for (int k = i; j <= i; j++)
            {
                List<int> userAnswer = game.CreateNumbers();//產生答案
                int[] ans = game.GetResult(userAnswer);//取回檢查結果 A & B

                textBox5.Text +=
                    "Q:" + game.ConvertNumbersToString(game.answer) +
                    Environment.NewLine +
                    "A:" + game.ConvertNumbersToString(userAnswer) +
                    Environment.NewLine +
                    "R:" + ans[0].ToString() + "A" +//輸出檢查結果 A
                           ans[1].ToString() + "B" +//輸出檢查結果 B
                    Environment.NewLine +
                    Environment.NewLine;

                if (ans[0] == 0) { A0 += 1; }
                if (ans[0] == 1) { A1 += 1; }
                if (ans[0] == 2) { A2 += 1; }
                if (ans[0] == 3) { A3 += 1; }
                if (ans[0] == 4) { A4 += 1; }

                if (ans[1] == 0) { B0 += 1; }
                if (ans[1] == 1) { B1 += 1; }
                if (ans[1] == 2) { B2 += 1; }
                if (ans[1] == 3) { B3 += 1; }
                if (ans[1] == 4) { B4 += 1; }
            }

            textBox1.Text += "0A:" + A0.ToString() + Environment.NewLine;
            textBox1.Text += "1A:" + A1.ToString() + Environment.NewLine;
            textBox1.Text += "2A:" + A2.ToString() + Environment.NewLine;
            textBox1.Text += "3A:" + A3.ToString() + Environment.NewLine;
            textBox1.Text += "4A:" + A4.ToString() + Environment.NewLine;

            textBox2.Text += "0B:" + B0.ToString() + Environment.NewLine;
            textBox2.Text += "1B:" + B1.ToString() + Environment.NewLine;
            textBox2.Text += "2B:" + B2.ToString() + Environment.NewLine;
            textBox2.Text += "3B:" + B3.ToString() + Environment.NewLine;
            textBox2.Text += "4B:" + B4.ToString() + Environment.NewLine;

            /*
                *1.設定執行 X 次
                *2.開始執行迴圈
                *3.檢查數值並輸出結果
                4.排除失敗數值
                5.統計成功次數
                6.統計失敗次數
                7.檢查執行次數是否達成
                8.完成執行次數後計算成果
                9.計算平均成功次數
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}