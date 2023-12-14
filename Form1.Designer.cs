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
            lblDataStudenta = new Label();
            btnAktualizujData = new Button();
            dataviewStudenti = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            jmeno_prijmeni = new DataGridViewTextBoxColumn();
            kategorie = new DataGridViewTextBoxColumn();
            skola = new DataGridViewTextBoxColumn();
            rocnik = new DataGridViewTextBoxColumn();
            souradnice = new DataGridViewTextBoxColumn();
            btnVypis = new Button();
            btnVlozit = new Button();
            btnHO = new Button();
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).BeginInit();
            SuspendLayout();
            // 
            // lblDataStudenta
            // 
            lblDataStudenta.AutoSize = true;
            lblDataStudenta.Location = new Point(12, 9);
            lblDataStudenta.Name = "lblDataStudenta";
            lblDataStudenta.Size = new Size(81, 15);
            lblDataStudenta.TabIndex = 0;
            lblDataStudenta.Text = "Data studentů";
            // 
            // btnAktualizujData
            // 
            btnAktualizujData.Location = new Point(713, 12);
            btnAktualizujData.Name = "btnAktualizujData";
            btnAktualizujData.Size = new Size(75, 23);
            btnAktualizujData.TabIndex = 1;
            btnAktualizujData.Text = "Aktualizuj";
            btnAktualizujData.UseVisualStyleBackColor = true;
            btnAktualizujData.Click += btnAktualizujData_Click;
            // 
            // dataviewStudenti
            // 
            dataviewStudenti.AllowUserToDeleteRows = false;
            dataviewStudenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataviewStudenti.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataviewStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewStudenti.Columns.AddRange(new DataGridViewColumn[] { id, jmeno_prijmeni, kategorie, skola, rocnik, souradnice });
            dataviewStudenti.Location = new Point(12, 27);
            dataviewStudenti.Name = "dataviewStudenti";
            dataviewStudenti.RowTemplate.Height = 25;
            dataviewStudenti.Size = new Size(695, 411);
            dataviewStudenti.TabIndex = 3;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // jmeno_prijmeni
            // 
            jmeno_prijmeni.HeaderText = "Jméno a přijmení";
            jmeno_prijmeni.Name = "jmeno_prijmeni";
            // 
            // kategorie
            // 
            kategorie.HeaderText = "Kategorie";
            kategorie.Name = "kategorie";
            // 
            // skola
            // 
            skola.HeaderText = "Škola";
            skola.Name = "skola";
            // 
            // rocnik
            // 
            rocnik.HeaderText = "Ročník";
            rocnik.Name = "rocnik";
            // 
            // souradnice
            // 
            souradnice.HeaderText = "Souřadnice";
            souradnice.Name = "souradnice";
            // 
            // btnVypis
            // 
            btnVypis.Location = new Point(713, 41);
            btnVypis.Name = "btnVypis";
            btnVypis.Size = new Size(75, 23);
            btnVypis.TabIndex = 4;
            btnVypis.Text = "Vypiš";
            btnVypis.UseVisualStyleBackColor = true;
            btnVypis.Click += btnVypis_Click;
            // 
            // btnVlozit
            // 
            btnVlozit.Location = new Point(713, 70);
            btnVlozit.Name = "btnVlozit";
            btnVlozit.Size = new Size(75, 23);
            btnVlozit.TabIndex = 5;
            btnVlozit.Text = "Vložit";
            btnVlozit.UseVisualStyleBackColor = true;
            btnVlozit.Click += btnVlozit_Click;
            // 
            // btnHO
            // 
            btnHO.Location = new Point(713, 415);
            btnHO.Name = "btnHO";
            btnHO.Size = new Size(75, 23);
            btnHO.TabIndex = 6;
            btnHO.Text = "HO";
            btnHO.UseVisualStyleBackColor = true;
            btnHO.Click += btnHO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHO);
            Controls.Add(btnVlozit);
            Controls.Add(btnVypis);
            Controls.Add(dataviewStudenti);
            Controls.Add(btnAktualizujData);
            Controls.Add(lblDataStudenta);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "SediM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnVypis;
        private Button btnVlozit;
        private Button btnHO;
    }
}