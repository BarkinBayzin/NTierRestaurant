namespace NTierRestaurant.WINUI
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
            this.btnYokEt = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSilinenler = new System.Windows.Forms.Button();
            this.btnModified = new System.Windows.Forms.Button();
            this.btnAktifler = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.bnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYokEt
            // 
            this.btnYokEt.Location = new System.Drawing.Point(436, 494);
            this.btnYokEt.Name = "btnYokEt";
            this.btnYokEt.Size = new System.Drawing.Size(140, 37);
            this.btnYokEt.TabIndex = 13;
            this.btnYokEt.Text = "Yok Et";
            this.btnYokEt.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(229, 494);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(140, 37);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(15, 494);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 37);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnSilinenler
            // 
            this.btnSilinenler.Location = new System.Drawing.Point(862, 427);
            this.btnSilinenler.Name = "btnSilinenler";
            this.btnSilinenler.Size = new System.Drawing.Size(216, 40);
            this.btnSilinenler.TabIndex = 10;
            this.btnSilinenler.Text = "Silinenler";
            this.btnSilinenler.UseVisualStyleBackColor = true;
            // 
            // btnModified
            // 
            this.btnModified.Location = new System.Drawing.Point(862, 381);
            this.btnModified.Name = "btnModified";
            this.btnModified.Size = new System.Drawing.Size(216, 40);
            this.btnModified.TabIndex = 11;
            this.btnModified.Text = "Guncellenenler";
            this.btnModified.UseVisualStyleBackColor = true;
            // 
            // btnAktifler
            // 
            this.btnAktifler.Location = new System.Drawing.Point(862, 335);
            this.btnAktifler.Name = "btnAktifler";
            this.btnAktifler.Size = new System.Drawing.Size(216, 40);
            this.btnAktifler.TabIndex = 12;
            this.btnAktifler.Text = "Aktifler";
            this.btnAktifler.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(862, 279);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(216, 22);
            this.txtAciklama.TabIndex = 8;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(862, 205);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(216, 22);
            this.txtIsim.TabIndex = 9;
            // 
            // bnKategoriEkle
            // 
            this.bnKategoriEkle.Location = new System.Drawing.Point(853, 101);
            this.bnKategoriEkle.Margin = new System.Windows.Forms.Padding(6);
            this.bnKategoriEkle.Name = "bnKategoriEkle";
            this.bnKategoriEkle.Size = new System.Drawing.Size(208, 48);
            this.bnKategoriEkle.TabIndex = 6;
            this.bnKategoriEkle.Text = "Kategori Ekle";
            this.bnKategoriEkle.UseVisualStyleBackColor = true;
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(853, 15);
            this.btnKategoriler.Margin = new System.Windows.Forms.Padding(6);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(208, 48);
            this.btnKategoriler.TabIndex = 7;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(15, 15);
            this.dgvKategoriler.Margin = new System.Windows.Forms.Padding(6);
            this.dgvKategoriler.MultiSelect = false;
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.RowHeadersWidth = 51;
            this.dgvKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriler.Size = new System.Drawing.Size(826, 450);
            this.dgvKategoriler.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 540);
            this.Controls.Add(this.btnYokEt);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSilinenler);
            this.Controls.Add(this.btnModified);
            this.Controls.Add(this.btnAktifler);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.bnKategoriEkle);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.dgvKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYokEt;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSilinenler;
        private System.Windows.Forms.Button btnModified;
        private System.Windows.Forms.Button btnAktifler;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button bnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.DataGridView dgvKategoriler;
    }
}

