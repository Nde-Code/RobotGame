
namespace RobotGame
{
    public partial class RobotGameWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotGameWindow));
            this.MoneyCount = new System.Windows.Forms.Label();
            this.FragCounter = new System.Windows.Forms.Label();
            this.HealthText = new System.Windows.Forms.Label();
            this.projectileText = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.ProjectileCounterBar = new System.Windows.Forms.ProgressBar();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MonsterCounter = new System.Windows.Forms.Label();
            this.tree12 = new System.Windows.Forms.PictureBox();
            this.tree11 = new System.Windows.Forms.PictureBox();
            this.tree2 = new System.Windows.Forms.PictureBox();
            this.tree10 = new System.Windows.Forms.PictureBox();
            this.tree8 = new System.Windows.Forms.PictureBox();
            this.tree7 = new System.Windows.Forms.PictureBox();
            this.Robot = new System.Windows.Forms.PictureBox();
            this.tree5 = new System.Windows.Forms.PictureBox();
            this.tree4 = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.patern7 = new System.Windows.Forms.PictureBox();
            this.patern6 = new System.Windows.Forms.PictureBox();
            this.patern5 = new System.Windows.Forms.PictureBox();
            this.patern4 = new System.Windows.Forms.PictureBox();
            this.patern3 = new System.Windows.Forms.PictureBox();
            this.patern2 = new System.Windows.Forms.PictureBox();
            this.patern = new System.Windows.Forms.PictureBox();
            this.grassBlock = new System.Windows.Forms.PictureBox();
            this.Barrier3 = new System.Windows.Forms.PictureBox();
            this.Barrier2 = new System.Windows.Forms.PictureBox();
            this.Barrier1 = new System.Windows.Forms.PictureBox();
            this.Barrier5 = new System.Windows.Forms.PictureBox();
            this.Barrier4 = new System.Windows.Forms.PictureBox();
            this.tree14 = new System.Windows.Forms.PictureBox();
            this.tree15 = new System.Windows.Forms.PictureBox();
            this.Barrier6 = new System.Windows.Forms.PictureBox();
            this.playerStatusChecker = new System.Windows.Forms.Timer(this.components);
            this.moneyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tree12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grassBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier6)).BeginInit();
            this.SuspendLayout();
            // 
            // MoneyCount
            // 
            this.MoneyCount.AutoSize = true;
            this.MoneyCount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyCount.ForeColor = System.Drawing.Color.White;
            this.MoneyCount.Location = new System.Drawing.Point(13, 14);
            this.MoneyCount.Name = "MoneyCount";
            this.MoneyCount.Size = new System.Drawing.Size(87, 27);
            this.MoneyCount.TabIndex = 1;
            this.MoneyCount.Tag = "moneyCounterTag";
            this.MoneyCount.Text = "Argent:";
            // 
            // FragCounter
            // 
            this.FragCounter.AutoSize = true;
            this.FragCounter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FragCounter.ForeColor = System.Drawing.Color.White;
            this.FragCounter.Location = new System.Drawing.Point(13, 55);
            this.FragCounter.Name = "FragCounter";
            this.FragCounter.Size = new System.Drawing.Size(73, 27);
            this.FragCounter.TabIndex = 2;
            this.FragCounter.Tag = "FragCounterTag";
            this.FragCounter.Text = "Score:";
            // 
            // HealthText
            // 
            this.HealthText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthText.AutoSize = true;
            this.HealthText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthText.ForeColor = System.Drawing.Color.White;
            this.HealthText.Location = new System.Drawing.Point(656, 14);
            this.HealthText.Name = "HealthText";
            this.HealthText.Size = new System.Drawing.Size(148, 27);
            this.HealthText.TabIndex = 3;
            this.HealthText.Tag = "HealthTextTag";
            this.HealthText.Text = "Points de vie:";
            // 
            // projectileText
            // 
            this.projectileText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectileText.AutoSize = true;
            this.projectileText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectileText.ForeColor = System.Drawing.Color.White;
            this.projectileText.Location = new System.Drawing.Point(656, 55);
            this.projectileText.Name = "projectileText";
            this.projectileText.Size = new System.Drawing.Size(130, 27);
            this.projectileText.TabIndex = 4;
            this.projectileText.Tag = "projectileTextTag";
            this.projectileText.Text = "Cartouches:";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(815, 17);
            this.HealthBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(331, 23);
            this.HealthBar.TabIndex = 5;
            this.HealthBar.Tag = "HealthBarTag";
            // 
            // ProjectileCounterBar
            // 
            this.ProjectileCounterBar.Location = new System.Drawing.Point(815, 59);
            this.ProjectileCounterBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProjectileCounterBar.Name = "ProjectileCounterBar";
            this.ProjectileCounterBar.Size = new System.Drawing.Size(331, 23);
            this.ProjectileCounterBar.TabIndex = 6;
            this.ProjectileCounterBar.Tag = "ProjectileCounterBarTag";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 20;
            this.MainTimer.Tick += new System.EventHandler(this.clockTickMain);
            // 
            // MonsterCounter
            // 
            this.MonsterCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonsterCounter.AutoSize = true;
            this.MonsterCounter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonsterCounter.ForeColor = System.Drawing.Color.White;
            this.MonsterCounter.Location = new System.Drawing.Point(1387, 14);
            this.MonsterCounter.Name = "MonsterCounter";
            this.MonsterCounter.Size = new System.Drawing.Size(113, 27);
            this.MonsterCounter.TabIndex = 28;
            this.MonsterCounter.Tag = "MonsterCounterTag";
            this.MonsterCounter.Text = "Monstres:";
            // 
            // tree12
            // 
            this.tree12.Image = global::RobotGame.Properties.Resources.tree;
            this.tree12.Location = new System.Drawing.Point(1441, 641);
            this.tree12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree12.Name = "tree12";
            this.tree12.Size = new System.Drawing.Size(64, 64);
            this.tree12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree12.TabIndex = 26;
            this.tree12.TabStop = false;
            this.tree12.Tag = "Tree";
            // 
            // tree11
            // 
            this.tree11.Image = global::RobotGame.Properties.Resources.tree;
            this.tree11.Location = new System.Drawing.Point(891, 452);
            this.tree11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree11.Name = "tree11";
            this.tree11.Size = new System.Drawing.Size(64, 64);
            this.tree11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree11.TabIndex = 25;
            this.tree11.TabStop = false;
            this.tree11.Tag = "Tree";
            // 
            // tree2
            // 
            this.tree2.Image = global::RobotGame.Properties.Resources.tree;
            this.tree2.Location = new System.Drawing.Point(277, 386);
            this.tree2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(64, 64);
            this.tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree2.TabIndex = 24;
            this.tree2.TabStop = false;
            this.tree2.Tag = "Tree";
            // 
            // tree10
            // 
            this.tree10.Image = global::RobotGame.Properties.Resources.tree;
            this.tree10.Location = new System.Drawing.Point(1113, 293);
            this.tree10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree10.Name = "tree10";
            this.tree10.Size = new System.Drawing.Size(64, 64);
            this.tree10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree10.TabIndex = 23;
            this.tree10.TabStop = false;
            this.tree10.Tag = "Tree";
            // 
            // tree8
            // 
            this.tree8.Image = global::RobotGame.Properties.Resources.tree;
            this.tree8.Location = new System.Drawing.Point(36, 116);
            this.tree8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree8.Name = "tree8";
            this.tree8.Size = new System.Drawing.Size(64, 64);
            this.tree8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree8.TabIndex = 22;
            this.tree8.TabStop = false;
            this.tree8.Tag = "Tree";
            // 
            // tree7
            // 
            this.tree7.Image = global::RobotGame.Properties.Resources.tree;
            this.tree7.Location = new System.Drawing.Point(569, 190);
            this.tree7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree7.Name = "tree7";
            this.tree7.Size = new System.Drawing.Size(64, 64);
            this.tree7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree7.TabIndex = 21;
            this.tree7.TabStop = false;
            this.tree7.Tag = "Tree";
            // 
            // Robot
            // 
            this.Robot.Image = global::RobotGame.Properties.Resources.robot;
            this.Robot.Location = new System.Drawing.Point(725, 641);
            this.Robot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Robot.Name = "Robot";
            this.Robot.Size = new System.Drawing.Size(64, 64);
            this.Robot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Robot.TabIndex = 19;
            this.Robot.TabStop = false;
            // 
            // tree5
            // 
            this.tree5.Image = global::RobotGame.Properties.Resources.tree;
            this.tree5.Location = new System.Drawing.Point(1393, 480);
            this.tree5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree5.Name = "tree5";
            this.tree5.Size = new System.Drawing.Size(64, 64);
            this.tree5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree5.TabIndex = 18;
            this.tree5.TabStop = false;
            this.tree5.Tag = "Tree";
            // 
            // tree4
            // 
            this.tree4.Image = global::RobotGame.Properties.Resources.tree;
            this.tree4.Location = new System.Drawing.Point(1441, 81);
            this.tree4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree4.Name = "tree4";
            this.tree4.Size = new System.Drawing.Size(64, 64);
            this.tree4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree4.TabIndex = 17;
            this.tree4.TabStop = false;
            this.tree4.Tag = "Tree";
            // 
            // tree
            // 
            this.tree.Image = global::RobotGame.Properties.Resources.tree;
            this.tree.Location = new System.Drawing.Point(0, 641);
            this.tree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(64, 64);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree.TabIndex = 14;
            this.tree.TabStop = false;
            this.tree.Tag = "Tree";
            // 
            // patern7
            // 
            this.patern7.BackgroundImage = global::RobotGame.Properties.Resources.iron;
            this.patern7.Location = new System.Drawing.Point(1196, 160);
            this.patern7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patern7.Name = "patern7";
            this.patern7.Size = new System.Drawing.Size(341, 79);
            this.patern7.TabIndex = 13;
            this.patern7.TabStop = false;
            // 
            // patern6
            // 
            this.patern6.BackgroundImage = global::RobotGame.Properties.Resources.iron;
            this.patern6.Location = new System.Drawing.Point(1196, 559);
            this.patern6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patern6.Name = "patern6";
            this.patern6.Size = new System.Drawing.Size(256, 79);
            this.patern6.TabIndex = 12;
            this.patern6.TabStop = false;
            // 
            // patern5
            // 
            this.patern5.BackgroundImage = global::RobotGame.Properties.Resources.iron;
            this.patern5.Location = new System.Drawing.Point(1081, 372);
            this.patern5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patern5.Name = "patern5";
            this.patern5.Size = new System.Drawing.Size(257, 79);
            this.patern5.TabIndex = 11;
            this.patern5.TabStop = false;
            // 
            // patern4
            // 
            this.patern4.BackgroundImage = global::RobotGame.Properties.Resources.iron;
            this.patern4.Location = new System.Drawing.Point(712, 530);
            this.patern4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patern4.Name = "patern4";
            this.patern4.Size = new System.Drawing.Size(256, 79);
            this.patern4.TabIndex = 10;
            this.patern4.TabStop = false;
            // 
            // patern3
            // 
            this.patern3.BackgroundImage = global::RobotGame.Properties.Resources.iron;
            this.patern3.Location = new System.Drawing.Point(407, 268);
            this.patern3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patern3.Name = "patern3";
            this.patern3.Size = new System.Drawing.Size(513, 79);
            this.patern3.TabIndex = 9;
            this.patern3.TabStop = false;
            // 
            // patern2
            // 
            this.patern2.BackgroundImage = global::RobotGame.Properties.Resources.iron;
            this.patern2.Location = new System.Drawing.Point(176, 465);
            this.patern2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patern2.Name = "patern2";
            this.patern2.Size = new System.Drawing.Size(341, 79);
            this.patern2.TabIndex = 8;
            this.patern2.TabStop = false;
            // 
            // patern
            // 
            this.patern.BackgroundImage = global::RobotGame.Properties.Resources.iron;
            this.patern.Location = new System.Drawing.Point(19, 194);
            this.patern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patern.Name = "patern";
            this.patern.Size = new System.Drawing.Size(257, 79);
            this.patern.TabIndex = 7;
            this.patern.TabStop = false;
            // 
            // grassBlock
            // 
            this.grassBlock.BackgroundImage = global::RobotGame.Properties.Resources.grass_block;
            this.grassBlock.Location = new System.Drawing.Point(0, 720);
            this.grassBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grassBlock.Name = "grassBlock";
            this.grassBlock.Size = new System.Drawing.Size(1539, 65);
            this.grassBlock.TabIndex = 0;
            this.grassBlock.TabStop = false;
            // 
            // Barrier3
            // 
            this.Barrier3.Location = new System.Drawing.Point(539, 353);
            this.Barrier3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Barrier3.Name = "Barrier3";
            this.Barrier3.Size = new System.Drawing.Size(169, 177);
            this.Barrier3.TabIndex = 30;
            this.Barrier3.TabStop = false;
            this.Barrier3.Tag = "Barrier";
            // 
            // Barrier2
            // 
            this.Barrier2.Location = new System.Drawing.Point(15, 372);
            this.Barrier2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Barrier2.Name = "Barrier2";
            this.Barrier2.Size = new System.Drawing.Size(151, 143);
            this.Barrier2.TabIndex = 31;
            this.Barrier2.TabStop = false;
            this.Barrier2.Tag = "Barrier";
            // 
            // Barrier1
            // 
            this.Barrier1.Location = new System.Drawing.Point(281, 81);
            this.Barrier1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Barrier1.Name = "Barrier1";
            this.Barrier1.Size = new System.Drawing.Size(120, 192);
            this.Barrier1.TabIndex = 33;
            this.Barrier1.TabStop = false;
            this.Barrier1.Tag = "Barrier";
            // 
            // Barrier5
            // 
            this.Barrier5.Location = new System.Drawing.Point(925, 96);
            this.Barrier5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Barrier5.Name = "Barrier5";
            this.Barrier5.Size = new System.Drawing.Size(265, 177);
            this.Barrier5.TabIndex = 34;
            this.Barrier5.TabStop = false;
            this.Barrier5.Tag = "Barrier";
            // 
            // Barrier4
            // 
            this.Barrier4.Location = new System.Drawing.Point(992, 457);
            this.Barrier4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Barrier4.Name = "Barrier4";
            this.Barrier4.Size = new System.Drawing.Size(199, 177);
            this.Barrier4.TabIndex = 35;
            this.Barrier4.TabStop = false;
            this.Barrier4.Tag = "Barrier";
            // 
            // tree14
            // 
            this.tree14.Image = global::RobotGame.Properties.Resources.tree;
            this.tree14.Location = new System.Drawing.Point(363, 386);
            this.tree14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree14.Name = "tree14";
            this.tree14.Size = new System.Drawing.Size(64, 64);
            this.tree14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree14.TabIndex = 36;
            this.tree14.TabStop = false;
            this.tree14.Tag = "Tree";
            // 
            // tree15
            // 
            this.tree15.Image = global::RobotGame.Properties.Resources.tree;
            this.tree15.Location = new System.Drawing.Point(484, 190);
            this.tree15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tree15.Name = "tree15";
            this.tree15.Size = new System.Drawing.Size(64, 64);
            this.tree15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tree15.TabIndex = 37;
            this.tree15.TabStop = false;
            this.tree15.Tag = "Tree";
            // 
            // Barrier6
            // 
            this.Barrier6.Location = new System.Drawing.Point(1344, 268);
            this.Barrier6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Barrier6.Name = "Barrier6";
            this.Barrier6.Size = new System.Drawing.Size(181, 177);
            this.Barrier6.TabIndex = 38;
            this.Barrier6.TabStop = false;
            this.Barrier6.Tag = "Barrier";
            // 
            // playerStatusChecker
            // 
            this.playerStatusChecker.Enabled = true;
            this.playerStatusChecker.Interval = 3000;
            this.playerStatusChecker.Tick += new System.EventHandler(this.detectPlayerStatus);
            // 
            // moneyTimer
            // 
            this.moneyTimer.Enabled = true;
            this.moneyTimer.Interval = 2000;
            this.moneyTimer.Tick += new System.EventHandler(this.spawnMoney);
            // 
            // RobotGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1537, 784);
            this.Controls.Add(this.Barrier6);
            this.Controls.Add(this.tree15);
            this.Controls.Add(this.tree14);
            this.Controls.Add(this.Barrier4);
            this.Controls.Add(this.Barrier5);
            this.Controls.Add(this.Barrier1);
            this.Controls.Add(this.Barrier2);
            this.Controls.Add(this.Barrier3);
            this.Controls.Add(this.MonsterCounter);
            this.Controls.Add(this.tree12);
            this.Controls.Add(this.tree11);
            this.Controls.Add(this.tree2);
            this.Controls.Add(this.tree10);
            this.Controls.Add(this.tree8);
            this.Controls.Add(this.tree7);
            this.Controls.Add(this.Robot);
            this.Controls.Add(this.tree5);
            this.Controls.Add(this.tree4);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.patern7);
            this.Controls.Add(this.patern6);
            this.Controls.Add(this.patern5);
            this.Controls.Add(this.patern4);
            this.Controls.Add(this.patern3);
            this.Controls.Add(this.patern2);
            this.Controls.Add(this.patern);
            this.Controls.Add(this.ProjectileCounterBar);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.projectileText);
            this.Controls.Add(this.HealthText);
            this.Controls.Add(this.FragCounter);
            this.Controls.Add(this.MoneyCount);
            this.Controls.Add(this.grassBlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RobotGameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RobotGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.goPlayer);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopPlayer);
            ((System.ComponentModel.ISupportInitialize)(this.tree12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grassBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrier6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox grassBlock;
        private System.Windows.Forms.Label MoneyCount;
        private System.Windows.Forms.Label FragCounter;
        private System.Windows.Forms.Label HealthText;
        private System.Windows.Forms.Label projectileText;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.ProgressBar ProjectileCounterBar;
        private System.Windows.Forms.PictureBox patern;
        private System.Windows.Forms.PictureBox patern2;
        private System.Windows.Forms.PictureBox patern3;
        private System.Windows.Forms.PictureBox patern4;
        private System.Windows.Forms.PictureBox patern5;
        private System.Windows.Forms.PictureBox patern6;
        private System.Windows.Forms.PictureBox patern7;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox tree4;
        private System.Windows.Forms.PictureBox tree5;
        private System.Windows.Forms.PictureBox Robot;
        private System.Windows.Forms.PictureBox tree7;
        private System.Windows.Forms.PictureBox tree8;
        private System.Windows.Forms.PictureBox tree10;
        private System.Windows.Forms.PictureBox tree2;
        private System.Windows.Forms.PictureBox tree11;
        private System.Windows.Forms.PictureBox tree12;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label MonsterCounter;
        private System.Windows.Forms.PictureBox Barrier3;
        private System.Windows.Forms.PictureBox Barrier2;
        private System.Windows.Forms.PictureBox Barrier1;
        private System.Windows.Forms.PictureBox Barrier5;
        private System.Windows.Forms.PictureBox Barrier4;
        private System.Windows.Forms.PictureBox tree14;
        private System.Windows.Forms.PictureBox tree15;
        private System.Windows.Forms.PictureBox Barrier6;
        private System.Windows.Forms.Timer playerStatusChecker;
        private System.Windows.Forms.Timer moneyTimer;
    }
}

