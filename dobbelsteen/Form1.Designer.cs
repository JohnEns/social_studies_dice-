namespace Dobbelsteen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.werpButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.IntroPic = new System.Windows.Forms.PictureBox();
            this.StopCountdown = new System.Windows.Forms.Button();
            this.CountDownbutton = new System.Windows.Forms.Button();
            this.CountDownLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.getal1PictureBox = new System.Windows.Forms.PictureBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.MainMenuPicture = new System.Windows.Forms.PictureBox();
            this.MainMenuTitle = new System.Windows.Forms.Label();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntroPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getal1PictureBox)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // werpButton
            // 
            this.werpButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.werpButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.werpButton.Location = new System.Drawing.Point(101, 393);
            this.werpButton.Name = "werpButton";
            this.werpButton.Size = new System.Drawing.Size(188, 38);
            this.werpButton.TabIndex = 0;
            this.werpButton.Text = "Werp dobbelsteen!";
            this.werpButton.UseVisualStyleBackColor = false;
            this.werpButton.Click += new System.EventHandler(this.WerpButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(153, -2);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(63, 24);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "label1";
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.IntroPic);
            this.GamePanel.Controls.Add(this.StopCountdown);
            this.GamePanel.Controls.Add(this.CountDownbutton);
            this.GamePanel.Controls.Add(this.CountDownLabel);
            this.GamePanel.Controls.Add(this.ExitButton);
            this.GamePanel.Controls.Add(this.werpButton);
            this.GamePanel.Controls.Add(this.ScoreLabel);
            this.GamePanel.Controls.Add(this.getal1PictureBox);
            this.GamePanel.Controls.Add(this.ResultLabel);
            this.GamePanel.Location = new System.Drawing.Point(107, 47);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(526, 451);
            this.GamePanel.TabIndex = 8;
            // 
            // IntroPic
            // 
            this.IntroPic.Image = ((System.Drawing.Image)(resources.GetObject("IntroPic.Image")));
            this.IntroPic.Location = new System.Drawing.Point(35, 74);
            this.IntroPic.Name = "IntroPic";
            this.IntroPic.Size = new System.Drawing.Size(410, 260);
            this.IntroPic.TabIndex = 10;
            this.IntroPic.TabStop = false;
            // 
            // StopCountdown
            // 
            this.StopCountdown.Location = new System.Drawing.Point(376, 242);
            this.StopCountdown.Name = "StopCountdown";
            this.StopCountdown.Size = new System.Drawing.Size(105, 23);
            this.StopCountdown.TabIndex = 11;
            this.StopCountdown.Text = "Stop de Klok!";
            this.StopCountdown.UseVisualStyleBackColor = true;
            this.StopCountdown.Click += new System.EventHandler(this.StopCountdown_Click);
            // 
            // CountDownbutton
            // 
            this.CountDownbutton.Location = new System.Drawing.Point(376, 242);
            this.CountDownbutton.Name = "CountDownbutton";
            this.CountDownbutton.Size = new System.Drawing.Size(105, 23);
            this.CountDownbutton.TabIndex = 10;
            this.CountDownbutton.Text = "Start de Klok";
            this.CountDownbutton.UseVisualStyleBackColor = true;
            this.CountDownbutton.Click += new System.EventHandler(this.CountDownbutton_Click);
            // 
            // CountDownLabel
            // 
            this.CountDownLabel.AutoSize = true;
            this.CountDownLabel.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDownLabel.Location = new System.Drawing.Point(378, 140);
            this.CountDownLabel.Name = "CountDownLabel";
            this.CountDownLabel.Size = new System.Drawing.Size(103, 77);
            this.CountDownLabel.TabIndex = 9;
            this.CountDownLabel.Text = "30";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(448, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 24);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Stop Spel";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // getal1PictureBox
            // 
            this.getal1PictureBox.Image = global::Dobbelsteen.Properties.Resources.dice6;
            this.getal1PictureBox.Location = new System.Drawing.Point(79, 110);
            this.getal1PictureBox.Name = "getal1PictureBox";
            this.getal1PictureBox.Size = new System.Drawing.Size(234, 224);
            this.getal1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.getal1PictureBox.TabIndex = 1;
            this.getal1PictureBox.TabStop = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(73, 23);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(137, 33);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "ResultLabel";
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.StartGameButton);
            this.MainMenuPanel.Controls.Add(this.MainMenuPicture);
            this.MainMenuPanel.Controls.Add(this.MainMenuTitle);
            this.MainMenuPanel.Location = new System.Drawing.Point(651, 47);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(526, 451);
            this.MainMenuPanel.TabIndex = 9;
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StartGameButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.Location = new System.Drawing.Point(185, 393);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(135, 38);
            this.StartGameButton.TabIndex = 9;
            this.StartGameButton.Text = "Start Spel!";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // MainMenuPicture
            // 
            this.MainMenuPicture.Image = ((System.Drawing.Image)(resources.GetObject("MainMenuPicture.Image")));
            this.MainMenuPicture.Location = new System.Drawing.Point(35, 74);
            this.MainMenuPicture.Name = "MainMenuPicture";
            this.MainMenuPicture.Size = new System.Drawing.Size(410, 260);
            this.MainMenuPicture.TabIndex = 8;
            this.MainMenuPicture.TabStop = false;
            this.MainMenuPicture.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // MainMenuTitle
            // 
            this.MainMenuTitle.AutoSize = true;
            this.MainMenuTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuTitle.Location = new System.Drawing.Point(60, 23);
            this.MainMenuTitle.Name = "MainMenuTitle";
            this.MainMenuTitle.Size = new System.Drawing.Size(368, 39);
            this.MainMenuTitle.TabIndex = 0;
            this.MainMenuTitle.Text = "Het spel van mevrouw Knel";
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 526);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.GamePanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dobbelsteen";
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntroPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getal1PictureBox)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button werpButton;
        private System.Windows.Forms.PictureBox getal1PictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.PictureBox MainMenuPicture;
        private System.Windows.Forms.Label MainMenuTitle;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label CountDownLabel;
        private System.Windows.Forms.Button CountDownbutton;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Button StopCountdown;
        private System.Windows.Forms.PictureBox IntroPic;
    }
}

