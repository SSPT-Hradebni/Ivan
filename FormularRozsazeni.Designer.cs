namespace SediM
{
    partial class FormularRozsazeni
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
            label1 = new Label();
            numupdownKategoriiNaTridu = new NumericUpDown();
            btnVyplnit = new Button();
            btnVyplnitVse = new Button();
            listbxVyberTrid = new ListBox();
            listbxVybraneTridy = new ListBox();
            btnPresunTridu = new Button();
            label2 = new Label();
            label3 = new Label();
            combobxAlgoritmus = new ComboBox();
            label4 = new Label();
            panelVykresleniRozsazeni = new Panel();
            listbxVyplneneTridy = new ListBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numupdownKategoriiNaTridu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Kategorií na třídu";
            // 
            // numupdownKategoriiNaTridu
            // 
            numupdownKategoriiNaTridu.Location = new Point(199, 46);
            numupdownKategoriiNaTridu.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numupdownKategoriiNaTridu.Name = "numupdownKategoriiNaTridu";
            numupdownKategoriiNaTridu.Size = new Size(50, 27);
            numupdownKategoriiNaTridu.TabIndex = 1;
            numupdownKategoriiNaTridu.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // btnVyplnit
            // 
            btnVyplnit.Location = new Point(12, 289);
            btnVyplnit.Name = "btnVyplnit";
            btnVyplnit.Size = new Size(100, 29);
            btnVyplnit.TabIndex = 2;
            btnVyplnit.Text = "Vyplnit";
            btnVyplnit.UseVisualStyleBackColor = true;
            // 
            // btnVyplnitVse
            // 
            btnVyplnitVse.Location = new Point(149, 289);
            btnVyplnitVse.Name = "btnVyplnitVse";
            btnVyplnitVse.Size = new Size(100, 29);
            btnVyplnitVse.TabIndex = 3;
            btnVyplnitVse.Text = "Vyplnit vše";
            btnVyplnitVse.UseVisualStyleBackColor = true;
            // 
            // listbxVyberTrid
            // 
            listbxVyberTrid.FormattingEnabled = true;
            listbxVyberTrid.ItemHeight = 20;
            listbxVyberTrid.Location = new Point(12, 99);
            listbxVyberTrid.Name = "listbxVyberTrid";
            listbxVyberTrid.Size = new Size(100, 184);
            listbxVyberTrid.TabIndex = 4;
            listbxVyberTrid.SelectedIndexChanged += listbxVyberTrid_SelectedIndexChanged;
            // 
            // listbxVybraneTridy
            // 
            listbxVybraneTridy.FormattingEnabled = true;
            listbxVybraneTridy.ItemHeight = 20;
            listbxVybraneTridy.Location = new Point(149, 99);
            listbxVybraneTridy.Name = "listbxVybraneTridy";
            listbxVybraneTridy.Size = new Size(100, 184);
            listbxVybraneTridy.TabIndex = 5;
            listbxVybraneTridy.SelectedIndexChanged += listbxVybraneTridy_SelectedIndexChanged;
            // 
            // btnPresunTridu
            // 
            btnPresunTridu.Location = new Point(118, 99);
            btnPresunTridu.Name = "btnPresunTridu";
            btnPresunTridu.Size = new Size(25, 184);
            btnPresunTridu.TabIndex = 6;
            btnPresunTridu.Text = ">";
            btnPresunTridu.UseVisualStyleBackColor = true;
            btnPresunTridu.Click += btnPresunTridu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 7;
            label2.Text = "Výběr tříd";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 76);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 8;
            label3.Text = "Vybrané třídy";
            // 
            // combobxAlgoritmus
            // 
            combobxAlgoritmus.FormattingEnabled = true;
            combobxAlgoritmus.Items.AddRange(new object[] { "Knight (Jezdec)" });
            combobxAlgoritmus.Location = new Point(100, 12);
            combobxAlgoritmus.Name = "combobxAlgoritmus";
            combobxAlgoritmus.Size = new Size(149, 28);
            combobxAlgoritmus.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 11;
            label4.Text = "Algoritmus";
            // 
            // panelVykresleniRozsazeni
            // 
            panelVykresleniRozsazeni.Location = new Point(255, 12);
            panelVykresleniRozsazeni.Name = "panelVykresleniRozsazeni";
            panelVykresleniRozsazeni.Size = new Size(380, 436);
            panelVykresleniRozsazeni.TabIndex = 12;
            panelVykresleniRozsazeni.Paint += panelVykresleniRozsazeni_Paint;
            // 
            // listbxVyplneneTridy
            // 
            listbxVyplneneTridy.FormattingEnabled = true;
            listbxVyplneneTridy.ItemHeight = 20;
            listbxVyplneneTridy.Location = new Point(12, 344);
            listbxVyplneneTridy.Name = "listbxVyplneneTridy";
            listbxVyplneneTridy.Size = new Size(237, 104);
            listbxVyplneneTridy.TabIndex = 13;
            listbxVyplneneTridy.SelectedIndexChanged += listbxVyplneneTridy_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 321);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 14;
            label5.Text = "Vyplněné třídy";
            // 
            // FormularRozsazeni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 460);
            Controls.Add(label5);
            Controls.Add(listbxVyplneneTridy);
            Controls.Add(panelVykresleniRozsazeni);
            Controls.Add(label4);
            Controls.Add(combobxAlgoritmus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPresunTridu);
            Controls.Add(listbxVybraneTridy);
            Controls.Add(listbxVyberTrid);
            Controls.Add(btnVyplnitVse);
            Controls.Add(btnVyplnit);
            Controls.Add(numupdownKategoriiNaTridu);
            Controls.Add(label1);
            Name = "FormularRozsazeni";
            Text = "FormularRozsazeni";
            ((System.ComponentModel.ISupportInitialize)numupdownKategoriiNaTridu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numupdownKategoriiNaTridu;
        private Button btnVyplnit;
        private Button btnVyplnitVse;
        private ListBox listbxVyberTrid;
        private ListBox listbxVybraneTridy;
        private Button btnPresunTridu;
        private Label label2;
        private Label label3;
        private ComboBox combobxAlgoritmus;
        private Label label4;
        private Panel panelVykresleniRozsazeni;
        private ListBox listbxVyplneneTridy;
        private Label label5;
    }
}