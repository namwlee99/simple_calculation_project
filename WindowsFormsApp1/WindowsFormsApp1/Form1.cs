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
            Split_String("받아올 문자열 혹은 함수");
        }

        // 배용진
        // 문자열을 받아와서 스플릿한 객체를 공백을 체크해서 배열 형태로 내보냄.
        public string[] Split_String(string s_calc)
        {
            string[] s_array = s_calc.Split(' '); ;

            return s_array;
        }

        // 배용진
        // 문자열을 split 한 내용을 받아와서 사칙연산
        public float Calculation(string[] s_calc)
        {
            float result = 0;

            return result;
        }
    }
}
