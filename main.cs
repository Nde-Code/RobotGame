// Par Nathan Debilloëz. 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RobotGame
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            MainStart();
            summonMonsterleft();
            summonMonsterRight();
        }
        
        int pvBar = 100;
        int ammoCount = 100;
        int score;
        int money;
        int ammoEntityCount;
        
        int playerPower = 7;
        bool goLeft, goRight;
        bool gameOver;
        string actMove;
        string move;

        
        int[] bulletXpos = {
            556,
            545,
            341,
            96,
            926,
        };
        
        int[] bulletYpos = {
            186,
            399,
            346,
            125,
            98,
        };
        int[] moneyXpos = {
            656,
            645,
            922, 
            1045,
            960,
            162,
            163,
        };
        
        int[] moneyYpos = {
            186,
            399,
            421,
            98,
            270,
            126,
            346,
        };
        int[] randMonsterLeft = {
            130,
            901,
            904,
            298,
            92,
            960,
        };
        
        int[] randTopMonster = {
            535,
            404,
            80,
            168,
            108,
            286,
        };
        int[] randRightLeft = {
            940,
            618,
            99,
        };
        
        int[] randTopRight = {
            252,
            381,
            108,
        };
        Random location = new Random();
        
        int monsterLeft = 2;
        
        int xCoord;
        
        List<PictureBox> currentRightGhost = new List<PictureBox>();
        
        List<PictureBox> currentGhost = new List<PictureBox>();
        
        List<PictureBox> currentBullet = new List<PictureBox>();
        
        List<PictureBox> moneyList = new List<PictureBox>();
        
        private void MainStart() => move = "starting";
        
        private void clockTickMain(object sender, EventArgs e)
        {
            MoneyCount.Text = $"Argent: {money}";
            FragCounter.Text = $"Score: {score}";
            monster_count.Text = $"Monstres: {currentGhost.Count + currentRightGhost.Count}";


            if (money <= 0)
            {
                money = 0;
            }
            if (currentGhost.Count == 1)
            {
                summonMonsterleft();
            }
            if (currentRightGhost.Count == 1)
            {
                summonMonsterRight();
            }
            if (ammoCount < 29 && ammoEntityCount == 0)
            {
                ammoEntityCount = 1;
                spawnBullet();
            }
            foreach (Control entityBu in this.Controls)
            {
                if (entityBu is PictureBox && (string)entityBu.Tag == "bulletTag")
                {
                    if (entityBu.Bounds.IntersectsWith(MainPlayer.Bounds))
                    {
                        ammoEntityCount = 0;
                        ammoCount += 72;
                        this.Controls.Remove(entityBu);
                        ((PictureBox)entityBu).Dispose();
                        currentBullet.Remove((PictureBox)entityBu);
                    }
                }
            }
            foreach(Control entityMoney in this.Controls)
            {
                if(entityMoney is PictureBox && (string)entityMoney.Tag is "MoneyBox")
                {
                    if (entityMoney.Bounds.IntersectsWith(MainPlayer.Bounds))
                    {
                        money++;
                        entityMoney.Dispose();
                        ((PictureBox)entityMoney).Dispose();
                        this.Controls.Remove(entityMoney);
                        moneyList.Remove((PictureBox)entityMoney);
                    }
                }
            }
            foreach (Control bulletEntity in this.Controls)
            {
                if (bulletEntity is PictureBox && (string)bulletEntity.Tag == "ProjBallLauncher")
                {
                    foreach (Control entityMonst in this.Controls)
                    {
                        if (entityMonst is PictureBox && (string)entityMonst.Tag == "Ghostms")
                        {
                            if (entityMonst.Bounds.IntersectsWith(bulletEntity.Bounds))
                            {
                                score++;
                                this.Controls.Remove(entityMonst);
                                this.Controls.Remove(bulletEntity);
                                ((PictureBox)bulletEntity).Dispose();
                                ((PictureBox)entityMonst).Dispose();
                                currentGhost.Remove((PictureBox)entityMonst);
                            }
                        }
                        if (entityMonst is PictureBox && (string)entityMonst.Tag == "GhostR")
                        {
                            if (entityMonst.Bounds.IntersectsWith(bulletEntity.Bounds))
                            {
                                score++;
                                this.Controls.Remove(entityMonst);
                                this.Controls.Remove(bulletEntity);
                                ((PictureBox)bulletEntity).Dispose();
                                ((PictureBox)entityMonst).Dispose();
                                currentRightGhost.Remove((PictureBox)entityMonst);
                                entityMonst.Dispose();
                            }
                        }
                    }
                }
            }
            
            foreach (Control entityGR in this.Controls)
            {
                if (entityGR is PictureBox && (string)entityGR.Tag == "GhostR")
                {
                    entityGR.Left -= monsterLeft;

                    if (entityGR.Bounds.IntersectsWith(tree10.Bounds))
                    {
                        entityGR.Dispose();
                        currentRightGhost.Remove((PictureBox)entityGR);
                        this.Controls.Remove(entityGR);
                    }
                    if (entityGR.Bounds.IntersectsWith(tree8.Bounds))
                    {
                        entityGR.Dispose();
                        currentRightGhost.Remove((PictureBox)entityGR);
                        this.Controls.Remove(entityGR);
                    }
                    if (entityGR.Bounds.IntersectsWith(stopone.Bounds))
                    {
                        currentRightGhost.Remove((PictureBox)entityGR);
                        entityGR.Dispose();
                        this.Controls.Remove(entityGR);
                    }
                    if (entityGR.Bounds.IntersectsWith(MainPlayer.Bounds))
                    {
                        score += 5;
                        pvBar -= 5;
                        entityGR.Dispose();
                        currentRightGhost.Remove((PictureBox)entityGR);
                        this.Controls.Remove(entityGR);
                    }
                }
            }
            
            foreach (Control entityG in this.Controls)
            {
                if (entityG is PictureBox && (string)entityG.Tag == "Ghostms")
                {
                    entityG.Left += monsterLeft;

                    if (entityG.Bounds.IntersectsWith(tree4.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(tree12.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(tree5.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(stopthree.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(stopone.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(stopFour.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(tree11.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(tree13.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(stopSix.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                    if (entityG.Bounds.IntersectsWith(MainPlayer.Bounds))
                    {
                        currentGhost.Remove((PictureBox)entityG);
                        score += 5;
                        pvBar -= 5;
                        entityG.Dispose();
                        this.Controls.Remove(entityG);
                    }
                }
            }
            
            if (pvBar > 1)
            {
                HealthBar.Value = pvBar;
            }
            else
            {
                foreach (Control EntityOnGames in this.Controls)
                {
                    if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "Ghostms")
                    {
                        ((PictureBox)EntityOnGames).Dispose();
                        this.Controls.Remove((PictureBox)EntityOnGames);
                        currentGhost.Clear();
                    }
                    if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "GhostR")
                    {
                        ((PictureBox)EntityOnGames).Dispose();
                        this.Controls.Remove((PictureBox)EntityOnGames);
                        currentRightGhost.Clear();
                    }
                    if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "MoneyBox")
                    {
                        ((PictureBox)EntityOnGames).Dispose();
                        this.Controls.Remove((PictureBox)EntityOnGames);
                        currentBullet.Clear();
                    }
                    if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag == "bulletTag")
                    {
                        ((PictureBox)EntityOnGames).Dispose();
                        this.Controls.Remove((PictureBox)EntityOnGames);
                        moneyList.Clear();
                    }
                }

                gameOver = true;
                endGames();
            }
            if (ammoCount > 1)
            {
                AmmoBar.Value = ammoCount;
            }
            
            if (goRight == true && goLeft == false && MainPlayer.Left + MainPlayer.Width < this.ClientSize.Width - 14 && gameOver != true)
            {
                MainPlayer.Left += playerPower;
            }
            if (goLeft == true && goRight == false && MainPlayer.Left > 4 && gameOver != true)
            {
                MainPlayer.Left -= playerPower;
            }
            
            foreach (Control entityStop in this.Controls)
            {
                if (entityStop is PictureBox && (string)entityStop.Name == "stopone" ||
                    entityStop is PictureBox && (string)entityStop.Name == "stoptwo" ||
                    entityStop is PictureBox && (string)entityStop.Name == "stopthree" ||
                    entityStop is PictureBox && (string)entityStop.Name == "stopFour" ||
                    entityStop is PictureBox && (string)entityStop.Name == "stopFive" ||
                    entityStop is PictureBox && (string)entityStop.Name == "stopSix")
                {
                    if (entityStop.Bounds.IntersectsWith(MainPlayer.Bounds))
                    {
                        pvBar -= 2;
                        MainPlayer.Location = new Point((this.ClientSize.Width / 2) - (MainPlayer.Width / 2), 520);
                    }
                }
            }
            
            foreach (Control entityWind in this.Controls)
            {
                if (entityWind is Label && (string)entityWind.Name == "FragCounter" ||
                   (string)entityWind.Name == "MoneyCount" ||
                   (string)entityWind.Name == "HalthText" ||
                   (string)entityWind.Name == "AmmoCount" ||
                   (string)entityWind.Name == "tops_count"
                )
                {
                    if (entityWind.Bounds.IntersectsWith(MainPlayer.Bounds))
                    {
                        MainPlayer.Location = new Point((this.ClientSize.Width / 2) - (MainPlayer.Width / 2), 520);
                    }
                }
            }
            
            foreach (Control entityDown in this.Controls)
            {
                if (entityDown is PictureBox && (string)entityDown.Name == "LaunchDown")
                {
                    if (entityDown.Bounds.IntersectsWith(patern3.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 367);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern4.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 520);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern2.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 520);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 314);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern7.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 238);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern5.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 390);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern6.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 521);
                        entityDown.Dispose();
                    }
                }
            }
            
            foreach (Control navigateB in this.Controls)
            {
                if (navigateB is PictureBox && (string)navigateB.Name == "detectJump")
                {
                    if (navigateB.Top == 0)
                    {
                        navigateB.Dispose();
                    }
                    if (navigateB.Bounds.IntersectsWith(patern3.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 154);
                        navigateB.Dispose();
                    }
                    if (navigateB.Bounds.IntersectsWith(patern.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 94);
                        navigateB.Dispose();
                    }
                    if (navigateB.Bounds.IntersectsWith(patern2.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 314);
                        navigateB.Dispose();
                    }
                    if (navigateB.Bounds.IntersectsWith(patern4.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 367);
                        navigateB.Dispose();
                    }
                    if (navigateB.Bounds.IntersectsWith(patern5.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 238);
                        navigateB.Dispose();
                    }
                    if (navigateB.Bounds.IntersectsWith(patern6.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 390);
                        navigateB.Dispose();
                    }
                    if (navigateB.Bounds.IntersectsWith(patern7.Bounds))
                    {
                        xCoord = (MainPlayer.Width / 2) + MainPlayer.Left;
                        MainPlayer.Location = new Point(xCoord - 32, 66);
                        navigateB.Dispose();
                    }
                }
            }
            
            foreach (Control entityTree in this.Controls)
            {
                if (entityTree is PictureBox && (string)entityTree.Name == "tree5" ||
                   (string)entityTree.Name == "tree" ||
                   (string)entityTree.Name == "tree2" ||
                   (string)entityTree.Name == "tree3" ||
                   (string)entityTree.Name == "tree4" ||
                   (string)entityTree.Name == "tree6" ||
                   (string)entityTree.Name == "tree7" ||
                   (string)entityTree.Name == "tree8" ||
                   (string)entityTree.Name == "tree10" ||
                   (string)entityTree.Name == "tree11" ||
                   (string)entityTree.Name == "tree12" ||
                   (string)entityTree.Name == "tree13" ||
                   (string)entityTree.Name == "tree14" ||
                   (string)entityTree.Name == "tree15"
                )
                {
                    if (MainPlayer.Bounds.IntersectsWith(entityTree.Bounds))
                    {
                        pvBar -= 4;
                        MainPlayer.Location = new Point((this.ClientSize.Width / 2) - (MainPlayer.Width / 2), 521);
                    }
                }
            }
            foreach (Control entityProject in this.Controls)
            {
                if (entityProject is PictureBox && (string)entityProject.Name == "ProjBall")
                {
                    if (tree.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree2.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree3.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree4.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree5.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree6.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree7.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree8.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree11.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree10.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree12.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree13.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree14.Bounds.IntersectsWith(entityProject.Bounds) ||
                        tree15.Bounds.IntersectsWith(entityProject.Bounds))
                    {
                        this.Controls.Remove(entityProject);
                        ((PictureBox)entityProject).Dispose();
                    }
                }
            }
        }
        
        private void goPlayer(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && gameOver is true)
            {
                replay();
            }
            if(e.KeyCode == Keys.K)
            {
                pvBar = 1;
            }
            if (e.KeyCode == Keys.Right && gameOver != true)
            {
                goRight = true;
                goLeft = false;
                move = "right";
                actMove = "right";
            }
            if (e.KeyCode == Keys.Left && gameOver != true)
            {
                goRight = false;
                goLeft = true;
                move = "left";
                actMove = "left";
            }
            if (e.KeyCode == Keys.Up && gameOver != true)
            {
                throwJump(move);
            }
            if (e.KeyCode == Keys.Down && gameOver != true)
            {
                goDown();
            }
            if (e.KeyCode == Keys.Space && ammoCount >= 30 && move != "starting" && gameOver != true)
            {
                launchBullet(move);
                ammoCount--;
            }
            if(e.KeyCode == Keys.Enter)
            {
                Console.WriteLine(ammoCount);
            }
        }
        
        private void launchBullet(string move)
        {
            projectiles bullet = new projectiles();
            ammoCount -= 5;
            bullet.travelStatus = move;
            bullet.leftPosCord = (MainPlayer.Width / 2) + MainPlayer.Left;
            bullet.topPosCord = (MainPlayer.Width / 2) + MainPlayer.Top;
            bullet.throwProj(this);
        }
        
        private void stopPlayer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                goLeft = false;
                actMove = "stop";
            }
            
            if (e.KeyCode == Keys.Left)
            {
                goRight = false;
                goLeft = false;
                actMove = "stop";
            }
        }
        
        private void throwJump(string moving)
        {
            navigate jumping = new navigate();
            jumping.topPos = (MainPlayer.Width / 2) + MainPlayer.Top;
            jumping.leftPos = (MainPlayer.Width / 2) + MainPlayer.Left;
            jumping.startJump(this);
        }

        private void currentPlayer(object sender, EventArgs e)
        {
            if (actMove == "stop" || move == "starting")
            {
                pvBar -= 4;
            }
        }

        private void goDown()
        {
            downto downP = new downto();
            downP.currentTop = (MainPlayer.Width / 2) + MainPlayer.Top + 32;
            downP.currentLeft = (MainPlayer.Width / 2) + MainPlayer.Left;
            downP.DownPlayer(this);
        }
        private void summonMonsterleft()
        {
            for(var l = 0; l < 3; l++)
            {
                spawnGhostLeft();
            }
        }
        private void summonMonsterRight()
        {
            for (var d = 0; d < 3; d++)
            {
                rightMonster();
            }
        }
        
        private void spawnGhostLeft()
        {
            int posRandX = location.Next(0, 6);

            PictureBox ghostBox = new PictureBox();
            ghostBox.Image = Properties.Resources.ghost;
            ghostBox.Left = randMonsterLeft[posRandX];
            ghostBox.Top = randTopMonster[posRandX];
            ghostBox.Tag = "Ghostms";
            ghostBox.Name = "monster";

            currentGhost.Add(ghostBox);
            ghostBox.BringToFront();
            this.Controls.Add(ghostBox);

        }
        private void rightMonster()
        {
            int posRandY = location.Next(0, 3);

            PictureBox ghostRight = new PictureBox();
            ghostRight.Image = Properties.Resources.ghost;
            ghostRight.Left = randRightLeft[posRandY];
            ghostRight.Top = randTopRight[posRandY];
            ghostRight.Tag = "GhostR";
            ghostRight.Name = "GhostRight";

            currentRightGhost.Add(ghostRight);
            ghostRight.BringToFront();
            this.Controls.Add(ghostRight);
        }
        private void spawnBullet()
        {
            int bPosRand = location.Next(0, 5);

            PictureBox bulletPict = new PictureBox();
            bulletPict.Image = Properties.Resources.bullet;
            bulletPict.AutoSize = true;
            bulletPict.Left = bulletXpos[bPosRand];
            bulletPict.Top = bulletYpos[bPosRand];
            bulletPict.Tag = "bulletTag";
            bulletPict.Name = "bulletName";

            currentBullet.Add(bulletPict);

            bulletPict.BringToFront();
            this.Controls.Add(bulletPict);
        }

        private void spawnMoney(object sender, EventArgs e)
        {
            if (moneyList.Count < 7)
            {
                moneyConstructor();
            }
        }
        private void moneyConstructor()
        {
            int moneyLocation = location.Next(0, 7);
            PictureBox moneyPicture = new PictureBox();
            moneyPicture.Image = Properties.Resources.dollar;
            moneyPicture.AutoSize = true;
            moneyPicture.Left = moneyXpos[moneyLocation];
            moneyPicture.Top = moneyYpos[moneyLocation];
            moneyPicture.Tag = "MoneyBox";
            moneyPicture.Name = "Money";
            moneyList.Add(moneyPicture);
            moneyPicture.BringToFront();
            this.Controls.Add(moneyPicture);
        }
        private void endGames()
        {

            foreach (Control EntityOnGames in currentBullet)
            {
                if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag == "Ghostms")
                {
                    ((PictureBox)EntityOnGames).Dispose();
                    this.Controls.Remove((PictureBox)EntityOnGames);
                    currentGhost.Clear();
                }
                if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag == "GhostR")
                {
                    ((PictureBox)EntityOnGames).Dispose();
                    this.Controls.Remove((PictureBox)EntityOnGames);
                    currentRightGhost.Clear();
                }
                if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag == "MoneyBox")
                {
                    ((PictureBox)EntityOnGames).Dispose();
                    this.Controls.Remove((PictureBox)EntityOnGames);
                    currentBullet.Clear();
                }
                if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag == "bulletTag")
                {
                    ((PictureBox)EntityOnGames).Dispose();
                    this.Controls.Remove((PictureBox)EntityOnGames);
                    moneyList.Clear();
                }
            }

            pvBar = 0;
            MainPlayer.Location = new Point((this.ClientSize.Width / 2) - (MainPlayer.Width / 2), 520); ;
            MainPlayer.Image = Properties.Resources.tombstone;

            playerStatusChecker.Stop();
            moneyTimer.Stop();
        }
        private void replay()
        {
            try
            {
                MainTimer.Stop();

                gameOver = false;
                MainPlayer.Image = Properties.Resources.robot;
                pvBar = 100;
                score = 0;
                money = 0;
                ammoCount = 100;
                goLeft = false;
                goRight = false;
                actMove = "stop";
                ammoEntityCount = 0;

                MainStart();
                summonMonsterleft();
                summonMonsterRight();

                MainTimer.Start();
                playerStatusChecker.Start();
                moneyTimer.Start();
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}