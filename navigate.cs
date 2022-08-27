using System;
using System.Windows.Forms;
using System.Drawing;

namespace RobotGame
{
    public class navigate
    {
        public int leftPos { get; set; }
        public int topPos { get; set; }
        public int timebpower = 30; 

        private PictureBox naviProj = new PictureBox();
        private Timer jumpBulletTime = new Timer();

        public void startJump(Form form)
        {
            naviProj.Size = new Size(10, 10);
            naviProj.Name = "detectJump";
            naviProj.Tag = "detector";
            naviProj.Left = leftPos;
            naviProj.Top = topPos;
            naviProj.BringToFront();

            form.Controls.Add(naviProj);
            jumpBulletTime.Interval = timebpower;
            jumpBulletTime.Tick += new EventHandler(throwproj);
            jumpBulletTime.Start();
        }
        private void throwproj(object sender, EventArgs e)
        {
            naviProj.Top -= timebpower;

            if(naviProj.Top < 10 || naviProj.Top > 830)
            {
                jumpBulletTime.Stop();
                naviProj.Dispose();
                jumpBulletTime.Dispose();
                naviProj = null;
                jumpBulletTime = null;
            }
        }
    }
}

