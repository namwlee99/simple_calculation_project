using System.Windows.Forms;
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
        private List<string> calculationHistory = new List<string>();
        public Form1()

        {
            InitializeComponent();
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
            // 배용진 여기까지

            // 김정관 시작
            //현재의 계산식과 결과를 계산 이력 리스트에 추가
            //계산 이력의 크기를 최대 10개로 제한
            //현재 계산 결과를 반환
            string currentCalculation = input;
            string currentResult = result.ToString();
            calculationHistory.Add(currentCalculation + " = " + currentResult);
            
            const int maxHistorySize = 10;
            if (calculationHistory.Count > maxHistorySize)
            {
                calculationHistory.RemoveAt(0);
            }
            
            return currentResult;
        }

        // 이남웅
        // textBox의 입력 및 필터링 함수
        private string allowedChars = "0123456789.+-*/%()";

        private void textBox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            // 입력된 문자가 허용된 문자 목록에 속하지 않으면 입력을 취소
            if (allowedChars.IndexOf(key) == -1)
            {
                e.Handled = true;
            }
        }

        // 이남웅
        // textBox의 입력을 실시간으로 처리하는 함수
        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            // TextBox 내용을 전부 검사하여 잘못된 문자를 제거
            string inputText = textBox_input.Text;
            string filteredText = new string(inputText.Where(c => allowedChars.Contains(c)).ToArray());

            textBox_print.Text = filteredText;
            textBox_input.Text = filteredText;

            // 커서 위치를 TextBox 끝으로 이동
            textBox_input.SelectionStart = textBox_input.Text.Length;
        }

        // 이남웅
        // C 버튼 함수
        private void button_res_Click(object sender, EventArgs e)
        {
            // 입력된 문자 초기화
            textBox_input.Text = "";
        }

        // 이남웅
        // DEL 버튼 함수
        private void button_del_Click(object sender, EventArgs e)
        {
            // 만약 입력된 문자가 존재할 경우
            if (!string.IsNullOrEmpty(textBox_input.Text))
            {
                // 마지막 문자를 제거하여 나머지 부분을 대입
                textBox_input.Text = textBox_input.Text.Substring(0, textBox_input.Text.Length - 1);
            }
        }

        // 배용진
        // "=" 버튼 함수
        private void button_ica_Click(object sender, EventArgs e)
        {
            textBox_print.Text = Calculation(textBox_input.Text);
        }

        //김정관 시작
        //최근 계산 이력 중 최대 10개의 항목을 가져와서 이를 텍스트 박스(textBox_print)에 표시
        private void button_log_Click(object sender, EventArgs e)
        {
            int count = Math.Min(calculationHistory.Count, 10);

            StringBuilder historyText = new StringBuilder();
            for (int i = calculationHistory.Count - count; i < calculationHistory.Count; i++)
            {
                historyText.AppendLine(calculationHistory[i]);
            }

            string fullText = "계산 이력 (최근 " + count + "개):\r\n\r\n" + historyText.ToString();
            textBox_print.Text = fullText;

        }
        // 김정관 끝
        

        // 배용진
        // 더하기 버튼, 누르면 계산기에 더하기 추가됨
        private void button_plu_Click(object sender, EventArgs e)
        {
            string text = textBox_input.Text;
            char lastcharacter = default;
            if (textBox_input.Text == "")
            {
                lastcharacter = default;
            }
            else
            {
                lastcharacter = text[text.Length - 1];
            }

            // 문자열 길이, 마지막 문자 조건 파악해서 입력 받기
            if ((lastcharacter == default && text.Length == 0) ||
               (text.Length == 1 && lastcharacter.ToString() == "-"))
            {
                // 아무것도 입력되지 않는 상태일 때 작동
                textBox_input.Text += "";
            }
            // 기호 있으면 교체
            else if (lastcharacter.ToString() == "+" || lastcharacter.ToString() == "-" ||
                lastcharacter.ToString() == "*" || lastcharacter.ToString() == "/" ||
                lastcharacter.ToString() == "%")
            {
                textBox_input.Text = text.Remove(text.Length - 1);
                textBox_input.Text += "+";
            }
            else
            {
                textBox_input.Text += "+";
            }
        }

        // 배용진
        // 빼기 버튼
        private void button_min_Click(object sender, EventArgs e)
        {
            string text = textBox_input.Text;
            char lastcharacter = default;
            if (textBox_input.Text == "")
            {
                lastcharacter = default;
            }
            else
            {
                lastcharacter = text[text.Length - 1];
            }

            if ((lastcharacter == default && text.Length == 0) ||
               (text.Length == 1 && lastcharacter.ToString() == "-"))
            {
                // 아무것도 입력되지 않는 상태일 때 작동
                if (textBox_input.Text == "-")
                {
                    textBox_input.Text = "";
                }
                else
                {
                    textBox_input.Text += "-";

                }
            }
            // 기호 있으면 교체
            else if (lastcharacter.ToString() == "+" || lastcharacter.ToString() == "-" ||
                lastcharacter.ToString() == "*" || lastcharacter.ToString() == "/" ||
                lastcharacter.ToString() == "%")
            {
                textBox_input.Text = text.Remove(text.Length - 1);
                textBox_input.Text += "-";
            }
            else
            {
                textBox_input.Text += "-";
            }
        }
        // 배용진
        // 곱하기 버튼
        private void button_mul_Click(object sender, EventArgs e)
        {

            string text = textBox_input.Text;
            char lastcharacter = default;
            if (textBox_input.Text == "")
            {
                lastcharacter = default;
            }
            else
            {
                lastcharacter = text[text.Length - 1];
            }


            if ((lastcharacter == default && text.Length == 0) ||
               (text.Length == 1 && lastcharacter.ToString() == "-"))
            {
                // 아무것도 입력되지 않는 상태일 때 작동
                textBox_input.Text += "";
            }
            // 기호 있으면 교체
            else if (lastcharacter.ToString() == "+" || lastcharacter.ToString() == "-" ||
                lastcharacter.ToString() == "*" || lastcharacter.ToString() == "/" ||
                lastcharacter.ToString() == "%")
            {
                textBox_input.Text = text.Remove(text.Length - 1);
                textBox_input.Text += "*";
            }
            else
            {
                textBox_input.Text += "*";
            }
        }
        // 배용진
        // 나누기 버튼 ( 몫 )
        private void button_div_Click(object sender, EventArgs e)
        {
            string text = textBox_input.Text;
            char lastcharacter = default;
            if (textBox_input.Text == "")
            {
                lastcharacter = default;
            }
            else
            {
                lastcharacter = text[text.Length - 1];
            }


            if ((lastcharacter == default && text.Length == 0) ||
               (text.Length == 1 && lastcharacter.ToString() == "-"))
            {
                // 아무것도 입력되지 않는 상태일 때 작동
                textBox_input.Text += "";
            }
            // 기호 있으면 교체
            else if (lastcharacter.ToString() == "+" || lastcharacter.ToString() == "-" ||
                lastcharacter.ToString() == "*" || lastcharacter.ToString() == "/" ||
                lastcharacter.ToString() == "%")
            {
                textBox_input.Text = text.Remove(text.Length - 1);
                textBox_input.Text += "/";
            }
            else
            {
                textBox_input.Text += "/";
            }
        }
        // 배용진
        // 나누기 버튼 ( 나머지 )
        private void button_rem_Click(object sender, EventArgs e)
        {
            string text = textBox_input.Text;
            char lastcharacter = default;
            if (textBox_input.Text == "")
            {
                lastcharacter = default;
            }
            else
            {
                lastcharacter = text[text.Length - 1];
            }


            if ((lastcharacter == default && text.Length == 0) ||
               (text.Length == 1 && lastcharacter.ToString() == "-"))
            {
                // 아무것도 입력되지 않는 상태일 때 작동
                textBox_input.Text += "";
            }
            // 기호 있으면 교체
            else if (lastcharacter.ToString() == "+" || lastcharacter.ToString() == "-" ||
                lastcharacter.ToString() == "*" || lastcharacter.ToString() == "/" ||
                lastcharacter.ToString() == "%")
            {
                textBox_input.Text = text.Remove(text.Length - 1);
                textBox_input.Text += "%";
            }
            else
            {
                textBox_input.Text += "%";
            }
        }
        // 배용진 여기까지


        //김정관 Log 초기화 구축
        private void log_reset_Click(object sender, EventArgs e)
        {
            calculationHistory.Clear();

            textBox_print.Text = "";
        }
        //김정관 끝
 
    }
}

