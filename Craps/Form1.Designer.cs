namespace Craps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSum = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblDisplayMsg = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblInstr2 = new System.Windows.Forms.Label();
            this.lblInstr = new System.Windows.Forms.Label();
            this.btnInstr = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDisplayResult = new System.Windows.Forms.Label();
            this.picDiceNum2 = new System.Windows.Forms.PictureBox();
            this.picDiceNum3 = new System.Windows.Forms.PictureBox();
            this.picDiceNum4 = new System.Windows.Forms.PictureBox();
            this.picDiceNum5 = new System.Windows.Forms.PictureBox();
            this.picDiceNum6 = new System.Windows.Forms.PictureBox();
            this.picDiceNum1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.picDice1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(334, 335);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(40, 17);
            this.lblSum.TabIndex = 29;
            this.lblSum.Text = "Sum:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(88, 290);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(103, 33);
            this.btnNewGame.TabIndex = 28;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGame.Location = new System.Drawing.Point(30, 255);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(240, 20);
            this.lblNewGame.TabIndex = 27;
            this.lblNewGame.Text = "Click here to play a New Game";
            // 
            // lblDisplayMsg
            // 
            this.lblDisplayMsg.AutoSize = true;
            this.lblDisplayMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayMsg.Location = new System.Drawing.Point(530, 162);
            this.lblDisplayMsg.Name = "lblDisplayMsg";
            this.lblDisplayMsg.Size = new System.Drawing.Size(0, 20);
            this.lblDisplayMsg.TabIndex = 26;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(334, 309);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(51, 17);
            this.lblPoints.TabIndex = 25;
            this.lblPoints.Text = "Points:";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(326, 245);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(122, 49);
            this.btnPlay.TabIndex = 24;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblInstr2
            // 
            this.lblInstr2.AutoSize = true;
            this.lblInstr2.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstr2.Location = new System.Drawing.Point(220, 94);
            this.lblInstr2.Name = "lblInstr2";
            this.lblInstr2.Size = new System.Drawing.Size(348, 46);
            this.lblInstr2.TabIndex = 21;
            this.lblInstr2.Text = "Do you want to play Craps?";
            // 
            // lblInstr
            // 
            this.lblInstr.AutoSize = true;
            this.lblInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstr.Location = new System.Drawing.Point(18, 156);
            this.lblInstr.Name = "lblInstr";
            this.lblInstr.Size = new System.Drawing.Size(261, 20);
            this.lblInstr.TabIndex = 20;
            this.lblInstr.Text = "Click here to read the Instructions";
            // 
            // btnInstr
            // 
            this.btnInstr.Location = new System.Drawing.Point(88, 191);
            this.btnInstr.Name = "btnInstr";
            this.btnInstr.Size = new System.Drawing.Size(103, 33);
            this.btnInstr.TabIndex = 19;
            this.btnInstr.Text = "Instructions";
            this.btnInstr.UseVisualStyleBackColor = true;
            this.btnInstr.Click += new System.EventHandler(this.btnInstr_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Chiller", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(310, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 92);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Craps";
            // 
            // lblDisplayResult
            // 
            this.lblDisplayResult.AutoSize = true;
            this.lblDisplayResult.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayResult.Location = new System.Drawing.Point(309, 403);
            this.lblDisplayResult.Name = "lblDisplayResult";
            this.lblDisplayResult.Size = new System.Drawing.Size(0, 33);
            this.lblDisplayResult.TabIndex = 36;
            // 
            // picDiceNum2
            // 
            this.picDiceNum2.Image = global::Craps.Properties.Resources.two;
            this.picDiceNum2.Location = new System.Drawing.Point(59, 403);
            this.picDiceNum2.Name = "picDiceNum2";
            this.picDiceNum2.Size = new System.Drawing.Size(35, 37);
            this.picDiceNum2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiceNum2.TabIndex = 35;
            this.picDiceNum2.TabStop = false;
            // 
            // picDiceNum3
            // 
            this.picDiceNum3.Image = global::Craps.Properties.Resources.three;
            this.picDiceNum3.Location = new System.Drawing.Point(100, 403);
            this.picDiceNum3.Name = "picDiceNum3";
            this.picDiceNum3.Size = new System.Drawing.Size(35, 37);
            this.picDiceNum3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiceNum3.TabIndex = 34;
            this.picDiceNum3.TabStop = false;
            // 
            // picDiceNum4
            // 
            this.picDiceNum4.Image = global::Craps.Properties.Resources.four;
            this.picDiceNum4.Location = new System.Drawing.Point(141, 403);
            this.picDiceNum4.Name = "picDiceNum4";
            this.picDiceNum4.Size = new System.Drawing.Size(35, 37);
            this.picDiceNum4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiceNum4.TabIndex = 33;
            this.picDiceNum4.TabStop = false;
            // 
            // picDiceNum5
            // 
            this.picDiceNum5.Image = global::Craps.Properties.Resources.five;
            this.picDiceNum5.Location = new System.Drawing.Point(182, 403);
            this.picDiceNum5.Name = "picDiceNum5";
            this.picDiceNum5.Size = new System.Drawing.Size(35, 37);
            this.picDiceNum5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiceNum5.TabIndex = 32;
            this.picDiceNum5.TabStop = false;
            // 
            // picDiceNum6
            // 
            this.picDiceNum6.Image = global::Craps.Properties.Resources.six;
            this.picDiceNum6.Location = new System.Drawing.Point(223, 403);
            this.picDiceNum6.Name = "picDiceNum6";
            this.picDiceNum6.Size = new System.Drawing.Size(35, 37);
            this.picDiceNum6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiceNum6.TabIndex = 31;
            this.picDiceNum6.TabStop = false;
            // 
            // picDiceNum1
            // 
            this.picDiceNum1.Image = global::Craps.Properties.Resources.one;
            this.picDiceNum1.Location = new System.Drawing.Point(18, 403);
            this.picDiceNum1.Name = "picDiceNum1";
            this.picDiceNum1.Size = new System.Drawing.Size(35, 37);
            this.picDiceNum1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiceNum1.TabIndex = 30;
            this.picDiceNum1.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.Location = new System.Drawing.Point(427, 162);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(80, 71);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 23;
            this.picDice2.TabStop = false;
            // 
            // picDice1
            // 
            this.picDice1.Location = new System.Drawing.Point(326, 162);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(85, 71);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 22;
            this.picDice1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayResult);
            this.Controls.Add(this.picDiceNum2);
            this.Controls.Add(this.picDiceNum3);
            this.Controls.Add(this.picDiceNum4);
            this.Controls.Add(this.picDiceNum5);
            this.Controls.Add(this.picDiceNum6);
            this.Controls.Add(this.picDiceNum1);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblNewGame);
            this.Controls.Add(this.lblDisplayMsg);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Controls.Add(this.lblInstr2);
            this.Controls.Add(this.lblInstr);
            this.Controls.Add(this.btnInstr);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Play Craps";
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiceNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDiceNum2;
        private System.Windows.Forms.PictureBox picDiceNum3;
        private System.Windows.Forms.PictureBox picDiceNum4;
        private System.Windows.Forms.PictureBox picDiceNum5;
        private System.Windows.Forms.PictureBox picDiceNum6;
        private System.Windows.Forms.PictureBox picDiceNum1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblDisplayMsg;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.Label lblInstr2;
        private System.Windows.Forms.Label lblInstr;
        private System.Windows.Forms.Button btnInstr;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDisplayResult;
    }
}

