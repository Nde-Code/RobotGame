using System;
using System.Windows.Forms;
using System.Drawing;

namespace RobotGame
{
    public class upProjectiles
    {
        public int upProjectileLeftCoordinate { get; set; }
        public int upProjectileTopCoordinate { get; set; }
        public int upProjectilePower = 30; 

        private PictureBox upProjectileElement = new PictureBox();
        private Timer upProjectileClock = new Timer();

        public void startJump(Form form)
        {
            upProjectileElement.Size = new Size(10, 10);
            upProjectileElement.Name = "UpProjectileName";
            upProjectileElement.Tag = "UpProjectileTag";
            upProjectileElement.Left = upProjectileLeftCoordinate;
            upProjectileElement.Top = upProjectileTopCoordinate;
            upProjectileElement.BringToFront();

            form.Controls.Add(upProjectileElement);
            upProjectileClock.Interval = upProjectilePower;
            upProjectileClock.Tick += new EventHandler(launchProjectilesToNavigate);
            upProjectileClock.Start();
        }
        private void launchProjectilesToNavigate(object sender, EventArgs e)
        {
            upProjectileElement.Top -= upProjectilePower;

            if(upProjectileElement.Top < 10 || upProjectileElement.Top > 830)
            {
                upProjectileClock.Stop();
                upProjectileElement.Dispose();
                upProjectileClock.Dispose();
                upProjectileElement = null;
                upProjectileClock = null;
            }
        }
    }
}

