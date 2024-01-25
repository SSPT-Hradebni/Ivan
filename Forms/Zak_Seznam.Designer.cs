namespace SediM.Forms
{
    partial class Zak_Seznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zak_Seznam));
            dataviewStudenti = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            jmeno_prijmeni = new DataGridViewTextBoxColumn();
            kategorie = new DataGridViewTextBoxColumn();
            skola = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).BeginInit();
            SuspendLayout();
            // 
            // dataviewStudenti
            // 
            dataviewStudenti.AllowUserToAddRows = false;
            dataviewStudenti.AllowUserToDeleteRows = false;
            dataviewStudenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataviewStudenti.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataviewStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewStudenti.Columns.AddRange(new DataGridViewColumn[] { id, jmeno_prijmeni, kategorie, skola });
            dataviewStudenti.Dock = DockStyle.Fill;
            dataviewStudenti.Location = new Point(0, 0);
            dataviewStudenti.Margin = new Padding(3, 4, 3, 4);
            dataviewStudenti.Name = "dataviewStudenti";
            dataviewStudenti.ReadOnly = true;
            dataviewStudenti.RowHeadersWidth = 51;
            dataviewStudenti.RowTemplate.Height = 25;
            dataviewStudenti.Size = new Size(800, 450);
            dataviewStudenti.TabIndex = 5;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // jmeno_prijmeni
            // 
            jmeno_prijmeni.HeaderText = "Jméno a přijmení";
            jmeno_prijmeni.MinimumWidth = 6;
            jmeno_prijmeni.Name = "jmeno_prijmeni";
            jmeno_prijmeni.ReadOnly = true;
            // 
            // kategorie
            // 
            kategorie.HeaderText = "Kategorie";
            kategorie.MinimumWidth = 6;
            kategorie.Name = "kategorie";
            kategorie.ReadOnly = true;
            // 
            // skola
            // 
            skola.HeaderText = "Škola";
            skola.MinimumWidth = 6;
            skola.Name = "skola";
            skola.ReadOnly = true;
            // 
            // Zak_Seznam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataviewStudenti);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Zak_Seznam";
            Text = "Seznam studentů";
            Load += Zak_Seznam_Load;
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataviewStudenti;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jmeno_prijmeni;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn skola;
    }
}