namespace SediM.Forms
{
    partial class Trida_Seznam
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
            this.dataviewTridy = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vyska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeRozsazena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewTridy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataviewTridy
            // 
            this.dataviewTridy.AllowUserToAddRows = false;
            this.dataviewTridy.AllowUserToDeleteRows = false;
            this.dataviewTridy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataviewTridy.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataviewTridy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewTridy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nazev,
            this.sirka,
            this.vyska,
            this.jeRozsazena});
            this.dataviewTridy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataviewTridy.Location = new System.Drawing.Point(0, 0);
            this.dataviewTridy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataviewTridy.Name = "dataviewTridy";
            this.dataviewTridy.ReadOnly = true;
            this.dataviewTridy.RowHeadersWidth = 51;
            this.dataviewTridy.RowTemplate.Height = 25;
            this.dataviewTridy.Size = new System.Drawing.Size(800, 450);
            this.dataviewTridy.TabIndex = 6;
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
            // sirka
            // 
            this.sirka.HeaderText = "Šířka";
            this.sirka.MinimumWidth = 6;
            this.sirka.Name = "sirka";
            this.sirka.ReadOnly = true;
            // 
            // vyska
            // 
            this.vyska.HeaderText = "Výška";
            this.vyska.MinimumWidth = 6;
            this.vyska.Name = "vyska";
            this.vyska.ReadOnly = true;
            // 
            // jeRozsazena
            // 
            this.jeRozsazena.HeaderText = "Je rozsazena?";
            this.jeRozsazena.Name = "jeRozsazena";
            this.jeRozsazena.ReadOnly = true;
            // 
            // Trida_Seznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataviewTridy);
            this.Name = "Trida_Seznam";
            this.Text = "Trida_Seznam";
            this.Load += new System.EventHandler(this.Trida_Seznam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewTridy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataviewTridy;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nazev;
        private DataGridViewTextBoxColumn sirka;
        private DataGridViewTextBoxColumn vyska;
        private DataGridViewTextBoxColumn jeRozsazena;
    }
}