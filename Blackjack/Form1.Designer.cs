namespace Blackjack
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
            this.btnHitMe = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnShuffleAndDeal = new System.Windows.Forms.Button();
            this.picboxDealer1 = new System.Windows.Forms.PictureBox();
            this.picboxDealer2 = new System.Windows.Forms.PictureBox();
            this.picboxPlayer2 = new System.Windows.Forms.PictureBox();
            this.picboxPlayer1 = new System.Windows.Forms.PictureBox();
            this.picboxPlayer4 = new System.Windows.Forms.PictureBox();
            this.picboxPlayer3 = new System.Windows.Forms.PictureBox();
            this.picboxDealer4 = new System.Windows.Forms.PictureBox();
            this.picboxDealer3 = new System.Windows.Forms.PictureBox();
            this.picboxDealer6 = new System.Windows.Forms.PictureBox();
            this.picboxDealer5 = new System.Windows.Forms.PictureBox();
            this.picboxPlayer6 = new System.Windows.Forms.PictureBox();
            this.picboxPlayer5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHitMe
            // 
            this.btnHitMe.Enabled = false;
            this.btnHitMe.Location = new System.Drawing.Point(12, 283);
            this.btnHitMe.Name = "btnHitMe";
            this.btnHitMe.Size = new System.Drawing.Size(95, 25);
            this.btnHitMe.TabIndex = 0;
            this.btnHitMe.Text = "Hit me";
            this.btnHitMe.UseVisualStyleBackColor = true;
            this.btnHitMe.Visible = false;
            this.btnHitMe.Click += new System.EventHandler(this.btnHitMe_Click);
            // 
            // btnStay
            // 
            this.btnStay.Enabled = false;
            this.btnStay.Location = new System.Drawing.Point(113, 283);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(95, 25);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Visible = false;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnShuffleAndDeal
            // 
            this.btnShuffleAndDeal.Location = new System.Drawing.Point(277, 285);
            this.btnShuffleAndDeal.Name = "btnShuffleAndDeal";
            this.btnShuffleAndDeal.Size = new System.Drawing.Size(137, 23);
            this.btnShuffleAndDeal.TabIndex = 2;
            this.btnShuffleAndDeal.Text = "Shuffle and Deal";
            this.btnShuffleAndDeal.UseVisualStyleBackColor = true;
            this.btnShuffleAndDeal.Click += new System.EventHandler(this.btnShuffleAndDeal_ClickAsync);
            // 
            // picboxDealer1
            // 
            this.picboxDealer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxDealer1.Location = new System.Drawing.Point(12, 12);
            this.picboxDealer1.Name = "picboxDealer1";
            this.picboxDealer1.Size = new System.Drawing.Size(62, 93);
            this.picboxDealer1.TabIndex = 3;
            this.picboxDealer1.TabStop = false;
            // 
            // picboxDealer2
            // 
            this.picboxDealer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxDealer2.Location = new System.Drawing.Point(80, 12);
            this.picboxDealer2.Name = "picboxDealer2";
            this.picboxDealer2.Size = new System.Drawing.Size(62, 93);
            this.picboxDealer2.TabIndex = 4;
            this.picboxDealer2.TabStop = false;
            // 
            // picboxPlayer2
            // 
            this.picboxPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPlayer2.Location = new System.Drawing.Point(80, 184);
            this.picboxPlayer2.Name = "picboxPlayer2";
            this.picboxPlayer2.Size = new System.Drawing.Size(62, 93);
            this.picboxPlayer2.TabIndex = 6;
            this.picboxPlayer2.TabStop = false;
            // 
            // picboxPlayer1
            // 
            this.picboxPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPlayer1.Location = new System.Drawing.Point(12, 184);
            this.picboxPlayer1.Name = "picboxPlayer1";
            this.picboxPlayer1.Size = new System.Drawing.Size(62, 93);
            this.picboxPlayer1.TabIndex = 5;
            this.picboxPlayer1.TabStop = false;
            // 
            // picboxPlayer4
            // 
            this.picboxPlayer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPlayer4.Location = new System.Drawing.Point(216, 184);
            this.picboxPlayer4.Name = "picboxPlayer4";
            this.picboxPlayer4.Size = new System.Drawing.Size(62, 93);
            this.picboxPlayer4.TabIndex = 8;
            this.picboxPlayer4.TabStop = false;
            // 
            // picboxPlayer3
            // 
            this.picboxPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPlayer3.Location = new System.Drawing.Point(148, 184);
            this.picboxPlayer3.Name = "picboxPlayer3";
            this.picboxPlayer3.Size = new System.Drawing.Size(62, 93);
            this.picboxPlayer3.TabIndex = 7;
            this.picboxPlayer3.TabStop = false;
            // 
            // picboxDealer4
            // 
            this.picboxDealer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxDealer4.Location = new System.Drawing.Point(216, 12);
            this.picboxDealer4.Name = "picboxDealer4";
            this.picboxDealer4.Size = new System.Drawing.Size(62, 93);
            this.picboxDealer4.TabIndex = 10;
            this.picboxDealer4.TabStop = false;
            // 
            // picboxDealer3
            // 
            this.picboxDealer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxDealer3.Location = new System.Drawing.Point(148, 12);
            this.picboxDealer3.Name = "picboxDealer3";
            this.picboxDealer3.Size = new System.Drawing.Size(62, 93);
            this.picboxDealer3.TabIndex = 9;
            this.picboxDealer3.TabStop = false;
            // 
            // picboxDealer6
            // 
            this.picboxDealer6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxDealer6.Location = new System.Drawing.Point(352, 12);
            this.picboxDealer6.Name = "picboxDealer6";
            this.picboxDealer6.Size = new System.Drawing.Size(62, 93);
            this.picboxDealer6.TabIndex = 12;
            this.picboxDealer6.TabStop = false;
            // 
            // picboxDealer5
            // 
            this.picboxDealer5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxDealer5.Location = new System.Drawing.Point(284, 12);
            this.picboxDealer5.Name = "picboxDealer5";
            this.picboxDealer5.Size = new System.Drawing.Size(62, 93);
            this.picboxDealer5.TabIndex = 11;
            this.picboxDealer5.TabStop = false;
            // 
            // picboxPlayer6
            // 
            this.picboxPlayer6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPlayer6.Location = new System.Drawing.Point(352, 184);
            this.picboxPlayer6.Name = "picboxPlayer6";
            this.picboxPlayer6.Size = new System.Drawing.Size(62, 93);
            this.picboxPlayer6.TabIndex = 14;
            this.picboxPlayer6.TabStop = false;
            // 
            // picboxPlayer5
            // 
            this.picboxPlayer5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPlayer5.Location = new System.Drawing.Point(284, 184);
            this.picboxPlayer5.Name = "picboxPlayer5";
            this.picboxPlayer5.Size = new System.Drawing.Size(62, 93);
            this.picboxPlayer5.TabIndex = 13;
            this.picboxPlayer5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bankroll";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Wager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(549, 319);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxPlayer6);
            this.Controls.Add(this.picboxPlayer5);
            this.Controls.Add(this.picboxDealer6);
            this.Controls.Add(this.picboxDealer5);
            this.Controls.Add(this.picboxDealer4);
            this.Controls.Add(this.picboxDealer3);
            this.Controls.Add(this.picboxPlayer4);
            this.Controls.Add(this.picboxPlayer3);
            this.Controls.Add(this.picboxPlayer2);
            this.Controls.Add(this.picboxPlayer1);
            this.Controls.Add(this.picboxDealer2);
            this.Controls.Add(this.picboxDealer1);
            this.Controls.Add(this.btnShuffleAndDeal);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHitMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDealer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHitMe;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnShuffleAndDeal;
        private System.Windows.Forms.PictureBox picboxDealer1;
        private System.Windows.Forms.PictureBox picboxDealer2;
        private System.Windows.Forms.PictureBox picboxPlayer2;
        private System.Windows.Forms.PictureBox picboxPlayer1;
        private System.Windows.Forms.PictureBox picboxPlayer4;
        private System.Windows.Forms.PictureBox picboxPlayer3;
        private System.Windows.Forms.PictureBox picboxDealer4;
        private System.Windows.Forms.PictureBox picboxDealer3;
        private System.Windows.Forms.PictureBox picboxDealer6;
        private System.Windows.Forms.PictureBox picboxDealer5;
        private System.Windows.Forms.PictureBox picboxPlayer6;
        private System.Windows.Forms.PictureBox picboxPlayer5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

