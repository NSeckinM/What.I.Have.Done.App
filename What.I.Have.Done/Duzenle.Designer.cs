
namespace What.I.Have.Done
{
    partial class Duzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYapilan = new System.Windows.Forms.TextBox();
            this.dtpZaman = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yapilan:";
            // 
            // txtYapilan
            // 
            this.txtYapilan.Location = new System.Drawing.Point(86, 11);
            this.txtYapilan.Multiline = true;
            this.txtYapilan.Name = "txtYapilan";
            this.txtYapilan.Size = new System.Drawing.Size(260, 34);
            this.txtYapilan.TabIndex = 1;
            // 
            // dtpZaman
            // 
            this.dtpZaman.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpZaman.Location = new System.Drawing.Point(12, 53);
            this.dtpZaman.Name = "dtpZaman";
            this.dtpZaman.Size = new System.Drawing.Size(334, 27);
            this.dtpZaman.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(366, 11);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(157, 33);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnİptal.Location = new System.Drawing.Point(366, 53);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(157, 33);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 154);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpZaman);
            this.Controls.Add(this.txtYapilan);
            this.Controls.Add(this.label1);
            this.Name = "Duzenle";
            this.Text = "Duzenleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYapilan;
        private System.Windows.Forms.DateTimePicker dtpZaman;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnİptal;
    }
}