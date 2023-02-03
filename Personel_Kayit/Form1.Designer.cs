namespace Personel_Kayit
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
            this.gbxPersonel = new System.Windows.Forms.GroupBox();
            this.gbxIslemler = new System.Windows.Forms.GroupBox();
            this.gbxKayitlar = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.tbxMeslek = new System.Windows.Forms.TextBox();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.mtbxMaas = new System.Windows.Forms.MaskedTextBox();
            this.cbxSehirler = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.tblPersonelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelsTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.tbl_PersonelsTableAdapter();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxPersonel.SuspendLayout();
            this.gbxIslemler.SuspendLayout();
            this.gbxKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPersonel
            // 
            this.gbxPersonel.Controls.Add(this.radioButton2);
            this.gbxPersonel.Controls.Add(this.radioButton1);
            this.gbxPersonel.Controls.Add(this.cbxSehirler);
            this.gbxPersonel.Controls.Add(this.mtbxMaas);
            this.gbxPersonel.Controls.Add(this.tbxMeslek);
            this.gbxPersonel.Controls.Add(this.lblMeslek);
            this.gbxPersonel.Controls.Add(this.lblDurum);
            this.gbxPersonel.Controls.Add(this.lblMaas);
            this.gbxPersonel.Controls.Add(this.lblSehir);
            this.gbxPersonel.Controls.Add(this.tbxSoyad);
            this.gbxPersonel.Controls.Add(this.lblSoyad);
            this.gbxPersonel.Controls.Add(this.tbxAd);
            this.gbxPersonel.Controls.Add(this.lblAd);
            this.gbxPersonel.Controls.Add(this.tbxId);
            this.gbxPersonel.Controls.Add(this.lblId);
            this.gbxPersonel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPersonel.Location = new System.Drawing.Point(12, 0);
            this.gbxPersonel.Name = "gbxPersonel";
            this.gbxPersonel.Size = new System.Drawing.Size(315, 312);
            this.gbxPersonel.TabIndex = 0;
            this.gbxPersonel.TabStop = false;
            this.gbxPersonel.Text = "Personel";
            // 
            // gbxIslemler
            // 
            this.gbxIslemler.Controls.Add(this.btnGrafikler);
            this.gbxIslemler.Controls.Add(this.btnIstatistik);
            this.gbxIslemler.Controls.Add(this.btnTemizle);
            this.gbxIslemler.Controls.Add(this.btnGuncelle);
            this.gbxIslemler.Controls.Add(this.btnSil);
            this.gbxIslemler.Controls.Add(this.btnKaydet);
            this.gbxIslemler.Controls.Add(this.btnListele);
            this.gbxIslemler.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.gbxIslemler.Location = new System.Drawing.Point(333, 0);
            this.gbxIslemler.Name = "gbxIslemler";
            this.gbxIslemler.Size = new System.Drawing.Size(228, 312);
            this.gbxIslemler.TabIndex = 0;
            this.gbxIslemler.TabStop = false;
            this.gbxIslemler.Text = "İşlemler";
            // 
            // gbxKayitlar
            // 
            this.gbxKayitlar.Controls.Add(this.dataGridView1);
            this.gbxKayitlar.Font = new System.Drawing.Font("Corbel", 11.25F);
            this.gbxKayitlar.Location = new System.Drawing.Point(12, 318);
            this.gbxKayitlar.Name = "gbxKayitlar";
            this.gbxKayitlar.Size = new System.Drawing.Size(549, 171);
            this.gbxKayitlar.TabIndex = 0;
            this.gbxKayitlar.TabStop = false;
            this.gbxKayitlar.Text = "Kayıtlar";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(6, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(78, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Personel id:";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(100, 28);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(136, 26);
            this.tbxId.TabIndex = 1;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(100, 62);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(136, 26);
            this.tbxAd.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(6, 69);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 18);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad:";
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(100, 97);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(136, 26);
            this.tbxSoyad.TabIndex = 5;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(6, 104);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 18);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSehir.Location = new System.Drawing.Point(6, 139);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(43, 18);
            this.lblSehir.TabIndex = 6;
            this.lblSehir.Text = "Şehir:";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaas.Location = new System.Drawing.Point(6, 176);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(44, 18);
            this.lblMaas.TabIndex = 8;
            this.lblMaas.Text = "Maaş:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.Location = new System.Drawing.Point(6, 211);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(55, 18);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "Durum:";
            // 
            // tbxMeslek
            // 
            this.tbxMeslek.Location = new System.Drawing.Point(100, 239);
            this.tbxMeslek.Name = "tbxMeslek";
            this.tbxMeslek.Size = new System.Drawing.Size(136, 26);
            this.tbxMeslek.TabIndex = 13;
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeslek.Location = new System.Drawing.Point(6, 246);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(50, 18);
            this.lblMeslek.TabIndex = 12;
            this.lblMeslek.Text = "Meslek";
            // 
            // mtbxMaas
            // 
            this.mtbxMaas.Location = new System.Drawing.Point(100, 173);
            this.mtbxMaas.Mask = "00000";
            this.mtbxMaas.Name = "mtbxMaas";
            this.mtbxMaas.Size = new System.Drawing.Size(136, 26);
            this.mtbxMaas.TabIndex = 14;
            this.mtbxMaas.ValidatingType = typeof(int);
            // 
            // cbxSehirler
            // 
            this.cbxSehirler.FormattingEnabled = true;
            this.cbxSehirler.Location = new System.Drawing.Point(100, 136);
            this.cbxSehirler.Name = "cbxSehirler";
            this.cbxSehirler.Size = new System.Drawing.Size(136, 26);
            this.cbxSehirler.TabIndex = 15;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(100, 211);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 22);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(153, 211);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 22);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(47, 35);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(133, 27);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(47, 71);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 27);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(47, 107);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 27);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(47, 140);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 27);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(47, 176);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(133, 27);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(47, 211);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(133, 27);
            this.btnIstatistik.TabIndex = 6;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.Location = new System.Drawing.Point(47, 244);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(133, 27);
            this.btnGrafikler.TabIndex = 7;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelsBindingSource
            // 
            this.tblPersonelsBindingSource.DataMember = "tbl_Personels";
            this.tblPersonelsBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // tbl_PersonelsTableAdapter
            // 
            this.tbl_PersonelsTableAdapter.ClearBeforeFill = true;
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "PerId";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "PerId";
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(589, 505);
            this.Controls.Add(this.gbxIslemler);
            this.Controls.Add(this.gbxKayitlar);
            this.Controls.Add(this.gbxPersonel);
            this.Name = "Form1";
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPersonel.ResumeLayout(false);
            this.gbxPersonel.PerformLayout();
            this.gbxIslemler.ResumeLayout(false);
            this.gbxKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPersonel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cbxSehirler;
        private System.Windows.Forms.MaskedTextBox mtbxMaas;
        private System.Windows.Forms.TextBox tbxMeslek;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gbxIslemler;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox gbxKayitlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelsBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.tbl_PersonelsTableAdapter tbl_PersonelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
    }
}

