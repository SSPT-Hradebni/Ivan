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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularRozsazeni));
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
            splitContainer = new SplitContainer();
            listbxSeznamStudentu = new ListBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numupdownKategoriiNaTridu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategorií na třídu";
            // 
            // numupdownKategoriiNaTridu
            // 
            numupdownKategoriiNaTridu.Location = new Point(176, 44);
            numupdownKategoriiNaTridu.Margin = new Padding(3, 2, 3, 2);
            numupdownKategoriiNaTridu.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numupdownKategoriiNaTridu.Name = "numupdownKategoriiNaTridu";
            numupdownKategoriiNaTridu.Size = new Size(44, 23);
            numupdownKategoriiNaTridu.TabIndex = 1;
            numupdownKategoriiNaTridu.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // btnVyplnit
            // 
            btnVyplnit.Location = new Point(12, 227);
            btnVyplnit.Margin = new Padding(3, 2, 3, 2);
            btnVyplnit.Name = "btnVyplnit";
            btnVyplnit.Size = new Size(88, 22);
            btnVyplnit.TabIndex = 2;
            btnVyplnit.Text = "Vyplnit";
            btnVyplnit.UseVisualStyleBackColor = true;
            btnVyplnit.Click += btnVyplnit_Click;
            // 
            // btnVyplnitVse
            // 
            btnVyplnitVse.Location = new Point(132, 227);
            btnVyplnitVse.Margin = new Padding(3, 2, 3, 2);
            btnVyplnitVse.Name = "btnVyplnitVse";
            btnVyplnitVse.Size = new Size(88, 22);
            btnVyplnitVse.TabIndex = 3;
            btnVyplnitVse.Text = "Vyplnit vše";
            btnVyplnitVse.UseVisualStyleBackColor = true;
            btnVyplnitVse.Click += btnVyplnitVse_Click;
            // 
            // listbxVyberTrid
            // 
            listbxVyberTrid.FormattingEnabled = true;
            listbxVyberTrid.ItemHeight = 15;
            listbxVyberTrid.Location = new Point(12, 84);
            listbxVyberTrid.Margin = new Padding(3, 2, 3, 2);
            listbxVyberTrid.Name = "listbxVyberTrid";
            listbxVyberTrid.Size = new Size(88, 139);
            listbxVyberTrid.TabIndex = 4;
            listbxVyberTrid.SelectedIndexChanged += listbxVyberTrid_SelectedIndexChanged;
            // 
            // listbxVybraneTridy
            // 
            listbxVybraneTridy.FormattingEnabled = true;
            listbxVybraneTridy.ItemHeight = 15;
            listbxVybraneTridy.Location = new Point(132, 84);
            listbxVybraneTridy.Margin = new Padding(3, 2, 3, 2);
            listbxVybraneTridy.Name = "listbxVybraneTridy";
            listbxVybraneTridy.Size = new Size(88, 139);
            listbxVybraneTridy.TabIndex = 5;
            listbxVybraneTridy.SelectedIndexChanged += listbxVybraneTridy_SelectedIndexChanged;
            // 
            // btnPresunTridu
            // 
            btnPresunTridu.Location = new Point(105, 84);
            btnPresunTridu.Margin = new Padding(3, 2, 3, 2);
            btnPresunTridu.Name = "btnPresunTridu";
            btnPresunTridu.Size = new Size(22, 138);
            btnPresunTridu.TabIndex = 6;
            btnPresunTridu.Text = ">";
            btnPresunTridu.UseVisualStyleBackColor = true;
            btnPresunTridu.Click += btnPresunTridu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Výběr tříd";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 67);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 8;
            label3.Text = "Vybrané třídy";
            // 
            // combobxAlgoritmus
            // 
            combobxAlgoritmus.FormattingEnabled = true;
            combobxAlgoritmus.Items.AddRange(new object[] { "Knight (Jezdec)" });
            combobxAlgoritmus.Location = new Point(90, 19);
            combobxAlgoritmus.Margin = new Padding(3, 2, 3, 2);
            combobxAlgoritmus.Name = "combobxAlgoritmus";
            combobxAlgoritmus.Size = new Size(131, 23);
            combobxAlgoritmus.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 11;
            label4.Text = "Algoritmus";
            // 
            // panelVykresleniRozsazeni
            // 
            panelVykresleniRozsazeni.Dock = DockStyle.Fill;
            panelVykresleniRozsazeni.Location = new Point(0, 0);
            panelVykresleniRozsazeni.Margin = new Padding(3, 2, 3, 2);
            panelVykresleniRozsazeni.Name = "panelVykresleniRozsazeni";
            panelVykresleniRozsazeni.Size = new Size(794, 602);
            panelVykresleniRozsazeni.TabIndex = 12;
            panelVykresleniRozsazeni.Paint += panelVykresleniRozsazeni_Paint;
            // 
            // listbxVyplneneTridy
            // 
            listbxVyplneneTridy.FormattingEnabled = true;
            listbxVyplneneTridy.ItemHeight = 15;
            listbxVyplneneTridy.Location = new Point(12, 268);
            listbxVyplneneTridy.Margin = new Padding(3, 2, 3, 2);
            listbxVyplneneTridy.Name = "listbxVyplneneTridy";
            listbxVyplneneTridy.Size = new Size(208, 79);
            listbxVyplneneTridy.TabIndex = 13;
            listbxVyplneneTridy.SelectedIndexChanged += listbxVyplneneTridy_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 251);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 14;
            label5.Text = "Vyplněné třídy";
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(listbxSeznamStudentu);
            splitContainer.Panel1.Controls.Add(label6);
            splitContainer.Panel1.Controls.Add(label4);
            splitContainer.Panel1.Controls.Add(label1);
            splitContainer.Panel1.Controls.Add(label2);
            splitContainer.Panel1.Controls.Add(label5);
            splitContainer.Panel1.Controls.Add(btnPresunTridu);
            splitContainer.Panel1.Controls.Add(numupdownKategoriiNaTridu);
            splitContainer.Panel1.Controls.Add(label3);
            splitContainer.Panel1.Controls.Add(listbxVyplneneTridy);
            splitContainer.Panel1.Controls.Add(listbxVybraneTridy);
            splitContainer.Panel1.Controls.Add(btnVyplnit);
            splitContainer.Panel1.Controls.Add(combobxAlgoritmus);
            splitContainer.Panel1.Controls.Add(listbxVyberTrid);
            splitContainer.Panel1.Controls.Add(btnVyplnitVse);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelVykresleniRozsazeni);
            splitContainer.Size = new Size(1022, 602);
            splitContainer.SplitterDistance = 224;
            splitContainer.TabIndex = 15;
            // 
            // listbxSeznamStudentu
            // 
            listbxSeznamStudentu.FormattingEnabled = true;
            listbxSeznamStudentu.ItemHeight = 15;
            listbxSeznamStudentu.Location = new Point(12, 367);
            listbxSeznamStudentu.Name = "listbxSeznamStudentu";
            listbxSeznamStudentu.Size = new Size(208, 229);
            listbxSeznamStudentu.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 349);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 15;
            label6.Text = "Seznam studentů";
            // 
            // FormularRozsazeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 602);
            Controls.Add(splitContainer);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularRozsazeni";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nové rozsazení";
            ((System.ComponentModel.ISupportInitialize)numupdownKategoriiNaTridu).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
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
        private SplitContainer splitContainer;
        private ListBox listbxSeznamStudentu;
        private Label label6;
    }
}