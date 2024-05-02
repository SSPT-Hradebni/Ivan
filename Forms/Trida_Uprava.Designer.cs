namespace SediM.Forms
{
    partial class Trida_Uprava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trida_Uprava));
            this.tboxNazev = new System.Windows.Forms.TextBox();
            this.panelEditClassroom = new System.Windows.Forms.Panel();
            this.numVyska = new System.Windows.Forms.NumericUpDown();
            this.numSirka = new System.Windows.Forms.NumericUpDown();
            this.gboxVelikost = new System.Windows.Forms.GroupBox();
            this.lblVyska = new System.Windows.Forms.Label();
            this.lblSirka = new System.Windows.Forms.Label();
            this.cboxTridy = new System.Windows.Forms.ComboBox();
            this.btnNastavit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numVyska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSirka)).BeginInit();
            this.gboxVelikost.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxNazev
            // 
            this.tboxNazev.Location = new System.Drawing.Point(12, 40);
            this.tboxNazev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxNazev.Name = "tboxNazev";
            this.tboxNazev.PlaceholderText = "Název učebny";
            this.tboxNazev.Size = new System.Drawing.Size(142, 23);
            this.tboxNazev.TabIndex = 15;
            // 
            // panelEditClassroom
            // 
            this.panelEditClassroom.Location = new System.Drawing.Point(160, 10);
            this.panelEditClassroom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEditClassroom.Name = "panelEditClassroom";
            this.panelEditClassroom.Size = new System.Drawing.Size(976, 574);
            this.panelEditClassroom.TabIndex = 14;
            this.panelEditClassroom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEditClassroom_Paint);
            // 
            // numVyska
            // 
            this.numVyska.Location = new System.Drawing.Point(6, 83);
            this.numVyska.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numVyska.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVyska.Name = "numVyska";
            this.numVyska.Size = new System.Drawing.Size(90, 23);
            this.numVyska.TabIndex = 11;
            this.numVyska.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVyska.ValueChanged += new System.EventHandler(this.numVyska_ValueChanged);
            // 
            // numSirka
            // 
            this.numSirka.Location = new System.Drawing.Point(6, 37);
            this.numSirka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSirka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSirka.Name = "numSirka";
            this.numSirka.Size = new System.Drawing.Size(90, 23);
            this.numSirka.TabIndex = 9;
            this.numSirka.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSirka.ValueChanged += new System.EventHandler(this.numSirka_ValueChanged);
            // 
            // gboxVelikost
            // 
            this.gboxVelikost.Controls.Add(this.lblVyska);
            this.gboxVelikost.Controls.Add(this.lblSirka);
            this.gboxVelikost.Controls.Add(this.numVyska);
            this.gboxVelikost.Controls.Add(this.numSirka);
            this.gboxVelikost.Location = new System.Drawing.Point(12, 67);
            this.gboxVelikost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxVelikost.Name = "gboxVelikost";
            this.gboxVelikost.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxVelikost.Size = new System.Drawing.Size(142, 117);
            this.gboxVelikost.TabIndex = 16;
            this.gboxVelikost.TabStop = false;
            this.gboxVelikost.Text = "Velikost učebny";
            // 
            // lblVyska
            // 
            this.lblVyska.AutoSize = true;
            this.lblVyska.Location = new System.Drawing.Point(6, 64);
            this.lblVyska.Name = "lblVyska";
            this.lblVyska.Size = new System.Drawing.Size(27, 15);
            this.lblVyska.TabIndex = 13;
            this.lblVyska.Text = "Řad";
            // 
            // lblSirka
            // 
            this.lblSirka.AutoSize = true;
            this.lblSirka.Location = new System.Drawing.Point(6, 18);
            this.lblSirka.Name = "lblSirka";
            this.lblSirka.Size = new System.Drawing.Size(65, 15);
            this.lblSirka.TabIndex = 12;
            this.lblSirka.Text = "Míst v řadě";
            // 
            // cboxTridy
            // 
            this.cboxTridy.FormattingEnabled = true;
            this.cboxTridy.Location = new System.Drawing.Point(12, 10);
            this.cboxTridy.Name = "cboxTridy";
            this.cboxTridy.Size = new System.Drawing.Size(142, 23);
            this.cboxTridy.TabIndex = 17;
            this.cboxTridy.SelectedIndexChanged += new System.EventHandler(this.cboxTridy_SelectedIndexChanged);
            // 
            // btnNastavit
            // 
            this.btnNastavit.Location = new System.Drawing.Point(12, 188);
            this.btnNastavit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNastavit.Name = "btnNastavit";
            this.btnNastavit.Size = new System.Drawing.Size(142, 31);
            this.btnNastavit.TabIndex = 18;
            this.btnNastavit.Text = "Nastavit";
            this.btnNastavit.UseVisualStyleBackColor = true;
            this.btnNastavit.Click += new System.EventHandler(this.btnNastavit_Click);
            // 
            // Trida_Uprava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 596);
            this.Controls.Add(this.btnNastavit);
            this.Controls.Add(this.cboxTridy);
            this.Controls.Add(this.gboxVelikost);
            this.Controls.Add(this.tboxNazev);
            this.Controls.Add(this.panelEditClassroom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Trida_Uprava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Úprava třídy";
            ((System.ComponentModel.ISupportInitialize)(this.numVyska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSirka)).EndInit();
            this.gboxVelikost.ResumeLayout(false);
            this.gboxVelikost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tboxNazev;
        private Panel panelEditClassroom;
        private Button btnOdstranitTridu;
        private NumericUpDown numVyska;
        private NumericUpDown numSirka;
        private GroupBox gboxVelikost;
        private Label lblVyska;
        private Label lblSirka;
        private ComboBox cboxTridy;
        private Button btnNastavit;
    }
}