namespace DungeonCrawl
{
    partial class RoyalsRuin
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
            this.kac_btn = new System.Windows.Forms.Button();
            this.char_lbl = new System.Windows.Forms.Label();
            this.Enemy_lbl = new System.Windows.Forms.Label();
            this.savas_btn = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kac_btn
            // 
            this.kac_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kac_btn.Location = new System.Drawing.Point(733, 541);
            this.kac_btn.Name = "kac_btn";
            this.kac_btn.Size = new System.Drawing.Size(237, 49);
            this.kac_btn.TabIndex = 23;
            this.kac_btn.Text = "Kaç";
            this.kac_btn.UseVisualStyleBackColor = true;
            this.kac_btn.Click += new System.EventHandler(this.kac_btn_Click);
            // 
            // char_lbl
            // 
            this.char_lbl.AutoSize = true;
            this.char_lbl.BackColor = System.Drawing.Color.Transparent;
            this.char_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.char_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.char_lbl.Location = new System.Drawing.Point(197, 460);
            this.char_lbl.Name = "char_lbl";
            this.char_lbl.Size = new System.Drawing.Size(104, 32);
            this.char_lbl.TabIndex = 22;
            this.char_lbl.Text = "Artyom";
            // 
            // Enemy_lbl
            // 
            this.Enemy_lbl.AutoSize = true;
            this.Enemy_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Enemy_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Enemy_lbl.Location = new System.Drawing.Point(1012, 460);
            this.Enemy_lbl.Name = "Enemy_lbl";
            this.Enemy_lbl.Size = new System.Drawing.Size(66, 32);
            this.Enemy_lbl.TabIndex = 21;
            this.Enemy_lbl.Text = "Kral";
            // 
            // savas_btn
            // 
            this.savas_btn.Location = new System.Drawing.Point(270, 541);
            this.savas_btn.Name = "savas_btn";
            this.savas_btn.Size = new System.Drawing.Size(233, 49);
            this.savas_btn.TabIndex = 20;
            this.savas_btn.Text = "Savaş";
            this.savas_btn.UseVisualStyleBackColor = true;
            this.savas_btn.Click += new System.EventHandler(this.savas_btn_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar2.Location = new System.Drawing.Point(944, 75);
            this.progressBar2.Maximum = 30;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(191, 23);
            this.progressBar2.TabIndex = 18;
            this.progressBar2.Value = 30;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(132, 75);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Value = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DungeonCrawl.Properties.Resources.KİNG;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(866, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 304);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DungeonCrawl.Properties.Resources.Artyom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 277);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // RoyalsRuin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DungeonCrawl.Properties.Resources.Ruin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.kac_btn);
            this.Controls.Add(this.char_lbl);
            this.Controls.Add(this.Enemy_lbl);
            this.Controls.Add(this.savas_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Name = "RoyalsRuin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoyalsRuin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kac_btn;
        public System.Windows.Forms.Label char_lbl;
        public System.Windows.Forms.Label Enemy_lbl;
        private System.Windows.Forms.Button savas_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}