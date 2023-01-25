using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace RobotGame
{
    public class downProjectiles
    {
        public int downProjectilePower = 30;
        public int downProjectileLeftCoordinate
        {
            get;
            set;
        }
        public int downProjectileTopCoordinate
        {
            get;
            set;
        }

        PictureBox downProjectileElement = new PictureBox();
        Timer downProjectileClock = new Timer();

        public void DownPlayer(Form form)
        {
            downProjectileElement.Size = new Size(10, 10);
            downProjectileElement.Name = "DownProjectileName";
            downProjectileElement.Tag = "DownProjectileTag";
            downProjectileElement.Left = downProjectileLeftCoordinate;
            downProjectileElement.Top = downProjectileTopCoordinate;
            downProjectileElement.BringToFront();

            form.Controls.Add(downProjectileElement);
            downProjectileClock.Interval = 30;
            downProjectileClock.Tick += new EventHandler(throwDown);
            downProjectileClock.Start();
        }

        private void throwDown(object sender, EventArgs e)
        {
            downProjectileElement.Top += downProjectilePower;
            if (downProjectileElement.Top < 10 || downProjectileElement.Top > 830)
            {
                downProjectileClock.Stop();
                downProjectileElement.Dispose();
                downProjectileClock.Dispose();
                downProjectileClock = null;
                downProjectileElement = null;
            }
        }
    }
}