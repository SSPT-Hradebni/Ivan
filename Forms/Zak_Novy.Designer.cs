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
            btnVytvořit = new Button();
            ((System.ComponentModel.ISupportInitialize)numKategorie).BeginInit();
            SuspendLayout();
            // 
            // lblJmeno
            // 
            lblJmeno.AutoSize = true;
            lblJmeno.Location = new Point(14, 12);
            lblJmeno.Name = "lblJmeno";
            lblJmeno.Size = new Size(52, 20);
            lblJmeno.TabIndex = 0;
            lblJmeno.Text = "Jméno";
            // 
            // tboxJmeno
            // 
            tboxJmeno.Location = new Point(14, 36);
            tboxJmeno.Margin = new Padding(3, 4, 3, 4);
            tboxJmeno.Name = "tboxJmeno";
            tboxJmeno.Size = new Size(298, 27);
            tboxJmeno.TabIndex = 1;
            // 
            // tboxPrijmeni
            // 
            tboxPrijmeni.Location = new Point(14, 107);
            tboxPrijmeni.Margin = new Padding(3, 4, 3, 4);
            tboxPrijmeni.Name = "tboxPrijmeni";
            tboxPrijmeni.Size = new Size(298, 27);
            tboxPrijmeni.TabIndex = 2;
            // 
            // lblPrijmeni
            // 
            lblPrijmeni.AutoSize = true;
            lblPrijmeni.Location = new Point(14, 83);
            lblPrijmeni.Name = "lblPrijmeni";
            lblPrijmeni.Size = new Size(63, 20);
            lblPrijmeni.TabIndex = 3;
            lblPrijmeni.Text = "Příjmení";
            // 
            // numKategorie
            // 
            numKategorie.Location = new Point(14, 189);
            numKategorie.Margin = new Padding(3, 4, 3, 4);
            numKategorie.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numKategorie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKategorie.Name = "numKategorie";
            numKategorie.Size = new Size(298, 27);
            numKategorie.TabIndex = 4;
            numKategorie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblKategorie
            // 
            lblKategorie.AutoSize = true;
            lblKategorie.Location = new Point(14, 165);
            lblKategorie.Name = "lblKategorie";
            lblKategorie.Size = new Size(74, 20);
            lblKategorie.TabIndex = 5;
            lblKategorie.Text = "Kategorie";
            // 
            // lblSkola
            // 
            lblSkola.AutoSize = true;
            lblSkola.Location = new Point(14, 243);
            lblSkola.Name = "lblSkola";
            lblSkola.Size = new Size(45, 20);
            lblSkola.TabIndex = 6;
            lblSkola.Text = "Škola";
            // 
            // cboxSkoly
            // 
            cboxSkoly.FormattingEnabled = true;
            cboxSkoly.Location = new Point(11, 267);
            cboxSkoly.Margin = new Padding(3, 4, 3, 4);
            cboxSkoly.Name = "cboxSkoly";
            cboxSkoly.Size = new Size(300, 28);
            cboxSkoly.TabIndex = 10;
            // 
            // btnVytvořit
            // 
            btnVytvořit.Location = new Point(14, 311);
            btnVytvořit.Name = "btnVytvořit";
            btnVytvořit.Size = new Size(298, 31);
            btnVytvořit.TabIndex = 11;
            btnVytvořit.Text = "Vytvořit";
            btnVytvořit.UseVisualStyleBackColor = true;
            btnVytvořit.Click += btnVytvořit_Click;
            // 
            // Zak_Novy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 359);
            Controls.Add(btnVytvořit);
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
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Zak_Novy";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nový student";
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
        private Button btnVytvořit;
    }
}