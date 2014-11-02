﻿namespace mysz
{
    partial class ColorsGameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorsGameWindow));
            this.gameWindow = new System.Windows.Forms.PictureBox();
            this.timeTextLabel = new System.Windows.Forms.Label();
            this.endGameLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreNumber = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // gameWindow
            // 
            this.gameWindow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameWindow.Location = new System.Drawing.Point(172, 31);
            this.gameWindow.Name = "gameWindow";
            this.gameWindow.Size = new System.Drawing.Size(800, 600);
            this.gameWindow.TabIndex = 15;
            this.gameWindow.TabStop = false;
            // 
            // timeTextLabel
            // 
            this.timeTextLabel.AutoSize = true;
            this.timeTextLabel.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextLabel.Location = new System.Drawing.Point(12, 31);
            this.timeTextLabel.Name = "timeTextLabel";
            this.timeTextLabel.Size = new System.Drawing.Size(51, 40);
            this.timeTextLabel.TabIndex = 29;
            this.timeTextLabel.Text = "Time";
            // 
            // endGameLabel
            // 
            this.endGameLabel.AutoSize = true;
            this.endGameLabel.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameLabel.Location = new System.Drawing.Point(9, 591);
            this.endGameLabel.Name = "endGameLabel";
            this.endGameLabel.Size = new System.Drawing.Size(85, 40);
            this.endGameLabel.TabIndex = 26;
            this.endGameLabel.Text = "End game";
            this.endGameLabel.Click += new System.EventHandler(this.endGame);
            this.endGameLabel.MouseEnter += new System.EventHandler(this.highlightLabel);
            this.endGameLabel.MouseLeave += new System.EventHandler(this.removeHighlightLabel);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(32, 71);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(29, 15);
            this.minutesLabel.TabIndex = 30;
            this.minutesLabel.Text = "time";
            this.minutesLabel.Visible = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Font = new System.Drawing.Font("Iskoola Pota", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(480, 270);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(198, 136);
            this.playButton.TabIndex = 31;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(172, 549);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(118, 82);
            this.yesButton.TabIndex = 32;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(854, 549);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(118, 82);
            this.noButton.TabIndex = 33;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 379);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(53, 40);
            this.scoreLabel.TabIndex = 35;
            this.scoreLabel.Text = "Score";
            // 
            // scoreNumber
            // 
            this.scoreNumber.AutoSize = true;
            this.scoreNumber.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNumber.Location = new System.Drawing.Point(28, 408);
            this.scoreNumber.Name = "scoreNumber";
            this.scoreNumber.Size = new System.Drawing.Size(26, 40);
            this.scoreNumber.TabIndex = 37;
            this.scoreNumber.Text = "0";
            this.scoreNumber.Visible = false;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(51, 71);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(29, 15);
            this.secondsLabel.TabIndex = 38;
            this.secondsLabel.Text = "time";
            this.secondsLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = ":";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ColorsGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.scoreNumber);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.timeTextLabel);
            this.Controls.Add(this.endGameLabel);
            this.Controls.Add(this.gameWindow);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "ColorsGameWindow";
            this.Text = "ColorsGameWindow";
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameWindow;
        private System.Windows.Forms.Label timeTextLabel;
        private System.Windows.Forms.Label endGameLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreNumber;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;

    }
}