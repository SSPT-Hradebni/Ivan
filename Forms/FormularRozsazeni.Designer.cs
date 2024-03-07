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
            this.label1 = new System.Windows.Forms.Label();
            this.numupdownKategoriiNaTridu = new System.Windows.Forms.NumericUpDown();
            this.btnVyplnit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combobxAlgoritmus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelVykresleniRozsazeni = new System.Windows.Forms.Panel();
            this.listbxVyplneneTridy = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxRuleset = new System.Windows.Forms.ComboBox();
            this.cboxTridy = new System.Windows.Forms.ComboBox();
            this.listbxSeznamStudentu = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownKategoriiNaTridu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorií na třídu";
            // 
            // numupdownKategoriiNaTridu
            // 
            this.numupdownKategoriiNaTridu.Location = new System.Drawing.Point(179, 74);
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
            this.btnVyplnit.Location = new System.Drawing.Point(15, 156);
            this.btnVyplnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyplnit.Name = "btnVyplnit";
            this.btnVyplnit.Size = new System.Drawing.Size(88, 22);
            this.btnVyplnit.TabIndex = 2;
            this.btnVyplnit.Text = "Vyplnit";
            this.btnVyplnit.UseVisualStyleBackColor = true;
            this.btnVyplnit.Click += new System.EventHandler(this.btnVyplnit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Třída k vyplnění";
            // 
            // combobxAlgoritmus
            // 
            this.combobxAlgoritmus.FormattingEnabled = true;
            this.combobxAlgoritmus.Items.AddRange(new object[] {
            "Knight (Jezdec)"});
            this.combobxAlgoritmus.Location = new System.Drawing.Point(98, 18);
            this.combobxAlgoritmus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobxAlgoritmus.Name = "combobxAlgoritmus";
            this.combobxAlgoritmus.Size = new System.Drawing.Size(125, 23);
            this.combobxAlgoritmus.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Algoritmus";
            // 
            // panelVykresleniRozsazeni
            // 
            this.panelVykresleniRozsazeni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVykresleniRozsazeni.Location = new System.Drawing.Point(0, 0);
            this.panelVykresleniRozsazeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVykresleniRozsazeni.Name = "panelVykresleniRozsazeni";
            this.panelVykresleniRozsazeni.Size = new System.Drawing.Size(976, 602);
            this.panelVykresleniRozsazeni.TabIndex = 12;
            this.panelVykresleniRozsazeni.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVykresleniRozsazeni_Paint);
            // 
            // listbxVyplneneTridy
            // 
            this.listbxVyplneneTridy.FormattingEnabled = true;
            this.listbxVyplneneTridy.ItemHeight = 15;
            this.listbxVyplneneTridy.Location = new System.Drawing.Point(15, 197);
            this.listbxVyplneneTridy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbxVyplneneTridy.Name = "listbxVyplneneTridy";
            this.listbxVyplneneTridy.Size = new System.Drawing.Size(208, 79);
            this.listbxVyplneneTridy.TabIndex = 13;
            this.listbxVyplneneTridy.SelectedIndexChanged += new System.EventHandler(this.listbxVyplneneTridy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vyplněné třídy";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.cboxRuleset);
            this.splitContainer.Panel1.Controls.Add(this.cboxTridy);
            this.splitContainer.Panel1.Controls.Add(this.listbxSeznamStudentu);
            this.splitContainer.Panel1.Controls.Add(this.label6);
            this.splitContainer.Panel1.Controls.Add(this.label4);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.label5);
            this.splitContainer.Panel1.Controls.Add(this.numupdownKategoriiNaTridu);
            this.splitContainer.Panel1.Controls.Add(this.listbxVyplneneTridy);
            this.splitContainer.Panel1.Controls.Add(this.btnVyplnit);
            this.splitContainer.Panel1.Controls.Add(this.combobxAlgoritmus);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelVykresleniRozsazeni);
            this.splitContainer.Size = new System.Drawing.Size(1216, 602);
            this.splitContainer.SplitterDistance = 236;
            this.splitContainer.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sada pravidel";
            // 
            // cboxRuleset
            // 
            this.cboxRuleset.FormattingEnabled = true;
            this.cboxRuleset.Items.AddRange(new object[] {
            "SPC&SPC",
            "HvAR"});
            this.cboxRuleset.Location = new System.Drawing.Point(98, 46);
            this.cboxRuleset.Name = "cboxRuleset";
            this.cboxRuleset.Size = new System.Drawing.Size(125, 23);
            this.cboxRuleset.TabIndex = 18;
            // 
            // cboxTridy
            // 
            this.cboxTridy.FormattingEnabled = true;
            this.cboxTridy.Location = new System.Drawing.Point(15, 129);
            this.cboxTridy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxTridy.Name = "cboxTridy";
            this.cboxTridy.Size = new System.Drawing.Size(208, 23);
            this.cboxTridy.TabIndex = 17;
            this.cboxTridy.SelectedIndexChanged += new System.EventHandler(this.cboxTridy_SelectedIndexChanged);
            // 
            // listbxSeznamStudentu
            // 
            this.listbxSeznamStudentu.FormattingEnabled = true;
            this.listbxSeznamStudentu.ItemHeight = 15;
            this.listbxSeznamStudentu.Location = new System.Drawing.Point(15, 296);
            this.listbxSeznamStudentu.Name = "listbxSeznamStudentu";
            this.listbxSeznamStudentu.Size = new System.Drawing.Size(208, 289);
            this.listbxSeznamStudentu.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seznam studentů";
            // 
            // FormularRozsazeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 602);
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularRozsazeni";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nové rozsazení";
            this.Load += new System.EventHandler(this.FormularRozsazeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupdownKategoriiNaTridu)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Label label3;
        private ComboBox cboxRuleset;
    }
}