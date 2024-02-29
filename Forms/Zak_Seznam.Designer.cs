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
            this.dataviewStudenti = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmeno_prijmeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).BeginInit();
            this.SuspendLayout();
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
            this.skola});
            this.dataviewStudenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataviewStudenti.Location = new System.Drawing.Point(0, 0);
            this.dataviewStudenti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataviewStudenti.Name = "dataviewStudenti";
            this.dataviewStudenti.ReadOnly = true;
            this.dataviewStudenti.RowHeadersWidth = 51;
            this.dataviewStudenti.RowTemplate.Height = 25;
            this.dataviewStudenti.Size = new System.Drawing.Size(800, 450);
            this.dataviewStudenti.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // jmeno_prijmeni
            // 
            this.jmeno_prijmeni.HeaderText = "Jméno a přijmení";
            this.jmeno_prijmeni.MinimumWidth = 6;
            this.jmeno_prijmeni.Name = "jmeno_prijmeni";
            this.jmeno_prijmeni.ReadOnly = true;
            // 
            // kategorie
            // 
            this.kategorie.HeaderText = "Kategorie";
            this.kategorie.MinimumWidth = 6;
            this.kategorie.Name = "kategorie";
            this.kategorie.ReadOnly = true;
            // 
            // skola
            // 
            this.skola.HeaderText = "Škola";
            this.skola.MinimumWidth = 6;
            this.skola.Name = "skola";
            this.skola.ReadOnly = true;
            // 
            // Zak_Seznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataviewStudenti);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zak_Seznam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seznam studentů";
            this.Load += new System.EventHandler(this.Zak_Seznam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataviewStudenti;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jmeno_prijmeni;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn skola;
    }
}