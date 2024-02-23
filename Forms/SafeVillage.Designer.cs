namespace DungeonCrawl
{
    partial class SafeVillage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeVillage));
            this.envanter_btn = new System.Windows.Forms.Button();
            this.yol_btn = new System.Windows.Forms.Button();
            this.market_btn = new System.Windows.Forms.Button();
            this.env_box = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.envPara_lbl = new System.Windows.Forms.Label();
            this.envHasar_lbl = new System.Windows.Forms.Label();
            this.envSaglik_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.geri_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new DungeonCrawl.InventoryDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inventoryTableAdapter = new DungeonCrawl.InventoryDataSetTableAdapters.InventoryTableAdapter();
            this.env_box.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // envanter_btn
            // 
            this.envanter_btn.Location = new System.Drawing.Point(527, 518);
            this.envanter_btn.Name = "envanter_btn";
            this.envanter_btn.Size = new System.Drawing.Size(188, 56);
            this.envanter_btn.TabIndex = 1;
            this.envanter_btn.Text = "Envantere Gir";
            this.envanter_btn.UseVisualStyleBackColor = true;
            this.envanter_btn.Click += new System.EventHandler(this.envanter_btn_Click);
            // 
            // yol_btn
            // 
            this.yol_btn.Location = new System.Drawing.Point(284, 518);
            this.yol_btn.Name = "yol_btn";
            this.yol_btn.Size = new System.Drawing.Size(177, 56);
            this.yol_btn.TabIndex = 2;
            this.yol_btn.Text = "Yola Çık";
            this.yol_btn.UseVisualStyleBackColor = true;
            this.yol_btn.Click += new System.EventHandler(this.yol_btn_Click);
            // 
            // market_btn
            // 
            this.market_btn.Location = new System.Drawing.Point(37, 518);
            this.market_btn.Name = "market_btn";
            this.market_btn.Size = new System.Drawing.Size(172, 56);
            this.market_btn.TabIndex = 3;
            this.market_btn.Text = "Markete Git";
            this.market_btn.UseVisualStyleBackColor = true;
            this.market_btn.Click += new System.EventHandler(this.market_btn_Click);
            // 
            // env_box
            // 
            this.env_box.BackColor = System.Drawing.Color.Silver;
            this.env_box.Controls.Add(this.groupBox3);
            this.env_box.Controls.Add(this.geri_btn);
            this.env_box.Controls.Add(this.groupBox1);
            this.env_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.env_box.Location = new System.Drawing.Point(779, 12);
            this.env_box.Name = "env_box";
            this.env_box.Size = new System.Drawing.Size(467, 614);
            this.env_box.TabIndex = 4;
            this.env_box.TabStop = false;
            this.env_box.Text = "Envanter";
            this.env_box.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.envPara_lbl);
            this.groupBox3.Controls.Add(this.envHasar_lbl);
            this.groupBox3.Controls.Add(this.envSaglik_lbl);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 270);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İstatistikler";
            // 
            // envPara_lbl
            // 
            this.envPara_lbl.AutoSize = true;
            this.envPara_lbl.BackColor = System.Drawing.Color.Transparent;
            this.envPara_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.envPara_lbl.ForeColor = System.Drawing.Color.Black;
            this.envPara_lbl.Location = new System.Drawing.Point(159, 180);
            this.envPara_lbl.Name = "envPara_lbl";
            this.envPara_lbl.Size = new System.Drawing.Size(185, 37);
            this.envPara_lbl.TabIndex = 5;
            this.envPara_lbl.Text = "envPara_lbl";
            // 
            // envHasar_lbl
            // 
            this.envHasar_lbl.AutoSize = true;
            this.envHasar_lbl.BackColor = System.Drawing.Color.Transparent;
            this.envHasar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.envHasar_lbl.ForeColor = System.Drawing.Color.Black;
            this.envHasar_lbl.Location = new System.Drawing.Point(159, 114);
            this.envHasar_lbl.Name = "envHasar_lbl";
            this.envHasar_lbl.Size = new System.Drawing.Size(203, 37);
            this.envHasar_lbl.TabIndex = 4;
            this.envHasar_lbl.Text = "envHasar_lbl";
            // 
            // envSaglik_lbl
            // 
            this.envSaglik_lbl.AutoSize = true;
            this.envSaglik_lbl.BackColor = System.Drawing.Color.Transparent;
            this.envSaglik_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.envSaglik_lbl.ForeColor = System.Drawing.Color.Black;
            this.envSaglik_lbl.Location = new System.Drawing.Point(159, 49);
            this.envSaglik_lbl.Name = "envSaglik_lbl";
            this.envSaglik_lbl.Size = new System.Drawing.Size(204, 37);
            this.envSaglik_lbl.TabIndex = 3;
            this.envSaglik_lbl.Text = "envSaglik_lbl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Para:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sağlık:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasar:";
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(338, 34);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(123, 43);
            this.geri_btn.TabIndex = 6;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 233);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eşyalar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.ınventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(448, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Damage";
            this.dataGridViewTextBoxColumn3.HeaderText = "Damage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Block";
            this.dataGridViewTextBoxColumn4.HeaderText = "Block";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ınventoryBindingSource
            // 
            this.ınventoryBindingSource.DataMember = "Inventory";
            this.ınventoryBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.market_btn);
            this.groupBox2.Controls.Add(this.yol_btn);
            this.groupBox2.Controls.Add(this.envanter_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(39, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 614);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güvenli Köy";
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // SafeVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.env_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SafeVillage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuvenliKoy";
            this.Load += new System.EventHandler(this.SafeVillage_Load);
            this.env_box.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button envanter_btn;
        private System.Windows.Forms.Button yol_btn;
        private System.Windows.Forms.Button market_btn;
        private System.Windows.Forms.GroupBox env_box;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label envPara_lbl;
        private System.Windows.Forms.Label envHasar_lbl;
        private System.Windows.Forms.Label envSaglik_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockDataGridViewTextBoxColumn;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource ınventoryBindingSource;
        private InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}