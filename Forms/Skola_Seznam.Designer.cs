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
            dataviewSkoly = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nazev = new DataGridViewTextBoxColumn();
            adresa = new DataGridViewTextBoxColumn();
            ico = new DataGridViewTextBoxColumn();
            kod = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataviewSkoly).BeginInit();
            SuspendLayout();
            // 
            // dataviewSkoly
            // 
            dataviewSkoly.AllowUserToAddRows = false;
            dataviewSkoly.AllowUserToDeleteRows = false;
            dataviewSkoly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataviewSkoly.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataviewSkoly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewSkoly.Columns.AddRange(new DataGridViewColumn[] { id, nazev, adresa, ico, kod });
            dataviewSkoly.Dock = DockStyle.Fill;
            dataviewSkoly.Location = new Point(0, 0);
            dataviewSkoly.Margin = new Padding(3, 5, 3, 5);
            dataviewSkoly.Name = "dataviewSkoly";
            dataviewSkoly.ReadOnly = true;
            dataviewSkoly.RowHeadersWidth = 51;
            dataviewSkoly.RowTemplate.Height = 25;
            dataviewSkoly.Size = new Size(1211, 600);
            dataviewSkoly.TabIndex = 5;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nazev
            // 
            nazev.HeaderText = "Název";
            nazev.MinimumWidth = 6;
            nazev.Name = "nazev";
            nazev.ReadOnly = true;
            // 
            // adresa
            // 
            adresa.HeaderText = "Adresa";
            adresa.MinimumWidth = 6;
            adresa.Name = "adresa";
            adresa.ReadOnly = true;
            // 
            // ico
            // 
            ico.HeaderText = "IČO";
            ico.MinimumWidth = 6;
            ico.Name = "ico";
            ico.ReadOnly = true;
            // 
            // kod
            // 
            kod.HeaderText = "Přístupový kód";
            kod.MinimumWidth = 6;
            kod.Name = "kod";
            kod.ReadOnly = true;
            // 
            // Skola_Seznam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 600);
            Controls.Add(dataviewSkoly);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Skola_Seznam";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Seznam škol";
            Load += Zak_Seznam_Load;
            ((System.ComponentModel.ISupportInitialize)dataviewSkoly).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataviewSkoly;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nazev;
        private DataGridViewTextBoxColumn adresa;
        private DataGridViewTextBoxColumn ico;
        private DataGridViewTextBoxColumn kod;
    }
}