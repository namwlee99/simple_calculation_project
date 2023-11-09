using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 배용진 작성
            Calculation("10 + (20 - 10) * 30 / 2");       //테스트용 생성자 추후 삭제
            Split_String("받아올 문자열 혹은 함수");      //테스트용 생성자 추후 삭제
            // 배용진 여기까지
        }

        // 배용진
        // 문자열을 받아와서 스플릿한 객체를 공백을 체크해서 배열 형태로 내보냄.
        // 필요가...없어졌나?
        public string[] Split_String(string s_calc)
        {
            string[] s_array = s_calc.Split(' '); ;

            return s_array;
        }

        // 문자열 내용을 받아와서 사칙연산 후 string으로 반환
        // split을 써야하나?? -> 문자열을 받아서 가능하게 바꿈 -> 이러면 split 기능이 쓸모 없어지지 않았나..?
        // 대신 공학용 계산기처럼 괄호 넣어도 계산이 됨.
        public string Calculation(string input)
        {
            // 데이터테이블 객체 생성
            DataTable dt = new DataTable();
            // 정확한 계산을 위해 decimal로 선언
            decimal result = 0;

            // string으로 받은 문자열을 compute()로 계산. 공백 구분 없이 사칙연산 해줌..
            // 이후 decimal로 변환한 값을 result에 저장
            result = Convert.ToDecimal(dt.Compute(input, ""));

            // string으로 바꿔서 리턴
            return result.ToString();
        }
        // 배용진 여기까지

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

        // 배용진
        // = 이퀄 함수
        private void button_ica_Click(object sender, EventArgs e)
        {
            // 입력 받았을 때 계산 텍스트 변경 및 텍스트박스 리셋
            textBox_print.Text = Calculation(textBox_input.Text);
            textBox_input.Text = "";
        }
        // 배용진 여기까지
    }
}
