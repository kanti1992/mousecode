﻿namespace mysz
{
    partial class ThingsGameWindow
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
            this.answerRButton = new System.Windows.Forms.Button();
            this.gameWindow = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.endGameLabel = new System.Windows.Forms.Label();
            this.timeTextLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.answerLButton = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // answerRButton
            // 
            this.answerRButton.Location = new System.Drawing.Point(872, 31);
            this.answerRButton.Name = "answerRButton";
            this.answerRButton.Size = new System.Drawing.Size(100, 23);
            this.answerRButton.TabIndex = 17;
            this.answerRButton.Text = "Answer";
            this.answerRButton.UseVisualStyleBackColor = true;
            this.answerRButton.Click += new System.EventHandler(this.stopRButton_Click);
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
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(522, 607);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 24);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // endGameLabel
            // 
            this.endGameLabel.AutoSize = true;
            this.endGameLabel.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameLabel.Location = new System.Drawing.Point(9, 591);
            this.endGameLabel.Name = "endGameLabel";
            this.endGameLabel.Size = new System.Drawing.Size(85, 40);
            this.endGameLabel.TabIndex = 22;
            this.endGameLabel.Text = "End game";
            this.endGameLabel.Click += new System.EventHandler(this.exitGame);
            this.endGameLabel.MouseEnter += new System.EventHandler(this.highlightLabel);
            this.endGameLabel.MouseLeave += new System.EventHandler(this.removeHighlightLabel);
            // 
            // timeTextLabel
            // 
            this.timeTextLabel.AutoSize = true;
            this.timeTextLabel.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextLabel.Location = new System.Drawing.Point(12, 31);
            this.timeTextLabel.Name = "timeTextLabel";
            this.timeTextLabel.Size = new System.Drawing.Size(80, 40);
            this.timeTextLabel.TabIndex = 25;
            this.timeTextLabel.Text = "Time left:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(16, 71);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 21);
            this.timeLabel.TabIndex = 24;
            this.timeLabel.Text = "time";
            this.timeLabel.Visible = false;
            // 
            // answerLButton
            // 
            this.answerLButton.Location = new System.Drawing.Point(172, 31);
            this.answerLButton.Name = "answerLButton";
            this.answerLButton.Size = new System.Drawing.Size(100, 23);
            this.answerLButton.TabIndex = 26;
            this.answerLButton.Text = "Answer";
            this.answerLButton.UseVisualStyleBackColor = true;
            this.answerLButton.Click += new System.EventHandler(this.stopLButton_Click);
            // 
            // questionBox
            // 
            this.questionBox.BackColor = System.Drawing.Color.White;
            this.questionBox.Location = new System.Drawing.Point(472, 50);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(200, 200);
            this.questionBox.TabIndex = 27;
            this.questionBox.TabStop = false;
            // 
            // ThingsGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.answerLButton);
            this.Controls.Add(this.timeTextLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.endGameLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.answerRButton);
            this.Controls.Add(this.gameWindow);
            this.Location = new System.Drawing.Point(172, 41);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "ThingsGameWindow";
            this.Text = "ReflexGameWindow";
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerRButton;
        private System.Windows.Forms.PictureBox gameWindow;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label endGameLabel;
        private System.Windows.Forms.Label timeTextLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button answerLButton;
        private System.Windows.Forms.PictureBox questionBox;
    }
}