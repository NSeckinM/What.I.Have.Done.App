
namespace What.I.Have.Done
{
    partial class AnaForm
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
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.lstYapilanlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYildizla = new System.Windows.Forms.Button();
            this.dtpAnaForm = new System.Windows.Forms.DateTimePicker();
            this.btnTarihSec = new System.Windows.Forms.Button();
            this.checkBYildizliGoster = new System.Windows.Forms.CheckBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.checkBYenile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(12, 37);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(329, 37);
            this.txtMesaj.TabIndex = 0;
            // 
            // lstYapilanlar
            // 
            this.lstYapilanlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstYapilanlar.FormattingEnabled = true;
            this.lstYapilanlar.ItemHeight = 20;
            this.lstYapilanlar.Location = new System.Drawing.Point(12, 194);
            this.lstYapilanlar.Name = "lstYapilanlar";
            this.lstYapilanlar.Size = new System.Drawing.Size(330, 204);
            this.lstYapilanlar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Neler Yaptın ?";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDuzenle.Location = new System.Drawing.Point(12, 414);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(153, 38);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(171, 414);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(170, 38);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(12, 149);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(329, 39);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYildizla
            // 
            this.btnYildizla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYildizla.Location = new System.Drawing.Point(12, 470);
            this.btnYildizla.Name = "btnYildizla";
            this.btnYildizla.Size = new System.Drawing.Size(329, 37);
            this.btnYildizla.TabIndex = 7;
            this.btnYildizla.Text = "Yildizla veya Yıldızı Kaldır.";
            this.btnYildizla.UseVisualStyleBackColor = true;
            this.btnYildizla.Click += new System.EventHandler(this.btnYildizla_Click);
            // 
            // dtpAnaForm
            // 
            this.dtpAnaForm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAnaForm.Location = new System.Drawing.Point(12, 80);
            this.dtpAnaForm.Name = "dtpAnaForm";
            this.dtpAnaForm.Size = new System.Drawing.Size(329, 27);
            this.dtpAnaForm.TabIndex = 8;
            this.dtpAnaForm.Visible = false;
            // 
            // btnTarihSec
            // 
            this.btnTarihSec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTarihSec.Location = new System.Drawing.Point(12, 113);
            this.btnTarihSec.Name = "btnTarihSec";
            this.btnTarihSec.Size = new System.Drawing.Size(329, 29);
            this.btnTarihSec.TabIndex = 9;
            this.btnTarihSec.Text = "Tarih Seç ";
            this.btnTarihSec.UseVisualStyleBackColor = true;
            this.btnTarihSec.Click += new System.EventHandler(this.btnTarihSec_Click);
            // 
            // checkBYildizliGoster
            // 
            this.checkBYildizliGoster.AutoSize = true;
            this.checkBYildizliGoster.Location = new System.Drawing.Point(12, 524);
            this.checkBYildizliGoster.Name = "checkBYildizliGoster";
            this.checkBYildizliGoster.Size = new System.Drawing.Size(186, 24);
            this.checkBYildizliGoster.TabIndex = 10;
            this.checkBYildizliGoster.Text = "Yıldızlı Mesajları Göster";
            this.checkBYildizliGoster.UseVisualStyleBackColor = true;
            this.checkBYildizliGoster.CheckedChanged += new System.EventHandler(this.checkBYildizliGoster_CheckedChanged);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAra.Location = new System.Drawing.Point(12, 554);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(329, 35);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Tarihe / İçeriğe Göre Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // checkBYenile
            // 
            this.checkBYenile.AutoSize = true;
            this.checkBYenile.Location = new System.Drawing.Point(194, 524);
            this.checkBYenile.Name = "checkBYenile";
            this.checkBYenile.Size = new System.Drawing.Size(115, 24);
            this.checkBYenile.TabIndex = 12;
            this.checkBYenile.Text = "Listeyi Yenile";
            this.checkBYenile.UseVisualStyleBackColor = true;
            this.checkBYenile.CheckedChanged += new System.EventHandler(this.checkBYenile_CheckedChanged);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 601);
            this.Controls.Add(this.checkBYenile);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.checkBYildizliGoster);
            this.Controls.Add(this.btnTarihSec);
            this.Controls.Add(this.dtpAnaForm);
            this.Controls.Add(this.btnYildizla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstYapilanlar);
            this.Controls.Add(this.txtMesaj);
            this.Name = "AnaForm";
            this.Text = "What I Have Done";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYildizla;
        private System.Windows.Forms.DateTimePicker dtpAnaForm;
        private System.Windows.Forms.Button btnTarihSec;
        public System.Windows.Forms.ListBox lstYapilanlar;
        private System.Windows.Forms.CheckBox checkBYildizliGoster;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.CheckBox checkBYenile;
    }
}