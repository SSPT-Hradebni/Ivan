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
            tboxNazev = new TextBox();
            panelEditClassroom = new Panel();
            btnNastavit = new Button();
            numVyska = new NumericUpDown();
            numSirka = new NumericUpDown();
            gboxVelikost = new GroupBox();
            lblVyska = new Label();
            lblSirka = new Label();
            cboxTridy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numVyska).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSirka).BeginInit();
            gboxVelikost.SuspendLayout();
            SuspendLayout();
            // 
            // tboxNazev
            // 
            tboxNazev.Location = new Point(12, 40);
            tboxNazev.Margin = new Padding(3, 4, 3, 4);
            tboxNazev.Name = "tboxNazev";
            tboxNazev.PlaceholderText = "Název třídy";
            tboxNazev.Size = new Size(142, 23);
            tboxNazev.TabIndex = 15;
            // 
            // panelEditClassroom
            // 
            panelEditClassroom.Location = new Point(160, 10);
            panelEditClassroom.Margin = new Padding(3, 4, 3, 4);
            panelEditClassroom.Name = "panelEditClassroom";
            panelEditClassroom.Size = new Size(830, 430);
            panelEditClassroom.TabIndex = 14;
            panelEditClassroom.Paint += panelEditClassroom_Paint;
            // 
            // btnNastavit
            // 
            btnNastavit.Location = new Point(12, 149);
            btnNastavit.Margin = new Padding(3, 4, 3, 4);
            btnNastavit.Name = "btnNastavit";
            btnNastavit.Size = new Size(143, 31);
            btnNastavit.TabIndex = 12;
            btnNastavit.Text = "Nastavit";
            btnNastavit.UseVisualStyleBackColor = true;
            // 
            // numVyska
            // 
            numVyska.Location = new Point(46, 49);
            numVyska.Margin = new Padding(3, 4, 3, 4);
            numVyska.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numVyska.Name = "numVyska";
            numVyska.Size = new Size(90, 23);
            numVyska.TabIndex = 11;
            numVyska.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numSirka
            // 
            numSirka.Location = new Point(46, 21);
            numSirka.Margin = new Padding(3, 4, 3, 4);
            numSirka.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSirka.Name = "numSirka";
            numSirka.Size = new Size(90, 23);
            numSirka.TabIndex = 9;
            numSirka.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gboxVelikost
            // 
            gboxVelikost.Controls.Add(lblVyska);
            gboxVelikost.Controls.Add(lblSirka);
            gboxVelikost.Controls.Add(numVyska);
            gboxVelikost.Controls.Add(numSirka);
            gboxVelikost.Location = new Point(12, 67);
            gboxVelikost.Margin = new Padding(3, 2, 3, 2);
            gboxVelikost.Name = "gboxVelikost";
            gboxVelikost.Padding = new Padding(3, 2, 3, 2);
            gboxVelikost.Size = new Size(142, 76);
            gboxVelikost.TabIndex = 16;
            gboxVelikost.TabStop = false;
            gboxVelikost.Text = "Velikost třídy";
            // 
            // lblVyska
            // 
            lblVyska.AutoSize = true;
            lblVyska.Location = new Point(5, 50);
            lblVyska.Name = "lblVyska";
            lblVyska.Size = new Size(37, 15);
            lblVyska.TabIndex = 13;
            lblVyska.Text = "Výška";
            // 
            // lblSirka
            // 
            lblSirka.AutoSize = true;
            lblSirka.Location = new Point(5, 22);
            lblSirka.Name = "lblSirka";
            lblSirka.Size = new Size(32, 15);
            lblSirka.TabIndex = 12;
            lblSirka.Text = "Šířka";
            // 
            // cboxTridy
            // 
            cboxTridy.FormattingEnabled = true;
            cboxTridy.Location = new Point(12, 10);
            cboxTridy.Name = "cboxTridy";
            cboxTridy.Size = new Size(142, 23);
            cboxTridy.TabIndex = 17;
            cboxTridy.SelectedIndexChanged += cboxTridy_SelectedIndexChanged;
            // 
            // Trida_Uprava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 446);
            Controls.Add(cboxTridy);
            Controls.Add(gboxVelikost);
            Controls.Add(tboxNazev);
            Controls.Add(panelEditClassroom);
            Controls.Add(btnNastavit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Trida_Uprava";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Úprava třídy";
            ((System.ComponentModel.ISupportInitialize)numVyska).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSirka).EndInit();
            gboxVelikost.ResumeLayout(false);
            gboxVelikost.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxNazev;
        private Panel panelEditClassroom;
        private Button btnOdstranitTridu;
        private Button btnNastavit;
        private NumericUpDown numVyska;
        private NumericUpDown numSirka;
        private GroupBox gboxVelikost;
        private Label lblVyska;
        private Label lblSirka;
        private ComboBox cboxTridy;
    }
}