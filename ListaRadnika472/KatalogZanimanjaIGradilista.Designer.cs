namespace ListaRadnika
{
    partial class KatalogZanimanjaIGradilista
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
            this.lblUnesiZanimanje = new System.Windows.Forms.Label();
            this.txtZanimanje = new System.Windows.Forms.TextBox();
            this.btnSnimiZanimanje = new System.Windows.Forms.Button();
            this.lblUnesiGradiliste = new System.Windows.Forms.Label();
            this.txtGradiliste = new System.Windows.Forms.TextBox();
            this.btnSnimiGradiliste = new System.Windows.Forms.Button();
            this.btnIdiNaIzbOp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnesiZanimanje
            // 
            this.lblUnesiZanimanje.AutoSize = true;
            this.lblUnesiZanimanje.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblUnesiZanimanje.Location = new System.Drawing.Point(41, 17);
            this.lblUnesiZanimanje.Name = "lblUnesiZanimanje";
            this.lblUnesiZanimanje.Size = new System.Drawing.Size(200, 25);
            this.lblUnesiZanimanje.TabIndex = 0;
            this.lblUnesiZanimanje.Text = "Unesi naziv zanimanja";
            // 
            // txtZanimanje
            // 
            this.txtZanimanje.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtZanimanje.Location = new System.Drawing.Point(251, 14);
            this.txtZanimanje.Multiline = true;
            this.txtZanimanje.Name = "txtZanimanje";
            this.txtZanimanje.Size = new System.Drawing.Size(500, 30);
            this.txtZanimanje.TabIndex = 1;
            // 
            // btnSnimiZanimanje
            // 
            this.btnSnimiZanimanje.BackColor = System.Drawing.Color.Gold;
            this.btnSnimiZanimanje.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiZanimanje.Location = new System.Drawing.Point(819, 13);
            this.btnSnimiZanimanje.Name = "btnSnimiZanimanje";
            this.btnSnimiZanimanje.Size = new System.Drawing.Size(239, 35);
            this.btnSnimiZanimanje.TabIndex = 2;
            this.btnSnimiZanimanje.Text = "Snimi zanimanje";
            this.btnSnimiZanimanje.UseVisualStyleBackColor = false;
            this.btnSnimiZanimanje.Click += new System.EventHandler(this.BtnSnimiZanimanje_Click);
            // 
            // lblUnesiGradiliste
            // 
            this.lblUnesiGradiliste.AutoSize = true;
            this.lblUnesiGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblUnesiGradiliste.Location = new System.Drawing.Point(41, 77);
            this.lblUnesiGradiliste.Name = "lblUnesiGradiliste";
            this.lblUnesiGradiliste.Size = new System.Drawing.Size(191, 25);
            this.lblUnesiGradiliste.TabIndex = 0;
            this.lblUnesiGradiliste.Text = "Unesi naziv gradilišta";
            // 
            // txtGradiliste
            // 
            this.txtGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtGradiliste.Location = new System.Drawing.Point(251, 74);
            this.txtGradiliste.Multiline = true;
            this.txtGradiliste.Name = "txtGradiliste";
            this.txtGradiliste.Size = new System.Drawing.Size(500, 30);
            this.txtGradiliste.TabIndex = 1;
            // 
            // btnSnimiGradiliste
            // 
            this.btnSnimiGradiliste.BackColor = System.Drawing.Color.Gold;
            this.btnSnimiGradiliste.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiGradiliste.Location = new System.Drawing.Point(819, 73);
            this.btnSnimiGradiliste.Name = "btnSnimiGradiliste";
            this.btnSnimiGradiliste.Size = new System.Drawing.Size(239, 35);
            this.btnSnimiGradiliste.TabIndex = 2;
            this.btnSnimiGradiliste.Text = "Snimi gradiliste";
            this.btnSnimiGradiliste.UseVisualStyleBackColor = false;
            this.btnSnimiGradiliste.Click += new System.EventHandler(this.BtnSnimiGradiliste_Click);
            // 
            // btnIdiNaIzbOp
            // 
            this.btnIdiNaIzbOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIdiNaIzbOp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdiNaIzbOp.Location = new System.Drawing.Point(819, 147);
            this.btnIdiNaIzbOp.Name = "btnIdiNaIzbOp";
            this.btnIdiNaIzbOp.Size = new System.Drawing.Size(239, 36);
            this.btnIdiNaIzbOp.TabIndex = 3;
            this.btnIdiNaIzbOp.Text = "Idi na \'Izbor operacija\'";
            this.btnIdiNaIzbOp.UseVisualStyleBackColor = false;
            this.btnIdiNaIzbOp.Click += new System.EventHandler(this.BtnIdiNaIzbOp_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUnesiZanimanje);
            this.panel1.Controls.Add(this.btnIdiNaIzbOp);
            this.panel1.Controls.Add(this.lblUnesiGradiliste);
            this.panel1.Controls.Add(this.txtZanimanje);
            this.panel1.Controls.Add(this.btnSnimiGradiliste);
            this.panel1.Controls.Add(this.txtGradiliste);
            this.panel1.Controls.Add(this.btnSnimiZanimanje);
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 202);
            this.panel1.TabIndex = 4;
            // 
            // KatalogZanimanjaIGradilista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 256);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.Name = "KatalogZanimanjaIGradilista";
            this.Text = "Katalog zanimanja i gradilista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUnesiZanimanje;
        private System.Windows.Forms.TextBox txtZanimanje;
        private System.Windows.Forms.Button btnSnimiZanimanje;
        private System.Windows.Forms.Label lblUnesiGradiliste;
        private System.Windows.Forms.TextBox txtGradiliste;
        private System.Windows.Forms.Button btnSnimiGradiliste;
        private System.Windows.Forms.Button btnIdiNaIzbOp;
        private System.Windows.Forms.Panel panel1;
    }
}