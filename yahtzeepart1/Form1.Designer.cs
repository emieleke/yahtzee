namespace yahtzeepart1
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
            this.dobbelen = new System.Windows.Forms.Button();
            this.spelregels = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.score_textbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bonus_textbox = new System.Windows.Forms.TextBox();
            this.stop_dice1 = new System.Windows.Forms.Button();
            this.stop_dice2 = new System.Windows.Forms.Button();
            this.stop_dice3 = new System.Windows.Forms.Button();
            this.stop_dice4 = new System.Windows.Forms.Button();
            this.stop_dice5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dobbelen
            // 
            this.dobbelen.BackColor = System.Drawing.Color.DarkGray;
            this.dobbelen.Location = new System.Drawing.Point(279, 444);
            this.dobbelen.Name = "dobbelen";
            this.dobbelen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dobbelen.Size = new System.Drawing.Size(307, 59);
            this.dobbelen.TabIndex = 1;
            this.dobbelen.Text = "dobbelen";
            this.dobbelen.UseVisualStyleBackColor = false;
            this.dobbelen.Click += new System.EventHandler(this.dobbelen_Click);
            // 
            // spelregels
            // 
            this.spelregels.BackColor = System.Drawing.Color.Transparent;
            this.spelregels.Location = new System.Drawing.Point(12, 12);
            this.spelregels.Name = "spelregels";
            this.spelregels.Size = new System.Drawing.Size(97, 36);
            this.spelregels.TabIndex = 7;
            this.spelregels.Text = "spelregels";
            this.spelregels.UseVisualStyleBackColor = false;
            this.spelregels.Click += new System.EventHandler(this.spelregels_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::yahtzeepart1.Properties.Resources._120px_Dice_0;
            this.pictureBox1.Location = new System.Drawing.Point(110, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 140);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::yahtzeepart1.Properties.Resources._120px_Dice_0;
            this.pictureBox4.Location = new System.Drawing.Point(514, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 140);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::yahtzeepart1.Properties.Resources._120px_Dice_0;
            this.pictureBox5.Location = new System.Drawing.Point(651, 260);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 145);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::yahtzeepart1.Properties.Resources._120px_Dice_0;
            this.pictureBox2.Location = new System.Drawing.Point(242, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 140);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::yahtzeepart1.Properties.Resources._120px_Dice_0;
            this.pictureBox3.Location = new System.Drawing.Point(372, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 140);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // score_textbox
            // 
            this.score_textbox.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.score_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score_textbox.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_textbox.Location = new System.Drawing.Point(778, 25);
            this.score_textbox.Multiline = true;
            this.score_textbox.Name = "score_textbox";
            this.score_textbox.ReadOnly = true;
            this.score_textbox.Size = new System.Drawing.Size(200, 50);
            this.score_textbox.TabIndex = 25;
            this.score_textbox.Text = "Score:";
            this.score_textbox.TextChanged += new System.EventHandler(this.score_textbox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(969, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 63);
            this.textBox1.TabIndex = 26;
            // 
            // bonus_textbox
            // 
            this.bonus_textbox.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.bonus_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bonus_textbox.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold);
            this.bonus_textbox.Location = new System.Drawing.Point(778, 453);
            this.bonus_textbox.Multiline = true;
            this.bonus_textbox.Name = "bonus_textbox";
            this.bonus_textbox.ReadOnly = true;
            this.bonus_textbox.Size = new System.Drawing.Size(298, 50);
            this.bonus_textbox.TabIndex = 1;
            this.bonus_textbox.TextChanged += new System.EventHandler(this.bonus_textbox_TextChanged);
            // 
            // stop_dice1
            // 
            this.stop_dice1.BackColor = System.Drawing.Color.Transparent;
            this.stop_dice1.ForeColor = System.Drawing.Color.Black;
            this.stop_dice1.Location = new System.Drawing.Point(137, 406);
            this.stop_dice1.Name = "stop_dice1";
            this.stop_dice1.Size = new System.Drawing.Size(100, 36);
            this.stop_dice1.TabIndex = 27;
            this.stop_dice1.Text = "stop";
            this.stop_dice1.UseVisualStyleBackColor = false;
            this.stop_dice1.Click += new System.EventHandler(this.stop_dice1_Click);
            // 
            // stop_dice2
            // 
            this.stop_dice2.BackColor = System.Drawing.Color.Transparent;
            this.stop_dice2.ForeColor = System.Drawing.Color.Black;
            this.stop_dice2.Location = new System.Drawing.Point(266, 260);
            this.stop_dice2.Name = "stop_dice2";
            this.stop_dice2.Size = new System.Drawing.Size(100, 36);
            this.stop_dice2.TabIndex = 28;
            this.stop_dice2.Text = "stop";
            this.stop_dice2.UseVisualStyleBackColor = false;
            this.stop_dice2.Click += new System.EventHandler(this.stop_dice2_Click);
            // 
            // stop_dice3
            // 
            this.stop_dice3.BackColor = System.Drawing.Color.Transparent;
            this.stop_dice3.ForeColor = System.Drawing.Color.Black;
            this.stop_dice3.Location = new System.Drawing.Point(396, 406);
            this.stop_dice3.Name = "stop_dice3";
            this.stop_dice3.Size = new System.Drawing.Size(100, 36);
            this.stop_dice3.TabIndex = 29;
            this.stop_dice3.Text = "stop";
            this.stop_dice3.UseVisualStyleBackColor = false;
            this.stop_dice3.Click += new System.EventHandler(this.stop_dice3_Click);
            // 
            // stop_dice4
            // 
            this.stop_dice4.BackColor = System.Drawing.Color.Transparent;
            this.stop_dice4.ForeColor = System.Drawing.Color.Black;
            this.stop_dice4.Location = new System.Drawing.Point(540, 260);
            this.stop_dice4.Name = "stop_dice4";
            this.stop_dice4.Size = new System.Drawing.Size(100, 36);
            this.stop_dice4.TabIndex = 30;
            this.stop_dice4.Text = "stop";
            this.stop_dice4.UseVisualStyleBackColor = false;
            this.stop_dice4.Click += new System.EventHandler(this.stop_dice4_Click);
            // 
            // stop_dice5
            // 
            this.stop_dice5.BackColor = System.Drawing.Color.Transparent;
            this.stop_dice5.ForeColor = System.Drawing.Color.Black;
            this.stop_dice5.Location = new System.Drawing.Point(672, 411);
            this.stop_dice5.Name = "stop_dice5";
            this.stop_dice5.Size = new System.Drawing.Size(100, 36);
            this.stop_dice5.TabIndex = 31;
            this.stop_dice5.Text = "stop";
            this.stop_dice5.UseVisualStyleBackColor = false;
            this.stop_dice5.Click += new System.EventHandler(this.stop_dice5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1088, 555);
            this.Controls.Add(this.stop_dice5);
            this.Controls.Add(this.stop_dice4);
            this.Controls.Add(this.stop_dice3);
            this.Controls.Add(this.stop_dice2);
            this.Controls.Add(this.stop_dice1);
            this.Controls.Add(this.bonus_textbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.score_textbox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spelregels);
            this.Controls.Add(this.dobbelen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "yathzee  (chris, emiel, emre, dylan, mike)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dobbelen;
        private System.Windows.Forms.Button spelregels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox score_textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox bonus_textbox;
        private System.Windows.Forms.Button stop_dice1;
        private System.Windows.Forms.Button stop_dice2;
        private System.Windows.Forms.Button stop_dice3;
        private System.Windows.Forms.Button stop_dice4;
        private System.Windows.Forms.Button stop_dice5;
    }
}

