namespace SediM.Forms
{
    partial class Skola_Nova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skola_Nova));
            lblNazev = new Label();
            tboxNazev = new TextBox();
            lblUlice = new Label();
            tboxUlice = new TextBox();
            lblCP = new Label();
            numCP = new NumericUpDown();
            lblMesto = new Label();
            cboxMesto = new ComboBox();
            numPSC = new NumericUpDown();
            lblPSC = new Label();
            cboxUcitel = new ComboBox();
            lblUcitel = new Label();
            btnVytvorit = new Button();
            ((System.ComponentModel.ISupportInitialize)numCP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPSC).BeginInit();
            SuspendLayout();
            // 
            // lblNazev
            // 
            lblNazev.AutoSize = true;
            lblNazev.Location = new Point(12, 9);
            lblNazev.Name = "lblNazev";
            lblNazev.Size = new Size(39, 15);
            lblNazev.TabIndex = 0;
            lblNazev.Text = "Název";
            // 
            // tboxNazev
            // 
            tboxNazev.Location = new Point(12, 27);
            tboxNazev.Name = "tboxNazev";
            tboxNazev.Size = new Size(261, 23);
            tboxNazev.TabIndex = 1;
            // 
            // lblUlice
            // 
            lblUlice.AutoSize = true;
            lblUlice.Location = new Point(12, 64);
            lblUlice.Name = "lblUlice";
            lblUlice.Size = new Size(33, 15);
            lblUlice.TabIndex = 2;
            lblUlice.Text = "Ulice";
            // 
            // tboxUlice
            // 
            tboxUlice.Location = new Point(12, 82);
            tboxUlice.Name = "tboxUlice";
            tboxUlice.Size = new Size(190, 23);
            tboxUlice.TabIndex = 3;
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Location = new Point(204, 64);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(29, 15);
            lblCP.TabIndex = 4;
            lblCP.Text = "č. p.";
            // 
            // numCP
            // 
            numCP.Location = new Point(208, 83);
            numCP.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numCP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCP.Name = "numCP";
            numCP.Size = new Size(65, 23);
            numCP.TabIndex = 5;
            numCP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMesto
            // 
            lblMesto.AutoSize = true;
            lblMesto.Location = new Point(12, 120);
            lblMesto.Name = "lblMesto";
            lblMesto.Size = new Size(40, 15);
            lblMesto.TabIndex = 6;
            lblMesto.Text = "Město";
            // 
            // cboxMesto
            // 
            cboxMesto.FormattingEnabled = true;
            cboxMesto.Items.AddRange(new object[] { "Broumov", "Dobruška", "Dvůr Králové nad Labem", "Hořice", "Hradec Králové", "Janské Lázně", "Jaroměř", "Jičín", "Kostelec nad Orlicí", "Malé Svatoňovice", "Náchod", "Náchod", "Nová Paka", "Nový Bydžov", "Rychnov nad Kněžnou", "Třebechovice pod Orebem", "Trutnov", "Úpice", "Vrchlabí" });
            cboxMesto.Location = new Point(12, 138);
            cboxMesto.Name = "cboxMesto";
            cboxMesto.Size = new Size(190, 23);
            cboxMesto.Sorted = true;
            cboxMesto.TabIndex = 7;
            // 
            // numPSC
            // 
            numPSC.Location = new Point(208, 138);
            numPSC.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numPSC.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPSC.Name = "numPSC";
            numPSC.Size = new Size(65, 23);
            numPSC.TabIndex = 8;
            numPSC.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // lblPSC
            // 
            lblPSC.AutoSize = true;
            lblPSC.Location = new Point(208, 120);
            lblPSC.Name = "lblPSC";
            lblPSC.Size = new Size(28, 15);
            lblPSC.TabIndex = 9;
            lblPSC.Text = "PSČ";
            // 
            // cboxUcitel
            // 
            cboxUcitel.FormattingEnabled = true;
            cboxUcitel.Location = new Point(12, 192);
            cboxUcitel.Name = "cboxUcitel";
            cboxUcitel.Size = new Size(261, 23);
            cboxUcitel.TabIndex = 10;
            // 
            // lblUcitel
            // 
            lblUcitel.AutoSize = true;
            lblUcitel.Location = new Point(10, 174);
            lblUcitel.Name = "lblUcitel";
            lblUcitel.Size = new Size(101, 15);
            lblUcitel.TabIndex = 11;
            lblUcitel.Text = "Odpovědný učitel";
            // 
            // btnVytvorit
            // 
            btnVytvorit.Location = new Point(10, 232);
            btnVytvorit.Margin = new Padding(3, 2, 3, 2);
            btnVytvorit.Name = "btnVytvorit";
            btnVytvorit.Size = new Size(262, 22);
            btnVytvorit.TabIndex = 12;
            btnVytvorit.Text = "Vytvořit";
            btnVytvorit.UseVisualStyleBackColor = true;
            btnVytvorit.Click += btnVytvorit_Click;
            // 
            // Skola_Nova
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 270);
            Controls.Add(btnVytvorit);
            Controls.Add(lblUcitel);
            Controls.Add(cboxUcitel);
            Controls.Add(lblPSC);
            Controls.Add(numPSC);
            Controls.Add(cboxMesto);
            Controls.Add(lblMesto);
            Controls.Add(numCP);
            Controls.Add(lblCP);
            Controls.Add(tboxUlice);
            Controls.Add(lblUlice);
            Controls.Add(tboxNazev);
            Controls.Add(lblNazev);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Skola_Nova";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nová škola";
            Load += Skola_Nova_Load;
            ((System.ComponentModel.ISupportInitialize)numCP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPSC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazev;
        private TextBox tboxNazev;
        private Label lblUlice;
        private TextBox tboxUlice;
        private Label lblCP;
        private NumericUpDown numCP;
        private Label lblMesto;
        private ComboBox cboxMesto;
        private NumericUpDown numPSC;
        private Label lblPSC;
        private ComboBox cboxUcitel;
        private Label lblUcitel;
        private Button btnVytvorit;
    }
}