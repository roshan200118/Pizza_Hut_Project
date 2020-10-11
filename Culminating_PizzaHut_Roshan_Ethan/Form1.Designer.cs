namespace Culminating_PizzaHut_Roshan_Ethan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTomatoSauce = new System.Windows.Forms.Button();
            this.btnSriLankanSauce = new System.Windows.Forms.Button();
            this.btnPepperoni = new System.Windows.Forms.Button();
            this.btnCheese = new System.Windows.Forms.Button();
            this.btnChicken = new System.Windows.Forms.Button();
            this.btnOnion = new System.Windows.Forms.Button();
            this.tmrPizzaSpeed = new System.Windows.Forms.Timer(this.components);
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picChicken = new System.Windows.Forms.PictureBox();
            this.picSriLankanSauce = new System.Windows.Forms.PictureBox();
            this.picTomatoSauce = new System.Windows.Forms.PictureBox();
            this.picOnion = new System.Windows.Forms.PictureBox();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.picPepperoni = new System.Windows.Forms.PictureBox();
            this.tmrSeconds = new System.Windows.Forms.Timer(this.components);
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblOrderPromt = new System.Windows.Forms.Label();
            this.pnlHomeScreen = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.picExitGame = new System.Windows.Forms.PictureBox();
            this.picTutorial = new System.Windows.Forms.PictureBox();
            this.picStartGame = new System.Windows.Forms.PictureBox();
            this.pnlLoseScreen = new System.Windows.Forms.Panel();
            this.picPlayAgain = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSriLankanSauce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomatoSauce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPepperoni)).BeginInit();
            this.pnlHomeScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExitGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTutorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStartGame)).BeginInit();
            this.pnlLoseScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayAgain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTomatoSauce
            // 
            this.btnTomatoSauce.BackColor = System.Drawing.Color.Red;
            this.btnTomatoSauce.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomatoSauce.Location = new System.Drawing.Point(318, 6);
            this.btnTomatoSauce.Name = "btnTomatoSauce";
            this.btnTomatoSauce.Size = new System.Drawing.Size(72, 35);
            this.btnTomatoSauce.TabIndex = 0;
            this.btnTomatoSauce.Text = "Tomato Sauce";
            this.btnTomatoSauce.UseVisualStyleBackColor = false;
            this.btnTomatoSauce.Click += new System.EventHandler(this.btnTomatoSauce_Click);
            // 
            // btnSriLankanSauce
            // 
            this.btnSriLankanSauce.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSriLankanSauce.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSriLankanSauce.Location = new System.Drawing.Point(423, 6);
            this.btnSriLankanSauce.Name = "btnSriLankanSauce";
            this.btnSriLankanSauce.Size = new System.Drawing.Size(72, 35);
            this.btnSriLankanSauce.TabIndex = 1;
            this.btnSriLankanSauce.Text = "Spicy SriLankan Sauce";
            this.btnSriLankanSauce.UseVisualStyleBackColor = false;
            this.btnSriLankanSauce.Click += new System.EventHandler(this.btnSriLankanSauce_Click);
            // 
            // btnPepperoni
            // 
            this.btnPepperoni.BackColor = System.Drawing.Color.DarkRed;
            this.btnPepperoni.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPepperoni.Location = new System.Drawing.Point(640, 6);
            this.btnPepperoni.Name = "btnPepperoni";
            this.btnPepperoni.Size = new System.Drawing.Size(72, 35);
            this.btnPepperoni.TabIndex = 2;
            this.btnPepperoni.Text = "Pepperoni";
            this.btnPepperoni.UseVisualStyleBackColor = false;
            this.btnPepperoni.Click += new System.EventHandler(this.btnPepperoni_Click);
            // 
            // btnCheese
            // 
            this.btnCheese.BackColor = System.Drawing.Color.Gold;
            this.btnCheese.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheese.Location = new System.Drawing.Point(540, 6);
            this.btnCheese.Name = "btnCheese";
            this.btnCheese.Size = new System.Drawing.Size(72, 35);
            this.btnCheese.TabIndex = 3;
            this.btnCheese.Text = "Cheese";
            this.btnCheese.UseVisualStyleBackColor = false;
            this.btnCheese.Click += new System.EventHandler(this.btnCheese_Click);
            // 
            // btnChicken
            // 
            this.btnChicken.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnChicken.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChicken.Location = new System.Drawing.Point(757, 6);
            this.btnChicken.Name = "btnChicken";
            this.btnChicken.Size = new System.Drawing.Size(72, 35);
            this.btnChicken.TabIndex = 4;
            this.btnChicken.Text = "Chicken";
            this.btnChicken.UseVisualStyleBackColor = false;
            this.btnChicken.Click += new System.EventHandler(this.btnChicken_Click);
            // 
            // btnOnion
            // 
            this.btnOnion.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnOnion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnion.Location = new System.Drawing.Point(859, 6);
            this.btnOnion.Name = "btnOnion";
            this.btnOnion.Size = new System.Drawing.Size(72, 35);
            this.btnOnion.TabIndex = 5;
            this.btnOnion.Text = "Onion";
            this.btnOnion.UseVisualStyleBackColor = false;
            this.btnOnion.Click += new System.EventHandler(this.btnOnion_Click);
            // 
            // tmrPizzaSpeed
            // 
            this.tmrPizzaSpeed.Enabled = true;
            this.tmrPizzaSpeed.Interval = 25;
            this.tmrPizzaSpeed.Tick += new System.EventHandler(this.tmrPizzaSpeed_Tick);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(50, 139);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(74, 29);
            this.lblOrder.TabIndex = 7;
            this.lblOrder.Text = "Order";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(44, 49);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 29);
            this.lblScore.TabIndex = 20;
            this.lblScore.Text = "Score";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(44, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picCheese
            // 
            this.picCheese.BackColor = System.Drawing.Color.Transparent;
            this.picCheese.Image = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.CheeseTrans;
            this.picCheese.Location = new System.Drawing.Point(540, 87);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(72, 25);
            this.picCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheese.TabIndex = 16;
            this.picCheese.TabStop = false;
            // 
            // picChicken
            // 
            this.picChicken.BackColor = System.Drawing.Color.Transparent;
            this.picChicken.Image = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.Chicken2;
            this.picChicken.Location = new System.Drawing.Point(756, 86);
            this.picChicken.Name = "picChicken";
            this.picChicken.Size = new System.Drawing.Size(67, 34);
            this.picChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChicken.TabIndex = 18;
            this.picChicken.TabStop = false;
            // 
            // picSriLankanSauce
            // 
            this.picSriLankanSauce.BackColor = System.Drawing.Color.Transparent;
            this.picSriLankanSauce.Image = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.SpicySauceDrop;
            this.picSriLankanSauce.Location = new System.Drawing.Point(406, 95);
            this.picSriLankanSauce.Name = "picSriLankanSauce";
            this.picSriLankanSauce.Size = new System.Drawing.Size(109, 42);
            this.picSriLankanSauce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSriLankanSauce.TabIndex = 15;
            this.picSriLankanSauce.TabStop = false;
            // 
            // picTomatoSauce
            // 
            this.picTomatoSauce.BackColor = System.Drawing.Color.Transparent;
            this.picTomatoSauce.Image = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.TomatoDrop;
            this.picTomatoSauce.Location = new System.Drawing.Point(302, 98);
            this.picTomatoSauce.Name = "picTomatoSauce";
            this.picTomatoSauce.Size = new System.Drawing.Size(109, 41);
            this.picTomatoSauce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTomatoSauce.TabIndex = 14;
            this.picTomatoSauce.TabStop = false;
            // 
            // picOnion
            // 
            this.picOnion.BackColor = System.Drawing.Color.Transparent;
            this.picOnion.Image = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.Onion;
            this.picOnion.Location = new System.Drawing.Point(869, 87);
            this.picOnion.Name = "picOnion";
            this.picOnion.Size = new System.Drawing.Size(60, 29);
            this.picOnion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOnion.TabIndex = 13;
            this.picOnion.TabStop = false;
            // 
            // picPizza
            // 
            this.picPizza.BackColor = System.Drawing.Color.Transparent;
            this.picPizza.Image = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.Pizza1;
            this.picPizza.Location = new System.Drawing.Point(12, 426);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(107, 44);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 6;
            this.picPizza.TabStop = false;
            // 
            // picPepperoni
            // 
            this.picPepperoni.BackColor = System.Drawing.Color.Transparent;
            this.picPepperoni.Image = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.Pepperoni;
            this.picPepperoni.Location = new System.Drawing.Point(638, 79);
            this.picPepperoni.Name = "picPepperoni";
            this.picPepperoni.Size = new System.Drawing.Size(72, 42);
            this.picPepperoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPepperoni.TabIndex = 17;
            this.picPepperoni.TabStop = false;
            // 
            // tmrSeconds
            // 
            this.tmrSeconds.Enabled = true;
            this.tmrSeconds.Interval = 1000;
            this.tmrSeconds.Tick += new System.EventHandler(this.tmrSeconds_Tick);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(50, 13);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(95, 29);
            this.lblSeconds.TabIndex = 24;
            this.lblSeconds.Text = "Seconds";
            // 
            // lblOrderPromt
            // 
            this.lblOrderPromt.AutoSize = true;
            this.lblOrderPromt.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderPromt.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPromt.Location = new System.Drawing.Point(49, 110);
            this.lblOrderPromt.Name = "lblOrderPromt";
            this.lblOrderPromt.Size = new System.Drawing.Size(80, 29);
            this.lblOrderPromt.TabIndex = 25;
            this.lblOrderPromt.Text = "Order:";
            // 
            // pnlHomeScreen
            // 
            this.pnlHomeScreen.BackColor = System.Drawing.Color.White;
            this.pnlHomeScreen.BackgroundImage = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.StartMenu;
            this.pnlHomeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHomeScreen.Controls.Add(this.lblInstructions);
            this.pnlHomeScreen.Controls.Add(this.picExitGame);
            this.pnlHomeScreen.Controls.Add(this.picTutorial);
            this.pnlHomeScreen.Controls.Add(this.picStartGame);
            this.pnlHomeScreen.Location = new System.Drawing.Point(844, 471);
            this.pnlHomeScreen.Name = "pnlHomeScreen";
            this.pnlHomeScreen.Size = new System.Drawing.Size(956, 510);
            this.pnlHomeScreen.TabIndex = 26;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 25);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(82, 18);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Instructions";
            // 
            // picExitGame
            // 
            this.picExitGame.BackColor = System.Drawing.Color.Transparent;
            this.picExitGame.Location = new System.Drawing.Point(616, 420);
            this.picExitGame.Name = "picExitGame";
            this.picExitGame.Size = new System.Drawing.Size(194, 50);
            this.picExitGame.TabIndex = 2;
            this.picExitGame.TabStop = false;
            this.picExitGame.Click += new System.EventHandler(this.picExitGame_Click);
            // 
            // picTutorial
            // 
            this.picTutorial.BackColor = System.Drawing.Color.Transparent;
            this.picTutorial.Location = new System.Drawing.Point(616, 325);
            this.picTutorial.Name = "picTutorial";
            this.picTutorial.Size = new System.Drawing.Size(194, 50);
            this.picTutorial.TabIndex = 1;
            this.picTutorial.TabStop = false;
            this.picTutorial.Click += new System.EventHandler(this.picTutorial_Click);
            // 
            // picStartGame
            // 
            this.picStartGame.BackColor = System.Drawing.Color.Transparent;
            this.picStartGame.Location = new System.Drawing.Point(616, 249);
            this.picStartGame.Name = "picStartGame";
            this.picStartGame.Size = new System.Drawing.Size(194, 50);
            this.picStartGame.TabIndex = 0;
            this.picStartGame.TabStop = false;
            this.picStartGame.Click += new System.EventHandler(this.picStartGame_Click);
            // 
            // pnlLoseScreen
            // 
            this.pnlLoseScreen.BackColor = System.Drawing.Color.White;
            this.pnlLoseScreen.BackgroundImage = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.LoserScreen;
            this.pnlLoseScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoseScreen.Controls.Add(this.picPlayAgain);
            this.pnlLoseScreen.Location = new System.Drawing.Point(869, 414);
            this.pnlLoseScreen.Name = "pnlLoseScreen";
            this.pnlLoseScreen.Size = new System.Drawing.Size(954, 514);
            this.pnlLoseScreen.TabIndex = 27;
            // 
            // picPlayAgain
            // 
            this.picPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.picPlayAgain.Location = new System.Drawing.Point(370, 345);
            this.picPlayAgain.Name = "picPlayAgain";
            this.picPlayAgain.Size = new System.Drawing.Size(242, 63);
            this.picPlayAgain.TabIndex = 0;
            this.picPlayAgain.TabStop = false;
            this.picPlayAgain.Click += new System.EventHandler(this.picPlayAgain_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Red;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(186, 320);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 28);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Culminating_PizzaHut_Roshan_Ethan.Properties.Resources.PizzaHutBackgroundGood2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 509);
            this.Controls.Add(this.pnlHomeScreen);
            this.Controls.Add(this.picOnion);
            this.Controls.Add(this.pnlLoseScreen);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblOrderPromt);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picChicken);
            this.Controls.Add(this.picSriLankanSauce);
            this.Controls.Add(this.picTomatoSauce);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.btnOnion);
            this.Controls.Add(this.btnChicken);
            this.Controls.Add(this.btnCheese);
            this.Controls.Add(this.btnPepperoni);
            this.Controls.Add(this.btnSriLankanSauce);
            this.Controls.Add(this.btnTomatoSauce);
            this.Controls.Add(this.picPepperoni);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSriLankanSauce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomatoSauce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPepperoni)).EndInit();
            this.pnlHomeScreen.ResumeLayout(false);
            this.pnlHomeScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExitGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTutorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStartGame)).EndInit();
            this.pnlLoseScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayAgain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTomatoSauce;
        private System.Windows.Forms.Button btnSriLankanSauce;
        private System.Windows.Forms.Button btnPepperoni;
        private System.Windows.Forms.Button btnCheese;
        private System.Windows.Forms.Button btnChicken;
        private System.Windows.Forms.Button btnOnion;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.Timer tmrPizzaSpeed;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.PictureBox picOnion;
        private System.Windows.Forms.PictureBox picTomatoSauce;
        private System.Windows.Forms.PictureBox picSriLankanSauce;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picPepperoni;
        private System.Windows.Forms.PictureBox picChicken;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer tmrSeconds;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblOrderPromt;
        private System.Windows.Forms.Panel pnlHomeScreen;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox picExitGame;
        private System.Windows.Forms.PictureBox picTutorial;
        private System.Windows.Forms.PictureBox picStartGame;
        private System.Windows.Forms.Panel pnlLoseScreen;
        private System.Windows.Forms.PictureBox picPlayAgain;
        private System.Windows.Forms.Button btnHome;
    }
}

