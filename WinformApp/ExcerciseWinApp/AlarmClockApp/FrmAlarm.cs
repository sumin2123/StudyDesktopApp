using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace AlarmClockApp
{
    public partial class FrmAlarm : Form
    {
        private DateTime SetDay;  
        private DateTime SetTime;
        // 날짜와 시간을 설정할 수 있게 만듦

        private bool IsSetAlarm;

        WindowsMediaPlayer mediaPlayer;
        // 미디어플레이어에 연결하여 알람시간이 되면 소리나게 해줌.

        public FrmAlarm()
        {
            InitializeComponent();

            // 초기화 작업
        }

        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            mediaPlayer = new WindowsMediaPlayer();
            // 미디어플레이어에 연결하여 알람시간이 되면 소리나게 해줌.

            LblAlarm.ForeColor = Color.Gray;

            LblDate.Text = LblTime.Text = ""; // 시작할때 글자를 지워줌

            DtpAlarmTime.Format = DateTimePickerFormat.Custom;
            DtpAlarmTime.CustomFormat = "hh:mm:ss";
            DtpAlarmTime.ShowUpDown = true; // 
            DtpAlarmTime.Value = DateTime.Now;
            // 디지털시계 형식 설정 (시분초, 시계는 현재시간으로 설정

            MyTimer.Interval = 1000; // 1sec => 1초 단위로 틱 가능
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Enabled = true;
            MyTimer.Start();

            TabClock.SelectedTab = TapDigitalClock;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            LblDate.Text = curDate.ToShortDateString();
            LblTime.Text = curDate.ToString("hh:mm:ss");

            if (IsSetAlarm == true) // 알람 설정이 되었다면
            {
                // 알람 시간하고 현재시간 일치하면 알람울림
                if (SetDay == DateTime.Today &&
                    SetTime.Hour == curDate.Hour &&
                    SetTime.Minute == curDate.Minute &&
                    SetTime.Second == curDate.Second)
                {
                    //IsSetAlarm = false; // 알람 설정 종료
                    BtnRelease_Click(sender, e);
                    mediaPlayer.launchURL(@"C:\Users\mini2\Desktop\Study Repository\StudyDesktopApp\WinformApp\ExcerciseWinApp\AlarmClockApp\medias/alarm.mp3");
                    mediaPlayer.controls.play();

                    MessageBox.Show("알람!!!", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            SetDay = DateTime.Parse(DtpAlarmDate.Text);
            SetTime = DateTime.Parse(DtpAlarmTime.Text);

            LblAlarm.Text = $"Alarm : {SetDay.ToShortDateString()} {SetTime:hh:mm:ss}";
            LblAlarm.ForeColor = Color.Red;

            TabClock.SelectedTab = TapDigitalClock;
            IsSetAlarm = true;
        }

        private void BtnRelease_Click(object sender, EventArgs e)
        {
            IsSetAlarm = false;
            LblAlarm.Text = "Alarm : ";
            LblAlarm.ForeColor = Color.Gray;
            TabClock.SelectedTab = TapDigitalClock;
        }
    }
}
