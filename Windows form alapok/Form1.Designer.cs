namespace Windows_form_alapok
{
    partial class hobbik
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
            this.nev = new System.Windows.Forms.Label();
            this.ujHobbi = new System.Windows.Forms.Label();
            this.kedvencHobbi = new System.Windows.Forms.Label();
            this.nem = new System.Windows.Forms.Label();
            this.szulDatum = new System.Windows.Forms.Label();
            this.hozzaAd = new System.Windows.Forms.Button();
            this.betoltes = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.RadioButton();
            this.ferfi = new System.Windows.Forms.RadioButton();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.szulDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.hobbiLista = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(57, 24);
            this.nev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(30, 13);
            this.nev.TabIndex = 0;
            this.nev.Text = "Név:";
            // 
            // ujHobbi
            // 
            this.ujHobbi.AutoSize = true;
            this.ujHobbi.Location = new System.Drawing.Point(357, 207);
            this.ujHobbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ujHobbi.Name = "ujHobbi";
            this.ujHobbi.Size = new System.Drawing.Size(49, 13);
            this.ujHobbi.TabIndex = 1;
            this.ujHobbi.Text = "Új hobbi:";
            // 
            // kedvencHobbi
            // 
            this.kedvencHobbi.AutoSize = true;
            this.kedvencHobbi.Location = new System.Drawing.Point(466, 7);
            this.kedvencHobbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kedvencHobbi.Name = "kedvencHobbi";
            this.kedvencHobbi.Size = new System.Drawing.Size(82, 13);
            this.kedvencHobbi.TabIndex = 2;
            this.kedvencHobbi.Text = "Kedvenc hobbi:";
            // 
            // nem
            // 
            this.nem.AutoSize = true;
            this.nem.Location = new System.Drawing.Point(54, 101);
            this.nem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(32, 13);
            this.nem.TabIndex = 3;
            this.nem.Text = "Nem:";
            // 
            // szulDatum
            // 
            this.szulDatum.AutoSize = true;
            this.szulDatum.Location = new System.Drawing.Point(20, 57);
            this.szulDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.szulDatum.Name = "szulDatum";
            this.szulDatum.Size = new System.Drawing.Size(65, 13);
            this.szulDatum.TabIndex = 4;
            this.szulDatum.Text = "Szül. dátum:";
            // 
            // hozzaAd
            // 
            this.hozzaAd.Location = new System.Drawing.Point(423, 236);
            this.hozzaAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hozzaAd.Name = "hozzaAd";
            this.hozzaAd.Size = new System.Drawing.Size(121, 28);
            this.hozzaAd.TabIndex = 5;
            this.hozzaAd.Text = "Hozzáad";
            this.hozzaAd.UseVisualStyleBackColor = true;
            this.hozzaAd.Click += new System.EventHandler(this.hozzaAd_Click);
            // 
            // betoltes
            // 
            this.betoltes.Location = new System.Drawing.Point(469, 318);
            this.betoltes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(75, 37);
            this.betoltes.TabIndex = 6;
            this.betoltes.Text = "Betöltés";
            this.betoltes.UseVisualStyleBackColor = true;
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(359, 318);
            this.mentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(88, 37);
            this.mentes.TabIndex = 7;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(114, 99);
            this.no.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(33, 17);
            this.no.TabIndex = 8;
            this.no.TabStop = true;
            this.no.Text = "N";
            this.no.UseVisualStyleBackColor = true;
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.Location = new System.Drawing.Point(178, 99);
            this.ferfi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(31, 17);
            this.ferfi.TabIndex = 9;
            this.ferfi.TabStop = true;
            this.ferfi.Text = "F";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(114, 20);
            this.textBoxNev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(167, 20);
            this.textBoxNev.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(415, 207);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 13;
            // 
            // szulDatumPicker
            // 
            this.szulDatumPicker.Location = new System.Drawing.Point(114, 57);
            this.szulDatumPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.szulDatumPicker.Name = "szulDatumPicker";
            this.szulDatumPicker.Size = new System.Drawing.Size(167, 20);
            this.szulDatumPicker.TabIndex = 14;
            // 
            // hobbiLista
            // 
            this.hobbiLista.FormattingEnabled = true;
            this.hobbiLista.Location = new System.Drawing.Point(415, 24);
            this.hobbiLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hobbiLista.Name = "hobbiLista";
            this.hobbiLista.Size = new System.Drawing.Size(177, 160);
            this.hobbiLista.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // hobbik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.hobbiLista);
            this.Controls.Add(this.szulDatumPicker);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.ferfi);
            this.Controls.Add(this.no);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.betoltes);
            this.Controls.Add(this.hozzaAd);
            this.Controls.Add(this.szulDatum);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.kedvencHobbi);
            this.Controls.Add(this.ujHobbi);
            this.Controls.Add(this.nev);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "hobbik";
            this.Text = "Hobbik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label ujHobbi;
        private System.Windows.Forms.Label kedvencHobbi;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.Label szulDatum;
        private System.Windows.Forms.Button hozzaAd;
        private System.Windows.Forms.Button betoltes;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton ferfi;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker szulDatumPicker;
        private System.Windows.Forms.ListBox hobbiLista;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

