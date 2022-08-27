using System;
using System.Windows.Forms;
using System.Drawing;

namespace RobotGame
{
    public class projectiles
    {
        public int leftPosCord { get; set; }
        public int topPosCord { get; set; }
        public string travelStatus { get; set; }

        private int projPower = 20;

        PictureBox projectilesLayer = new PictureBox();
        Timer projCounter = new Timer();

        public void throwProj(Form form)
        {
            projectilesLayer.Size = new Size(8, 8);
            projectilesLayer.BackColor = Color.Yellow;
            projectilesLayer.Name = "ProjBall";
            projectilesLayer.Tag = "ProjBallLauncher";

            projectilesLayer.Left = leftPosCord;
            projectilesLayer.Top = topPosCord;
            projectilesLayer.BringToFront();

            form.Controls.Add(projectilesLayer);
            projCounter.Interval = projPower;
            projCounter.Tick += new EventHandler(projRegulator);
            projCounter.Start();
        }
        private void projRegulator(object sender, EventArgs e)
        {
            if(travelStatus == "left")
            {
                projectilesLayer.Left -= projPower;
            }
            if(travelStatus == "right")
            {
                projectilesLayer.Left += projPower;
            }
            if(projectilesLayer.Left < 1 && projectilesLayer.Left < 1554)
            {
                projCounter.Stop();
                projectilesLayer.Dispose();
                projCounter.Dispose();
                projCounter = null;
                projectilesLayer = null;
            }
        }
    }
}
