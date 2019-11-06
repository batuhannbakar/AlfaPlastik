namespace Alfa.MOLD
{
    partial class ucKalıpGor
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Duzenle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_İncele = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_No = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMB_AMBAR = new System.Windows.Forms.ComboBox();
            this.wAREHOUSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alfaPlastikDataSet = new Alfa.AlfaPlastikDataSet();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_duzen_kyt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.wAREHOUSETableAdapter = new Alfa.AlfaPlastikDataSetTableAdapters.WAREHOUSETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPlastikDataSet)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(1083, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick_1);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // button_Duzenle
            // 
            this.button_Duzenle.BackColor = System.Drawing.Color.Silver;
            this.button_Duzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Duzenle.Image = global::Alfa.Properties.Resources.pencil_50px;
            this.button_Duzenle.Location = new System.Drawing.Point(151, 3);
            this.button_Duzenle.Name = "button_Duzenle";
            this.button_Duzenle.Size = new System.Drawing.Size(68, 60);
            this.button_Duzenle.TabIndex = 10;
            this.button_Duzenle.UseVisualStyleBackColor = false;
            this.button_Duzenle.Click += new System.EventHandler(this.button_Duzenle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.BackColor = System.Drawing.Color.Silver;
            this.button_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Sil.Image = global::Alfa.Properties.Resources.icons8_trash_48;
            this.button_Sil.Location = new System.Drawing.Point(77, 3);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(68, 60);
            this.button_Sil.TabIndex = 9;
            this.button_Sil.UseVisualStyleBackColor = false;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.BackColor = System.Drawing.Color.Silver;
            this.button_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Ekle.Image = global::Alfa.Properties.Resources.add_48px;
            this.button_Ekle.Location = new System.Drawing.Point(3, 3);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(68, 60);
            this.button_Ekle.TabIndex = 8;
            this.button_Ekle.UseVisualStyleBackColor = false;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_İncele
            // 
            this.button_İncele.BackColor = System.Drawing.Color.Silver;
            this.button_İncele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_İncele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_İncele.Image = global::Alfa.Properties.Resources.view_file_50px;
            this.button_İncele.Location = new System.Drawing.Point(225, 3);
            this.button_İncele.Name = "button_İncele";
            this.button_İncele.Size = new System.Drawing.Size(68, 60);
            this.button_İncele.TabIndex = 11;
            this.button_İncele.UseVisualStyleBackColor = false;
            this.button_İncele.Click += new System.EventHandler(this.button_İncele_Click);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 569);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.30097F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.69903F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_Name, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox_No, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.CMB_AMBAR, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.btn_ekle, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_duzen_kyt, 2, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 327);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(616, 239);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Name.Location = new System.Drawing.Point(223, 132);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(172, 20);
            this.textBox_Name.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(145, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "KALIP ADI:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "KALIP NUMARASI:";
            // 
            // textBox_No
            // 
            this.textBox_No.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_No.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_No.Location = new System.Drawing.Point(223, 72);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.Size = new System.Drawing.Size(172, 20);
            this.textBox_No.TabIndex = 10;
            this.textBox_No.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_No_KeyDown_1);
            this.textBox_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_No_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "KALIP EKLEME";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(133, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "AMBAR ADI:";
            // 
            // CMB_AMBAR
            // 
            this.CMB_AMBAR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CMB_AMBAR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wAREHOUSEBindingSource, "WAREHOUSE_NAME", true));
            this.CMB_AMBAR.DataSource = this.wAREHOUSEBindingSource;
            this.CMB_AMBAR.DisplayMember = "WAREHOUSE_NAME";
            this.CMB_AMBAR.FormattingEnabled = true;
            this.CMB_AMBAR.Location = new System.Drawing.Point(223, 196);
            this.CMB_AMBAR.Name = "CMB_AMBAR";
            this.CMB_AMBAR.Size = new System.Drawing.Size(172, 21);
            this.CMB_AMBAR.TabIndex = 16;
            this.CMB_AMBAR.ValueMember = "WAREHOUSE_ID";
            this.CMB_AMBAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMB_AMBAR_KeyPress);
            // 
            // wAREHOUSEBindingSource
            // 
            this.wAREHOUSEBindingSource.DataMember = "WAREHOUSE";
            this.wAREHOUSEBindingSource.DataSource = this.alfaPlastikDataSet;
            // 
            // alfaPlastikDataSet
            // 
            this.alfaPlastikDataSet.DataSetName = "AlfaPlastikDataSet";
            this.alfaPlastikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ekle.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Image = global::Alfa.Properties.Resources.ekle;
            this.btn_ekle.Location = new System.Drawing.Point(524, 113);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 56);
            this.btn_ekle.TabIndex = 15;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_duzen_kyt
            // 
            this.btn_duzen_kyt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_duzen_kyt.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_duzen_kyt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_duzen_kyt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duzen_kyt.Image = global::Alfa.Properties.Resources.approve_and_update_48px;
            this.btn_duzen_kyt.Location = new System.Drawing.Point(524, 178);
            this.btn_duzen_kyt.Name = "btn_duzen_kyt";
            this.btn_duzen_kyt.Size = new System.Drawing.Size(75, 58);
            this.btn_duzen_kyt.TabIndex = 13;
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
            this.tableLayoutPanel2.Controls.Add(this.button_İncele, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Duzenle, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Ekle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Sil, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 578);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 66);
            this.tableLayoutPanel2.TabIndex = 13;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1095, 647);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // wAREHOUSETableAdapter
            // 
            this.wAREHOUSETableAdapter.ClearBeforeFill = true;
            // 
            // ucKalıpGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "ucKalıpGor";
            this.Size = new System.Drawing.Size(1095, 647);
            this.Load += new System.EventHandler(this.ucKalıpGor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wAREHOUSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfaPlastikDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Duzenle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Ekle;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button_İncele;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_duzen_kyt;
        public System.Windows.Forms.TextBox textBox_No;
        public System.Windows.Forms.TextBox textBox_Name;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMB_AMBAR;
        private System.Windows.Forms.BindingSource wAREHOUSEBindingSource;
        private AlfaPlastikDataSet alfaPlastikDataSet;
        private AlfaPlastikDataSetTableAdapters.WAREHOUSETableAdapter wAREHOUSETableAdapter;
    }
}
