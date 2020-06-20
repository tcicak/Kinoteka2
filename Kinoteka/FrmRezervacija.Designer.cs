namespace Kinoteka
{
    partial class FrmRezervacija
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOdabranaSjedala = new System.Windows.Forms.DataGridView();
            this.cboRed = new System.Windows.Forms.ComboBox();
            this.cboSjedalo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDodajSjedalo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.btnKupi = new System.Windows.Forms.Button();
            this.txtImeFilma = new System.Windows.Forms.TextBox();
            this.txtDatumFilma = new System.Windows.Forms.TextBox();
            this.txtVrijemeTrajanja = new System.Windows.Forms.TextBox();
            this.txtImeKina = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabranaSjedala)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime filma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum filma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrijeme trajanja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ime kina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adresa:";
            // 
            // dgvOdabranaSjedala
            // 
            this.dgvOdabranaSjedala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabranaSjedala.Location = new System.Drawing.Point(319, 201);
            this.dgvOdabranaSjedala.Name = "dgvOdabranaSjedala";
            this.dgvOdabranaSjedala.Size = new System.Drawing.Size(249, 278);
            this.dgvOdabranaSjedala.TabIndex = 6;
            // 
            // cboRed
            // 
            this.cboRed.FormattingEnabled = true;
            this.cboRed.Location = new System.Drawing.Point(169, 201);
            this.cboRed.Name = "cboRed";
            this.cboRed.Size = new System.Drawing.Size(121, 21);
            this.cboRed.TabIndex = 7;
            // 
            // cboSjedalo
            // 
            this.cboSjedalo.FormattingEnabled = true;
            this.cboSjedalo.Location = new System.Drawing.Point(169, 246);
            this.cboSjedalo.Name = "cboSjedalo";
            this.cboSjedalo.Size = new System.Drawing.Size(121, 21);
            this.cboSjedalo.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Red:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Broj sjedala:";
            // 
            // btnDodajSjedalo
            // 
            this.btnDodajSjedalo.Location = new System.Drawing.Point(192, 290);
            this.btnDodajSjedalo.Name = "btnDodajSjedalo";
            this.btnDodajSjedalo.Size = new System.Drawing.Size(81, 35);
            this.btnDodajSjedalo.TabIndex = 11;
            this.btnDodajSjedalo.Text = "Dodaj sjedalo";
            this.btnDodajSjedalo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Odabrana sjedala";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Cijena:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "PDV:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(640, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Ukupna cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(761, 206);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 16;
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(761, 234);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(100, 20);
            this.txtPDV.TabIndex = 17;
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(761, 264);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(100, 20);
            this.txtUkupnaCijena.TabIndex = 18;
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(677, 332);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(154, 76);
            this.btnKupi.TabIndex = 19;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            // 
            // txtImeFilma
            // 
            this.txtImeFilma.Location = new System.Drawing.Point(169, 61);
            this.txtImeFilma.Name = "txtImeFilma";
            this.txtImeFilma.Size = new System.Drawing.Size(100, 20);
            this.txtImeFilma.TabIndex = 20;
            // 
            // txtDatumFilma
            // 
            this.txtDatumFilma.Location = new System.Drawing.Point(169, 87);
            this.txtDatumFilma.Name = "txtDatumFilma";
            this.txtDatumFilma.Size = new System.Drawing.Size(100, 20);
            this.txtDatumFilma.TabIndex = 21;
            // 
            // txtVrijemeTrajanja
            // 
            this.txtVrijemeTrajanja.Location = new System.Drawing.Point(169, 113);
            this.txtVrijemeTrajanja.Name = "txtVrijemeTrajanja";
            this.txtVrijemeTrajanja.Size = new System.Drawing.Size(100, 20);
            this.txtVrijemeTrajanja.TabIndex = 22;
            // 
            // txtImeKina
            // 
            this.txtImeKina.Location = new System.Drawing.Point(432, 61);
            this.txtImeKina.Name = "txtImeKina";
            this.txtImeKina.Size = new System.Drawing.Size(100, 20);
            this.txtImeKina.TabIndex = 23;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(432, 87);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(100, 20);
            this.txtGrad.TabIndex = 24;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(432, 113);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 25;
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 639);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtImeKina);
            this.Controls.Add(this.txtVrijemeTrajanja);
            this.Controls.Add(this.txtDatumFilma);
            this.Controls.Add(this.txtImeFilma);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDodajSjedalo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboSjedalo);
            this.Controls.Add(this.cboRed);
            this.Controls.Add(this.dgvOdabranaSjedala);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rezervacija";
            this.Text = "Rezervacija";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabranaSjedala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOdabranaSjedala;
        private System.Windows.Forms.ComboBox cboRed;
        private System.Windows.Forms.ComboBox cboSjedalo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDodajSjedalo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.TextBox txtImeFilma;
        private System.Windows.Forms.TextBox txtDatumFilma;
        private System.Windows.Forms.TextBox txtVrijemeTrajanja;
        private System.Windows.Forms.TextBox txtImeKina;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtAdresa;
    }
}