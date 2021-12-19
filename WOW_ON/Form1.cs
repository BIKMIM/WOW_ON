using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace WOW_ON
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")] private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")] private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")] private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private const int SW_WINDOW_NORMAL = 1;
        private const int SW_WINDOW_MINIMIZED = 2;
        private const int SW_WINDOW_MAXIMIZED = 3;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;

            timer1.Tick += new EventHandler(timer1_Tick);
        }
        
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        [DllImport("user32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(int wCode, int wMapType);

        


        private void start_btn_Click(object sender, EventArgs e)
        {
            work();
        }

        public void work()
        {
            Random rand = new Random();
            int D_time = rand.Next(1, 300);

            timer1.Enabled = true;                      // 타이머 온
            timer1.Interval = rand.Next(300000, 600000);   // 타이머 5분(300초,300,000 MS)~10분(600초, 600,000 MS) 사이 랜덤 셋팅
            timer1.Start();                             // 타이머 시작
            
            string W_name = "월드 오브 워크래프트";
            IntPtr hWnd = FindWindow(null, W_name); // 윈도우 타이틀명으로 핸들을 찾음. 
            if (!hWnd.Equals(IntPtr.Zero))
            {
                ShowWindowAsync(hWnd, SW_WINDOW_NORMAL); // 윈도우가 최소화 되어 있다면 활성화 
                SetForegroundWindow(hWnd);  // 윈도우에 포커스를 줘서 최상위로 만든다
                lblOnOff.Text = "ON";

                keybd_event((byte)Keys.Space, 0, 0x00, 0); // 스페이스 바 누름
                Delay(D_time);                              // 스페이스바 누르는 시간
                keybd_event((byte)Keys.Space, 0, 0x02, 0); // 스페이스바 뗌
            }
        }

        private void end_btn_Click(object sender, EventArgs e)
        {
            lblOnOff.Text = "OFF";  // 동작 종료 확인 텍스트
            timer1.Stop();          //타이머 종료
            timer1.Enabled = false; // 타이머 정지
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Random rand = new Random();
            //int D_time = rand.Next(2000, 4000);
            //Delay(D_time);
            work();
        }

        
    }
}

