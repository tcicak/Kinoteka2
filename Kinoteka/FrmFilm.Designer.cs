namespace Kinoteka
{
    partial class FrmFilm
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtDirektor = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnDodajKino = new System.Windows.Forms.Button();
            this.cboKina = new System.Windows.Forms.ComboBox();
            this.dgvKina = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Žanr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrijeme trajanja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Datum premijere:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(610, 234);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(610, 259);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(100, 20);
            this.txtZanr.TabIndex = 7;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(610, 285);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(100, 20);
            this.txtTrajanje.TabIndex = 8;
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(610, 313);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(100, 20);
            this.txtGodina.TabIndex = 9;
            // 
            // txtDirektor
            // 
            this.txtDirektor.Location = new System.Drawing.Point(610, 342);
            this.txtDirektor.Name = "txtDirektor";
            this.txtDirektor.Size = new System.Drawing.Size(100, 20);
            this.txtDirektor.TabIndex = 10;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(610, 98);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 11;
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(836, 555);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmijeni.TabIndex = 12;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(931, 555);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(855, 373);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(139, 68);
            this.btnRezerviraj.TabIndex = 16;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            // 
            // btnDodajKino
            // 
            this.btnDodajKino.Location = new System.Drawing.Point(671, 555);
            this.btnDodajKino.Name = "btnDodajKino";
            this.btnDodajKino.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKino.TabIndex = 17;
            this.btnDodajKino.Text = "Dodaj kino";
            this.btnDodajKino.UseVisualStyleBackColor = true;
            // 
            // cboKina
            // 
            this.cboKina.FormattingEnabled = true;
            this.cboKina.Location = new System.Drawing.Point(649, 528);
            this.cboKina.Name = "cboKina";
            this.cboKina.Size = new System.Drawing.Size(121, 21);
            this.cboKina.TabIndex = 34;
            // 
            // dgvKina
            // 
            this.dgvKina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKina.Location = new System.Drawing.Point(753, 51);
            this.dgvKina.Name = "dgvKina";
            this.dgvKina.Size = new System.Drawing.Size(316, 307);
            this.dgvKina.TabIndex = 35;
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 632);
            this.Controls.Add(this.dgvKina);
            this.Controls.Add(this.cboKina);
            this.Controls.Add(this.btnDodajKino);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtDirektor);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtZanr);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Film";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.Film_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKina)).EndInit();
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
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtDirektor;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnDodajKino;
        private System.Windows.Forms.ComboBox cboKina;
        private System.Windows.Forms.DataGridView dgvKina;
    }
}