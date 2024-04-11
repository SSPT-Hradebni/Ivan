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
            this.btnVyplnit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelVykresleniRozsazeni = new System.Windows.Forms.Panel();
            this.listbxVyplneneUcebny = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.cboxUcebny = new System.Windows.Forms.ComboBox();
            this.listbxSeznamStudentu = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Tisk = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVyplnit
            // 
            this.btnVyplnit.Location = new System.Drawing.Point(12, 53);
            this.btnVyplnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVyplnit.Name = "btnVyplnit";
            this.btnVyplnit.Size = new System.Drawing.Size(88, 22);
            this.btnVyplnit.TabIndex = 0;
            this.btnVyplnit.Text = "Vyplnit";
            this.btnVyplnit.UseVisualStyleBackColor = true;
            this.btnVyplnit.Click += new System.EventHandler(this.btnVyplnit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Učebna k vyplnění";
            // 
            // panelVykresleniRozsazeni
            // 
            this.panelVykresleniRozsazeni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVykresleniRozsazeni.Location = new System.Drawing.Point(0, 0);
            this.panelVykresleniRozsazeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVykresleniRozsazeni.Name = "panelVykresleniRozsazeni";
            this.panelVykresleniRozsazeni.Size = new System.Drawing.Size(976, 574);
            this.panelVykresleniRozsazeni.TabIndex = 12;
            this.panelVykresleniRozsazeni.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVykresleniRozsazeni_Paint);
            // 
            // listbxVyplneneUcebny
            // 
            this.listbxVyplneneUcebny.FormattingEnabled = true;
            this.listbxVyplneneUcebny.ItemHeight = 15;
            this.listbxVyplneneUcebny.Location = new System.Drawing.Point(12, 106);
            this.listbxVyplneneUcebny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbxVyplneneUcebny.Name = "listbxVyplneneUcebny";
            this.listbxVyplneneUcebny.Size = new System.Drawing.Size(208, 79);
            this.listbxVyplneneUcebny.TabIndex = 2;
            this.listbxVyplneneUcebny.SelectedIndexChanged += new System.EventHandler(this.listbxVyplneneUcebny_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vyplněné učebny";
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(0, 28);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.cboxUcebny);
            this.splitContainer.Panel1.Controls.Add(this.listbxSeznamStudentu);
            this.splitContainer.Panel1.Controls.Add(this.label6);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.label5);
            this.splitContainer.Panel1.Controls.Add(this.listbxVyplneneUcebny);
            this.splitContainer.Panel1.Controls.Add(this.btnVyplnit);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelVykresleniRozsazeni);
            this.splitContainer.Size = new System.Drawing.Size(1216, 574);
            this.splitContainer.SplitterDistance = 236;
            this.splitContainer.TabIndex = 15;
            // 
            // cboxUcebny
            // 
            this.cboxUcebny.FormattingEnabled = true;
            this.cboxUcebny.Location = new System.Drawing.Point(12, 26);
            this.cboxUcebny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxUcebny.Name = "cboxUcebny";
            this.cboxUcebny.Size = new System.Drawing.Size(221, 23);
            this.cboxUcebny.TabIndex = 1;
            this.cboxUcebny.SelectedIndexChanged += new System.EventHandler(this.cboxUcebny_SelectedIndexChanged);
            // 
            // listbxSeznamStudentu
            // 
            this.listbxSeznamStudentu.FormattingEnabled = true;
            this.listbxSeznamStudentu.ItemHeight = 15;
            this.listbxSeznamStudentu.Location = new System.Drawing.Point(12, 205);
            this.listbxSeznamStudentu.Name = "listbxSeznamStudentu";
            this.listbxSeznamStudentu.Size = new System.Drawing.Size(208, 364);
            this.listbxSeznamStudentu.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seznam studentů";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Tisk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1216, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Tisk
            // 
            this.toolStripButton_Tisk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Tisk.Image = global::SediM.Properties.Resources.PrintToFile;
            this.toolStripButton_Tisk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Tisk.Name = "toolStripButton_Tisk";
            this.toolStripButton_Tisk.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Tisk.Text = "Vytisknout rozsazení do souboru";
            this.toolStripButton_Tisk.Visible = false;
            this.toolStripButton_Tisk.Click += new System.EventHandler(this.toolStripButton_Tisk_Click);
            // 
            // FormularRozsazeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 602);
            this.Controls.Add(this.toolStrip1);
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
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnVyplnit;
        private Label label2;
        private Panel panelVykresleniRozsazeni;
        private ListBox listbxVyplneneUcebny;
        private Label label5;
        private SplitContainer splitContainer;
        private ListBox listbxSeznamStudentu;
        private Label label6;
        private ComboBox cboxUcebny;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton_Tisk;
    }
}