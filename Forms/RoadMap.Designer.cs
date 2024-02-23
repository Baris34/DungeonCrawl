namespace DungeonCrawl
{
    partial class RoadMap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ruin_btn = new System.Windows.Forms.Button();
            this.Cave_btn = new System.Windows.Forms.Button();
            this.Mystic_btn = new System.Windows.Forms.Button();
            this.Geri_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DungeonCrawl.Properties.Resources.yolacik;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1285, 713);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Ruin_btn);
            this.groupBox1.Controls.Add(this.Cave_btn);
            this.groupBox1.Controls.Add(this.Mystic_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(24, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mekanlar";
            // 
            // Ruin_btn
            // 
            this.Ruin_btn.Enabled = false;
            this.Ruin_btn.Location = new System.Drawing.Point(854, 229);
            this.Ruin_btn.Name = "Ruin_btn";
            this.Ruin_btn.Size = new System.Drawing.Size(347, 62);
            this.Ruin_btn.TabIndex = 2;
            this.Ruin_btn.Text = "Kraliyet Harabelerine Git";
            this.Ruin_btn.UseVisualStyleBackColor = true;
            this.Ruin_btn.Click += new System.EventHandler(this.Ruin_btn_Click);
            // 
            // Cave_btn
            // 
            this.Cave_btn.Enabled = false;
            this.Cave_btn.Location = new System.Drawing.Point(438, 229);
            this.Cave_btn.Name = "Cave_btn";
            this.Cave_btn.Size = new System.Drawing.Size(347, 62);
            this.Cave_btn.TabIndex = 1;
            this.Cave_btn.Text = "Ejder Mağarasına Git";
            this.Cave_btn.UseVisualStyleBackColor = true;
            this.Cave_btn.Click += new System.EventHandler(this.Cave_btn_Click);
            // 
            // Mystic_btn
            // 
            this.Mystic_btn.Location = new System.Drawing.Point(20, 229);
            this.Mystic_btn.Name = "Mystic_btn";
            this.Mystic_btn.Size = new System.Drawing.Size(347, 62);
            this.Mystic_btn.TabIndex = 0;
            this.Mystic_btn.Text = "Mistik Ormana Git";
            this.Mystic_btn.UseVisualStyleBackColor = true;
            this.Mystic_btn.Click += new System.EventHandler(this.Mystic_btn_Click);
            // 
            // Geri_btn
            // 
            this.Geri_btn.Location = new System.Drawing.Point(1152, 36);
            this.Geri_btn.Name = "Geri_btn";
            this.Geri_btn.Size = new System.Drawing.Size(73, 60);
            this.Geri_btn.TabIndex = 3;
            this.Geri_btn.Text = "Geri";
            this.Geri_btn.UseVisualStyleBackColor = true;
            this.Geri_btn.Click += new System.EventHandler(this.Geri_btn_Click);
            // 
            // RoadMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DungeonCrawl.Properties.Resources.yolacik;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 660);
            this.Controls.Add(this.Geri_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RoadMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoadMap";
            this.Load += new System.EventHandler(this.RoadMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Mystic_btn;
        private System.Windows.Forms.Button Geri_btn;
        public System.Windows.Forms.Button Cave_btn;
        public System.Windows.Forms.Button Ruin_btn;
    }
}