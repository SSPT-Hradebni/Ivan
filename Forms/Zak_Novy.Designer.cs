namespace SediM
{
    partial class Zak_Novy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zak_Novy));
            this.lblJmeno = new System.Windows.Forms.Label();
            this.tboxJmeno = new System.Windows.Forms.TextBox();
            this.tboxPrijmeni = new System.Windows.Forms.TextBox();
            this.lblPrijmeni = new System.Windows.Forms.Label();
            this.numKategorie = new System.Windows.Forms.NumericUpDown();
            this.lblKategorie = new System.Windows.Forms.Label();
            this.lblSkola = new System.Windows.Forms.Label();
            this.cboxSkoly = new System.Windows.Forms.ComboBox();
            this.btnVytvořit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(12, 9);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(42, 15);
            this.lblJmeno.TabIndex = 0;
            this.lblJmeno.Text = "Jméno";
            // 
            // tboxJmeno
            // 
            this.tboxJmeno.Location = new System.Drawing.Point(12, 27);
            this.tboxJmeno.Name = "tboxJmeno";
            this.tboxJmeno.Size = new System.Drawing.Size(261, 23);
            this.tboxJmeno.TabIndex = 1;
            // 
            // tboxPrijmeni
            // 
            this.tboxPrijmeni.Location = new System.Drawing.Point(12, 80);
            this.tboxPrijmeni.Name = "tboxPrijmeni";
            this.tboxPrijmeni.Size = new System.Drawing.Size(261, 23);
            this.tboxPrijmeni.TabIndex = 2;
            // 
            // lblPrijmeni
            // 
            this.lblPrijmeni.AutoSize = true;
            this.lblPrijmeni.Location = new System.Drawing.Point(12, 62);
            this.lblPrijmeni.Name = "lblPrijmeni";
            this.lblPrijmeni.Size = new System.Drawing.Size(51, 15);
            this.lblPrijmeni.TabIndex = 3;
            this.lblPrijmeni.Text = "Příjmení";
            // 
            // numKategorie
            // 
            this.numKategorie.Location = new System.Drawing.Point(12, 142);
            this.numKategorie.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numKategorie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKategorie.Name = "numKategorie";
            this.numKategorie.Size = new System.Drawing.Size(261, 23);
            this.numKategorie.TabIndex = 4;
            this.numKategorie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKategorie
            // 
            this.lblKategorie.AutoSize = true;
            this.lblKategorie.Location = new System.Drawing.Point(12, 124);
            this.lblKategorie.Name = "lblKategorie";
            this.lblKategorie.Size = new System.Drawing.Size(57, 15);
            this.lblKategorie.TabIndex = 5;
            this.lblKategorie.Text = "Kategorie";
            // 
            // lblSkola
            // 
            this.lblSkola.AutoSize = true;
            this.lblSkola.Location = new System.Drawing.Point(12, 182);
            this.lblSkola.Name = "lblSkola";
            this.lblSkola.Size = new System.Drawing.Size(35, 15);
            this.lblSkola.TabIndex = 6;
            this.lblSkola.Text = "Škola";
            // 
            // cboxSkoly
            // 
            this.cboxSkoly.FormattingEnabled = true;
            this.cboxSkoly.Location = new System.Drawing.Point(10, 200);
            this.cboxSkoly.Name = "cboxSkoly";
            this.cboxSkoly.Size = new System.Drawing.Size(263, 23);
            this.cboxSkoly.TabIndex = 10;
            // 
            // btnVytvořit
            // 
            this.btnVytvořit.Location = new System.Drawing.Point(12, 233);
            this.btnVytvořit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVytvořit.Name = "btnVytvořit";
            this.btnVytvořit.Size = new System.Drawing.Size(261, 23);
            this.btnVytvořit.TabIndex = 11;
            this.btnVytvořit.Text = "Vytvořit";
            this.btnVytvořit.UseVisualStyleBackColor = true;
            // 
            // Zak_Novy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 269);
            this.Controls.Add(this.btnVytvořit);
            this.Controls.Add(this.cboxSkoly);
            this.Controls.Add(this.lblSkola);
            this.Controls.Add(this.lblKategorie);
            this.Controls.Add(this.numKategorie);
            this.Controls.Add(this.lblPrijmeni);
            this.Controls.Add(this.tboxPrijmeni);
            this.Controls.Add(this.tboxJmeno);
            this.Controls.Add(this.lblJmeno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zak_Novy";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nový student";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Zak_Novy_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.numKategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblJmeno;
        private TextBox tboxJmeno;
        private TextBox tboxPrijmeni;
        private Label lblPrijmeni;
        private NumericUpDown numKategorie;
        private Label lblKategorie;
        private Label lblSkola;
        private ComboBox cboxSkoly;
        private Button btnVytvořit;
    }
}