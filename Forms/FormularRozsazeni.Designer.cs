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
            label2 = new Label();
            combobxAlgoritmus = new ComboBox();
            label4 = new Label();
            panelVykresleniRozsazeni = new Panel();
            listbxVyplneneTridy = new ListBox();
            label5 = new Label();
            splitContainer = new SplitContainer();
            cboxTridy = new ComboBox();
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
            btnVyplnit.Location = new Point(15, 112);
            btnVyplnit.Margin = new Padding(3, 2, 3, 2);
            btnVyplnit.Name = "btnVyplnit";
            btnVyplnit.Size = new Size(88, 22);
            btnVyplnit.TabIndex = 2;
            btnVyplnit.Text = "Vyplnit";
            btnVyplnit.UseVisualStyleBackColor = true;
            btnVyplnit.Click += btnVyplnit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 7;
            label2.Text = "Třída k vyplnění";
            // 
            // combobxAlgoritmus
            // 
            combobxAlgoritmus.FormattingEnabled = true;
            combobxAlgoritmus.Items.AddRange(new object[] { "Knight (Jezdec)" });
            combobxAlgoritmus.Location = new Point(84, 18);
            combobxAlgoritmus.Margin = new Padding(3, 2, 3, 2);
            combobxAlgoritmus.Name = "combobxAlgoritmus";
            combobxAlgoritmus.Size = new Size(137, 23);
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
            panelVykresleniRozsazeni.Size = new Size(976, 602);
            panelVykresleniRozsazeni.TabIndex = 12;
            panelVykresleniRozsazeni.Paint += panelVykresleniRozsazeni_Paint;
            // 
            // listbxVyplneneTridy
            // 
            listbxVyplneneTridy.FormattingEnabled = true;
            listbxVyplneneTridy.ItemHeight = 15;
            listbxVyplneneTridy.Location = new Point(15, 167);
            listbxVyplneneTridy.Margin = new Padding(3, 2, 3, 2);
            listbxVyplneneTridy.Name = "listbxVyplneneTridy";
            listbxVyplneneTridy.Size = new Size(208, 79);
            listbxVyplneneTridy.TabIndex = 13;
            listbxVyplneneTridy.SelectedIndexChanged += listbxVyplneneTridy_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 150);
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
            splitContainer.Panel1.Controls.Add(cboxTridy);
            splitContainer.Panel1.Controls.Add(listbxSeznamStudentu);
            splitContainer.Panel1.Controls.Add(label6);
            splitContainer.Panel1.Controls.Add(label4);
            splitContainer.Panel1.Controls.Add(label1);
            splitContainer.Panel1.Controls.Add(label2);
            splitContainer.Panel1.Controls.Add(label5);
            splitContainer.Panel1.Controls.Add(numupdownKategoriiNaTridu);
            splitContainer.Panel1.Controls.Add(listbxVyplneneTridy);
            splitContainer.Panel1.Controls.Add(btnVyplnit);
            splitContainer.Panel1.Controls.Add(combobxAlgoritmus);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelVykresleniRozsazeni);
            splitContainer.Size = new Size(1216, 602);
            splitContainer.SplitterDistance = 236;
            splitContainer.TabIndex = 15;
            // 
            // cboxTridy
            // 
            cboxTridy.FormattingEnabled = true;
            cboxTridy.Location = new Point(15, 86);
            cboxTridy.Margin = new Padding(3, 2, 3, 2);
            cboxTridy.Name = "cboxTridy";
            cboxTridy.Size = new Size(206, 23);
            cboxTridy.TabIndex = 17;
            cboxTridy.SelectedIndexChanged += cboxTridy_SelectedIndexChanged;
            // 
            // listbxSeznamStudentu
            // 
            listbxSeznamStudentu.FormattingEnabled = true;
            listbxSeznamStudentu.ItemHeight = 15;
            listbxSeznamStudentu.Location = new Point(15, 266);
            listbxSeznamStudentu.Name = "listbxSeznamStudentu";
            listbxSeznamStudentu.Size = new Size(208, 319);
            listbxSeznamStudentu.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 248);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 15;
            label6.Text = "Seznam studentů";
            // 
            // FormularRozsazeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 602);
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
            Load += FormularRozsazeni_Load;
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
        private Label label2;
        private ComboBox combobxAlgoritmus;
        private Label label4;
        private Panel panelVykresleniRozsazeni;
        private ListBox listbxVyplneneTridy;
        private Label label5;
        private SplitContainer splitContainer;
        private ListBox listbxSeznamStudentu;
        private Label label6;
        private ComboBox cboxTridy;
    }
}