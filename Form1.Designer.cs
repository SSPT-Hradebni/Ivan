namespace SediM
{
    partial class Form1
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
            this.lblDataStudenta = new System.Windows.Forms.Label();
            this.btnAktualizujData = new System.Windows.Forms.Button();
            this.dataviewStudenti = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmeno_prijmeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rocnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.souradnice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataStudenta
            // 
            this.lblDataStudenta.AutoSize = true;
            this.lblDataStudenta.Location = new System.Drawing.Point(12, 9);
            this.lblDataStudenta.Name = "lblDataStudenta";
            this.lblDataStudenta.Size = new System.Drawing.Size(81, 15);
            this.lblDataStudenta.TabIndex = 0;
            this.lblDataStudenta.Text = "Data studentů";
            // 
            // btnAktualizujData
            // 
            this.btnAktualizujData.Location = new System.Drawing.Point(713, 12);
            this.btnAktualizujData.Name = "btnAktualizujData";
            this.btnAktualizujData.Size = new System.Drawing.Size(75, 23);
            this.btnAktualizujData.TabIndex = 1;
            this.btnAktualizujData.Text = "Aktualizuj";
            this.btnAktualizujData.UseVisualStyleBackColor = true;
            this.btnAktualizujData.Click += new System.EventHandler(this.btnAktualizujData_Click);
            // 
            // dataviewStudenti
            // 
            this.dataviewStudenti.AllowUserToAddRows = false;
            this.dataviewStudenti.AllowUserToDeleteRows = false;
            this.dataviewStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataviewStudenti.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataviewStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.jmeno_prijmeni,
            this.kategorie,
            this.skola,
            this.rocnik,
            this.souradnice});
            this.dataviewStudenti.Location = new System.Drawing.Point(12, 27);
            this.dataviewStudenti.Name = "dataviewStudenti";
            this.dataviewStudenti.ReadOnly = true;
            this.dataviewStudenti.RowTemplate.Height = 25;
            this.dataviewStudenti.Size = new System.Drawing.Size(695, 411);
            this.dataviewStudenti.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // jmeno_prijmeni
            // 
            this.jmeno_prijmeni.HeaderText = "Jméno a přijmení";
            this.jmeno_prijmeni.Name = "jmeno_prijmeni";
            this.jmeno_prijmeni.ReadOnly = true;
            // 
            // kategorie
            // 
            this.kategorie.HeaderText = "Kategorie";
            this.kategorie.Name = "kategorie";
            this.kategorie.ReadOnly = true;
            // 
            // skola
            // 
            this.skola.HeaderText = "Škola";
            this.skola.Name = "skola";
            this.skola.ReadOnly = true;
            // 
            // rocnik
            // 
            this.rocnik.HeaderText = "Ročník";
            this.rocnik.Name = "rocnik";
            this.rocnik.ReadOnly = true;
            // 
            // souradnice
            // 
            this.souradnice.HeaderText = "Souřadnice";
            this.souradnice.Name = "souradnice";
            this.souradnice.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataviewStudenti);
            this.Controls.Add(this.btnAktualizujData);
            this.Controls.Add(this.lblDataStudenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SediM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDataStudenta;
        private Button btnAktualizujData;
        private DataGridView dataviewStudenti;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jmeno_prijmeni;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn skola;
        private DataGridViewTextBoxColumn rocnik;
        private DataGridViewTextBoxColumn souradnice;
    }
}