namespace DungeonCrawl
{
    partial class MainScene
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.basla_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DungeonCrawl.Properties.Resources.Kale;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DungeonCrawl.Properties.Resources.Kale;
            this.pictureBox2.Location = new System.Drawing.Point(-19, -42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1286, 938);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cikis_btn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis_btn.Location = new System.Drawing.Point(499, 463);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(279, 55);
            this.cikis_btn.TabIndex = 12;
            this.cikis_btn.Text = "Cikis Yap";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.info_btn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_btn.Location = new System.Drawing.Point(499, 341);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(279, 55);
            this.info_btn.TabIndex = 11;
            this.info_btn.Text = "Emegi Gecenler";
            this.info_btn.UseVisualStyleBackColor = false;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(279, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 82);
            this.label1.TabIndex = 10;
            this.label1.Text = "DUNGEON CRAWL";
            // 
            // basla_btn
            // 
            this.basla_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.basla_btn.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basla_btn.Location = new System.Drawing.Point(499, 215);
            this.basla_btn.Name = "basla_btn";
            this.basla_btn.Size = new System.Drawing.Size(279, 55);
            this.basla_btn.TabIndex = 9;
            this.basla_btn.Text = "Oyuna Basla";
            this.basla_btn.UseVisualStyleBackColor = false;
            this.basla_btn.Click += new System.EventHandler(this.basla_btn_Click);
            // 
            // MainScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DungeonCrawl.Properties.Resources.Kale;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basla_btn);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "t";
            this.Load += new System.EventHandler(this.MainScene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button basla_btn;
    }
}

