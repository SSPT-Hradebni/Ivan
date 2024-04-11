namespace SediM.Forms
{
    partial class Skola_Seznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skola_Seznam));
            this.dataviewSkoly = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewSkoly)).BeginInit();
            this.SuspendLayout();
            // 
            // dataviewSkoly
            // 
            this.dataviewSkoly.AllowUserToAddRows = false;
            this.dataviewSkoly.AllowUserToDeleteRows = false;
            this.dataviewSkoly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataviewSkoly.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataviewSkoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewSkoly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nazev,
            this.ulice,
            this.cp,
            this.psc,
            this.mesto,
            this.ucitel});
            this.dataviewSkoly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataviewSkoly.Location = new System.Drawing.Point(0, 0);
            this.dataviewSkoly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataviewSkoly.Name = "dataviewSkoly";
            this.dataviewSkoly.ReadOnly = true;
            this.dataviewSkoly.RowHeadersWidth = 51;
            this.dataviewSkoly.RowTemplate.Height = 25;
            this.dataviewSkoly.Size = new System.Drawing.Size(1060, 450);
            this.dataviewSkoly.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nazev
            // 
            this.nazev.HeaderText = "Název";
            this.nazev.MinimumWidth = 6;
            this.nazev.Name = "nazev";
            this.nazev.ReadOnly = true;
            // 
            // ulice
            // 
            this.ulice.HeaderText = "Ulice";
            this.ulice.MinimumWidth = 6;
            this.ulice.Name = "ulice";
            this.ulice.ReadOnly = true;
            // 
            // cp
            // 
            this.cp.HeaderText = "Číslo popisné";
            this.cp.MinimumWidth = 6;
            this.cp.Name = "cp";
            this.cp.ReadOnly = true;
            // 
            // psc
            // 
            this.psc.HeaderText = "PSČ";
            this.psc.Name = "psc";
            this.psc.ReadOnly = true;
            // 
            // mesto
            // 
            this.mesto.HeaderText = "Město";
            this.mesto.Name = "mesto";
            this.mesto.ReadOnly = true;
            // 
            // ucitel
            // 
            this.ucitel.HeaderText = "Odpovědný učitel";
            this.ucitel.Name = "ucitel";
            this.ucitel.ReadOnly = true;
            // 
            // Skola_Seznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.dataviewSkoly);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Skola_Seznam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seznam škol";
            ((System.ComponentModel.ISupportInitialize)(this.dataviewSkoly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataviewSkoly;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nazev;
        private DataGridViewTextBoxColumn ulice;
        private DataGridViewTextBoxColumn cp;
        private DataGridViewTextBoxColumn psc;
        private DataGridViewTextBoxColumn mesto;
        private DataGridViewTextBoxColumn ucitel;
    }
}