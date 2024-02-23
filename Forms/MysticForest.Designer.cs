namespace DungeonCrawl
{
    partial class MysticForest
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.savas_btn = new System.Windows.Forms.Button();
            this.Enemy_lbl = new System.Windows.Forms.Label();
            this.char_lbl = new System.Windows.Forms.Label();
            this.kac_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(85, 45);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 20;
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar2.Location = new System.Drawing.Point(1017, 45);
            this.progressBar2.Maximum = 40;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(191, 23);
            this.progressBar2.TabIndex = 2;
            this.progressBar2.Value = 40;
            // 
            // savas_btn
            // 
            this.savas_btn.Location = new System.Drawing.Point(326, 511);
            this.savas_btn.Name = "savas_btn";
            this.savas_btn.Size = new System.Drawing.Size(233, 49);
            this.savas_btn.TabIndex = 4;
            this.savas_btn.Text = "Savaş";
            this.savas_btn.UseVisualStyleBackColor = true;
            this.savas_btn.Click += new System.EventHandler(this.savas_btn_Click);
            // 
            // Enemy_lbl
            // 
            this.Enemy_lbl.AutoSize = true;
            this.Enemy_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Enemy_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Enemy_lbl.Location = new System.Drawing.Point(956, 430);
            this.Enemy_lbl.Name = "Enemy_lbl";
            this.Enemy_lbl.Size = new System.Drawing.Size(172, 32);
            this.Enemy_lbl.TabIndex = 5;
            this.Enemy_lbl.Text = "Efsanevi Ayı";
            // 
            // char_lbl
            // 
            this.char_lbl.AutoSize = true;
            this.char_lbl.BackColor = System.Drawing.Color.Transparent;
            this.char_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.char_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.char_lbl.Location = new System.Drawing.Point(196, 430);
            this.char_lbl.Name = "char_lbl";
            this.char_lbl.Size = new System.Drawing.Size(104, 32);
            this.char_lbl.TabIndex = 6;
            this.char_lbl.Text = "Artyom";
            // 
            // kac_btn
            // 
            this.kac_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kac_btn.Location = new System.Drawing.Point(727, 511);
            this.kac_btn.Name = "kac_btn";
            this.kac_btn.Size = new System.Drawing.Size(237, 49);
            this.kac_btn.TabIndex = 7;
            this.kac_btn.Text = "Kaç";
            this.kac_btn.UseVisualStyleBackColor = true;
            this.kac_btn.Click += new System.EventHandler(this.kac_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DungeonCrawl.Properties.Resources.Bear;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(858, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 320);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DungeonCrawl.Properties.Resources.Artyom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(48, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 320);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MysticForest
            // 
            this.AcceptButton = this.savas_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DungeonCrawl.Properties.Resources.orman1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.kac_btn;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.kac_btn);
            this.Controls.Add(this.char_lbl);
            this.Controls.Add(this.Enemy_lbl);
            this.Controls.Add(this.savas_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.Name = "MysticForest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MysticForest";
            this.Load += new System.EventHandler(this.MysticForest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button savas_btn;
        private System.Windows.Forms.Button kac_btn;
        public System.Windows.Forms.Label Enemy_lbl;
        public System.Windows.Forms.Label char_lbl;
    }
}