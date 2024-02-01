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
            this.lblNazev = new System.Windows.Forms.Label();
            this.tboxNazev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUlice = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.numCP = new System.Windows.Forms.NumericUpDown();
            this.lblMesto = new System.Windows.Forms.Label();
            this.cboxMesto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazev
            // 
            this.lblNazev.AutoSize = true;
            this.lblNazev.Location = new System.Drawing.Point(12, 9);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(39, 15);
            this.lblNazev.TabIndex = 0;
            this.lblNazev.Text = "Název";
            // 
            // tboxNazev
            // 
            this.tboxNazev.Location = new System.Drawing.Point(12, 27);
            this.tboxNazev.Name = "tboxNazev";
            this.tboxNazev.Size = new System.Drawing.Size(261, 23);
            this.tboxNazev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ulice";
            // 
            // tboxUlice
            // 
            this.tboxUlice.Location = new System.Drawing.Point(12, 82);
            this.tboxUlice.Name = "tboxUlice";
            this.tboxUlice.Size = new System.Drawing.Size(190, 23);
            this.tboxUlice.TabIndex = 3;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(204, 64);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(29, 15);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "č. p.";
            // 
            // numCP
            // 
            this.numCP.Location = new System.Drawing.Point(208, 83);
            this.numCP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCP.Name = "numCP";
            this.numCP.Size = new System.Drawing.Size(65, 23);
            this.numCP.TabIndex = 5;
            this.numCP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMesto
            // 
            this.lblMesto.AutoSize = true;
            this.lblMesto.Location = new System.Drawing.Point(12, 120);
            this.lblMesto.Name = "lblMesto";
            this.lblMesto.Size = new System.Drawing.Size(40, 15);
            this.lblMesto.TabIndex = 6;
            this.lblMesto.Text = "Město";
            // 
            // cboxMesto
            // 
            this.cboxMesto.FormattingEnabled = true;
            this.cboxMesto.Items.AddRange(new object[] {
            "Broumov",
            "Dobruška",
            "Dvůr Králové nad Labem",
            "Hořice",
            "Hradec Králové",
            "Janské Lázně",
            "Jaroměř",
            "Jičín",
            "Kostelec nad Orlicí",
            "Malé Svatoňovice",
            "Náchod",
            "Náchod",
            "Nová Paka",
            "Nový Bydžov",
            "Rychnov nad Kněžnou",
            "Trutnov",
            "Třebechovice pod Orebem",
            "Úpice",
            "Vrchlabí"});
            this.cboxMesto.Location = new System.Drawing.Point(12, 138);
            this.cboxMesto.Name = "cboxMesto";
            this.cboxMesto.Size = new System.Drawing.Size(190, 23);
            this.cboxMesto.Sorted = true;
            this.cboxMesto.TabIndex = 7;
            // 
            // Skola_Nova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxMesto);
            this.Controls.Add(this.lblMesto);
            this.Controls.Add(this.numCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.tboxUlice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNazev);
            this.Controls.Add(this.lblNazev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Skola_Nova";
            this.Text = "Nová škola";
            ((System.ComponentModel.ISupportInitialize)(this.numCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNazev;
        private TextBox tboxNazev;
        private Label label1;
        private TextBox tboxUlice;
        private Label lblCP;
        private NumericUpDown numCP;
        private Label lblMesto;
        private ComboBox cboxMesto;
    }
}