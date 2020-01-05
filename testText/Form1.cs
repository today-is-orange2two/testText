using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace testText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string[] PortNames = SerialPort.GetPortNames(); //포트검색

            //foreach (string portnumber in PortNames)
            //{
            //    Port_Combox.Items.Add(portnumber); //검색한 포트를 콤보박스에 입력
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // 텍스트 쓰기 (내보내기)
        private void Output_btn_Click(object sender, EventArgs e)
        {
            string First = Port_Combox.Text;
            string Second = Baud_Combox.Text;
            string Third = Data_Combox.Text;

            string[] lines = { "port : "+ First, "baud : "+ Second, "data : " + Third }; // 저장할 값 설정
            using (StreamWriter outputFile = new StreamWriter(@"C:\test\text.txt"))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }
            textBox1.Text += "생성완료" + Environment.NewLine;

        }

        // 텍스트 읽기 (가져오기)
        private void Input_btn_Click(object sender, EventArgs e)
        {
            string path = @"C:\test\text.txt"; // 저장된 경로에서 불러오기

            string[] textValue = System.IO.File.ReadAllLines(path); // 저장된 텍스트 문자열에 저장
            if (textValue.Length > 0)
            {
                for(int i = 0; i < textValue.Length; i++)
                {
                    textBox1.Text += textValue[i] + Environment.NewLine;

                }
            }
            textBox1.Text += "가져오기 완료" + Environment.NewLine;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
        }
    }
}
