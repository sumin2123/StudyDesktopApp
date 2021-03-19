using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphiEditor
{
    enum DrawMode
    {
        // 각 항목에 대해서 이름 설정
        LINE,
        RECTANGLE,
        CIRCLE,
        CURVED_LINE
    }

    /* ----------------------------------------------------------------------------------------------- */


    /* [ 그림 그릴때 클릭 시작점과 들그 끝나는 점 메서드 생성 ] */
    public partial class FrmMain : Form
    {

        private DrawMode mode;
        private Graphics g;
        private Pen pen;
        private Pen eraser;
        private Point startP, endP, currP, prevP;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StsCurrent.Text = "";

            g = CreateGraphics();
            this.pen = new Pen(Color.Black, 2);
            StsCurrent.Text = "Line Mode";
            this.mode = DrawMode.LINE; 
            this.BackColor = Color.White;
            this.eraser = new Pen(Color.White, 2);
            
        }

/* ----------------------------------------------------------------------------------------------- */


        private void TlmLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.LINE;// 설정한 이름으로 클릭하면 연동되게 하기
            StsCurrent.Text = "Line Mode";

        }

        private void TlmRectangle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.RECTANGLE; // 설정한 이름으로 클릭하면 연동되게 하기
            StsCurrent.Text = "Rextangle Mode";
        }

/* ----------------------------------------------------------------------------------------------- */



        /* [ MouseDown = 마우스 클릭 ] */
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.startP = new Point(e.X, e.Y);
            this.currP = this.prevP = this.startP;
        }

/* ----------------------------------------------------------------------------------------------- */


        /// <summary>
        ///  마우스 옮길때마다 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            this.prevP = this.currP;
            this.currP = new Point(e.X, e.Y);
            /* 버튼 왼클릭이 진행된다면, 
               이전지점이 현재지점으로 바뀌면서 그려지고,
               현재지점이 새로운지점으로 계속 변한다는 말 
               (85 ~ 90)
            */


            switch (this.mode)
            {
                case DrawMode.LINE:
                    g.DrawLine(this.eraser, this.startP, this.prevP);
                    g.DrawLine(this.pen, this.startP, this.currP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(this.eraser,
                        new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawRectangle(this.pen,
                        new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(this.eraser,
                        new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawEllipse(this.pen,
                        new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }
        // 그림이 진행되는 동안 지우개와 펜이 동시에 연동
        // 앞에 있는건 지우면서 그림이 그려짐


/* ----------------------------------------------------------------------------------------------- */


        /*  
         * Mouse Up = 마우스에서 손 뗀다
         * 그림이 끝나는 지점이 현재 마우스가 있는 곳으로 결정
         * 각 항목마다 전부 설정
         */
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.endP = new Point(e.X, e.Y);

            switch (this.mode)
            {
                case DrawMode.LINE:
                    g.DrawLine(this.pen, this.startP, this.endP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(this.pen,
                        new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(this.pen,
                        new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }

 /* ----------------------------------------------------------------------------------------------- */

        private void TlmCircle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CIRCLE; // 설정한 이름으로 클릭하면 연동되게 하기
            StsCurrent.Text = "Circle Mode";
        }

        private void TlmCurvedLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CURVED_LINE; // 설정한 이름으로 클릭하면 연동되게 하기
            StsCurrent.Text = "Curvedline Mode";
        }

/* ----------------------------------------------------------------------------------------------- */


        /* [ 색깔항목 클릭하고 색 선택후 확인하면 펜 색깔로 나오게 하기 ] */
        private void TlmColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pen.Color = dialog.Color;
            }
        }
    }
}
