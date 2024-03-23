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
            lblJmeno = new Label();
            tboxJmeno = new TextBox();
            tboxPrijmeni = new TextBox();
            lblPrijmeni = new Label();
            numKategorie = new NumericUpDown();
            lblKategorie = new Label();
            lblSkola = new Label();
            cboxSkoly = new ComboBox();
            btnVytvorit = new Button();
            ((System.ComponentModel.ISupportInitialize)numKategorie).BeginInit();
            SuspendLayout();
            // 
            // lblJmeno
            // 
            lblJmeno.AutoSize = true;
            lblJmeno.Location = new Point(12, 9);
            lblJmeno.Name = "lblJmeno";
            lblJmeno.Size = new Size(42, 15);
            lblJmeno.TabIndex = 0;
            lblJmeno.Text = "Jméno";
            // 
            // tboxJmeno
            // 
            tboxJmeno.Location = new Point(12, 27);
            tboxJmeno.Name = "tboxJmeno";
            tboxJmeno.Size = new Size(261, 23);
            tboxJmeno.TabIndex = 1;
            // 
            // tboxPrijmeni
            // 
            tboxPrijmeni.Location = new Point(12, 80);
            tboxPrijmeni.Name = "tboxPrijmeni";
            tboxPrijmeni.Size = new Size(261, 23);
            tboxPrijmeni.TabIndex = 2;
            // 
            // lblPrijmeni
            // 
            lblPrijmeni.AutoSize = true;
            lblPrijmeni.Location = new Point(12, 62);
            lblPrijmeni.Name = "lblPrijmeni";
            lblPrijmeni.Size = new Size(51, 15);
            lblPrijmeni.TabIndex = 3;
            lblPrijmeni.Text = "Příjmení";
            // 
            // numKategorie
            // 
            numKategorie.Location = new Point(12, 142);
            numKategorie.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numKategorie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKategorie.Name = "numKategorie";
            numKategorie.Size = new Size(261, 23);
            numKategorie.TabIndex = 4;
            numKategorie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblKategorie
            // 
            lblKategorie.AutoSize = true;
            lblKategorie.Location = new Point(12, 124);
            lblKategorie.Name = "lblKategorie";
            lblKategorie.Size = new Size(57, 15);
            lblKategorie.TabIndex = 5;
            lblKategorie.Text = "Kategorie";
            // 
            // lblSkola
            // 
            lblSkola.AutoSize = true;
            lblSkola.Location = new Point(12, 182);
            lblSkola.Name = "lblSkola";
            lblSkola.Size = new Size(35, 15);
            lblSkola.TabIndex = 6;
            lblSkola.Text = "Škola";
            // 
            // cboxSkoly
            // 
            cboxSkoly.FormattingEnabled = true;
            cboxSkoly.Location = new Point(10, 200);
            cboxSkoly.Name = "cboxSkoly";
            cboxSkoly.Size = new Size(263, 23);
            cboxSkoly.TabIndex = 10;
            // 
            // btnVytvorit
            // 
            btnVytvorit.Location = new Point(12, 233);
            btnVytvorit.Margin = new Padding(3, 2, 3, 2);
            btnVytvorit.Name = "btnVytvorit";
            btnVytvorit.Size = new Size(261, 23);
            btnVytvorit.TabIndex = 11;
            btnVytvorit.Text = "Vytvořit";
            btnVytvorit.UseVisualStyleBackColor = true;
            btnVytvorit.Click += btnVytvorit_Click;
            // 
            // Zak_Novy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 269);
            Controls.Add(btnVytvorit);
            Controls.Add(cboxSkoly);
            Controls.Add(lblSkola);
            Controls.Add(lblKategorie);
            Controls.Add(numKategorie);
            Controls.Add(lblPrijmeni);
            Controls.Add(tboxPrijmeni);
            Controls.Add(tboxJmeno);
            Controls.Add(lblJmeno);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Zak_Novy";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nový žák";
            HelpButtonClicked += Zak_Novy_HelpButtonClicked;
            Load += Zak_Novy_Load;
            ((System.ComponentModel.ISupportInitialize)numKategorie).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnVytvorit;
    }
}