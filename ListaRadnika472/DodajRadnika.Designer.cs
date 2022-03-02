namespace ListaRadnika
{
    partial class DodajRadnika
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodenja = new System.Windows.Forms.Label();
            this.lblBrojPasosa = new System.Windows.Forms.Label();
            this.lblMjestoBoravka = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtMjestoBoravka = new System.Windows.Forms.TextBox();
            this.txtBrojPasosa = new System.Windows.Forms.TextBox();
            this.lblSpol = new System.Windows.Forms.Label();
            this.rbtnMusko = new System.Windows.Forms.RadioButton();
            this.rbtnZensko = new System.Windows.Forms.RadioButton();
            this.lblPlata = new System.Windows.Forms.Label();
            this.lblNaGradilistuOd = new System.Windows.Forms.Label();
            this.lblGradiliste = new System.Windows.Forms.Label();
            this.lblZanimanje = new System.Windows.Forms.Label();
            this.lblDatumIstekaVize = new System.Windows.Forms.Label();
            this.btnSnimiPodatke = new System.Windows.Forms.Button();
            this.dtpDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.dtpNaGradilistuOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumIstekaVize = new System.Windows.Forms.DateTimePicker();
            this.nudPlata = new System.Windows.Forms.NumericUpDown();
            this.pnlUnosPodataka = new System.Windows.Forms.Panel();
            this.cbGradiliste = new System.Windows.Forms.ComboBox();
            this.cbZanimanje = new System.Windows.Forms.ComboBox();
            this.txtLokacijaRadneDozvole = new System.Windows.Forms.TextBox();
            this.txtLokacijaVize = new System.Windows.Forms.TextBox();
            this.btnIzaberiRadnuDozvolu = new System.Windows.Forms.Button();
            this.btnPregledajRadnuDozvolu = new System.Windows.Forms.Button();
            this.btnIzaberiVizu = new System.Windows.Forms.Button();
            this.btnPregledajVizu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIzaberiPasos = new System.Windows.Forms.Button();
            this.txtLokacijaPasosa = new System.Windows.Forms.TextBox();
            this.txtLokacijaSlike = new System.Windows.Forms.TextBox();
            this.btnPregledajSliku = new System.Windows.Forms.Button();
            this.grbAktivan = new System.Windows.Forms.GroupBox();
            this.lblAktivan = new System.Windows.Forms.Label();
            this.rbtnNe = new System.Windows.Forms.RadioButton();
            this.rbtnDa = new System.Windows.Forms.RadioButton();
            this.grbSpol = new System.Windows.Forms.GroupBox();
            this.btnIzaberiSliku = new System.Windows.Forms.Button();
            this.btnVratiSeNaIzOp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlata)).BeginInit();
            this.pnlUnosPodataka.SuspendLayout();
            this.grbAktivan.SuspendLayout();
            this.grbSpol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(19, 22);
            this.lblIme.Margin = new System.Windows.Forms.Padding(0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(47, 25);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(19, 59);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(84, 25);
            this.lblPrezime.TabIndex = 0;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblDatumRodenja
            // 
            this.lblDatumRodenja.AutoSize = true;
            this.lblDatumRodenja.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblDatumRodenja.Location = new System.Drawing.Point(19, 107);
            this.lblDatumRodenja.Name = "lblDatumRodenja";
            this.lblDatumRodenja.Size = new System.Drawing.Size(142, 25);
            this.lblDatumRodenja.TabIndex = 0;
            this.lblDatumRodenja.Text = "Datum rođenja:";
            // 
            // lblBrojPasosa
            // 
            this.lblBrojPasosa.AutoSize = true;
            this.lblBrojPasosa.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblBrojPasosa.Location = new System.Drawing.Point(19, 252);
            this.lblBrojPasosa.Name = "lblBrojPasosa";
            this.lblBrojPasosa.Size = new System.Drawing.Size(113, 25);
            this.lblBrojPasosa.TabIndex = 0;
            this.lblBrojPasosa.Text = "Broj pasoša:";
            // 
            // lblMjestoBoravka
            // 
            this.lblMjestoBoravka.AutoSize = true;
            this.lblMjestoBoravka.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblMjestoBoravka.Location = new System.Drawing.Point(21, 202);
            this.lblMjestoBoravka.Name = "lblMjestoBoravka";
            this.lblMjestoBoravka.Size = new System.Drawing.Size(145, 25);
            this.lblMjestoBoravka.TabIndex = 0;
            this.lblMjestoBoravka.Text = "Mjesto boravka:";
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.White;
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtIme.Location = new System.Drawing.Point(188, 14);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(409, 30);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.Color.White;
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtPrezime.Location = new System.Drawing.Point(188, 59);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Multiline = true;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(409, 30);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtMjestoBoravka
            // 
            this.txtMjestoBoravka.BackColor = System.Drawing.Color.White;
            this.txtMjestoBoravka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMjestoBoravka.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtMjestoBoravka.Location = new System.Drawing.Point(189, 202);
            this.txtMjestoBoravka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMjestoBoravka.Multiline = true;
            this.txtMjestoBoravka.Name = "txtMjestoBoravka";
            this.txtMjestoBoravka.Size = new System.Drawing.Size(409, 30);
            this.txtMjestoBoravka.TabIndex = 6;
            // 
            // txtBrojPasosa
            // 
            this.txtBrojPasosa.BackColor = System.Drawing.Color.White;
            this.txtBrojPasosa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrojPasosa.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtBrojPasosa.Location = new System.Drawing.Point(189, 247);
            this.txtBrojPasosa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrojPasosa.Multiline = true;
            this.txtBrojPasosa.Name = "txtBrojPasosa";
            this.txtBrojPasosa.Size = new System.Drawing.Size(409, 30);
            this.txtBrojPasosa.TabIndex = 7;
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblSpol.Location = new System.Drawing.Point(5, 6);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(53, 25);
            this.lblSpol.TabIndex = 0;
            this.lblSpol.Text = "Spol:";
            // 
            // rbtnMusko
            // 
            this.rbtnMusko.AutoSize = true;
            this.rbtnMusko.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMusko.Location = new System.Drawing.Point(171, 1);
            this.rbtnMusko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMusko.Name = "rbtnMusko";
            this.rbtnMusko.Size = new System.Drawing.Size(89, 29);
            this.rbtnMusko.TabIndex = 4;
            this.rbtnMusko.TabStop = true;
            this.rbtnMusko.Text = "Muško";
            this.rbtnMusko.UseVisualStyleBackColor = true;
            // 
            // rbtnZensko
            // 
            this.rbtnZensko.AutoSize = true;
            this.rbtnZensko.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnZensko.Location = new System.Drawing.Point(307, 2);
            this.rbtnZensko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnZensko.Name = "rbtnZensko";
            this.rbtnZensko.Size = new System.Drawing.Size(93, 29);
            this.rbtnZensko.TabIndex = 5;
            this.rbtnZensko.TabStop = true;
            this.rbtnZensko.Text = "Žensko";
            this.rbtnZensko.UseVisualStyleBackColor = true;
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblPlata.Location = new System.Drawing.Point(19, 478);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(58, 25);
            this.lblPlata.TabIndex = 3;
            this.lblPlata.Text = "Plata:";
            // 
            // lblNaGradilistuOd
            // 
            this.lblNaGradilistuOd.AutoSize = true;
            this.lblNaGradilistuOd.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblNaGradilistuOd.Location = new System.Drawing.Point(19, 436);
            this.lblNaGradilistuOd.Name = "lblNaGradilistuOd";
            this.lblNaGradilistuOd.Size = new System.Drawing.Size(151, 25);
            this.lblNaGradilistuOd.TabIndex = 4;
            this.lblNaGradilistuOd.Text = "Na gradilištu od:";
            // 
            // lblGradiliste
            // 
            this.lblGradiliste.AutoSize = true;
            this.lblGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblGradiliste.Location = new System.Drawing.Point(19, 391);
            this.lblGradiliste.Name = "lblGradiliste";
            this.lblGradiliste.Size = new System.Drawing.Size(96, 25);
            this.lblGradiliste.TabIndex = 5;
            this.lblGradiliste.Text = "Gradilište:";
            // 
            // lblZanimanje
            // 
            this.lblZanimanje.AutoSize = true;
            this.lblZanimanje.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblZanimanje.Location = new System.Drawing.Point(19, 345);
            this.lblZanimanje.Name = "lblZanimanje";
            this.lblZanimanje.Size = new System.Drawing.Size(105, 25);
            this.lblZanimanje.TabIndex = 6;
            this.lblZanimanje.Text = "Zanimanje:";
            // 
            // lblDatumIstekaVize
            // 
            this.lblDatumIstekaVize.AutoSize = true;
            this.lblDatumIstekaVize.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblDatumIstekaVize.Location = new System.Drawing.Point(23, 298);
            this.lblDatumIstekaVize.Margin = new System.Windows.Forms.Padding(0);
            this.lblDatumIstekaVize.Name = "lblDatumIstekaVize";
            this.lblDatumIstekaVize.Size = new System.Drawing.Size(163, 25);
            this.lblDatumIstekaVize.TabIndex = 7;
            this.lblDatumIstekaVize.Text = "Datum isteka vize:";
            // 
            // btnSnimiPodatke
            // 
            this.btnSnimiPodatke.BackColor = System.Drawing.Color.Gold;
            this.btnSnimiPodatke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnimiPodatke.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSnimiPodatke.Location = new System.Drawing.Point(898, 594);
            this.btnSnimiPodatke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSnimiPodatke.Name = "btnSnimiPodatke";
            this.btnSnimiPodatke.Size = new System.Drawing.Size(350, 50);
            this.btnSnimiPodatke.TabIndex = 17;
            this.btnSnimiPodatke.Text = "Snimi podatke";
            this.btnSnimiPodatke.UseVisualStyleBackColor = false;
            this.btnSnimiPodatke.Click += new System.EventHandler(this.BtnSnimiPodatke_Click);
            // 
            // dtpDatumRodenja
            // 
            this.dtpDatumRodenja.Checked = false;
            this.dtpDatumRodenja.CustomFormat = "";
            this.dtpDatumRodenja.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumRodenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodenja.Location = new System.Drawing.Point(188, 103);
            this.dtpDatumRodenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumRodenja.Name = "dtpDatumRodenja";
            this.dtpDatumRodenja.Size = new System.Drawing.Size(409, 31);
            this.dtpDatumRodenja.TabIndex = 3;
            this.dtpDatumRodenja.Tag = "0";
            this.dtpDatumRodenja.ValueChanged += new System.EventHandler(this.DtpDatumRodenja_ValueChanged);
            // 
            // dtpNaGradilistuOd
            // 
            this.dtpNaGradilistuOd.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNaGradilistuOd.Checked = false;
            this.dtpNaGradilistuOd.CustomFormat = "";
            this.dtpNaGradilistuOd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNaGradilistuOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNaGradilistuOd.Location = new System.Drawing.Point(189, 430);
            this.dtpNaGradilistuOd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNaGradilistuOd.Name = "dtpNaGradilistuOd";
            this.dtpNaGradilistuOd.Size = new System.Drawing.Size(409, 31);
            this.dtpNaGradilistuOd.TabIndex = 11;
            this.dtpNaGradilistuOd.Tag = "0";
            this.dtpNaGradilistuOd.ValueChanged += new System.EventHandler(this.DtpNaGradilistuOd_ValueChanged);
            // 
            // dtpDatumIstekaVize
            // 
            this.dtpDatumIstekaVize.Checked = false;
            this.dtpDatumIstekaVize.CustomFormat = "";
            this.dtpDatumIstekaVize.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumIstekaVize.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumIstekaVize.Location = new System.Drawing.Point(188, 292);
            this.dtpDatumIstekaVize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumIstekaVize.Name = "dtpDatumIstekaVize";
            this.dtpDatumIstekaVize.Size = new System.Drawing.Size(409, 31);
            this.dtpDatumIstekaVize.TabIndex = 8;
            this.dtpDatumIstekaVize.Tag = "0";
            this.dtpDatumIstekaVize.ValueChanged += new System.EventHandler(this.DtpDatumIstekaVize_ValueChanged);
            // 
            // nudPlata
            // 
            this.nudPlata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPlata.DecimalPlaces = 2;
            this.nudPlata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlata.ForeColor = System.Drawing.Color.Silver;
            this.nudPlata.Location = new System.Drawing.Point(188, 478);
            this.nudPlata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPlata.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPlata.Name = "nudPlata";
            this.nudPlata.Size = new System.Drawing.Size(411, 30);
            this.nudPlata.TabIndex = 12;
            this.nudPlata.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudPlata.ValueChanged += new System.EventHandler(this.NudPlata_ValueChanged);
            this.nudPlata.Enter += new System.EventHandler(this.NudPlata_ValueChanged);
            // 
            // pnlUnosPodataka
            // 
            this.pnlUnosPodataka.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUnosPodataka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnosPodataka.Controls.Add(this.cbGradiliste);
            this.pnlUnosPodataka.Controls.Add(this.cbZanimanje);
            this.pnlUnosPodataka.Controls.Add(this.txtLokacijaRadneDozvole);
            this.pnlUnosPodataka.Controls.Add(this.txtLokacijaVize);
            this.pnlUnosPodataka.Controls.Add(this.btnIzaberiRadnuDozvolu);
            this.pnlUnosPodataka.Controls.Add(this.btnPregledajRadnuDozvolu);
            this.pnlUnosPodataka.Controls.Add(this.btnIzaberiVizu);
            this.pnlUnosPodataka.Controls.Add(this.btnPregledajVizu);
            this.pnlUnosPodataka.Controls.Add(this.button3);
            this.pnlUnosPodataka.Controls.Add(this.btnIzaberiPasos);
            this.pnlUnosPodataka.Controls.Add(this.txtLokacijaPasosa);
            this.pnlUnosPodataka.Controls.Add(this.txtLokacijaSlike);
            this.pnlUnosPodataka.Controls.Add(this.btnPregledajSliku);
            this.pnlUnosPodataka.Controls.Add(this.grbAktivan);
            this.pnlUnosPodataka.Controls.Add(this.grbSpol);
            this.pnlUnosPodataka.Controls.Add(this.lblIme);
            this.pnlUnosPodataka.Controls.Add(this.nudPlata);
            this.pnlUnosPodataka.Controls.Add(this.lblPrezime);
            this.pnlUnosPodataka.Controls.Add(this.btnIzaberiSliku);
            this.pnlUnosPodataka.Controls.Add(this.dtpDatumIstekaVize);
            this.pnlUnosPodataka.Controls.Add(this.lblDatumRodenja);
            this.pnlUnosPodataka.Controls.Add(this.dtpNaGradilistuOd);
            this.pnlUnosPodataka.Controls.Add(this.lblMjestoBoravka);
            this.pnlUnosPodataka.Controls.Add(this.dtpDatumRodenja);
            this.pnlUnosPodataka.Controls.Add(this.lblBrojPasosa);
            this.pnlUnosPodataka.Controls.Add(this.txtIme);
            this.pnlUnosPodataka.Controls.Add(this.txtPrezime);
            this.pnlUnosPodataka.Controls.Add(this.txtMjestoBoravka);
            this.pnlUnosPodataka.Controls.Add(this.lblPlata);
            this.pnlUnosPodataka.Controls.Add(this.txtBrojPasosa);
            this.pnlUnosPodataka.Controls.Add(this.lblNaGradilistuOd);
            this.pnlUnosPodataka.Controls.Add(this.lblGradiliste);
            this.pnlUnosPodataka.Controls.Add(this.lblZanimanje);
            this.pnlUnosPodataka.Controls.Add(this.lblDatumIstekaVize);
            this.pnlUnosPodataka.Location = new System.Drawing.Point(27, 12);
            this.pnlUnosPodataka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUnosPodataka.Name = "pnlUnosPodataka";
            this.pnlUnosPodataka.Size = new System.Drawing.Size(1221, 564);
            this.pnlUnosPodataka.TabIndex = 19;
            // 
            // cbGradiliste
            // 
            this.cbGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGradiliste.ForeColor = System.Drawing.Color.Silver;
            this.cbGradiliste.FormattingEnabled = true;
            this.cbGradiliste.Location = new System.Drawing.Point(188, 386);
            this.cbGradiliste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGradiliste.Name = "cbGradiliste";
            this.cbGradiliste.Size = new System.Drawing.Size(409, 33);
            this.cbGradiliste.TabIndex = 27;
            this.cbGradiliste.Text = "Izaberi gradilište";
            this.cbGradiliste.DropDown += new System.EventHandler(this.CbGradiliste_DropDown);
            this.cbGradiliste.SelectedIndexChanged += new System.EventHandler(this.CbGradiliste_SelectedIndexChanged);
            // 
            // cbZanimanje
            // 
            this.cbZanimanje.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZanimanje.ForeColor = System.Drawing.Color.Silver;
            this.cbZanimanje.FormattingEnabled = true;
            this.cbZanimanje.Location = new System.Drawing.Point(189, 342);
            this.cbZanimanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbZanimanje.Name = "cbZanimanje";
            this.cbZanimanje.Size = new System.Drawing.Size(409, 33);
            this.cbZanimanje.TabIndex = 27;
            this.cbZanimanje.Text = "Izaberi zanimanje";
            this.cbZanimanje.DropDown += new System.EventHandler(this.CbZanimanje_DropDown);
            this.cbZanimanje.SelectedIndexChanged += new System.EventHandler(this.CbZanimanje_SelectedIndexChanged);
            // 
            // txtLokacijaRadneDozvole
            // 
            this.txtLokacijaRadneDozvole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLokacijaRadneDozvole.Location = new System.Drawing.Point(671, 474);
            this.txtLokacijaRadneDozvole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLokacijaRadneDozvole.Multiline = true;
            this.txtLokacijaRadneDozvole.Name = "txtLokacijaRadneDozvole";
            this.txtLokacijaRadneDozvole.ReadOnly = true;
            this.txtLokacijaRadneDozvole.Size = new System.Drawing.Size(531, 30);
            this.txtLokacijaRadneDozvole.TabIndex = 26;
            // 
            // txtLokacijaVize
            // 
            this.txtLokacijaVize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLokacijaVize.Location = new System.Drawing.Point(671, 341);
            this.txtLokacijaVize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLokacijaVize.Multiline = true;
            this.txtLokacijaVize.Name = "txtLokacijaVize";
            this.txtLokacijaVize.ReadOnly = true;
            this.txtLokacijaVize.Size = new System.Drawing.Size(531, 30);
            this.txtLokacijaVize.TabIndex = 23;
            // 
            // btnIzaberiRadnuDozvolu
            // 
            this.btnIzaberiRadnuDozvolu.AutoSize = true;
            this.btnIzaberiRadnuDozvolu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzaberiRadnuDozvolu.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnIzaberiRadnuDozvolu.Location = new System.Drawing.Point(671, 415);
            this.btnIzaberiRadnuDozvolu.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzaberiRadnuDozvolu.Name = "btnIzaberiRadnuDozvolu";
            this.btnIzaberiRadnuDozvolu.Size = new System.Drawing.Size(255, 45);
            this.btnIzaberiRadnuDozvolu.TabIndex = 24;
            this.btnIzaberiRadnuDozvolu.Text = "Izaberi radnu dozvolu";
            this.btnIzaberiRadnuDozvolu.UseVisualStyleBackColor = true;
            this.btnIzaberiRadnuDozvolu.Click += new System.EventHandler(this.BtnIzaberiRadnuDozvolu_Click);
            // 
            // btnPregledajRadnuDozvolu
            // 
            this.btnPregledajRadnuDozvolu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledajRadnuDozvolu.Location = new System.Drawing.Point(947, 415);
            this.btnPregledajRadnuDozvolu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPregledajRadnuDozvolu.Name = "btnPregledajRadnuDozvolu";
            this.btnPregledajRadnuDozvolu.Size = new System.Drawing.Size(255, 45);
            this.btnPregledajRadnuDozvolu.TabIndex = 25;
            this.btnPregledajRadnuDozvolu.Text = "Pregledaj radnu dozvolu";
            this.btnPregledajRadnuDozvolu.UseVisualStyleBackColor = true;
            this.btnPregledajRadnuDozvolu.Click += new System.EventHandler(this.BtnPregledajRadnuDozvolu_Click);
            // 
            // btnIzaberiVizu
            // 
            this.btnIzaberiVizu.AutoSize = true;
            this.btnIzaberiVizu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzaberiVizu.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnIzaberiVizu.Location = new System.Drawing.Point(671, 281);
            this.btnIzaberiVizu.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzaberiVizu.Name = "btnIzaberiVizu";
            this.btnIzaberiVizu.Size = new System.Drawing.Size(255, 45);
            this.btnIzaberiVizu.TabIndex = 21;
            this.btnIzaberiVizu.Text = "Izaberi vizu";
            this.btnIzaberiVizu.UseVisualStyleBackColor = true;
            this.btnIzaberiVizu.Click += new System.EventHandler(this.BtnIzaberiVizu_Click);
            // 
            // btnPregledajVizu
            // 
            this.btnPregledajVizu.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnPregledajVizu.Location = new System.Drawing.Point(947, 281);
            this.btnPregledajVizu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPregledajVizu.Name = "btnPregledajVizu";
            this.btnPregledajVizu.Size = new System.Drawing.Size(255, 45);
            this.btnPregledajVizu.TabIndex = 22;
            this.btnPregledajVizu.Text = "Pregledaj vizu";
            this.btnPregledajVizu.UseVisualStyleBackColor = true;
            this.btnPregledajVizu.Click += new System.EventHandler(this.BtnPregledajVizu_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.button3.Location = new System.Drawing.Point(671, 146);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 45);
            this.button3.TabIndex = 18;
            this.button3.Text = "Izaberi pasoš";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnIzaberiPasos_Click);
            // 
            // btnIzaberiPasos
            // 
            this.btnIzaberiPasos.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnIzaberiPasos.Location = new System.Drawing.Point(947, 146);
            this.btnIzaberiPasos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzaberiPasos.Name = "btnIzaberiPasos";
            this.btnIzaberiPasos.Size = new System.Drawing.Size(255, 45);
            this.btnIzaberiPasos.TabIndex = 19;
            this.btnIzaberiPasos.Text = "Pregledaj pasoš";
            this.btnIzaberiPasos.UseVisualStyleBackColor = true;
            this.btnIzaberiPasos.Click += new System.EventHandler(this.BtnPregledajPasos_Click);
            // 
            // txtLokacijaPasosa
            // 
            this.txtLokacijaPasosa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLokacijaPasosa.Location = new System.Drawing.Point(671, 206);
            this.txtLokacijaPasosa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLokacijaPasosa.Multiline = true;
            this.txtLokacijaPasosa.Name = "txtLokacijaPasosa";
            this.txtLokacijaPasosa.ReadOnly = true;
            this.txtLokacijaPasosa.Size = new System.Drawing.Size(531, 30);
            this.txtLokacijaPasosa.TabIndex = 20;
            // 
            // txtLokacijaSlike
            // 
            this.txtLokacijaSlike.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLokacijaSlike.Location = new System.Drawing.Point(671, 71);
            this.txtLokacijaSlike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLokacijaSlike.Multiline = true;
            this.txtLokacijaSlike.Name = "txtLokacijaSlike";
            this.txtLokacijaSlike.ReadOnly = true;
            this.txtLokacijaSlike.Size = new System.Drawing.Size(531, 30);
            this.txtLokacijaSlike.TabIndex = 17;
            // 
            // btnPregledajSliku
            // 
            this.btnPregledajSliku.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnPregledajSliku.Location = new System.Drawing.Point(947, 14);
            this.btnPregledajSliku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPregledajSliku.Name = "btnPregledajSliku";
            this.btnPregledajSliku.Size = new System.Drawing.Size(255, 44);
            this.btnPregledajSliku.TabIndex = 16;
            this.btnPregledajSliku.Text = "Pregledaj sliku";
            this.btnPregledajSliku.UseVisualStyleBackColor = true;
            this.btnPregledajSliku.Click += new System.EventHandler(this.BtnPregledajSliku_Click);
            // 
            // grbAktivan
            // 
            this.grbAktivan.Controls.Add(this.lblAktivan);
            this.grbAktivan.Controls.Add(this.rbtnNe);
            this.grbAktivan.Controls.Add(this.rbtnDa);
            this.grbAktivan.Location = new System.Drawing.Point(13, 526);
            this.grbAktivan.Margin = new System.Windows.Forms.Padding(0);
            this.grbAktivan.Name = "grbAktivan";
            this.grbAktivan.Padding = new System.Windows.Forms.Padding(0);
            this.grbAktivan.Size = new System.Drawing.Size(396, 33);
            this.grbAktivan.TabIndex = 13;
            this.grbAktivan.TabStop = false;
            // 
            // lblAktivan
            // 
            this.lblAktivan.AutoSize = true;
            this.lblAktivan.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblAktivan.Location = new System.Drawing.Point(5, 0);
            this.lblAktivan.Name = "lblAktivan";
            this.lblAktivan.Size = new System.Drawing.Size(78, 25);
            this.lblAktivan.TabIndex = 0;
            this.lblAktivan.Text = "Aktivan:";
            // 
            // rbtnNe
            // 
            this.rbtnNe.AutoSize = true;
            this.rbtnNe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNe.Location = new System.Drawing.Point(307, -2);
            this.rbtnNe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNe.Name = "rbtnNe";
            this.rbtnNe.Size = new System.Drawing.Size(57, 29);
            this.rbtnNe.TabIndex = 14;
            this.rbtnNe.TabStop = true;
            this.rbtnNe.Text = "Ne";
            this.rbtnNe.UseVisualStyleBackColor = true;
            // 
            // rbtnDa
            // 
            this.rbtnDa.AutoSize = true;
            this.rbtnDa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDa.Location = new System.Drawing.Point(175, -4);
            this.rbtnDa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnDa.Name = "rbtnDa";
            this.rbtnDa.Size = new System.Drawing.Size(56, 29);
            this.rbtnDa.TabIndex = 13;
            this.rbtnDa.TabStop = true;
            this.rbtnDa.Text = "Da";
            this.rbtnDa.UseVisualStyleBackColor = true;
            // 
            // grbSpol
            // 
            this.grbSpol.Controls.Add(this.lblSpol);
            this.grbSpol.Controls.Add(this.rbtnZensko);
            this.grbSpol.Controls.Add(this.rbtnMusko);
            this.grbSpol.Location = new System.Drawing.Point(17, 151);
            this.grbSpol.Margin = new System.Windows.Forms.Padding(0);
            this.grbSpol.Name = "grbSpol";
            this.grbSpol.Padding = new System.Windows.Forms.Padding(0);
            this.grbSpol.Size = new System.Drawing.Size(497, 30);
            this.grbSpol.TabIndex = 4;
            this.grbSpol.TabStop = false;
            // 
            // btnIzaberiSliku
            // 
            this.btnIzaberiSliku.AutoSize = true;
            this.btnIzaberiSliku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzaberiSliku.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnIzaberiSliku.Location = new System.Drawing.Point(671, 14);
            this.btnIzaberiSliku.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzaberiSliku.Name = "btnIzaberiSliku";
            this.btnIzaberiSliku.Size = new System.Drawing.Size(255, 44);
            this.btnIzaberiSliku.TabIndex = 15;
            this.btnIzaberiSliku.Text = "Izaberi sliku";
            this.btnIzaberiSliku.UseVisualStyleBackColor = true;
            this.btnIzaberiSliku.Click += new System.EventHandler(this.BtnIzaberiSliku_Click);
            // 
            // btnVratiSeNaIzOp
            // 
            this.btnVratiSeNaIzOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVratiSeNaIzOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVratiSeNaIzOp.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnVratiSeNaIzOp.Location = new System.Drawing.Point(27, 594);
            this.btnVratiSeNaIzOp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVratiSeNaIzOp.Name = "btnVratiSeNaIzOp";
            this.btnVratiSeNaIzOp.Size = new System.Drawing.Size(350, 50);
            this.btnVratiSeNaIzOp.TabIndex = 17;
            this.btnVratiSeNaIzOp.Text = "Idi na \'Izbor operacija\'";
            this.btnVratiSeNaIzOp.UseVisualStyleBackColor = false;
            this.btnVratiSeNaIzOp.Click += new System.EventHandler(this.BtnVratiSeNaIzOp_Click);
            // 
            // DodajRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1273, 654);
            this.Controls.Add(this.btnVratiSeNaIzOp);
            this.Controls.Add(this.btnSnimiPodatke);
            this.Controls.Add(this.pnlUnosPodataka);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "DodajRadnika";
            this.Text = "Dodaj radnika";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonShadow;
            this.Load += new System.EventHandler(this.DodajRadnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlata)).EndInit();
            this.pnlUnosPodataka.ResumeLayout(false);
            this.pnlUnosPodataka.PerformLayout();
            this.grbAktivan.ResumeLayout(false);
            this.grbAktivan.PerformLayout();
            this.grbSpol.ResumeLayout(false);
            this.grbSpol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumRodenja;
        private System.Windows.Forms.Label lblBrojPasosa;
        private System.Windows.Forms.Label lblMjestoBoravka;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtMjestoBoravka;
        private System.Windows.Forms.TextBox txtBrojPasosa;
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.RadioButton rbtnMusko;
        private System.Windows.Forms.RadioButton rbtnZensko;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.Label lblNaGradilistuOd;
        private System.Windows.Forms.Label lblGradiliste;
        private System.Windows.Forms.Label lblZanimanje;
        private System.Windows.Forms.Label lblDatumIstekaVize;
        private System.Windows.Forms.Button btnSnimiPodatke;
        private System.Windows.Forms.DateTimePicker dtpDatumRodenja;
        private System.Windows.Forms.DateTimePicker dtpNaGradilistuOd;
        private System.Windows.Forms.DateTimePicker dtpDatumIstekaVize;
        private System.Windows.Forms.NumericUpDown nudPlata;
        private System.Windows.Forms.Panel pnlUnosPodataka;
        private System.Windows.Forms.Label lblAktivan;
        private System.Windows.Forms.RadioButton rbtnDa;
        private System.Windows.Forms.RadioButton rbtnNe;
        private System.Windows.Forms.Button btnIzaberiSliku;
        private System.Windows.Forms.GroupBox grbAktivan;
        private System.Windows.Forms.GroupBox grbSpol;
        private System.Windows.Forms.TextBox txtLokacijaSlike;
        private System.Windows.Forms.Button btnPregledajSliku;
        private System.Windows.Forms.TextBox txtLokacijaRadneDozvole;
        private System.Windows.Forms.TextBox txtLokacijaVize;
        private System.Windows.Forms.TextBox txtLokacijaPasosa;
        private System.Windows.Forms.Button btnPregledajRadnuDozvolu;
        private System.Windows.Forms.Button btnPregledajVizu;
        private System.Windows.Forms.Button btnIzaberiPasos;
        private System.Windows.Forms.Button btnIzaberiRadnuDozvolu;
        private System.Windows.Forms.Button btnIzaberiVizu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnVratiSeNaIzOp;
        private System.Windows.Forms.ComboBox cbGradiliste;
        private System.Windows.Forms.ComboBox cbZanimanje;
    }
}

