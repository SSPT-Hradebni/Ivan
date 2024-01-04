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
            this.label1 = new System.Windows.Forms.Label();
            this.numupdownKategoriiNaTridu = new System.Windows.Forms.NumericUpDown();
            this.btnVyplnit = new System.Windows.Forms.Button();
            this.btnVyplnitVse = new System.Windows.Forms.Button();
            this.listbxVyberTrid = new System.Windows.Forms.ListBox();
            this.listbxVybraneTridy = new System.Windows.Forms.ListBox();
            this.btnPresunTridu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobxAlgoritmus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelVykresleniRozsazeni = new System.Windows.Forms.Panel();
            this.listbxVyplneneTridy = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownKategoriiNaTridu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorií na třídu";
            // 
            // numupdownKategoriiNaTridu
            // 
            this.numupdownKategoriiNaTridu.Location = new System.Drawing.Point(174, 34);
            this.numupdownKategoriiNaTridu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numupdownKategoriiNaTridu.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numupdownKategoriiNaTridu.Name = "numupdownKategoriiNaTridu";
            this.numupdownKategoriiNaTridu.Size = new System.Drawing.Size(44, 23);
            this.numupdownKategoriiNaTridu.TabIndex = 1;
            this.numupdownKategoriiNaTridu.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // btnVyplnit
            // 
            this.btnVyplnit.Location = new System.Drawing.Point(10, 217);
            this.btnVyplnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyplnit.Name = "btnVyplnit";
            this.btnVyplnit.Size = new System.Drawing.Size(88, 22);
            this.btnVyplnit.TabIndex = 2;
            this.btnVyplnit.Text = "Vyplnit";
            this.btnVyplnit.UseVisualStyleBackColor = true;
            // 
            // btnVyplnitVse
            // 
            this.btnVyplnitVse.Location = new System.Drawing.Point(130, 217);
            this.btnVyplnitVse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyplnitVse.Name = "btnVyplnitVse";
            this.btnVyplnitVse.Size = new System.Drawing.Size(88, 22);
            this.btnVyplnitVse.TabIndex = 3;
            this.btnVyplnitVse.Text = "Vyplnit vše";
            this.btnVyplnitVse.UseVisualStyleBackColor = true;
            this.btnVyplnitVse.Click += new System.EventHandler(this.btnVyplnitVse_Click);
            // 
            // listbxVyberTrid
            // 
            this.listbxVyberTrid.FormattingEnabled = true;
            this.listbxVyberTrid.ItemHeight = 15;
            this.listbxVyberTrid.Location = new System.Drawing.Point(10, 74);
            this.listbxVyberTrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbxVyberTrid.Name = "listbxVyberTrid";
            this.listbxVyberTrid.Size = new System.Drawing.Size(88, 139);
            this.listbxVyberTrid.TabIndex = 4;
            // 
            // listbxVybraneTridy
            // 
            this.listbxVybraneTridy.FormattingEnabled = true;
            this.listbxVybraneTridy.ItemHeight = 15;
            this.listbxVybraneTridy.Location = new System.Drawing.Point(130, 74);
            this.listbxVybraneTridy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbxVybraneTridy.Name = "listbxVybraneTridy";
            this.listbxVybraneTridy.Size = new System.Drawing.Size(88, 139);
            this.listbxVybraneTridy.TabIndex = 5;
            // 
            // btnPresunTridu
            // 
            this.btnPresunTridu.Location = new System.Drawing.Point(103, 74);
            this.btnPresunTridu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPresunTridu.Name = "btnPresunTridu";
            this.btnPresunTridu.Size = new System.Drawing.Size(22, 138);
            this.btnPresunTridu.TabIndex = 6;
            this.btnPresunTridu.Text = ">";
            this.btnPresunTridu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Výběr tříd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vybrané třídy";
            // 
            // combobxAlgoritmus
            // 
            this.combobxAlgoritmus.FormattingEnabled = true;
            this.combobxAlgoritmus.Items.AddRange(new object[] {
            "Knight (Jezdec)"});
            this.combobxAlgoritmus.Location = new System.Drawing.Point(88, 9);
            this.combobxAlgoritmus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobxAlgoritmus.Name = "combobxAlgoritmus";
            this.combobxAlgoritmus.Size = new System.Drawing.Size(131, 23);
            this.combobxAlgoritmus.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Algoritmus";
            // 
            // panelVykresleniRozsazeni
            // 
            this.panelVykresleniRozsazeni.Location = new System.Drawing.Point(223, 9);
            this.panelVykresleniRozsazeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVykresleniRozsazeni.Name = "panelVykresleniRozsazeni";
            this.panelVykresleniRozsazeni.Size = new System.Drawing.Size(332, 327);
            this.panelVykresleniRozsazeni.TabIndex = 12;
            // 
            // listbxVyplneneTridy
            // 
            this.listbxVyplneneTridy.FormattingEnabled = true;
            this.listbxVyplneneTridy.ItemHeight = 15;
            this.listbxVyplneneTridy.Location = new System.Drawing.Point(10, 258);
            this.listbxVyplneneTridy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbxVyplneneTridy.Name = "listbxVyplneneTridy";
            this.listbxVyplneneTridy.Size = new System.Drawing.Size(208, 79);
            this.listbxVyplneneTridy.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vyplněné třídy";
            // 
            // FormularRozsazeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 345);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listbxVyplneneTridy);
            this.Controls.Add(this.panelVykresleniRozsazeni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combobxAlgoritmus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPresunTridu);
            this.Controls.Add(this.listbxVybraneTridy);
            this.Controls.Add(this.listbxVyberTrid);
            this.Controls.Add(this.btnVyplnitVse);
            this.Controls.Add(this.btnVyplnit);
            this.Controls.Add(this.numupdownKategoriiNaTridu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularRozsazeni";
            this.Text = "FormularRozsazeni";
            ((System.ComponentModel.ISupportInitialize)(this.numupdownKategoriiNaTridu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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