namespace SediM.Forms
{
    partial class Trida_Nova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trida_Nova));
            tboxNazev = new TextBox();
            panelEditClassroom = new Panel();
            btnVytvorit = new Button();
            numVyska = new NumericUpDown();
            numSirka = new NumericUpDown();
            gboxVelikost = new GroupBox();
            lblVyska = new Label();
            lblSirka = new Label();
            ((System.ComponentModel.ISupportInitialize)numVyska).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSirka).BeginInit();
            gboxVelikost.SuspendLayout();
            SuspendLayout();
            // 
            // tboxNazev
            // 
            tboxNazev.Location = new Point(12, 14);
            tboxNazev.Margin = new Padding(3, 5, 3, 5);
            tboxNazev.Name = "tboxNazev";
            tboxNazev.PlaceholderText = "Název třídy";
            tboxNazev.Size = new Size(162, 27);
            tboxNazev.TabIndex = 15;
            // 
            // panelEditClassroom
            // 
            panelEditClassroom.Location = new Point(183, 14);
            panelEditClassroom.Margin = new Padding(3, 5, 3, 5);
            panelEditClassroom.Name = "panelEditClassroom";
            panelEditClassroom.Size = new Size(949, 573);
            panelEditClassroom.TabIndex = 14;
            panelEditClassroom.Paint += panelEditClassroom_Paint;
            // 
            // btnVytvorit
            // 
            btnVytvorit.Location = new Point(11, 159);
            btnVytvorit.Margin = new Padding(3, 5, 3, 5);
            btnVytvorit.Name = "btnVytvorit";
            btnVytvorit.Size = new Size(163, 41);
            btnVytvorit.TabIndex = 12;
            btnVytvorit.Text = "Vytvořit";
            btnVytvorit.UseVisualStyleBackColor = true;
            btnVytvorit.Click += btnVytvorit_Click;
            // 
            // numVyska
            // 
            numVyska.Location = new Point(53, 65);
            numVyska.Margin = new Padding(3, 5, 3, 5);
            numVyska.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numVyska.Name = "numVyska";
            numVyska.Size = new Size(103, 27);
            numVyska.TabIndex = 11;
            numVyska.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numVyska.ValueChanged += numVyska_ValueChanged;
            // 
            // numSirka
            // 
            numSirka.Location = new Point(53, 28);
            numSirka.Margin = new Padding(3, 5, 3, 5);
            numSirka.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSirka.Name = "numSirka";
            numSirka.Size = new Size(103, 27);
            numSirka.TabIndex = 9;
            numSirka.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSirka.ValueChanged += numSirka_ValueChanged;
            // 
            // gboxVelikost
            // 
            gboxVelikost.Controls.Add(lblVyska);
            gboxVelikost.Controls.Add(lblSirka);
            gboxVelikost.Controls.Add(numVyska);
            gboxVelikost.Controls.Add(numSirka);
            gboxVelikost.Location = new Point(12, 49);
            gboxVelikost.Name = "gboxVelikost";
            gboxVelikost.Size = new Size(162, 102);
            gboxVelikost.TabIndex = 16;
            gboxVelikost.TabStop = false;
            gboxVelikost.Text = "Velikost třídy";
            // 
            // lblVyska
            // 
            lblVyska.AutoSize = true;
            lblVyska.Location = new Point(6, 67);
            lblVyska.Name = "lblVyska";
            lblVyska.Size = new Size(46, 20);
            lblVyska.TabIndex = 13;
            lblVyska.Text = "Výška";
            // 
            // lblSirka
            // 
            lblSirka.AutoSize = true;
            lblSirka.Location = new Point(6, 30);
            lblSirka.Name = "lblSirka";
            lblSirka.Size = new Size(41, 20);
            lblSirka.TabIndex = 12;
            lblSirka.Text = "Šířka";
            // 
            // Trida_Nova
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 595);
            Controls.Add(gboxVelikost);
            Controls.Add(tboxNazev);
            Controls.Add(panelEditClassroom);
            Controls.Add(btnVytvorit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Trida_Nova";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nová třída";
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
        private Button btnVytvorit;
        private NumericUpDown numVyska;
        private NumericUpDown numSirka;
        private GroupBox gboxVelikost;
        private Label lblVyska;
        private Label lblSirka;
    }
}