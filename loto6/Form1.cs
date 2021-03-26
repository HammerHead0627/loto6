using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace loto6
{
    public partial class Form1 : Form
    {

        //過去の抽選内容
        List<string> lotoNoLog = new List<string>();

        //抽選番号
        private string[] lotoNo  = new string[6];
 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        //抽選を実行する
        private void button1_Click(object sender, EventArgs e)
        {

            //textBox1に抽選した数字を表示する
            lotoNo.SetValue(MyRandom.Next(1, 44).ToString(), 0);
            textBox1.Text = lotoNo[0];

            //textBox2に抽選した数字を表示する
            lotoNo.SetValue(MyRandom.Next(1, 44).ToString(), 1);
            textBox2.Text = lotoNo[1];

            //textBox3に抽選した数字を表示する
            lotoNo.SetValue(MyRandom.Next(1, 44).ToString(), 2);
            textBox3.Text = lotoNo[2];

            //textBox4に抽選した数字を表示する
            lotoNo.SetValue(MyRandom.Next(1, 44).ToString(), 3);
            textBox4.Text = lotoNo[3];

            //textBox5に抽選した数字を表示する
            lotoNo.SetValue(MyRandom.Next(1, 44).ToString(), 4);
            textBox5.Text = lotoNo[4];

            //textBox6に抽選した数字を表示する
            lotoNo.SetValue(MyRandom.Next(1, 44).ToString(), 5);
            textBox6.Text = lotoNo[5];

            //1回の抽選ごとに抽選番号をカンマ区切りで保存する
            lotoNoLog.Add(string.Join(",", lotoNo));
            
            //コンソールに抽選番号を表示する
            Console.WriteLine(string.Join("," , lotoNo));
            
        }

        //保存を実行する
        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\loto6";
            //Cドライブ直下にloto6フォルダが存在しない場合、loto6フォルダを作成する
            if (!Directory.Exists(path))           
            {
                DirectoryInfo di = new DirectoryInfo(path);
                di.Create();
            }

            //Shift JISで書き込む
            //書き込むファイルが既に存在している場合は、上書きする
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
            @"C:\loto6\loto6.txt",
            false,
            System.Text.Encoding.GetEncoding("shift_jis"));
            //抽選内容を1行ずつテキストファイルに書き込む
            foreach (string line in lotoNoLog)
            {
                sw.WriteLine(line);
            }
            //閉じる
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
