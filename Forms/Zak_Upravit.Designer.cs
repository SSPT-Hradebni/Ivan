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
            lblZakID = new Label();
            btnUlozit = new Button();
            cboxZaci = new ComboBox();
            lblZak = new Label();
            ((System.ComponentModel.ISupportInitialize)numKategorie).BeginInit();
            groupBoxStudent.SuspendLayout();
            SuspendLayout();
            // 
            // lblJmeno
            // 
            lblJmeno.AutoSize = true;
            lblJmeno.Location = new Point(22, 27);
            lblJmeno.Name = "lblJmeno";
            lblJmeno.Size = new Size(42, 15);
            lblJmeno.TabIndex = 0;
            lblJmeno.Text = "Jméno";
            // 
            // lblPrijmeni
            // 
            lblPrijmeni.AutoSize = true;
            lblPrijmeni.Location = new Point(22, 80);
            lblPrijmeni.Name = "lblPrijmeni";
            lblPrijmeni.Size = new Size(51, 15);
            lblPrijmeni.TabIndex = 1;
            lblPrijmeni.Text = "Příjmení";
            // 
            // tboxJmeno
            // 
            tboxJmeno.Location = new Point(22, 44);
            tboxJmeno.Margin = new Padding(3, 2, 3, 2);
            tboxJmeno.Name = "tboxJmeno";
            tboxJmeno.Size = new Size(261, 23);
            tboxJmeno.TabIndex = 2;
            // 
            // tboxPrijmeni
            // 
            tboxPrijmeni.Location = new Point(22, 97);
            tboxPrijmeni.Margin = new Padding(3, 2, 3, 2);
            tboxPrijmeni.Name = "tboxPrijmeni";
            tboxPrijmeni.Size = new Size(261, 23);
            tboxPrijmeni.TabIndex = 3;
            // 
            // lblKategorie
            // 
            lblKategorie.AutoSize = true;
            lblKategorie.Location = new Point(22, 130);
            lblKategorie.Name = "lblKategorie";
            lblKategorie.Size = new Size(57, 15);
            lblKategorie.TabIndex = 4;
            lblKategorie.Text = "Kategorie";
            // 
            // lblSkola
            // 
            lblSkola.AutoSize = true;
            lblSkola.Location = new Point(22, 185);
            lblSkola.Name = "lblSkola";
            lblSkola.Size = new Size(35, 15);
            lblSkola.TabIndex = 5;
            lblSkola.Text = "Škola";
            // 
            // numKategorie
            // 
            numKategorie.Location = new Point(22, 148);
            numKategorie.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numKategorie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKategorie.Name = "numKategorie";
            numKategorie.Size = new Size(261, 23);
            numKategorie.TabIndex = 6;
            numKategorie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboxSkoly
            // 
            cboxSkoly.FormattingEnabled = true;
            cboxSkoly.Location = new Point(22, 203);
            cboxSkoly.Name = "cboxSkoly";
            cboxSkoly.Size = new Size(261, 23);
            cboxSkoly.TabIndex = 11;
            // 
            // groupBoxStudent
            // 
            groupBoxStudent.Controls.Add(lblZakID);
            groupBoxStudent.Controls.Add(btnUlozit);
            groupBoxStudent.Controls.Add(lblJmeno);
            groupBoxStudent.Controls.Add(cboxSkoly);
            groupBoxStudent.Controls.Add(lblPrijmeni);
            groupBoxStudent.Controls.Add(numKategorie);
            groupBoxStudent.Controls.Add(tboxJmeno);
            groupBoxStudent.Controls.Add(lblSkola);
            groupBoxStudent.Controls.Add(tboxPrijmeni);
            groupBoxStudent.Controls.Add(lblKategorie);
            groupBoxStudent.Location = new Point(10, 52);
            groupBoxStudent.Margin = new Padding(3, 2, 3, 2);
            groupBoxStudent.Name = "groupBoxStudent";
            groupBoxStudent.Padding = new Padding(3, 2, 3, 2);
            groupBoxStudent.Size = new Size(626, 238);
            groupBoxStudent.TabIndex = 12;
            groupBoxStudent.TabStop = false;
            groupBoxStudent.Text = "Žák";
            // 
            // lblZakID
            // 
            lblZakID.AutoSize = true;
            lblZakID.Location = new Point(407, 17);
            lblZakID.Name = "lblZakID";
            lblZakID.Size = new Size(44, 15);
            lblZakID.TabIndex = 13;
            lblZakID.Text = "ID žáka";
            lblZakID.Visible = false;
            // 
            // btnUlozit
            // 
            btnUlozit.Location = new Point(539, 212);
            btnUlozit.Margin = new Padding(3, 2, 3, 2);
            btnUlozit.Name = "btnUlozit";
            btnUlozit.Size = new Size(82, 22);
            btnUlozit.TabIndex = 12;
            btnUlozit.Text = "Uložit";
            btnUlozit.UseVisualStyleBackColor = true;
            btnUlozit.Click += btnUlozit_Click;
            // 
            // cboxZaci
            // 
            cboxZaci.FormattingEnabled = true;
            cboxZaci.Location = new Point(10, 26);
            cboxZaci.Name = "cboxZaci";
            cboxZaci.Size = new Size(627, 23);
            cboxZaci.TabIndex = 12;
            cboxZaci.SelectedIndexChanged += cboxZaci_SelectedIndexChanged;
            // 
            // lblZak
            // 
            lblZak.AutoSize = true;
            lblZak.Location = new Point(10, 7);
            lblZak.Name = "lblZak";
            lblZak.Size = new Size(73, 15);
            lblZak.TabIndex = 12;
            lblZak.Text = "Vyberte žáka";
            // 
            // Zak_Upravit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 299);
            Controls.Add(lblZak);
            Controls.Add(cboxZaci);
            Controls.Add(groupBoxStudent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Zak_Upravit";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Upravit žáka";
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
        private ComboBox cboxZaci;
        private Label lblZak;
        private Button btnUlozit;
        private Label lblZakID;
    }
}