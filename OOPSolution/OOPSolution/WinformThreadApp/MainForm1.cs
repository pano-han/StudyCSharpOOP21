using System;
using System.Threading;
using System.Windows.Forms;

namespace WinformThreadApp
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10000;

            
            
            // 스레드로 분리 윈폼의 화면스레드, 처리스레드를 분리한 것.
            Thread th = new Thread(()=> { //람다식
                for (int i = 0; i <= 10000; i++)
                {
                    progressBar1.BeginInvoke(
                        new Action(() =>
                        {
                            progressBar1.Value = i;
                        })); //크로스 스레드로 문제 해결. 분리된 스레드에 접근하려고하니 오류가 발생함. 이를 해결하기위해 BeginInvoke 사용.
                    Thread.Sleep(5);
                }
            });
            th.IsBackground = true; // 백그라운드로 실행할지 여부
            th.Start();
        }
    }
}
