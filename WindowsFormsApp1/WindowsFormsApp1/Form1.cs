using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_input.Text.Contains(","))
            {
                // 숫자로 변환하여 다시 형식화
                if (double.TryParse(textBox_input.Text, out double number))
                {
                    textBox_input.Text.ToString();
                }
            }
            textBox_print.Text = textBox_input.Text;
        }

        // 초기화 함수
        private void button_res_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "";
        }

        // 한글자씩 삭제 함수
        private void button_del_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_input.Text))
            {
                textBox_input.Text = textBox_input.Text.Substring(0, textBox_input.Text.Length - 1);
            }
        }
        public static string AddCommasToNumber(double number)
        {
            return number.ToString("N0");
        }
    }
}
