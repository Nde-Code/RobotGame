// Par Nathan Debilloëz. 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RobotGame
{
    public partial class RobotGameWindow : Form
    {
        public RobotGameWindow()
        {
            InitializeComponent();
            onLoading();
            spawnMonsterLeft();
            spawnMonsterRight();
        }

        int xCoord;
        int pvCount = 100;
        int projectilesCounter = 100;
        int score;
        int money;
        int ProjectilesLootCounter;
        int playerSpeed = 5;
        
        bool isLeft, isRight;
        bool gameOver;

        string whereMoving;
        string move;

        
        int[] swordXpos = {
            556,
            545,
            341,
            96,
            926,
        };
        
        int[] swordYpos = {
            170, 
            383,
            330,
            109,
            82,
        };

        int[] moneyXpos = {
            656,
            625,
            922, 
            1045,
            960,
            162,
            163,
        };
        
        int[] moneyYpos = {
            176,
            389,
            411,
            88,
            260,
            116,
            336,
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

        Random randomLocation = new Random();
        
        List<PictureBox> currentRightGhost = new List<PictureBox>();
        
        List<PictureBox> currentLeftGhost = new List<PictureBox>();
        
        List<PictureBox> currentProjectilesBox = new List<PictureBox>();
        
        List<PictureBox> currentMoney = new List<PictureBox>();
        
        private void onLoading() => move = "starting";
        
        private void clockTickMain(object sender, EventArgs e)
        {

            MoneyCount.Text = $"Argent: {money}";
            FragCounter.Text = $"Score: {score}";
            MonsterCounter.Text = $"Monstres: {currentLeftGhost.Count + currentRightGhost.Count}";


            if (money <= 0)
            {
                money = 0;
            }

            if (currentLeftGhost.Count is 0 && gameOver != true)
            {
                spawnMonsterLeft();
            }

            if (currentRightGhost.Count is 0 && gameOver != true)
            {
                spawnMonsterRight();
            }

            if (projectilesCounter is 0 && ProjectilesLootCounter is 0)
            {
                ProjectilesLootCounter = 1;
                spawnProjectilesBox();
            }

            foreach (Control entityProjectilesLoot in this.Controls)
            {
                if (entityProjectilesLoot is PictureBox && (string)entityProjectilesLoot.Tag == "ProjectileLootTag")
                {
                    if (entityProjectilesLoot.Bounds.IntersectsWith(Robot.Bounds))
                    {
                        ProjectilesLootCounter = 0;
                        projectilesCounter += 100;
                        this.Controls.Remove(entityProjectilesLoot);
                        ((PictureBox)entityProjectilesLoot).Dispose();
                        currentProjectilesBox.Remove((PictureBox)entityProjectilesLoot);
                    }
                }
            }

            foreach(Control entityDownProjectiles in this.Controls)
            foreach(Control entityUpProjectiles in this.Controls)
            foreach(Control entityKillProjectiles in this.Controls)
            {
                if(entityDownProjectiles is PictureBox && (string)entityDownProjectiles.Tag is "DownProjectileTag" && entityKillProjectiles is PictureBox && (string)entityKillProjectiles.Tag is "ProjectileTag")
                {
                    entityDownProjectiles.Dispose();
                    ((PictureBox)entityDownProjectiles).Dispose();
                    this.Controls.Remove(entityDownProjectiles);
                }
                if (entityUpProjectiles is PictureBox && (string)entityUpProjectiles.Tag is "UpProjectileTag" && entityKillProjectiles is PictureBox && (string)entityKillProjectiles.Tag is "ProjectileTag")
                {
                    entityUpProjectiles.Dispose();
                    ((PictureBox)entityUpProjectiles).Dispose();
                    this.Controls.Remove(entityUpProjectiles);
                }
            }

            foreach(Control entityMoney in this.Controls)
            {
                if(entityMoney is PictureBox && (string)entityMoney.Tag is "MoneyTag")
                {
                    if (entityMoney.Bounds.IntersectsWith(Robot.Bounds))
                    {
                        money++;
                        entityMoney.Dispose();
                        ((PictureBox)entityMoney).Dispose();
                        this.Controls.Remove(entityMoney);
                        currentMoney.Remove((PictureBox)entityMoney);
                    }
                }
            }

            foreach (Control projectileEntity in this.Controls)
            {
                if (projectileEntity is PictureBox && (string)projectileEntity.Tag is "ProjectileTag")
                {
                    foreach (Control entityGhost in this.Controls)
                    {
                        if (entityGhost is PictureBox && (string)entityGhost.Tag is "GhostLeftTag")
                        {
                            if (entityGhost.Bounds.IntersectsWith(projectileEntity.Bounds))
                            {
                                score++;
                                this.Controls.Remove(entityGhost);
                                this.Controls.Remove(projectileEntity);
                                ((PictureBox)projectileEntity).Dispose();
                                ((PictureBox)entityGhost).Dispose();
                                currentLeftGhost.Remove((PictureBox)entityGhost);
                            }
                        }
                        if (entityGhost is PictureBox && (string)entityGhost.Tag is "GhostRightTag")
                        {
                            if (entityGhost.Bounds.IntersectsWith(projectileEntity.Bounds))
                            {
                                score++;
                                this.Controls.Remove(entityGhost);
                                this.Controls.Remove(projectileEntity);
                                ((PictureBox)projectileEntity).Dispose();
                                ((PictureBox)entityGhost).Dispose();
                                currentRightGhost.Remove((PictureBox)entityGhost);
                                entityGhost.Dispose();
                            }
                        }
                    }
                }
            }

            foreach (Control projectileLootEntity in this.Controls)
            {
                if (projectileLootEntity is PictureBox && (string)projectileLootEntity.Tag is "ProjectileLootTag")
                {
                    foreach (Control entityGhost in this.Controls)
                    {
                        if (entityGhost is PictureBox && (string)entityGhost.Tag is "GhostLeftTag")
                        {
                            if (entityGhost.Bounds.IntersectsWith(projectileLootEntity.Bounds))
                            {
                                this.Controls.Remove(entityGhost);
                                ((PictureBox)entityGhost).Dispose();
                                currentLeftGhost.Remove((PictureBox)entityGhost);
                                entityGhost.Dispose();
                            }
                        }
                        if (entityGhost is PictureBox && (string)entityGhost.Tag is "GhostRightTag")
                        {
                            if (entityGhost.Bounds.IntersectsWith(projectileLootEntity.Bounds))
                            {
                                this.Controls.Remove(entityGhost);
                                ((PictureBox)entityGhost).Dispose();
                                currentRightGhost.Remove((PictureBox)entityGhost);
                                entityGhost.Dispose();
                            }
                        }
                    }
                }
            }

            foreach (Control entityGhostLefthostRight in this.Controls)
            {
                if (entityGhostLefthostRight is PictureBox && (string)entityGhostLefthostRight.Tag is "GhostRightTag")
                {

                    entityGhostLefthostRight.Left -= 2;

                    if (entityGhostLefthostRight.Bounds.IntersectsWith(tree10.Bounds))
                    {
                        entityGhostLefthostRight.Dispose();
                        currentRightGhost.Remove((PictureBox)entityGhostLefthostRight);
                        this.Controls.Remove(entityGhostLefthostRight);
                    }
                    if (entityGhostLefthostRight.Bounds.IntersectsWith(tree8.Bounds))
                    {
                        entityGhostLefthostRight.Dispose();
                        currentRightGhost.Remove((PictureBox)entityGhostLefthostRight);
                        this.Controls.Remove(entityGhostLefthostRight);
                    }
                    if (entityGhostLefthostRight.Bounds.IntersectsWith(Barrier3.Bounds))
                    {
                        currentRightGhost.Remove((PictureBox)entityGhostLefthostRight);
                        entityGhostLefthostRight.Dispose();
                        this.Controls.Remove(entityGhostLefthostRight);
                    }
                    if (entityGhostLefthostRight.Bounds.IntersectsWith(Robot.Bounds))
                    {
                        score += 5;
                        pvCount -= 5;
                        entityGhostLefthostRight.Dispose();
                        currentRightGhost.Remove((PictureBox)entityGhostLefthostRight);
                        this.Controls.Remove(entityGhostLefthostRight);
                    }
                }
            }
            
            foreach (Control entityGhostLeft in this.Controls)
            {
                if (entityGhostLeft is PictureBox && (string)entityGhostLeft.Tag is "GhostLeftTag")
                {
                    entityGhostLeft.Left += 2;

                    if (entityGhostLeft.Bounds.IntersectsWith(tree4.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                    if (entityGhostLeft.Bounds.IntersectsWith(tree12.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                    if (entityGhostLeft.Bounds.IntersectsWith(tree5.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                    if (entityGhostLeft.Bounds.IntersectsWith(tree11.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                    if (entityGhostLeft.Bounds.IntersectsWith(Barrier1.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                    if (entityGhostLeft.Bounds.IntersectsWith(Barrier3.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                    if (entityGhostLeft.Bounds.IntersectsWith(Barrier5.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                    if (entityGhostLeft.Bounds.IntersectsWith(Barrier6.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                    if (entityGhostLeft.Bounds.IntersectsWith(Robot.Bounds))
                    {
                        currentLeftGhost.Remove((PictureBox)entityGhostLeft);
                        score += 5;
                        pvCount -= 5;
                        entityGhostLeft.Dispose();
                        this.Controls.Remove(entityGhostLeft);
                    }
                }
            }
            
            if (pvCount > 0)
            {
                HealthBar.Value = pvCount;
            }
            else
            {
                foreach (Control EntityOnGames in this.Controls)
                {
                    if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "GhostLeftTag")
                    {
                        ((PictureBox)EntityOnGames).Dispose();
                        this.Controls.Remove((PictureBox)EntityOnGames);
                        currentLeftGhost.Clear();
                    }
                    if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "GhostRightTag")
                    {
                        ((PictureBox)EntityOnGames).Dispose();
                        this.Controls.Remove((PictureBox)EntityOnGames);
                        currentRightGhost.Clear();
                    }
                    if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "MoneyTag")
                    {
                        ((PictureBox)EntityOnGames).Dispose();
                        this.Controls.Remove((PictureBox)EntityOnGames);
                        currentProjectilesBox.Clear();
                    }
                    if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "ProjectileLootTag")
                    {
                        ((PictureBox)EntityOnGames).Dispose();
                        this.Controls.Remove((PictureBox)EntityOnGames);
                        currentMoney.Clear();
                    }
                }

                gameOver = true;
                onGameOver();

            }

            if (projectilesCounter > 1)
            {
                ProjectileCounterBar.Value = projectilesCounter;
            }
            
            if (isRight is true && isLeft is false && Robot.Left + Robot.Width < this.ClientSize.Width - 14 && gameOver != true)
            {
                Robot.Left += playerSpeed;
            }

            if (isLeft is true && isRight is false && Robot.Left > 4 && gameOver != true)
            {
                Robot.Left -= playerSpeed;
            }
            
            foreach (Control entityBarrier in this.Controls)
            {
                if (entityBarrier is PictureBox && (string)entityBarrier.Tag is "Barrier")
                {
                    if (entityBarrier.Bounds.IntersectsWith(Robot.Bounds))
                    {
                        pvCount -= 5;
                        Robot.Location = new Point((this.ClientSize.Width / 2) - (Robot.Width / 2), 521);
                    }
                }
            }

            foreach (Control entityOnWindow in this.Controls)
            {
                if (entityOnWindow is Label && (string)entityOnWindow.Tag is "FragCounterTag" || (string)entityOnWindow.Tag is "moneyCounterTag" || (string)entityOnWindow.Tag is "HealthTextTag" || (string)entityOnWindow.Tag is "projectileTextTag" || (string)entityOnWindow.Tag is "MonsterCounterTag")
                {
                    if (entityOnWindow.Bounds.IntersectsWith(Robot.Bounds))
                    {
                        Robot.Location = new Point((this.ClientSize.Width / 2) - (Robot.Width / 2), 521);
                    }
                }

                if(entityOnWindow is ProgressBar && (string)entityOnWindow.Tag is "HealthBarTag" || (string)entityOnWindow.Tag is "ProjectileCounterBarTag")
                {
                    if (entityOnWindow.Bounds.IntersectsWith(Robot.Bounds))
                    {
                        Robot.Location = new Point((this.ClientSize.Width / 2) - (Robot.Width / 2), 521);
                    }
                }
            }
            
            foreach (Control entityDown in this.Controls)
            {
                if (entityDown is PictureBox && (string)entityDown.Tag is "DownProjectileTag")
                {
                    if (entityDown.Bounds.IntersectsWith(patern3.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - (Robot.Width / 2), 367);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern4.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - (Robot.Width / 2), 521);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern2.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - (Robot.Width / 2), 521);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - (Robot.Width / 2), 314);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern7.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - (Robot.Width / 2), 238);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern5.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - (Robot.Width / 2), 390);
                        entityDown.Dispose();
                    }
                    if (entityDown.Bounds.IntersectsWith(patern6.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - (Robot.Width / 2), 521);
                        entityDown.Dispose();
                    }
                }
            }
            
            foreach (Control upNavigation in this.Controls)
            {
                if (upNavigation is PictureBox && (string)upNavigation.Tag is "UpProjectileTag")
                {
                    if (upNavigation.Top is 0)
                    {
                        upNavigation.Dispose();
                    }
                    if (upNavigation.Bounds.IntersectsWith(patern3.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - 32, 154);
                        upNavigation.Dispose();
                    }
                    if (upNavigation.Bounds.IntersectsWith(patern.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - 32, 94);
                        upNavigation.Dispose();
                    }
                    if (upNavigation.Bounds.IntersectsWith(patern2.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - 32, 314);
                        upNavigation.Dispose();
                    }
                    if (upNavigation.Bounds.IntersectsWith(patern4.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - 32, 367);
                        upNavigation.Dispose();
                    }
                    if (upNavigation.Bounds.IntersectsWith(patern5.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - 32, 238);
                        upNavigation.Dispose();
                    }
                    if (upNavigation.Bounds.IntersectsWith(patern6.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - 32, 390);
                        upNavigation.Dispose();
                    }
                    if (upNavigation.Bounds.IntersectsWith(patern7.Bounds))
                    {
                        xCoord = (Robot.Width / 2) + Robot.Left;
                        Robot.Location = new Point(xCoord - 32, 66);
                        upNavigation.Dispose();
                    }
                }
            }
            
            foreach (Control entityTree in this.Controls)
            {
                if (entityTree is PictureBox && (string)entityTree.Tag is "Tree")
                {
                    if (Robot.Bounds.IntersectsWith(entityTree.Bounds))
                    {
                        pvCount -= 5;
                        Robot.Location = new Point((this.ClientSize.Width / 2) - (Robot.Width / 2), 521);
                    }
                }
            }

            foreach(Control entityTree in this.Controls)
            foreach(Control entityProjectiles in this.Controls)
            {
                if (entityProjectiles is PictureBox && (string)entityProjectiles.Tag is "ProjectileTag")
                {
                    if(entityTree is PictureBox && (string)entityTree.Tag is "Tree")
                    {

                        if (entityTree.Bounds.IntersectsWith(entityProjectiles.Bounds))
                        {
                            this.Controls.Remove(entityProjectiles);
                            ((PictureBox)entityProjectiles).Dispose();
                        }

                    }
                }
            }

            foreach (Control entityToSet in this.Controls)
            {
                if (entityToSet is PictureBox && (string)entityToSet.Tag is "MoneyTag" || (string)entityToSet.Tag is "ProjectileLootTag")
                {
                    entityToSet.SendToBack();
                }
            }

        }
        
        private void goPlayer(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && gameOver is true)
            {
                replay();
            }
            if (e.KeyCode == Keys.Right && gameOver != true)
            {
                isRight = true;
                isLeft = false;
                move = "right";
                whereMoving = "right";
            }
            if (e.KeyCode == Keys.Left && gameOver != true)
            {
                isRight = false;
                isLeft = true;
                move = "left";
                whereMoving = "left";
            }
            if (e.KeyCode == Keys.Up && gameOver != true && getNumberOfProjectilesByType("UpProjectile") < 1)
            {
                goUp();
            }
            if (e.KeyCode == Keys.Down && gameOver != true && getNumberOfProjectilesByType("DownProjectile") < 1)
            {
                goDown();
            }
            if (e.KeyCode == Keys.Space && projectilesCounter > 0 && move != "starting" && gameOver != true && getNumberOfProjectilesByType("BasicProjectile") < 3)
            {
                shootGhost(move);
                projectilesCounter--;
            }
        }
        
        private void shootGhost(string move)
        {
            projectilesCounter -= 1;
            projectiles projectiles = new projectiles();
            projectiles.projectileLeftCoordinate = (Robot.Width / 2) + Robot.Left;
            projectiles.projectileTopCoordinate = (Robot.Width / 2) + Robot.Top;
            projectiles.projectileDirection = move;
            projectiles.launchProjectiles(this);
        }
        
        private void stopPlayer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                isRight = false;
                isLeft = false;
                whereMoving = "stop";
            }
            
            if (e.KeyCode == Keys.Left)
            {
                isRight = false;
                isLeft = false;
                whereMoving = "stop";
            }
        }

        private int getNumberOfProjectilesByType(string typeOfProjectile)
        {

            int numberOfProjectiles = 0;

            foreach(Control projectilesEntities in this.Controls)
            {
                if(typeOfProjectile is "BasicProjectile" && projectilesEntities is PictureBox && (string)projectilesEntities.Tag is "ProjectileTag")
                {
                    numberOfProjectiles++;
                }

                if (typeOfProjectile is "UpProjectile" && projectilesEntities is PictureBox && (string)projectilesEntities.Tag is "UpProjectileTag")
                {
                    numberOfProjectiles++;
                }

                if (typeOfProjectile is "DownProjectile" && projectilesEntities is PictureBox && (string)projectilesEntities.Tag is "DownProjectileTag")
                {
                    numberOfProjectiles++;
                }
            }

            return numberOfProjectiles;

        }
        
        private void goUp()
        {
            upProjectiles upProjectile = new upProjectiles();
            upProjectile.upProjectileLeftCoordinate = (Robot.Width / 2) + Robot.Left;
            upProjectile.upProjectileTopCoordinate = (Robot.Width / 2) + Robot.Top;
            upProjectile.startJump(this);
        }

        private void detectPlayerStatus(object sender, EventArgs e)
        {
            if (whereMoving is "stop" || move is "starting")
            {
                pvCount -= 10;
            }
        }

        private void goDown()
        {
            downProjectiles downProjectile = new downProjectiles();
            downProjectile.downProjectileLeftCoordinate = (Robot.Width / 2) + Robot.Left;
            downProjectile.downProjectileTopCoordinate = (Robot.Width / 2) + Robot.Top + 32;
            downProjectile.DownPlayer(this);
        }

        private void spawnMonsterLeft()
        {
            for(var b = 0; b < 2; b++)
            {
                spawnGhostLeft();
            }
        }

        private void spawnMonsterRight()
        {
            for (var c = 0; c < 2; c++)
            {
                spawnRightLeft();
            }
        }
        
        private void spawnGhostLeft()
        {
            int ghostLeftRandomCoordinate = randomLocation.Next(0, 6);

            PictureBox ghostLeftBox = new PictureBox();
            ghostLeftBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ghostLeftBox.Image = Properties.Resources.ghost;
            ghostLeftBox.Left = randMonsterLeft[ghostLeftRandomCoordinate];
            ghostLeftBox.Top = randTopMonster[ghostLeftRandomCoordinate];
            ghostLeftBox.Tag = "GhostLeftTag";
            ghostLeftBox.Name = "GhostLeftName";
            ghostLeftBox.BringToFront();

            currentLeftGhost.Add(ghostLeftBox);
            this.Controls.Add(ghostLeftBox);

        }

        private void spawnRightLeft()
        {
            int ghostRightBoxRandomCoordinate = randomLocation.Next(0, 3);

            PictureBox ghostRightBox = new PictureBox();
            ghostRightBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ghostRightBox.Image = Properties.Resources.ghost;
            ghostRightBox.Left = randRightLeft[ghostRightBoxRandomCoordinate];
            ghostRightBox.Top = randTopRight[ghostRightBoxRandomCoordinate];
            ghostRightBox.Tag = "GhostRightTag";
            ghostRightBox.Name = "GhostRightName";
            ghostRightBox.BringToFront();

            currentRightGhost.Add(ghostRightBox);
            this.Controls.Add(ghostRightBox);
        }

        private void spawnProjectilesBox()
        {
            int bulletRandomXY = randomLocation.Next(0, 5);

            PictureBox projectileLoot = new PictureBox();
            projectileLoot.SizeMode = PictureBoxSizeMode.AutoSize;
            projectileLoot.Image = Properties.Resources.weapon;
            projectileLoot.Left = swordXpos[bulletRandomXY]; 
            projectileLoot.Top = swordYpos[bulletRandomXY]; 
            projectileLoot.Tag = "ProjectileLootTag";
            projectileLoot.Name = "ProjectileLootName";
            projectileLoot.SendToBack();

            currentProjectilesBox.Add(projectileLoot);
            this.Controls.Add(projectileLoot);
        }

        private void spawnMoney(object sender, EventArgs e)
        {
            if (currentMoney.Count < 5)
            {
                moneyConstructor();
            } 
        }

        private void moneyConstructor()
        {
            int moneyRandomXY = randomLocation.Next(0, 7);
            PictureBox moneyPicture = new PictureBox();
            moneyPicture.Image = Properties.Resources.ruby;
            moneyPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            moneyPicture.Left = moneyXpos[moneyRandomXY];
            moneyPicture.Top = moneyYpos[moneyRandomXY];
            moneyPicture.Tag = "MoneyTag";
            moneyPicture.Name = "MoneyName";
            moneyPicture.SendToBack();

            currentMoney.Add(moneyPicture);
            this.Controls.Add(moneyPicture);
        }

        private void onGameOver()
        {

            foreach (Control EntityOnGames in this.Controls)
            {
                if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "GhostLeftTag")
                {
                    ((PictureBox)EntityOnGames).Dispose();
                    this.Controls.Remove((PictureBox)EntityOnGames);
                    currentLeftGhost.Clear();
                }
                if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "GhostRightTag")
                {
                    ((PictureBox)EntityOnGames).Dispose();
                    this.Controls.Remove((PictureBox)EntityOnGames);
                    currentRightGhost.Clear();
                }
                if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "MoneyTag")
                {
                    ((PictureBox)EntityOnGames).Dispose();
                    this.Controls.Remove((PictureBox)EntityOnGames);
                    currentProjectilesBox.Clear();
                }
                if (EntityOnGames is PictureBox && (string)EntityOnGames.Tag is "ProjectileLootTag")
                {
                    ((PictureBox)EntityOnGames).Dispose();
                    this.Controls.Remove((PictureBox)EntityOnGames);
                    currentMoney.Clear();
                }
            }

            HealthBar.Value = 0;
            ProjectileCounterBar.Value = 0;

            Robot.Image = Properties.Resources.tombstone;
            Robot.Location = new Point((this.ClientSize.Width / 2) - (Robot.Width / 2), 525); 

            playerStatusChecker.Stop();
            moneyTimer.Stop();
        }

        private void replay()
        {
            MainTimer.Stop();

            gameOver = false;
            Robot.Image = Properties.Resources.robot;
            Robot.Location = new Point((this.ClientSize.Width / 2) - (Robot.Width / 2), 521);
            pvCount = 100;
            score = 0;
            money = 0;
            projectilesCounter = 100;
            isLeft = false;
            isRight = false;
            whereMoving = "stop";
            ProjectilesLootCounter = 0;

            onLoading();
            spawnMonsterLeft();
            spawnMonsterRight();

            MainTimer.Start();
            playerStatusChecker.Start();
            moneyTimer.Start();
        }
    }
}