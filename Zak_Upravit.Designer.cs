namespace SediM
{
    partial class Zak_Upravit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zak_Upravit));
            lblJmeno = new Label();
            lblPrijmeni = new Label();
            tboxJmeno = new TextBox();
            tboxPrijmeni = new TextBox();
            lblKategorie = new Label();
            lblSkola = new Label();
            numKategorie = new NumericUpDown();
            cboxSkoly = new ComboBox();
            groupBoxStudent = new GroupBox();
            cboxStudenti = new ComboBox();
            lblStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)numKategorie).BeginInit();
            groupBoxStudent.SuspendLayout();
            SuspendLayout();
            // 
            // lblJmeno
            // 
            lblJmeno.AutoSize = true;
            lblJmeno.Location = new Point(25, 36);
            lblJmeno.Name = "lblJmeno";
            lblJmeno.Size = new Size(52, 20);
            lblJmeno.TabIndex = 0;
            lblJmeno.Text = "Jméno";
            // 
            // lblPrijmeni
            // 
            lblPrijmeni.AutoSize = true;
            lblPrijmeni.Location = new Point(25, 106);
            lblPrijmeni.Name = "lblPrijmeni";
            lblPrijmeni.Size = new Size(63, 20);
            lblPrijmeni.TabIndex = 1;
            lblPrijmeni.Text = "Příjmení";
            // 
            // tboxJmeno
            // 
            tboxJmeno.Location = new Point(25, 59);
            tboxJmeno.Name = "tboxJmeno";
            tboxJmeno.Size = new Size(298, 27);
            tboxJmeno.TabIndex = 2;
            // 
            // tboxPrijmeni
            // 
            tboxPrijmeni.Location = new Point(25, 129);
            tboxPrijmeni.Name = "tboxPrijmeni";
            tboxPrijmeni.Size = new Size(298, 27);
            tboxPrijmeni.TabIndex = 3;
            // 
            // lblKategorie
            // 
            lblKategorie.AutoSize = true;
            lblKategorie.Location = new Point(25, 174);
            lblKategorie.Name = "lblKategorie";
            lblKategorie.Size = new Size(74, 20);
            lblKategorie.TabIndex = 4;
            lblKategorie.Text = "Kategorie";
            // 
            // lblSkola
            // 
            lblSkola.AutoSize = true;
            lblSkola.Location = new Point(25, 247);
            lblSkola.Name = "lblSkola";
            lblSkola.Size = new Size(45, 20);
            lblSkola.TabIndex = 5;
            lblSkola.Text = "Škola";
            // 
            // numKategorie
            // 
            numKategorie.Location = new Point(25, 198);
            numKategorie.Margin = new Padding(3, 4, 3, 4);
            numKategorie.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numKategorie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKategorie.Name = "numKategorie";
            numKategorie.Size = new Size(298, 27);
            numKategorie.TabIndex = 6;
            numKategorie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboxSkoly
            // 
            cboxSkoly.FormattingEnabled = true;
            cboxSkoly.Location = new Point(25, 271);
            cboxSkoly.Margin = new Padding(3, 4, 3, 4);
            cboxSkoly.Name = "cboxSkoly";
            cboxSkoly.Size = new Size(298, 28);
            cboxSkoly.TabIndex = 11;
            // 
            // groupBoxStudent
            // 
            groupBoxStudent.Controls.Add(lblJmeno);
            groupBoxStudent.Controls.Add(cboxSkoly);
            groupBoxStudent.Controls.Add(lblPrijmeni);
            groupBoxStudent.Controls.Add(numKategorie);
            groupBoxStudent.Controls.Add(tboxJmeno);
            groupBoxStudent.Controls.Add(lblSkola);
            groupBoxStudent.Controls.Add(tboxPrijmeni);
            groupBoxStudent.Controls.Add(lblKategorie);
            groupBoxStudent.Location = new Point(12, 70);
            groupBoxStudent.Name = "groupBoxStudent";
            groupBoxStudent.Size = new Size(716, 317);
            groupBoxStudent.TabIndex = 12;
            groupBoxStudent.TabStop = false;
            groupBoxStudent.Text = "Student";
            // 
            // cboxStudenti
            // 
            cboxStudenti.FormattingEnabled = true;
            cboxStudenti.Location = new Point(12, 35);
            cboxStudenti.Margin = new Padding(3, 4, 3, 4);
            cboxStudenti.Name = "cboxStudenti";
            cboxStudenti.Size = new Size(716, 28);
            cboxStudenti.TabIndex = 12;
            cboxStudenti.SelectedIndexChanged += cboxStudenti_SelectedIndexChanged;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 9);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(121, 20);
            lblStudent.TabIndex = 12;
            lblStudent.Text = "Vyberte studenta";
            // 
            // Zak_Upravit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 399);
            Controls.Add(lblStudent);
            Controls.Add(cboxStudenti);
            Controls.Add(groupBoxStudent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Zak_Upravit";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Upravit studenta";
            Load += Zak_Upravit_Load;
            ((System.ComponentModel.ISupportInitialize)numKategorie).EndInit();
            groupBoxStudent.ResumeLayout(false);
            groupBoxStudent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJmeno;
        private Label lblPrijmeni;
        private TextBox tboxJmeno;
        private TextBox tboxPrijmeni;
        private Label lblKategorie;
        private Label lblSkola;
        private NumericUpDown numKategorie;
        private ComboBox cboxSkoly;
        private GroupBox groupBoxStudent;
        private ComboBox cboxStudenti;
        private Label lblStudent;
    }
}