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
            btnVyplnit = new Button();
            label2 = new Label();
            panelVykresleniRozsazeni = new Panel();
            listbxVyplneneTridy = new ListBox();
            label5 = new Label();
            splitContainer = new SplitContainer();
            cboxTridy = new ComboBox();
            listbxSeznamStudentu = new ListBox();
            label6 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton_Tisk = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVyplnit
            // 
            btnVyplnit.Location = new Point(12, 53);
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
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 7;
            label2.Text = "Třída k vyplnění";
            // 
            // panelVykresleniRozsazeni
            // 
            panelVykresleniRozsazeni.Dock = DockStyle.Fill;
            panelVykresleniRozsazeni.Location = new Point(0, 0);
            panelVykresleniRozsazeni.Margin = new Padding(3, 2, 3, 2);
            panelVykresleniRozsazeni.Name = "panelVykresleniRozsazeni";
            panelVykresleniRozsazeni.Size = new Size(976, 574);
            panelVykresleniRozsazeni.TabIndex = 12;
            panelVykresleniRozsazeni.Paint += panelVykresleniRozsazeni_Paint;
            // 
            // listbxVyplneneUcebny
            // 
            listbxVyplneneTridy.FormattingEnabled = true;
            listbxVyplneneTridy.ItemHeight = 15;
            listbxVyplneneTridy.Location = new Point(12, 106);
            listbxVyplneneTridy.Margin = new Padding(3, 2, 3, 2);
            listbxVyplneneTridy.Name = "listbxVyplneneTridy";
            listbxVyplneneTridy.Size = new Size(208, 79);
            listbxVyplneneTridy.TabIndex = 13;
            listbxVyplneneTridy.SelectedIndexChanged += listbxVyplneneTridy_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 89);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 14;
            label5.Text = "Vyplněné třídy";
            // 
            // splitContainer
            // 
            splitContainer.Location = new Point(0, 28);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(cboxTridy);
            splitContainer.Panel1.Controls.Add(listbxSeznamStudentu);
            splitContainer.Panel1.Controls.Add(label6);
            splitContainer.Panel1.Controls.Add(label2);
            splitContainer.Panel1.Controls.Add(label5);
            splitContainer.Panel1.Controls.Add(listbxVyplneneTridy);
            splitContainer.Panel1.Controls.Add(btnVyplnit);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelVykresleniRozsazeni);
            splitContainer.Size = new Size(1216, 574);
            splitContainer.SplitterDistance = 236;
            splitContainer.TabIndex = 15;
            // 
            // cboxUcebny
            // 
            cboxTridy.FormattingEnabled = true;
            cboxTridy.Location = new Point(12, 26);
            cboxTridy.Margin = new Padding(3, 2, 3, 2);
            cboxTridy.Name = "cboxTridy";
            cboxTridy.Size = new Size(221, 23);
            cboxTridy.TabIndex = 17;
            cboxTridy.SelectedIndexChanged += cboxTridy_SelectedIndexChanged;
            // 
            // listbxSeznamStudentu
            // 
            listbxSeznamStudentu.FormattingEnabled = true;
            listbxSeznamStudentu.ItemHeight = 15;
            listbxSeznamStudentu.Location = new Point(12, 205);
            listbxSeznamStudentu.Name = "listbxSeznamStudentu";
            listbxSeznamStudentu.Size = new Size(208, 364);
            listbxSeznamStudentu.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 187);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 15;
            label6.Text = "Seznam studentů";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_Tisk });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1216, 25);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Tisk
            // 
            toolStripButton_Tisk.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Tisk.Image = Properties.Resources.PrintToFile;
            toolStripButton_Tisk.ImageTransparentColor = Color.Magenta;
            toolStripButton_Tisk.Name = "toolStripButton_Tisk";
            toolStripButton_Tisk.Size = new Size(23, 22);
            toolStripButton_Tisk.Text = "Vytisknout rozsazení do souboru";
            toolStripButton_Tisk.Visible = false;
            toolStripButton_Tisk.Click += toolStripButton_Tisk_Click;
            // 
            // FormularRozsazeni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 602);
            Controls.Add(toolStrip1);
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
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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