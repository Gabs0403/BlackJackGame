namespace BlackJackGame
{
    partial class Form1
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
            btnHit = new Button();
            btnStand = new Button();
            btnRestart = new Button();
            label1 = new Label();
            PlayerPanel = new FlowLayoutPanel();
            pictureBox7 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            scoreLabel = new Label();
            dealerPanel = new FlowLayoutPanel();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            lblPlayerScore = new Label();
            lblDealerScore = new Label();
            PlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            dealerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // btnHit
            // 
            btnHit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHit.Location = new Point(380, 676);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(142, 38);
            btnHit.TabIndex = 14;
            btnHit.Text = "HIT";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStand.Location = new Point(571, 676);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(142, 38);
            btnStand.TabIndex = 15;
            btnStand.Text = "STAND";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(760, 676);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(142, 38);
            btnRestart.TabIndex = 16;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 241);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 24;
            label1.Text = "Dealer's Score:";
            // 
            // PlayerPanel
            // 
            PlayerPanel.Controls.Add(pictureBox7);
            PlayerPanel.Controls.Add(pictureBox3);
            PlayerPanel.Controls.Add(pictureBox5);
            PlayerPanel.Controls.Add(pictureBox4);
            PlayerPanel.Controls.Add(pictureBox2);
            PlayerPanel.Controls.Add(pictureBox1);
            PlayerPanel.Controls.Add(pictureBox6);
            PlayerPanel.Location = new Point(282, 443);
            PlayerPanel.Name = "PlayerPanel";
            PlayerPanel.Size = new Size(745, 177);
            PlayerPanel.TabIndex = 27;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(3, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 171);
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(109, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 171);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(215, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 171);
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(321, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 171);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(427, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 171);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(533, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 171);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(639, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 171);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(391, 404);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(114, 25);
            scoreLabel.TabIndex = 21;
            scoreLabel.Text = "Your Score:";
            // 
            // dealerPanel
            // 
            dealerPanel.Controls.Add(pictureBox8);
            dealerPanel.Controls.Add(pictureBox9);
            dealerPanel.Controls.Add(pictureBox10);
            dealerPanel.Controls.Add(pictureBox11);
            dealerPanel.Controls.Add(pictureBox12);
            dealerPanel.Controls.Add(pictureBox13);
            dealerPanel.Controls.Add(pictureBox14);
            dealerPanel.Location = new Point(282, 48);
            dealerPanel.Name = "dealerPanel";
            dealerPanel.Size = new Size(745, 177);
            dealerPanel.TabIndex = 28;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(3, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 171);
            pictureBox8.TabIndex = 20;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(109, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 171);
            pictureBox9.TabIndex = 17;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(215, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 171);
            pictureBox10.TabIndex = 19;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(321, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(100, 171);
            pictureBox11.TabIndex = 18;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(427, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(100, 171);
            pictureBox12.TabIndex = 16;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(533, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(100, 171);
            pictureBox13.TabIndex = 15;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(639, 3);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(100, 171);
            pictureBox14.TabIndex = 14;
            pictureBox14.TabStop = false;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPlayerScore.Location = new Point(511, 407);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(0, 21);
            lblPlayerScore.TabIndex = 29;
            // 
            // lblDealerScore
            // 
            lblDealerScore.AutoSize = true;
            lblDealerScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDealerScore.Location = new Point(539, 242);
            lblDealerScore.Name = "lblDealerScore";
            lblDealerScore.Size = new Size(0, 21);
            lblDealerScore.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1333, 758);
            Controls.Add(lblDealerScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(label1);
            Controls.Add(PlayerPanel);
            Controls.Add(scoreLabel);
            Controls.Add(btnRestart);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(dealerPanel);
            Name = "Form1";
            Text = "BlackJack";
            Load += Form1_Load;
            PlayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            dealerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnHit;
        private Button btnStand;
        private Button btnRestart;
        private Label label1;
        private FlowLayoutPanel PlayerPanel;
        private PictureBox pictureBox7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private Label scoreLabel;
        private FlowLayoutPanel dealerPanel;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Label lblPlayerScore;
        private Label lblDealerScore;
    }
}
