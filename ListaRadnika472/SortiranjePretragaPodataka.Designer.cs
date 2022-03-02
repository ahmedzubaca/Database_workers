namespace ListaRadnika
{
    partial class SortiranjePretragaPodataka
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortiranjePretragaPodataka));
            this.dgvSortiranjePretragaPodataka = new System.Windows.Forms.DataGridView();
            this.RedniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cbZanimanje = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGradiliste = new System.Windows.Forms.ComboBox();
            this.pnlPretraga = new System.Windows.Forms.Panel();
            this.rbtnNe = new System.Windows.Forms.RadioButton();
            this.rbtnDa = new System.Windows.Forms.RadioButton();
            this.lblAktivan = new System.Windows.Forms.Label();
            this.btnResetujFiltere = new System.Windows.Forms.Button();
            this.btnPretraziTabelu = new System.Windows.Forms.Button();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblme = new System.Windows.Forms.Label();
            this.btnIdiNaPojedinacniPregled = new System.Windows.Forms.Button();
            this.btnIdiNaIzborOperacije = new System.Windows.Forms.Button();
            this.txtDanaNaGradilistu = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtDanaDoIstekaVize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVrijemeNaGradilistu = new System.Windows.Forms.Label();
            this.lblIsticanjeVize = new System.Windows.Forms.Label();
            this.cbManjeViseViza = new System.Windows.Forms.ComboBox();
            this.cbManjeViseGradiliste = new System.Windows.Forms.ComboBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortiranjePretragaPodataka)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSortiranjePretragaPodataka
            // 
            this.dgvSortiranjePretragaPodataka.AllowUserToAddRows = false;
            this.dgvSortiranjePretragaPodataka.AllowUserToDeleteRows = false;
            this.dgvSortiranjePretragaPodataka.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSortiranjePretragaPodataka.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSortiranjePretragaPodataka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSortiranjePretragaPodataka.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSortiranjePretragaPodataka.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSortiranjePretragaPodataka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSortiranjePretragaPodataka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RedniBroj,
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
            this.Aktivan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSortiranjePretragaPodataka.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSortiranjePretragaPodataka.Location = new System.Drawing.Point(11, 8);
            this.dgvSortiranjePretragaPodataka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSortiranjePretragaPodataka.Name = "dgvSortiranjePretragaPodataka";
            this.dgvSortiranjePretragaPodataka.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSortiranjePretragaPodataka.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSortiranjePretragaPodataka.RowTemplate.Height = 29;
            this.dgvSortiranjePretragaPodataka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSortiranjePretragaPodataka.Size = new System.Drawing.Size(1235, 503);
            this.dgvSortiranjePretragaPodataka.TabIndex = 0;
            this.dgvSortiranjePretragaPodataka.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvSortiranjePretragaPodataka_DataBindingComplete);
            // 
            // RedniBroj
            // 
            this.RedniBroj.HeaderText = "Red. br";
            this.RedniBroj.MinimumWidth = 6;
            this.RedniBroj.Name = "RedniBroj";
            this.RedniBroj.Width = 79;
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
            this.Vrijeme_provedeno_na_gradilištu.HeaderText = "Dana na gradilištu";
            this.Vrijeme_provedeno_na_gradilištu.MinimumWidth = 6;
            this.Vrijeme_provedeno_na_gradilištu.Name = "Vrijeme_provedeno_na_gradilištu";
            this.Vrijeme_provedeno_na_gradilištu.Width = 145;
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
            // cbZanimanje
            // 
            this.cbZanimanje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbZanimanje.FormattingEnabled = true;
            this.cbZanimanje.ItemHeight = 20;
            this.cbZanimanje.Location = new System.Drawing.Point(11, 10);
            this.cbZanimanje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbZanimanje.Name = "cbZanimanje";
            this.cbZanimanje.Size = new System.Drawing.Size(184, 28);
            this.cbZanimanje.TabIndex = 3;
            this.cbZanimanje.Text = "Izaberi naziv zanimanja";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(-732, 505);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(457, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sortiranje podataka";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(5, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "Izaberi kriterij za sortiranje";
            // 
            // cbGradiliste
            // 
            this.cbGradiliste.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbGradiliste.FormattingEnabled = true;
            this.cbGradiliste.Location = new System.Drawing.Point(11, 55);
            this.cbGradiliste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGradiliste.Name = "cbGradiliste";
            this.cbGradiliste.Size = new System.Drawing.Size(184, 28);
            this.cbGradiliste.TabIndex = 3;
            this.cbGradiliste.Text = "Izaberi naziv gradilišta";
            // 
            // pnlPretraga
            // 
            this.pnlPretraga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPretraga.Controls.Add(this.rbtnNe);
            this.pnlPretraga.Controls.Add(this.rbtnDa);
            this.pnlPretraga.Controls.Add(this.lblAktivan);
            this.pnlPretraga.Controls.Add(this.btnResetujFiltere);
            this.pnlPretraga.Controls.Add(this.btnPretraziTabelu);
            this.pnlPretraga.Controls.Add(this.lblPrezime);
            this.pnlPretraga.Controls.Add(this.lblme);
            this.pnlPretraga.Controls.Add(this.btnIdiNaPojedinacniPregled);
            this.pnlPretraga.Controls.Add(this.btnIdiNaIzborOperacije);
            this.pnlPretraga.Controls.Add(this.txtDanaNaGradilistu);
            this.pnlPretraga.Controls.Add(this.txtPrezime);
            this.pnlPretraga.Controls.Add(this.txtIme);
            this.pnlPretraga.Controls.Add(this.txtDanaDoIstekaVize);
            this.pnlPretraga.Controls.Add(this.label5);
            this.pnlPretraga.Controls.Add(this.label1);
            this.pnlPretraga.Controls.Add(this.label4);
            this.pnlPretraga.Controls.Add(this.label2);
            this.pnlPretraga.Controls.Add(this.lblVrijemeNaGradilistu);
            this.pnlPretraga.Controls.Add(this.lblIsticanjeVize);
            this.pnlPretraga.Controls.Add(this.cbManjeViseViza);
            this.pnlPretraga.Controls.Add(this.cbManjeViseGradiliste);
            this.pnlPretraga.Controls.Add(this.cbZanimanje);
            this.pnlPretraga.Controls.Add(this.btnExportToExcel);
            this.pnlPretraga.Controls.Add(this.btnPrint);
            this.pnlPretraga.Controls.Add(this.cbGradiliste);
            this.pnlPretraga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pnlPretraga.Location = new System.Drawing.Point(11, 522);
            this.pnlPretraga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPretraga.Name = "pnlPretraga";
            this.pnlPretraga.Size = new System.Drawing.Size(1235, 141);
            this.pnlPretraga.TabIndex = 5;
            // 
            // rbtnNe
            // 
            this.rbtnNe.AutoSize = true;
            this.rbtnNe.Location = new System.Drawing.Point(906, 59);
            this.rbtnNe.Name = "rbtnNe";
            this.rbtnNe.Size = new System.Drawing.Size(49, 24);
            this.rbtnNe.TabIndex = 12;
            this.rbtnNe.TabStop = true;
            this.rbtnNe.Text = "Ne";
            this.rbtnNe.UseVisualStyleBackColor = true;
            // 
            // rbtnDa
            // 
            this.rbtnDa.AutoSize = true;
            this.rbtnDa.Location = new System.Drawing.Point(851, 59);
            this.rbtnDa.Name = "rbtnDa";
            this.rbtnDa.Size = new System.Drawing.Size(49, 24);
            this.rbtnDa.TabIndex = 12;
            this.rbtnDa.TabStop = true;
            this.rbtnDa.Text = "Da";
            this.rbtnDa.UseVisualStyleBackColor = true;
            // 
            // lblAktivan
            // 
            this.lblAktivan.AutoSize = true;
            this.lblAktivan.Location = new System.Drawing.Point(851, 17);
            this.lblAktivan.Name = "lblAktivan";
            this.lblAktivan.Size = new System.Drawing.Size(58, 20);
            this.lblAktivan.TabIndex = 11;
            this.lblAktivan.Text = "Aktivan";
            // 
            // btnResetujFiltere
            // 
            this.btnResetujFiltere.BackColor = System.Drawing.Color.LightSalmon;
            this.btnResetujFiltere.Location = new System.Drawing.Point(1004, 52);
            this.btnResetujFiltere.Name = "btnResetujFiltere";
            this.btnResetujFiltere.Size = new System.Drawing.Size(225, 35);
            this.btnResetujFiltere.TabIndex = 10;
            this.btnResetujFiltere.Text = "Resetuj filtere";
            this.btnResetujFiltere.UseVisualStyleBackColor = false;
            this.btnResetujFiltere.Click += new System.EventHandler(this.BtnResetujFiltere_Click);
            // 
            // btnPretraziTabelu
            // 
            this.btnPretraziTabelu.BackColor = System.Drawing.Color.Yellow;
            this.btnPretraziTabelu.Location = new System.Drawing.Point(1004, 9);
            this.btnPretraziTabelu.Name = "btnPretraziTabelu";
            this.btnPretraziTabelu.Size = new System.Drawing.Size(225, 35);
            this.btnPretraziTabelu.TabIndex = 10;
            this.btnPretraziTabelu.Text = "Pretraži tabelu";
            this.btnPretraziTabelu.UseVisualStyleBackColor = false;
            this.btnPretraziTabelu.Click += new System.EventHandler(this.BtnPretraziTabelu_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(220, 58);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(103, 20);
            this.lblPrezime.TabIndex = 9;
            this.lblPrezime.Text = "Unesi prezime";
            // 
            // lblme
            // 
            this.lblme.AutoSize = true;
            this.lblme.Location = new System.Drawing.Point(220, 17);
            this.lblme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblme.Name = "lblme";
            this.lblme.Size = new System.Drawing.Size(74, 20);
            this.lblme.TabIndex = 9;
            this.lblme.Text = "Unesi ime";
            // 
            // btnIdiNaPojedinacniPregled
            // 
            this.btnIdiNaPojedinacniPregled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIdiNaPojedinacniPregled.Location = new System.Drawing.Point(743, 95);
            this.btnIdiNaPojedinacniPregled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIdiNaPojedinacniPregled.Name = "btnIdiNaPojedinacniPregled";
            this.btnIdiNaPojedinacniPregled.Size = new System.Drawing.Size(225, 35);
            this.btnIdiNaPojedinacniPregled.TabIndex = 8;
            this.btnIdiNaPojedinacniPregled.Text = "Idi na \'Pojedinačni pregled\'";
            this.btnIdiNaPojedinacniPregled.UseVisualStyleBackColor = false;
            this.btnIdiNaPojedinacniPregled.Click += new System.EventHandler(this.BtnIdiNapojedinacniPregled_Click);
            // 
            // btnIdiNaIzborOperacije
            // 
            this.btnIdiNaIzborOperacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIdiNaIzborOperacije.Location = new System.Drawing.Point(1004, 95);
            this.btnIdiNaIzborOperacije.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIdiNaIzborOperacije.Name = "btnIdiNaIzborOperacije";
            this.btnIdiNaIzborOperacije.Size = new System.Drawing.Size(225, 35);
            this.btnIdiNaIzborOperacije.TabIndex = 8;
            this.btnIdiNaIzborOperacije.Text = "Idi na \'Izbor operacije\'";
            this.btnIdiNaIzborOperacije.UseVisualStyleBackColor = false;
            this.btnIdiNaIzborOperacije.Click += new System.EventHandler(this.BtnIdiNaIzborOperacije_Click);
            // 
            // txtDanaNaGradilistu
            // 
            this.txtDanaNaGradilistu.Location = new System.Drawing.Point(724, 55);
            this.txtDanaNaGradilistu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDanaNaGradilistu.Multiline = true;
            this.txtDanaNaGradilistu.Name = "txtDanaNaGradilistu";
            this.txtDanaNaGradilistu.Size = new System.Drawing.Size(54, 28);
            this.txtDanaNaGradilistu.TabIndex = 6;
            this.txtDanaNaGradilistu.Enter += new System.EventHandler(this.TxtDanaNaGradilistu_Enter);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(327, 55);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrezime.Multiline = true;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(104, 28);
            this.txtPrezime.TabIndex = 6;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(327, 10);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(104, 28);
            this.txtIme.TabIndex = 6;
            // 
            // txtDanaDoIstekaVize
            // 
            this.txtDanaDoIstekaVize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDanaDoIstekaVize.Location = new System.Drawing.Point(724, 10);
            this.txtDanaDoIstekaVize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDanaDoIstekaVize.Multiline = true;
            this.txtDanaDoIstekaVize.Name = "txtDanaDoIstekaVize";
            this.txtDanaDoIstekaVize.Size = new System.Drawing.Size(54, 28);
            this.txtDanaDoIstekaVize.TabIndex = 6;
            this.txtDanaDoIstekaVize.Enter += new System.EventHandler(this.TxtDanaDoIstekaVize_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(692, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "od";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(692, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(784, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "dana.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(784, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "dana.";
            // 
            // lblVrijemeNaGradilistu
            // 
            this.lblVrijemeNaGradilistu.AutoSize = true;
            this.lblVrijemeNaGradilistu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVrijemeNaGradilistu.Location = new System.Drawing.Point(468, 58);
            this.lblVrijemeNaGradilistu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrijemeNaGradilistu.Name = "lblVrijemeNaGradilistu";
            this.lblVrijemeNaGradilistu.Size = new System.Drawing.Size(94, 20);
            this.lblVrijemeNaGradilistu.TabIndex = 5;
            this.lblVrijemeNaGradilistu.Text = "Na gradilištu";
            // 
            // lblIsticanjeVize
            // 
            this.lblIsticanjeVize.AutoSize = true;
            this.lblIsticanjeVize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIsticanjeVize.Location = new System.Drawing.Point(468, 17);
            this.lblIsticanjeVize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsticanjeVize.Name = "lblIsticanjeVize";
            this.lblIsticanjeVize.Size = new System.Drawing.Size(98, 20);
            this.lblIsticanjeVize.TabIndex = 5;
            this.lblIsticanjeVize.Text = "Viza ističe za ";
            // 
            // cbManjeViseViza
            // 
            this.cbManjeViseViza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbManjeViseViza.FormattingEnabled = true;
            this.cbManjeViseViza.ItemHeight = 20;
            this.cbManjeViseViza.Location = new System.Drawing.Point(566, 10);
            this.cbManjeViseViza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbManjeViseViza.Name = "cbManjeViseViza";
            this.cbManjeViseViza.Size = new System.Drawing.Size(120, 28);
            this.cbManjeViseViza.TabIndex = 3;
            this.cbManjeViseViza.Text = "Izaberi uslov";
            // 
            // cbManjeViseGradiliste
            // 
            this.cbManjeViseGradiliste.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbManjeViseGradiliste.FormattingEnabled = true;
            this.cbManjeViseGradiliste.ItemHeight = 20;
            this.cbManjeViseGradiliste.Location = new System.Drawing.Point(566, 53);
            this.cbManjeViseGradiliste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbManjeViseGradiliste.Name = "cbManjeViseGradiliste";
            this.cbManjeViseGradiliste.Size = new System.Drawing.Size(120, 28);
            this.cbManjeViseGradiliste.TabIndex = 3;
            this.cbManjeViseGradiliste.Text = "Izaberi uslov";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExportToExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportToExcel.Location = new System.Drawing.Point(482, 95);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(225, 35);
            this.btnExportToExcel.TabIndex = 4;
            this.btnExportToExcel.Text = "Otvori tabelu u Excelu";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.Location = new System.Drawing.Point(214, 95);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(225, 35);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Printaj/snimi tabelu u Pdf-u";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SortiranjePretragaPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1256, 672);
            this.Controls.Add(this.pnlPretraga);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSortiranjePretragaPodataka);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SortiranjePretragaPodataka";
            this.Text = "Pretraživanje podataka";
            this.Load += new System.EventHandler(this.SortiranjePretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortiranjePretragaPodataka)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.pnlPretraga.ResumeLayout(false);
            this.pnlPretraga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSortiranjePretragaPodataka;
        private System.Windows.Forms.ComboBox cbZanimanje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGradiliste;
        private System.Windows.Forms.Panel pnlPretraga;
        private System.Windows.Forms.TextBox txtDanaDoIstekaVize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIsticanjeVize;
        private System.Windows.Forms.TextBox txtDanaNaGradilistu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVrijemeNaGradilistu;
        private System.Windows.Forms.ComboBox cbManjeViseGradiliste;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnIdiNaIzborOperacije;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnPretraziTabelu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbManjeViseViza;
        private System.Windows.Forms.RadioButton rbtnNe;
        private System.Windows.Forms.RadioButton rbtnDa;
        private System.Windows.Forms.Label lblAktivan;
        private System.Windows.Forms.Button btnResetujFiltere;
        private System.Windows.Forms.Button btnIdiNaPojedinacniPregled;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedniBroj;
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
    }
}