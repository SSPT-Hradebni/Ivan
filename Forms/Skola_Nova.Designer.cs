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
            lblNazev.Location = new Point(14, 12);
            lblNazev.Name = "lblNazev";
            lblNazev.Size = new Size(50, 20);
            lblNazev.TabIndex = 0;
            lblNazev.Text = "Název";
            // 
            // tboxNazev
            // 
            tboxNazev.Location = new Point(14, 36);
            tboxNazev.Margin = new Padding(3, 4, 3, 4);
            tboxNazev.Name = "tboxNazev";
            tboxNazev.Size = new Size(298, 27);
            tboxNazev.TabIndex = 1;
            // 
            // lblUlice
            // 
            lblUlice.AutoSize = true;
            lblUlice.Location = new Point(14, 85);
            lblUlice.Name = "lblUlice";
            lblUlice.Size = new Size(42, 20);
            lblUlice.TabIndex = 2;
            lblUlice.Text = "Ulice";
            // 
            // tboxUlice
            // 
            tboxUlice.Location = new Point(14, 109);
            tboxUlice.Margin = new Padding(3, 4, 3, 4);
            tboxUlice.Name = "tboxUlice";
            tboxUlice.Size = new Size(217, 27);
            tboxUlice.TabIndex = 3;
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Location = new Point(233, 85);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(35, 20);
            lblCP.TabIndex = 4;
            lblCP.Text = "č. p.";
            // 
            // numCP
            // 
            numCP.Location = new Point(238, 111);
            numCP.Margin = new Padding(3, 4, 3, 4);
            numCP.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numCP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCP.Name = "numCP";
            numCP.Size = new Size(74, 27);
            numCP.TabIndex = 5;
            numCP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMesto
            // 
            lblMesto.AutoSize = true;
            lblMesto.Location = new Point(14, 160);
            lblMesto.Name = "lblMesto";
            lblMesto.Size = new Size(50, 20);
            lblMesto.TabIndex = 6;
            lblMesto.Text = "Město";
            // 
            // cboxMesto
            // 
            cboxMesto.FormattingEnabled = true;
            cboxMesto.Items.AddRange(new object[] { "Broumov", "Dobruška", "Dvůr Králové nad Labem", "Hořice", "Hradec Králové", "Janské Lázně", "Jaroměř", "Jičín", "Kostelec nad Orlicí", "Malé Svatoňovice", "Náchod", "Náchod", "Nová Paka", "Nový Bydžov", "Rychnov nad Kněžnou", "Trutnov", "Třebechovice pod Orebem", "Úpice", "Vrchlabí" });
            cboxMesto.Location = new Point(14, 184);
            cboxMesto.Margin = new Padding(3, 4, 3, 4);
            cboxMesto.Name = "cboxMesto";
            cboxMesto.Size = new Size(217, 28);
            cboxMesto.Sorted = true;
            cboxMesto.TabIndex = 7;
            // 
            // numPSC
            // 
            numPSC.Location = new Point(238, 184);
            numPSC.Margin = new Padding(3, 4, 3, 4);
            numPSC.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numPSC.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPSC.Name = "numPSC";
            numPSC.Size = new Size(74, 27);
            numPSC.TabIndex = 8;
            numPSC.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // lblPSC
            // 
            lblPSC.AutoSize = true;
            lblPSC.Location = new Point(238, 160);
            lblPSC.Name = "lblPSC";
            lblPSC.Size = new Size(34, 20);
            lblPSC.TabIndex = 9;
            lblPSC.Text = "PSČ";
            // 
            // cboxUcitel
            // 
            cboxUcitel.FormattingEnabled = true;
            cboxUcitel.Items.AddRange(new object[] { "Broumov", "Dobruška", "Dvůr Králové nad Labem", "Hořice", "Hradec Králové", "Janské Lázně", "Jaroměř", "Jičín", "Kostelec nad Orlicí", "Malé Svatoňovice", "Náchod", "Náchod", "Nová Paka", "Nový Bydžov", "Rychnov nad Kněžnou", "Trutnov", "Třebechovice pod Orebem", "Úpice", "Vrchlabí" });
            cboxUcitel.Location = new Point(14, 256);
            cboxUcitel.Margin = new Padding(3, 4, 3, 4);
            cboxUcitel.Name = "cboxUcitel";
            cboxUcitel.Size = new Size(298, 28);
            cboxUcitel.Sorted = true;
            cboxUcitel.TabIndex = 10;
            // 
            // lblUcitel
            // 
            lblUcitel.AutoSize = true;
            lblUcitel.Location = new Point(12, 232);
            lblUcitel.Name = "lblUcitel";
            lblUcitel.Size = new Size(126, 20);
            lblUcitel.TabIndex = 11;
            lblUcitel.Text = "Odpovědný učitel";
            // 
            // btnVytvorit
            // 
            btnVytvorit.Location = new Point(12, 309);
            btnVytvorit.Name = "btnVytvorit";
            btnVytvorit.Size = new Size(300, 29);
            btnVytvorit.TabIndex = 12;
            btnVytvorit.Text = "Vytvořit";
            btnVytvorit.UseVisualStyleBackColor = true;
            btnVytvorit.Click += btnVytvorit_Click;
            // 
            // Skola_Nova
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 360);
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
            Margin = new Padding(3, 4, 3, 4);
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