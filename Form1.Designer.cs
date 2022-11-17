namespace egg_catcher_game
{
    partial class gameBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eggBasket1 = new System.Windows.Forms.PictureBox();
            this.eggBasket2 = new System.Windows.Forms.PictureBox();
            this.eggBasket3 = new System.Windows.Forms.PictureBox();
            this.egg = new System.Windows.Forms.PictureBox();
            this.timer_basket1 = new System.Windows.Forms.Timer(this.components);
            this.timer_basket2 = new System.Windows.Forms.Timer(this.components);
            this.timer_basket3 = new System.Windows.Forms.Timer(this.components);
            this.timer_eggFall = new System.Windows.Forms.Timer(this.components);
            this.timer_eggBasketMove = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblEggsLeft = new System.Windows.Forms.Label();
            this.cover = new System.Windows.Forms.PictureBox();
            this.cloud = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eggBasket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eggBasket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eggBasket3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            this.SuspendLayout();
            // 
            // eggBasket1
            // 
            this.eggBasket1.BackColor = System.Drawing.Color.Transparent;
            this.eggBasket1.Image = global::egg_catcher_game.Properties.Resources.egg_basket;
            this.eggBasket1.Location = new System.Drawing.Point(0, 315);
            this.eggBasket1.Margin = new System.Windows.Forms.Padding(0);
            this.eggBasket1.Name = "eggBasket1";
            this.eggBasket1.Size = new System.Drawing.Size(70, 36);
            this.eggBasket1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eggBasket1.TabIndex = 0;
            this.eggBasket1.TabStop = false;
            // 
            // eggBasket2
            // 
            this.eggBasket2.BackColor = System.Drawing.Color.Transparent;
            this.eggBasket2.Image = global::egg_catcher_game.Properties.Resources.egg_basket;
            this.eggBasket2.Location = new System.Drawing.Point(0, 185);
            this.eggBasket2.Margin = new System.Windows.Forms.Padding(0);
            this.eggBasket2.Name = "eggBasket2";
            this.eggBasket2.Size = new System.Drawing.Size(70, 36);
            this.eggBasket2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eggBasket2.TabIndex = 1;
            this.eggBasket2.TabStop = false;
            // 
            // eggBasket3
            // 
            this.eggBasket3.BackColor = System.Drawing.Color.Transparent;
            this.eggBasket3.Image = global::egg_catcher_game.Properties.Resources.egg_basket;
            this.eggBasket3.Location = new System.Drawing.Point(0, 55);
            this.eggBasket3.Margin = new System.Windows.Forms.Padding(0);
            this.eggBasket3.Name = "eggBasket3";
            this.eggBasket3.Size = new System.Drawing.Size(70, 36);
            this.eggBasket3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eggBasket3.TabIndex = 2;
            this.eggBasket3.TabStop = false;
            // 
            // egg
            // 
            this.egg.BackColor = System.Drawing.Color.Transparent;
            this.egg.Image = global::egg_catcher_game.Properties.Resources.egg_cropped;
            this.egg.Location = new System.Drawing.Point(156, 445);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(35, 36);
            this.egg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg.TabIndex = 3;
            this.egg.TabStop = false;
            // 
            // timer_basket1
            // 
            this.timer_basket1.Enabled = true;
            this.timer_basket1.Interval = 10;
            this.timer_basket1.Tick += new System.EventHandler(this.timer_basket1_Tick);
            // 
            // timer_basket2
            // 
            this.timer_basket2.Enabled = true;
            this.timer_basket2.Interval = 10;
            this.timer_basket2.Tick += new System.EventHandler(this.timer_basket2_Tick);
            // 
            // timer_basket3
            // 
            this.timer_basket3.Enabled = true;
            this.timer_basket3.Interval = 10;
            this.timer_basket3.Tick += new System.EventHandler(this.timer_basket3_Tick);
            // 
            // timer_eggFall
            // 
            this.timer_eggFall.Interval = 10;
            this.timer_eggFall.Tick += new System.EventHandler(this.timer_eggFall_Tick);
            // 
            // timer_eggBasketMove
            // 
            this.timer_eggBasketMove.Interval = 10;
            this.timer_eggBasketMove.Tick += new System.EventHandler(this.timer_eggBasketMove_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.Green;
            this.lblScore.Location = new System.Drawing.Point(309, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 26);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "00";
            // 
            // lblEggsLeft
            // 
            this.lblEggsLeft.AutoSize = true;
            this.lblEggsLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblEggsLeft.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEggsLeft.ForeColor = System.Drawing.Color.Red;
            this.lblEggsLeft.Location = new System.Drawing.Point(247, 9);
            this.lblEggsLeft.Name = "lblEggsLeft";
            this.lblEggsLeft.Size = new System.Drawing.Size(38, 26);
            this.lblEggsLeft.TabIndex = 5;
            this.lblEggsLeft.Text = "00";
            // 
            // cover
            // 
            this.cover.BackColor = System.Drawing.Color.Transparent;
            this.cover.Image = global::egg_catcher_game.Properties.Resources.win2;
            this.cover.Location = new System.Drawing.Point(324, 445);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(358, 481);
            this.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cover.TabIndex = 6;
            this.cover.TabStop = false;
            this.cover.Visible = false;
            // 
            // cloud
            // 
            this.cloud.BackColor = System.Drawing.Color.Transparent;
            this.cloud.Image = global::egg_catcher_game.Properties.Resources.cloud1;
            this.cloud.Location = new System.Drawing.Point(218, 107);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(273, 55);
            this.cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud.TabIndex = 7;
            this.cloud.TabStop = false;
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.Image = global::egg_catcher_game.Properties.Resources.cloud1;
            this.cloud2.Location = new System.Drawing.Point(-134, 236);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(273, 55);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud2.TabIndex = 8;
            this.cloud2.TabStop = false;
            // 
            // gameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(359, 481);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud);
            this.Controls.Add(this.cover);
            this.Controls.Add(this.lblEggsLeft);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.eggBasket3);
            this.Controls.Add(this.eggBasket2);
            this.Controls.Add(this.eggBasket1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "gameBoard";
            this.Text = "Egg Catcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameBoard_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.eggBasket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eggBasket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eggBasket3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox eggBasket1;
        private PictureBox eggBasket2;
        private PictureBox eggBasket3;
        private PictureBox egg;
        private System.Windows.Forms.Timer timer_basket1;
        private System.Windows.Forms.Timer timer_basket2;
        private System.Windows.Forms.Timer timer_basket3;
        private System.Windows.Forms.Timer timer_eggFall;
        private System.Windows.Forms.Timer timer_eggBasketMove;
        private Label lblScore;
        private Label lblEggsLeft;
        private PictureBox cover;
        private PictureBox cloud;
        private PictureBox cloud2;
    }
}