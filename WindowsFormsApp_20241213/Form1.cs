using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_20241213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 메시지 박스가 창보다 먼저 뜬 이유 -> InitializeComponent() 보다 MessageBox.Show() 메소드가 먼저 실행되서
            // MessageBox.Show("안녕하세요.");

            /*
                텍스트 박스에 메시지 출력
             */
            textBox_print.Text = "이것은\r\n멀티라인\r\n텍스트박스\r\n인데요.";
            int a = 1;
            string msg = "hi";
        }


    }
}
