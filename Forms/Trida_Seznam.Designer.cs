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
            dataviewUcebny = new DataGridView();
            nazev = new DataGridViewTextBoxColumn();
            sirka = new DataGridViewTextBoxColumn();
            vyska = new DataGridViewTextBoxColumn();
            jeRozsazena = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataviewUcebny).BeginInit();
            SuspendLayout();
            // 
            // dataviewUcebny
            // 
            dataviewUcebny.AllowUserToAddRows = false;
            dataviewUcebny.AllowUserToDeleteRows = false;
            dataviewUcebny.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataviewUcebny.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataviewUcebny.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewUcebny.Columns.AddRange(new DataGridViewColumn[] { nazev, sirka, vyska, jeRozsazena });
            dataviewUcebny.Dock = DockStyle.Fill;
            dataviewUcebny.Location = new Point(0, 0);
            dataviewUcebny.Margin = new Padding(3, 4, 3, 4);
            dataviewUcebny.MultiSelect = false;
            dataviewUcebny.Name = "dataviewUcebny";
            dataviewUcebny.ReadOnly = true;
            dataviewUcebny.RowHeadersWidth = 51;
            dataviewUcebny.RowTemplate.Height = 25;
            dataviewUcebny.Size = new Size(800, 450);
            dataviewUcebny.TabIndex = 6;
            dataviewUcebny.CellDoubleClick += dataviewTridy_CellDoubleClick;
            dataviewUcebny.KeyPress += dataviewTridy_KeyPress;
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
            Controls.Add(dataviewUcebny);
            Name = "Trida_Seznam";
            Text = "Seznam učeben";
            FormClosed += Trida_Seznam_FormClosed;
            Load += Trida_Seznam_Load;
            ((System.ComponentModel.ISupportInitialize)dataviewUcebny).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataviewUcebny;
        private DataGridViewTextBoxColumn nazev;
        private DataGridViewTextBoxColumn sirka;
        private DataGridViewTextBoxColumn vyska;
        private DataGridViewTextBoxColumn jeRozsazena;
    }
}