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
            dataviewTridy = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nazev = new DataGridViewTextBoxColumn();
            sirka = new DataGridViewTextBoxColumn();
            vyska = new DataGridViewTextBoxColumn();
            jeRozsazena = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataviewTridy).BeginInit();
            SuspendLayout();
            // 
            // dataviewTridy
            // 
            dataviewTridy.AllowUserToAddRows = false;
            dataviewTridy.AllowUserToDeleteRows = false;
            dataviewTridy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataviewTridy.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataviewTridy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewTridy.Columns.AddRange(new DataGridViewColumn[] { id, nazev, sirka, vyska, jeRozsazena });
            dataviewTridy.Dock = DockStyle.Fill;
            dataviewTridy.Location = new Point(0, 0);
            dataviewTridy.Margin = new Padding(3, 4, 3, 4);
            dataviewTridy.Name = "dataviewTridy";
            dataviewTridy.ReadOnly = true;
            dataviewTridy.RowHeadersWidth = 51;
            dataviewTridy.RowTemplate.Height = 25;
            dataviewTridy.Size = new Size(800, 450);
            dataviewTridy.TabIndex = 6;
            dataviewTridy.CellDoubleClick += dataviewTridy_CellDoubleClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nazev
            // 
            nazev.HeaderText = "Název";
            nazev.MinimumWidth = 6;
            nazev.Name = "nazev";
            nazev.ReadOnly = true;
            // 
            // sirka
            // 
            sirka.HeaderText = "Šířka";
            sirka.MinimumWidth = 6;
            sirka.Name = "sirka";
            sirka.ReadOnly = true;
            // 
            // vyska
            // 
            vyska.HeaderText = "Výška";
            vyska.MinimumWidth = 6;
            vyska.Name = "vyska";
            vyska.ReadOnly = true;
            // 
            // jeRozsazena
            // 
            jeRozsazena.HeaderText = "Je rozsazena?";
            jeRozsazena.Name = "jeRozsazena";
            jeRozsazena.ReadOnly = true;
            // 
            // Trida_Seznam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataviewTridy);
            Name = "Trida_Seznam";
            Text = "Trida_Seznam";
            FormClosed += Trida_Seznam_FormClosed;
            Load += Trida_Seznam_Load;
            ((System.ComponentModel.ISupportInitialize)dataviewTridy).EndInit();
            ResumeLayout(false);
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