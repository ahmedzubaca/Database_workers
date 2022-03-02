namespace ListaRadnika
{
    partial class PromjenaGradilista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromjenaGradilista));
            this.lblStaroGradiliste = new System.Windows.Forms.Label();
            this.lblDatumZavrsetkaStaGra = new System.Windows.Forms.Label();
            this.dtpDatumZavrsetkaStaGra = new System.Windows.Forms.DateTimePicker();
            this.btnSnimiIzmjene = new System.Windows.Forms.Button();
            this.txtStaroGradiliste = new System.Windows.Forms.TextBox();
            this.lblUpozorenje = new System.Windows.Forms.Label();
            this.lblImeZaPretragu = new System.Windows.Forms.Label();
            this.PnlPodaciORadniku = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDatumPocetkaNoGra = new System.Windows.Forms.DateTimePicker();
            this.txtNovoGradiliste = new System.Windows.Forms.TextBox();
            this.lblDatumPocetkaNoGra = new System.Windows.Forms.Label();
            this.lblNovoGradiliste = new System.Windows.Forms.Label();
            this.pnlPodaciZaPretragu = new System.Windows.Forms.Panel();
            this.btnVratiSeNaIzOp = new System.Windows.Forms.Button();
            this.txtPrezimeZaPretragu = new System.Windows.Forms.TextBox();
            this.txtImeZaPretragu = new System.Windows.Forms.TextBox();
            this.lblPrezimeZaPretragu = new System.Windows.Forms.Label();
            this.DgvPromjenaGradilista = new System.Windows.Forms.DataGridView();
            this.PnlPodaciORadniku.SuspendLayout();
            this.pnlPodaciZaPretragu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPromjenaGradilista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaroGradiliste
            // 
            this.lblStaroGradiliste.AutoSize = true;
            this.lblStaroGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStaroGradiliste.Location = new System.Drawing.Point(50, 26);
            this.lblStaroGradiliste.Name = "lblStaroGradiliste";
            this.lblStaroGradiliste.Size = new System.Drawing.Size(127, 23);
            this.lblStaroGradiliste.TabIndex = 5;
            this.lblStaroGradiliste.Text = "Staro gradilište:";
            // 
            // lblDatumZavrsetkaStaGra
            // 
            this.lblDatumZavrsetkaStaGra.AutoSize = true;
            this.lblDatumZavrsetkaStaGra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatumZavrsetkaStaGra.Location = new System.Drawing.Point(546, 26);
            this.lblDatumZavrsetkaStaGra.Name = "lblDatumZavrsetkaStaGra";
            this.lblDatumZavrsetkaStaGra.Size = new System.Drawing.Size(333, 23);
            this.lblDatumZavrsetkaStaGra.TabIndex = 4;
            this.lblDatumZavrsetkaStaGra.Text = "Datum završetka rada na starom gradilištu";
            // 
            // dtpDatumZavrsetkaStaGra
            // 
            this.dtpDatumZavrsetkaStaGra.CustomFormat = "0000-00-00";
            this.dtpDatumZavrsetkaStaGra.Font = new System.Drawing.Font("AMGDT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumZavrsetkaStaGra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumZavrsetkaStaGra.Location = new System.Drawing.Point(896, 21);
            this.dtpDatumZavrsetkaStaGra.Name = "dtpDatumZavrsetkaStaGra";
            this.dtpDatumZavrsetkaStaGra.Size = new System.Drawing.Size(297, 31);
            this.dtpDatumZavrsetkaStaGra.TabIndex = 16;
            // 
            // btnSnimiIzmjene
            // 
            this.btnSnimiIzmjene.BackColor = System.Drawing.Color.Gold;
            this.btnSnimiIzmjene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnimiIzmjene.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSnimiIzmjene.Location = new System.Drawing.Point(375, 116);
            this.btnSnimiIzmjene.Name = "btnSnimiIzmjene";
            this.btnSnimiIzmjene.Size = new System.Drawing.Size(468, 41);
            this.btnSnimiIzmjene.TabIndex = 14;
            this.btnSnimiIzmjene.Text = "Snimi izmjene";
            this.btnSnimiIzmjene.UseVisualStyleBackColor = false;
            this.btnSnimiIzmjene.Click += new System.EventHandler(this.BtnSnimiIzmjene_Click);
            // 
            // txtStaroGradiliste
            // 
            this.txtStaroGradiliste.BackColor = System.Drawing.Color.White;
            this.txtStaroGradiliste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaroGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStaroGradiliste.Location = new System.Drawing.Point(183, 26);
            this.txtStaroGradiliste.Name = "txtStaroGradiliste";
            this.txtStaroGradiliste.Size = new System.Drawing.Size(297, 23);
            this.txtStaroGradiliste.TabIndex = 10;
            // 
            // lblUpozorenje
            // 
            this.lblUpozorenje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUpozorenje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpozorenje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpozorenje.Location = new System.Drawing.Point(12, 9);
            this.lblUpozorenje.Name = "lblUpozorenje";
            this.lblUpozorenje.Padding = new System.Windows.Forms.Padding(3);
            this.lblUpozorenje.Size = new System.Drawing.Size(1268, 50);
            this.lblUpozorenje.TabIndex = 19;
            this.lblUpozorenje.Text = resources.GetString("lblUpozorenje.Text");
            // 
            // lblImeZaPretragu
            // 
            this.lblImeZaPretragu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImeZaPretragu.Location = new System.Drawing.Point(16, 11);
            this.lblImeZaPretragu.Name = "lblImeZaPretragu";
            this.lblImeZaPretragu.Size = new System.Drawing.Size(292, 29);
            this.lblImeZaPretragu.TabIndex = 20;
            this.lblImeZaPretragu.Text = "Unesite ime za pretragu tabele";
            // 
            // PnlPodaciORadniku
            // 
            this.PnlPodaciORadniku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPodaciORadniku.Controls.Add(this.groupBox1);
            this.PnlPodaciORadniku.Controls.Add(this.dtpDatumPocetkaNoGra);
            this.PnlPodaciORadniku.Controls.Add(this.dtpDatumZavrsetkaStaGra);
            this.PnlPodaciORadniku.Controls.Add(this.txtNovoGradiliste);
            this.PnlPodaciORadniku.Controls.Add(this.txtStaroGradiliste);
            this.PnlPodaciORadniku.Controls.Add(this.lblDatumPocetkaNoGra);
            this.PnlPodaciORadniku.Controls.Add(this.btnSnimiIzmjene);
            this.PnlPodaciORadniku.Controls.Add(this.lblNovoGradiliste);
            this.PnlPodaciORadniku.Controls.Add(this.lblDatumZavrsetkaStaGra);
            this.PnlPodaciORadniku.Controls.Add(this.lblStaroGradiliste);
            this.PnlPodaciORadniku.Location = new System.Drawing.Point(12, 89);
            this.PnlPodaciORadniku.Name = "PnlPodaciORadniku";
            this.PnlPodaciORadniku.Size = new System.Drawing.Size(1268, 173);
            this.PnlPodaciORadniku.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(489, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 24);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // dtpDatumPocetkaNoGra
            // 
            this.dtpDatumPocetkaNoGra.CustomFormat = "0000-00-00";
            this.dtpDatumPocetkaNoGra.Font = new System.Drawing.Font("AMGDT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumPocetkaNoGra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPocetkaNoGra.Location = new System.Drawing.Point(896, 65);
            this.dtpDatumPocetkaNoGra.Name = "dtpDatumPocetkaNoGra";
            this.dtpDatumPocetkaNoGra.Size = new System.Drawing.Size(297, 31);
            this.dtpDatumPocetkaNoGra.TabIndex = 16;
            // 
            // txtNovoGradiliste
            // 
            this.txtNovoGradiliste.BackColor = System.Drawing.Color.White;
            this.txtNovoGradiliste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovoGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNovoGradiliste.Location = new System.Drawing.Point(183, 70);
            this.txtNovoGradiliste.Name = "txtNovoGradiliste";
            this.txtNovoGradiliste.Size = new System.Drawing.Size(297, 23);
            this.txtNovoGradiliste.TabIndex = 10;
            // 
            // lblDatumPocetkaNoGra
            // 
            this.lblDatumPocetkaNoGra.AutoSize = true;
            this.lblDatumPocetkaNoGra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatumPocetkaNoGra.Location = new System.Drawing.Point(546, 70);
            this.lblDatumPocetkaNoGra.Name = "lblDatumPocetkaNoGra";
            this.lblDatumPocetkaNoGra.Size = new System.Drawing.Size(323, 23);
            this.lblDatumPocetkaNoGra.TabIndex = 4;
            this.lblDatumPocetkaNoGra.Text = "Datum početka rada na novom gradilištu";
            // 
            // lblNovoGradiliste
            // 
            this.lblNovoGradiliste.AutoSize = true;
            this.lblNovoGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoGradiliste.Location = new System.Drawing.Point(50, 70);
            this.lblNovoGradiliste.Name = "lblNovoGradiliste";
            this.lblNovoGradiliste.Size = new System.Drawing.Size(129, 23);
            this.lblNovoGradiliste.TabIndex = 5;
            this.lblNovoGradiliste.Text = "Novo gradilište:";
            // 
            // pnlPodaciZaPretragu
            // 
            this.pnlPodaciZaPretragu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPodaciZaPretragu.Controls.Add(this.btnVratiSeNaIzOp);
            this.pnlPodaciZaPretragu.Controls.Add(this.txtPrezimeZaPretragu);
            this.pnlPodaciZaPretragu.Controls.Add(this.txtImeZaPretragu);
            this.pnlPodaciZaPretragu.Controls.Add(this.lblPrezimeZaPretragu);
            this.pnlPodaciZaPretragu.Controls.Add(this.lblImeZaPretragu);
            this.pnlPodaciZaPretragu.Location = new System.Drawing.Point(12, 283);
            this.pnlPodaciZaPretragu.Name = "pnlPodaciZaPretragu";
            this.pnlPodaciZaPretragu.Size = new System.Drawing.Size(1268, 52);
            this.pnlPodaciZaPretragu.TabIndex = 22;
            // 
            // btnVratiSeNaIzOp
            // 
            this.btnVratiSeNaIzOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVratiSeNaIzOp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVratiSeNaIzOp.Location = new System.Drawing.Point(953, 6);
            this.btnVratiSeNaIzOp.Name = "btnVratiSeNaIzOp";
            this.btnVratiSeNaIzOp.Size = new System.Drawing.Size(279, 39);
            this.btnVratiSeNaIzOp.TabIndex = 22;
            this.btnVratiSeNaIzOp.Text = "Idi na \'Izbor operacija\'";
            this.btnVratiSeNaIzOp.UseVisualStyleBackColor = false;
            this.btnVratiSeNaIzOp.Click += new System.EventHandler(this.btnVratiSeNaIzOp_Click);
            // 
            // txtPrezimeZaPretragu
            // 
            this.txtPrezimeZaPretragu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtPrezimeZaPretragu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrezimeZaPretragu.Location = new System.Drawing.Point(730, 8);
            this.txtPrezimeZaPretragu.Name = "txtPrezimeZaPretragu";
            this.txtPrezimeZaPretragu.Size = new System.Drawing.Size(129, 31);
            this.txtPrezimeZaPretragu.TabIndex = 21;
            this.txtPrezimeZaPretragu.TextChanged += new System.EventHandler(this.TxtPodaciZaPretragu_TextChanged);
            // 
            // txtImeZaPretragu
            // 
            this.txtImeZaPretragu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImeZaPretragu.Location = new System.Drawing.Point(266, 8);
            this.txtImeZaPretragu.Name = "txtImeZaPretragu";
            this.txtImeZaPretragu.Size = new System.Drawing.Size(129, 30);
            this.txtImeZaPretragu.TabIndex = 21;
            this.txtImeZaPretragu.TextChanged += new System.EventHandler(this.TxtPodaciZaPretragu_TextChanged);
            // 
            // lblPrezimeZaPretragu
            // 
            this.lblPrezimeZaPretragu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrezimeZaPretragu.Location = new System.Drawing.Point(450, 11);
            this.lblPrezimeZaPretragu.Name = "lblPrezimeZaPretragu";
            this.lblPrezimeZaPretragu.Size = new System.Drawing.Size(320, 29);
            this.lblPrezimeZaPretragu.TabIndex = 20;
            this.lblPrezimeZaPretragu.Text = "Unesite prezime za pretragu tabele";
            // 
            // DgvPromjenaGradilista
            // 
            this.DgvPromjenaGradilista.AllowUserToAddRows = false;
            this.DgvPromjenaGradilista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvPromjenaGradilista.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvPromjenaGradilista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPromjenaGradilista.Location = new System.Drawing.Point(12, 355);
            this.DgvPromjenaGradilista.Name = "DgvPromjenaGradilista";
            this.DgvPromjenaGradilista.RowHeadersWidth = 51;
            this.DgvPromjenaGradilista.RowTemplate.Height = 29;
            this.DgvPromjenaGradilista.Size = new System.Drawing.Size(1268, 285);
            this.DgvPromjenaGradilista.TabIndex = 23;
            this.DgvPromjenaGradilista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPromjenaGradilista_CellClick);
            // 
            // PromjenaGradilista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1292, 664);
            this.Controls.Add(this.DgvPromjenaGradilista);
            this.Controls.Add(this.pnlPodaciZaPretragu);
            this.Controls.Add(this.PnlPodaciORadniku);
            this.Controls.Add(this.lblUpozorenje);
            this.Name = "PromjenaGradilista";
            this.Text = "Promjena gradilišta";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonShadow;
            this.Load += new System.EventHandler(this.PromjenaGradilista_Load);
            this.PnlPodaciORadniku.ResumeLayout(false);
            this.PnlPodaciORadniku.PerformLayout();
            this.pnlPodaciZaPretragu.ResumeLayout(false);
            this.pnlPodaciZaPretragu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPromjenaGradilista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblStaroGradiliste;
        private System.Windows.Forms.Label lblDatumZavrsetkaStaGra;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetkaStaGra;
        private System.Windows.Forms.Button btnSnimiIzmjene;
        private System.Windows.Forms.TextBox txtStaroGradiliste;
        private System.Windows.Forms.Label lblUpozorenje;
        private System.Windows.Forms.Label lblImeZaPretragu;
        private System.Windows.Forms.Panel PnlPodaciORadniku;
        private System.Windows.Forms.Panel pnlPodaciZaPretragu;
        private System.Windows.Forms.TextBox txtPrezimeZaPretragu;
        private System.Windows.Forms.TextBox txtImeZaPretragu;
        private System.Windows.Forms.Label lblPrezimeZaPretragu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvPromjenaGradilista;
        private System.Windows.Forms.Button btnVratiSeNaIzOp;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetkaNoGra;
        private System.Windows.Forms.TextBox txtNovoGradiliste;
        private System.Windows.Forms.Label lblDatumPocetkaNoGra;
        private System.Windows.Forms.Label lblNovoGradiliste;
    }
}

