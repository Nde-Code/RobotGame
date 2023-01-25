using System;
using System.Windows.Forms;
using System.Drawing;

namespace RobotGame
{
    public class projectiles
    {
        public int projectileLeftCoordinate { get; set; }
        public int projectileTopCoordinate { get; set; }
        public string projectileDirection { get; set; }

        private int projectilePower = 20;

        PictureBox projectileElement = new PictureBox();
        Timer projectileClock  = new Timer();

        public void launchProjectiles(Form form)
        {
            projectileElement.Size = new Size(5, 5);
            projectileElement.BackColor = Color.Yellow;
            projectileElement.Name = "projectileName";
            projectileElement.Tag = "ProjectileTag";

            projectileElement.Left = projectileLeftCoordinate;
            projectileElement.Top = projectileTopCoordinate;
            projectileElement.BringToFront();

            form.Controls.Add(projectileElement);
            projectileClock.Interval = projectilePower;
            projectileClock.Tick += new EventHandler(launchTimer);
            projectileClock.Start();
        }
        private void launchTimer(object sender, EventArgs e)
        {
            if(projectileDirection == "left")
            {
                projectileElement.Left -= projectilePower;
            }
            if(projectileDirection == "right")
            {
                projectileElement.Left += projectilePower;
            }
            if(projectileElement.Left < 1 && projectileElement.Left < 1554)
            {
                projectileClock.Stop();
                projectileElement.Dispose();
                projectileClock.Dispose();
                projectileClock  = null;
                projectileElement = null;
            }
        }
    }
}
