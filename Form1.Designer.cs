namespace Tic_Tac_Toe
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
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.xo1 = new System.Windows.Forms.Button();
            this.xo2 = new System.Windows.Forms.Button();
            this.xo3 = new System.Windows.Forms.Button();
            this.xo6 = new System.Windows.Forms.Button();
            this.xo5 = new System.Windows.Forms.Button();
            this.xo4 = new System.Windows.Forms.Button();
            this.xo9 = new System.Windows.Forms.Button();
            this.xo8 = new System.Windows.Forms.Button();
            this.xo7 = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1TextBox
            // 
            this.player1TextBox.AccessibleDescription = "";
            this.player1TextBox.Location = new System.Drawing.Point(12, 54);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(136, 20);
            this.player1TextBox.TabIndex = 0;
            this.player1TextBox.Tag = "";
            this.player1TextBox.Text = "Player1";
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(189, 54);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(136, 20);
            this.player2TextBox.TabIndex = 1;
            this.player2TextBox.Text = "Player2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Players Name";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 94);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(313, 38);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(9, 28);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(61, 13);
            this.player1Label.TabIndex = 4;
            this.player1Label.Text = "Player 1 (X)";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(197, 28);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(62, 13);
            this.player2Label.TabIndex = 5;
            this.player2Label.Text = "Player 2 (O)";
            // 
            // xo1
            // 
            this.xo1.Location = new System.Drawing.Point(12, 147);
            this.xo1.Name = "xo1";
            this.xo1.Size = new System.Drawing.Size(100, 55);
            this.xo1.TabIndex = 6;
            this.xo1.Text = "-";
            this.xo1.UseVisualStyleBackColor = true;
            this.xo1.Visible = false;
            this.xo1.Click += new System.EventHandler(this.game_Click);
            // 
            // xo2
            // 
            this.xo2.Location = new System.Drawing.Point(118, 147);
            this.xo2.Name = "xo2";
            this.xo2.Size = new System.Drawing.Size(100, 55);
            this.xo2.TabIndex = 7;
            this.xo2.Text = "-";
            this.xo2.UseVisualStyleBackColor = true;
            this.xo2.Visible = false;
            this.xo2.Click += new System.EventHandler(this.game_Click);
            this.xo2.Resize += new System.EventHandler(this.xo2_Resize);
            // 
            // xo3
            // 
            this.xo3.Location = new System.Drawing.Point(224, 147);
            this.xo3.Name = "xo3";
            this.xo3.Size = new System.Drawing.Size(100, 55);
            this.xo3.TabIndex = 8;
            this.xo3.Text = "-";
            this.xo3.UseVisualStyleBackColor = true;
            this.xo3.Visible = false;
            this.xo3.Click += new System.EventHandler(this.game_Click);
            // 
            // xo6
            // 
            this.xo6.Location = new System.Drawing.Point(225, 208);
            this.xo6.Name = "xo6";
            this.xo6.Size = new System.Drawing.Size(100, 55);
            this.xo6.TabIndex = 11;
            this.xo6.Text = "-";
            this.xo6.UseVisualStyleBackColor = true;
            this.xo6.Visible = false;
            this.xo6.Click += new System.EventHandler(this.game_Click);
            // 
            // xo5
            // 
            this.xo5.Location = new System.Drawing.Point(119, 208);
            this.xo5.Name = "xo5";
            this.xo5.Size = new System.Drawing.Size(100, 55);
            this.xo5.TabIndex = 10;
            this.xo5.Text = "-";
            this.xo5.UseVisualStyleBackColor = true;
            this.xo5.Visible = false;
            this.xo5.Click += new System.EventHandler(this.game_Click);
            // 
            // xo4
            // 
            this.xo4.Location = new System.Drawing.Point(13, 208);
            this.xo4.Name = "xo4";
            this.xo4.Size = new System.Drawing.Size(100, 55);
            this.xo4.TabIndex = 9;
            this.xo4.Text = "-";
            this.xo4.UseVisualStyleBackColor = true;
            this.xo4.Visible = false;
            this.xo4.Click += new System.EventHandler(this.game_Click);
            // 
            // xo9
            // 
            this.xo9.Location = new System.Drawing.Point(225, 269);
            this.xo9.Name = "xo9";
            this.xo9.Size = new System.Drawing.Size(100, 55);
            this.xo9.TabIndex = 14;
            this.xo9.Text = "-";
            this.xo9.UseVisualStyleBackColor = true;
            this.xo9.Visible = false;
            this.xo9.Click += new System.EventHandler(this.game_Click);
            // 
            // xo8
            // 
            this.xo8.Location = new System.Drawing.Point(119, 269);
            this.xo8.Name = "xo8";
            this.xo8.Size = new System.Drawing.Size(100, 55);
            this.xo8.TabIndex = 13;
            this.xo8.Text = "-";
            this.xo8.UseVisualStyleBackColor = true;
            this.xo8.Visible = false;
            this.xo8.Click += new System.EventHandler(this.game_Click);
            // 
            // xo7
            // 
            this.xo7.Location = new System.Drawing.Point(13, 269);
            this.xo7.Name = "xo7";
            this.xo7.Size = new System.Drawing.Size(100, 55);
            this.xo7.TabIndex = 12;
            this.xo7.Text = "-";
            this.xo7.UseVisualStyleBackColor = true;
            this.xo7.Visible = false;
            this.xo7.Click += new System.EventHandler(this.game_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(13, 94);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(311, 38);
            this.RestartButton.TabIndex = 15;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 337);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.xo9);
            this.Controls.Add(this.xo8);
            this.Controls.Add(this.xo7);
            this.Controls.Add(this.xo6);
            this.Controls.Add(this.xo5);
            this.Controls.Add(this.xo4);
            this.Controls.Add(this.xo3);
            this.Controls.Add(this.xo2);
            this.Controls.Add(this.xo1);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2TextBox);
            this.Controls.Add(this.player1TextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(356, 376);
            this.MinimumSize = new System.Drawing.Size(356, 376);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Button xo1;
        private System.Windows.Forms.Button xo2;
        private System.Windows.Forms.Button xo3;
        private System.Windows.Forms.Button xo6;
        private System.Windows.Forms.Button xo5;
        private System.Windows.Forms.Button xo4;
        private System.Windows.Forms.Button xo9;
        private System.Windows.Forms.Button xo8;
        private System.Windows.Forms.Button xo7;
        private System.Windows.Forms.Button RestartButton;

    }
}

