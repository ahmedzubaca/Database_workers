namespace ListaRadnika
{
    partial class IzborOperacije
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrikazPodatakaORadnicima = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_rođenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesto_boravka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj_pasoša = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_isteka_vize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dana_do_isteka_vize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zanimanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gradilište = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na_gradilištu_od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme_provedeno_na_gradilištu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija_slike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija_pasoša = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija_vize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija_radne_dozvole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajRadnika = new System.Windows.Forms.Button();
            this.btnIzbrisiRadnika = new System.Windows.Forms.Button();
            this.btnIspraviPogresanUnos = new System.Windows.Forms.Button();
            this.btnPojedinacniPregled = new System.Windows.Forms.Button();
            this.BtnPretraziSortirajPodatke = new System.Windows.Forms.Button();
            this.btnKatalozi = new System.Windows.Forms.Button();
            this.btnOtvoriTabeluUExcelu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazPodatakaORadnicima)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazPodatakaORadnicima
            // 
            this.dgvPrikazPodatakaORadnicima.AllowUserToAddRows = false;
            this.dgvPrikazPodatakaORadnicima.AllowUserToDeleteRows = false;
            this.dgvPrikazPodatakaORadnicima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPrikazPodatakaORadnicima.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPrikazPodatakaORadnicima.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPrikazPodatakaORadnicima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazPodatakaORadnicima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.Datum_rođenja,
            this.Spol,
            this.Mjesto_boravka,
            this.Broj_pasoša,
            this.Datum_isteka_vize,
            this.Dana_do_isteka_vize,
            this.Zanimanje,
            this.Gradilište,
            this.Na_gradilištu_od,
            this.Vrijeme_provedeno_na_gradilištu,
            this.Plata,
            this.Aktivan,
            this.Lokacija_slike,
            this.Lokacija_pasoša,
            this.Lokacija_vize,
            this.Lokacija_radne_dozvole});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazPodatakaORadnicima.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrikazPodatakaORadnicima.Location = new System.Drawing.Point(12, 22);
            this.dgvPrikazPodatakaORadnicima.Name = "dgvPrikazPodatakaORadnicima";
            this.dgvPrikazPodatakaORadnicima.RowHeadersWidth = 60;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrikazPodatakaORadnicima.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrikazPodatakaORadnicima.RowTemplate.Height = 29;
            this.dgvPrikazPodatakaORadnicima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPrikazPodatakaORadnicima.Size = new System.Drawing.Size(1220, 490);
            this.dgvPrikazPodatakaORadnicima.TabIndex = 0;
            this.dgvPrikazPodatakaORadnicima.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvPrikazPodatakaORadnicima_DataBindingComplete);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_radnika";
            this.Id.HeaderText = "Id radnika";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 96;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.Width = 63;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.Width = 91;
            // 
            // Datum_rođenja
            // 
            this.Datum_rođenja.DataPropertyName = "Datum_rođenja";
            this.Datum_rođenja.HeaderText = "Datum rođenja";
            this.Datum_rođenja.MinimumWidth = 6;
            this.Datum_rođenja.Name = "Datum_rođenja";
            this.Datum_rođenja.Width = 127;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.MinimumWidth = 6;
            this.Spol.Name = "Spol";
            this.Spol.Width = 68;
            // 
            // Mjesto_boravka
            // 
            this.Mjesto_boravka.DataPropertyName = "Mjesto_boravka";
            this.Mjesto_boravka.HeaderText = "Mjesto boravka";
            this.Mjesto_boravka.MinimumWidth = 6;
            this.Mjesto_boravka.Name = "Mjesto_boravka";
            this.Mjesto_boravka.Width = 128;
            // 
            // Broj_pasoša
            // 
            this.Broj_pasoša.DataPropertyName = "Broj_pasoša";
            this.Broj_pasoša.HeaderText = "Broj pasoša";
            this.Broj_pasoša.MinimumWidth = 6;
            this.Broj_pasoša.Name = "Broj_pasoša";
            this.Broj_pasoša.Width = 106;
            // 
            // Datum_isteka_vize
            // 
            this.Datum_isteka_vize.DataPropertyName = "Datum_isteka_vize";
            this.Datum_isteka_vize.HeaderText = "Datum isteka vize";
            this.Datum_isteka_vize.MinimumWidth = 6;
            this.Datum_isteka_vize.Name = "Datum_isteka_vize";
            this.Datum_isteka_vize.Width = 118;
            // 
            // Dana_do_isteka_vize
            // 
            this.Dana_do_isteka_vize.DataPropertyName = "Dana_do_isteka_vize";
            this.Dana_do_isteka_vize.HeaderText = "Dana do isteka vize";
            this.Dana_do_isteka_vize.MinimumWidth = 6;
            this.Dana_do_isteka_vize.Name = "Dana_do_isteka_vize";
            this.Dana_do_isteka_vize.Width = 129;
            // 
            // Zanimanje
            // 
            this.Zanimanje.DataPropertyName = "Zanimanje";
            this.Zanimanje.HeaderText = "Zanimanje";
            this.Zanimanje.MinimumWidth = 6;
            this.Zanimanje.Name = "Zanimanje";
            this.Zanimanje.Width = 108;
            // 
            // Gradilište
            // 
            this.Gradilište.DataPropertyName = "Gradilište";
            this.Gradilište.HeaderText = "Gradilište";
            this.Gradilište.MinimumWidth = 6;
            this.Gradilište.Name = "Gradilište";
            this.Gradilište.Width = 101;
            // 
            // Na_gradilištu_od
            // 
            this.Na_gradilištu_od.DataPropertyName = "Na_gradilištu_od";
            this.Na_gradilištu_od.HeaderText = "Na gradilištu od";
            this.Na_gradilištu_od.MinimumWidth = 6;
            this.Na_gradilištu_od.Name = "Na_gradilištu_od";
            this.Na_gradilištu_od.Width = 133;
            // 
            // Vrijeme_provedeno_na_gradilištu
            // 
            this.Vrijeme_provedeno_na_gradilištu.DataPropertyName = "Vrijeme_provedeno_na_gradilištu";
            this.Vrijeme_provedeno_na_gradilištu.HeaderText = "Vrijeme provedeno na gradilištu";
            this.Vrijeme_provedeno_na_gradilištu.MinimumWidth = 6;
            this.Vrijeme_provedeno_na_gradilištu.Name = "Vrijeme_provedeno_na_gradilištu";
            this.Vrijeme_provedeno_na_gradilištu.Width = 172;
            // 
            // Plata
            // 
            this.Plata.DataPropertyName = "Plata";
            this.Plata.HeaderText = "Plata";
            this.Plata.MinimumWidth = 6;
            this.Plata.Name = "Plata";
            this.Plata.Width = 71;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.Width = 87;
            // 
            // Lokacija_slike
            // 
            this.Lokacija_slike.DataPropertyName = "Lokacija_slike";
            this.Lokacija_slike.HeaderText = "Lokacija slike";
            this.Lokacija_slike.MinimumWidth = 6;
            this.Lokacija_slike.Name = "Lokacija_slike";
            this.Lokacija_slike.Width = 115;
            // 
            // Lokacija_pasoša
            // 
            this.Lokacija_pasoša.DataPropertyName = "Lokacija_pasoša";
            this.Lokacija_pasoša.HeaderText = "Lokacija pasoša";
            this.Lokacija_pasoša.MinimumWidth = 6;
            this.Lokacija_pasoša.Name = "Lokacija_pasoša";
            this.Lokacija_pasoša.Width = 130;
            // 
            // Lokacija_vize
            // 
            this.Lokacija_vize.DataPropertyName = "Lokacija_vize";
            this.Lokacija_vize.HeaderText = "Lokacija_vize";
            this.Lokacija_vize.MinimumWidth = 6;
            this.Lokacija_vize.Name = "Lokacija_vize";
            this.Lokacija_vize.Width = 124;
            // 
            // Lokacija_radne_dozvole
            // 
            this.Lokacija_radne_dozvole.DataPropertyName = "Lokacija_radne_dozvole";
            this.Lokacija_radne_dozvole.HeaderText = "Lokacija_radne_dozvole";
            this.Lokacija_radne_dozvole.MinimumWidth = 6;
            this.Lokacija_radne_dozvole.Name = "Lokacija_radne_dozvole";
            this.Lokacija_radne_dozvole.Width = 195;
            // 
            // btnDodajRadnika
            // 
            this.btnDodajRadnika.BackColor = System.Drawing.Color.Wheat;
            this.btnDodajRadnika.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRadnika.Location = new System.Drawing.Point(35, 520);
            this.btnDodajRadnika.Name = "btnDodajRadnika";
            this.btnDodajRadnika.Size = new System.Drawing.Size(215, 40);
            this.btnDodajRadnika.TabIndex = 1;
            this.btnDodajRadnika.Text = "Dodaj radnika";
            this.btnDodajRadnika.UseVisualStyleBackColor = false;
            this.btnDodajRadnika.Click += new System.EventHandler(this.btnDodajRadnika_Click);
            // 
            // btnIzbrisiRadnika
            // 
            this.btnIzbrisiRadnika.BackColor = System.Drawing.Color.Wheat;
            this.btnIzbrisiRadnika.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiRadnika.Location = new System.Drawing.Point(276, 520);
            this.btnIzbrisiRadnika.Name = "btnIzbrisiRadnika";
            this.btnIzbrisiRadnika.Size = new System.Drawing.Size(215, 40);
            this.btnIzbrisiRadnika.TabIndex = 1;
            this.btnIzbrisiRadnika.Text = "Izbriši radnika";
            this.btnIzbrisiRadnika.UseVisualStyleBackColor = false;
            this.btnIzbrisiRadnika.Click += new System.EventHandler(this.btnIzbrisiRadnika_Click);
            // 
            // btnIspraviPogresanUnos
            // 
            this.btnIspraviPogresanUnos.BackColor = System.Drawing.Color.Wheat;
            this.btnIspraviPogresanUnos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspraviPogresanUnos.Location = new System.Drawing.Point(517, 520);
            this.btnIspraviPogresanUnos.Name = "btnIspraviPogresanUnos";
            this.btnIspraviPogresanUnos.Size = new System.Drawing.Size(215, 40);
            this.btnIspraviPogresanUnos.TabIndex = 1;
            this.btnIspraviPogresanUnos.Text = "Ispravi pogrešan unos";
            this.btnIspraviPogresanUnos.UseVisualStyleBackColor = false;
            this.btnIspraviPogresanUnos.Click += new System.EventHandler(this.btnIspraviPogresanUnos_Click);
            // 
            // btnPojedinacniPregled
            // 
            this.btnPojedinacniPregled.BackColor = System.Drawing.Color.Wheat;
            this.btnPojedinacniPregled.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPojedinacniPregled.Location = new System.Drawing.Point(1000, 520);
            this.btnPojedinacniPregled.Name = "btnPojedinacniPregled";
            this.btnPojedinacniPregled.Size = new System.Drawing.Size(215, 40);
            this.btnPojedinacniPregled.TabIndex = 1;
            this.btnPojedinacniPregled.Text = "Pojedinačni pregled";
            this.btnPojedinacniPregled.UseVisualStyleBackColor = false;
            this.btnPojedinacniPregled.Click += new System.EventHandler(this.BtnPojedinacniPregled_Click);
            // 
            // BtnPretraziSortirajPodatke
            // 
            this.BtnPretraziSortirajPodatke.BackColor = System.Drawing.Color.Wheat;
            this.BtnPretraziSortirajPodatke.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPretraziSortirajPodatke.Location = new System.Drawing.Point(758, 520);
            this.BtnPretraziSortirajPodatke.Name = "BtnPretraziSortirajPodatke";
            this.BtnPretraziSortirajPodatke.Size = new System.Drawing.Size(215, 40);
            this.BtnPretraziSortirajPodatke.TabIndex = 1;
            this.BtnPretraziSortirajPodatke.Text = "Pretraži i sortiraj podatke";
            this.BtnPretraziSortirajPodatke.UseVisualStyleBackColor = false;
            this.BtnPretraziSortirajPodatke.Click += new System.EventHandler(this.BtnPretraziSortirajPodatke_Click);
            // 
            // btnKatalozi
            // 
            this.btnKatalozi.BackColor = System.Drawing.Color.Wheat;
            this.btnKatalozi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKatalozi.Location = new System.Drawing.Point(150, 573);
            this.btnKatalozi.Name = "btnKatalozi";
            this.btnKatalozi.Size = new System.Drawing.Size(300, 40);
            this.btnKatalozi.TabIndex = 1;
            this.btnKatalozi.Text = "Ažuriraj zanimanja i gradilišta";
            this.btnKatalozi.UseVisualStyleBackColor = false;
            this.btnKatalozi.Click += new System.EventHandler(this.btnKatalozi_Click);
            // 
            // btnOtvoriTabeluUExcelu
            // 
            this.btnOtvoriTabeluUExcelu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOtvoriTabeluUExcelu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtvoriTabeluUExcelu.Location = new System.Drawing.Point(782, 573);
            this.btnOtvoriTabeluUExcelu.Name = "btnOtvoriTabeluUExcelu";
            this.btnOtvoriTabeluUExcelu.Size = new System.Drawing.Size(300, 40);
            this.btnOtvoriTabeluUExcelu.TabIndex = 2;
            this.btnOtvoriTabeluUExcelu.Text = "Otvori tabelu u Excelu";
            this.btnOtvoriTabeluUExcelu.UseVisualStyleBackColor = false;
            this.btnOtvoriTabeluUExcelu.Click += new System.EventHandler(this.btnOtvoriTabeluUExcelu_Click);
            // 
            // IzborOperacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 623);
            this.Controls.Add(this.btnOtvoriTabeluUExcelu);
            this.Controls.Add(this.BtnPretraziSortirajPodatke);
            this.Controls.Add(this.btnPojedinacniPregled);
            this.Controls.Add(this.btnIspraviPogresanUnos);
            this.Controls.Add(this.btnIzbrisiRadnika);
            this.Controls.Add(this.btnKatalozi);
            this.Controls.Add(this.btnDodajRadnika);
            this.Controls.Add(this.dgvPrikazPodatakaORadnicima);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.Name = "IzborOperacije";
            this.Text = "Izbor operacije";
            this.Load += new System.EventHandler(this.IzborOperacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazPodatakaORadnicima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazPodatakaORadnicima;
        private System.Windows.Forms.Button btnDodajRadnika;
        private System.Windows.Forms.Button btnIzbrisiRadnika;
        private System.Windows.Forms.Button btnIspraviPogresanUnos;
        private System.Windows.Forms.Button btnPojedinacniPregled;
        private System.Windows.Forms.Button BtnPretraziSortirajPodatke;
        private System.Windows.Forms.Button btnKatalozi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_rođenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesto_boravka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj_pasoša;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum_isteka_vize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dana_do_isteka_vize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zanimanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gradilište;
        private System.Windows.Forms.DataGridViewTextBoxColumn Na_gradilištu_od;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme_provedeno_na_gradilištu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija_slike;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija_pasoša;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija_vize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija_radne_dozvole;
        private System.Windows.Forms.Button btnOtvoriTabeluUExcelu;
    }
}