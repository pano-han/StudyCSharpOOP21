using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerCheckApp
{
    public partial class MainForm : Form
    {
        static readonly Logger logger = LogManager.GetCurrentClassLogger(); //요거 하나 추가하면 됨. 
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //초기화 내용...
            logger.Info("MainForm 로드");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = TxtUserID.Text + "\n" + TxtPassword.Text;
            MessageBox.Show($"당신이 아이디와 패스워드는 {result}");

            try
            {
                var val = TxtPassword.Text.Substring(3, 2); //문자열 자르는 메서드
                MessageBox.Show($"{val}");
                logger.Info("제대로 완료!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외발생, 관리자에게 문의요망");
                logger.Error("예외발생, 관리자에게 문의요망");
                logger.Error($"{ex}");
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
