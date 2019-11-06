namespace Alfa.WAREHOUSE
{
    partial class ucAmbarGor
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_duzen = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_incele = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_EKLE = new System.Windows.Forms.Button();
            this.btn_duzen_kyt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_No = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // btn_duzen
            // 
            this.btn_duzen.BackColor = System.Drawing.Color.Silver;
            this.btn_duzen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_duzen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_duzen.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_duzen.FlatAppearance.BorderSize = 0;
            this.btn_duzen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_duzen.Image = global::Alfa.Properties.Resources.pencil_50px;
            this.btn_duzen.Location = new System.Drawing.Point(151, 3);
            this.btn_duzen.Name = "btn_duzen";
            this.btn_duzen.Size = new System.Drawing.Size(68, 60);
            this.btn_duzen.TabIndex = 7;
            this.btn_duzen.UseVisualStyleBackColor = false;
            this.btn_duzen.Click += new System.EventHandler(this.btn_duzen_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Silver;
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Image = global::Alfa.Properties.Resources.icons8_trash_48;
            this.btn_sil.Location = new System.Drawing.Point(77, 3);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(68, 60);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click_1);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Silver;
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Image = global::Alfa.Properties.Resources.add_48px;
            this.btn_ekle.Location = new System.Drawing.Point(3, 3);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(68, 60);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click_1);
            // 
            // btn_incele
            // 
            this.btn_incele.BackColor = System.Drawing.Color.Silver;
            this.btn_incele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_incele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_incele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_incele.Image = global::Alfa.Properties.Resources.view_file_50px;
            this.btn_incele.Location = new System.Drawing.Point(225, 3);
            this.btn_incele.Name = "btn_incele";
            this.btn_incele.Size = new System.Drawing.Size(68, 60);
            this.btn_incele.TabIndex = 8;
            this.btn_incele.UseVisualStyleBackColor = false;
            this.btn_incele.Click += new System.EventHandler(this.btn_incele_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 569);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.12892F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.87108F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox_Name, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox_No, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_EKLE, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_duzen_kyt, 2, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 389);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(462, 176);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(84, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "AMBAR ADI:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Name.Location = new System.Drawing.Point(174, 134);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(165, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMBAR NUMARASI:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "AMBAR EKLEME";
            // 
            // button_EKLE
            // 
            this.button_EKLE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_EKLE.BackColor = System.Drawing.Color.ForestGreen;
            this.button_EKLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_EKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EKLE.Image = global::Alfa.Properties.Resources.ekle;
            this.button_EKLE.Location = new System.Drawing.Point(368, 47);
            this.button_EKLE.Name = "button_EKLE";
            this.button_EKLE.Size = new System.Drawing.Size(75, 58);
            this.button_EKLE.TabIndex = 11;
            this.button_EKLE.UseVisualStyleBackColor = false;
            this.button_EKLE.Click += new System.EventHandler(this.button_EKLE_Click);
            // 
            // btn_duzen_kyt
            // 
            this.btn_duzen_kyt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_duzen_kyt.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_duzen_kyt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_duzen_kyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duzen_kyt.Image = global::Alfa.Properties.Resources.approve_and_update_48px;
            this.btn_duzen_kyt.Location = new System.Drawing.Point(367, 115);
            this.btn_duzen_kyt.Name = "btn_duzen_kyt";
            this.btn_duzen_kyt.Size = new System.Drawing.Size(76, 58);
            this.btn_duzen_kyt.TabIndex = 8;
            this.btn_duzen_kyt.UseVisualStyleBackColor = false;
            this.btn_duzen_kyt.Visible = false;
            this.btn_duzen_kyt.Click += new System.EventHandler(this.btn_duzen_kyt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_incele, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_duzen, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_ekle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_sil, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 578);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 66);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.87172F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12828F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1094, 647);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // textBox_No
            // 
            this.textBox_No.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_No.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_No.Location = new System.Drawing.Point(174, 68);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.Size = new System.Drawing.Size(165, 20);
            this.textBox_No.TabIndex = 3;
            this.textBox_No.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_No_KeyDown_1);
            this.textBox_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_No_KeyPress);
            // 
            // ucAmbarGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "ucAmbarGor";
            this.Size = new System.Drawing.Size(1094, 647);
            this.Load += new System.EventHandler(this.ucAmbarGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_duzen;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_incele;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_duzen_kyt;
        public System.Windows.Forms.TextBox textBox_Name;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button_EKLE;
        public System.Windows.Forms.TextBox textBox_No;
    }
}
