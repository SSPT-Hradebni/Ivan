namespace SediM
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataviewStudenti = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmeno_prijmeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rocnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.souradnice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCboxStudenti = new System.Windows.Forms.Label();
            this.cboxStudenti = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataviewStudenti);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Seznam studentů";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataviewStudenti
            // 
            this.dataviewStudenti.AllowUserToAddRows = false;
            this.dataviewStudenti.AllowUserToDeleteRows = false;
            this.dataviewStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataviewStudenti.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataviewStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.jmeno_prijmeni,
            this.kategorie,
            this.skola,
            this.rocnik,
            this.souradnice});
            this.dataviewStudenti.Location = new System.Drawing.Point(0, 0);
            this.dataviewStudenti.Name = "dataviewStudenti";
            this.dataviewStudenti.ReadOnly = true;
            this.dataviewStudenti.RowHeadersWidth = 51;
            this.dataviewStudenti.RowTemplate.Height = 25;
            this.dataviewStudenti.Size = new System.Drawing.Size(793, 374);
            this.dataviewStudenti.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // jmeno_prijmeni
            // 
            this.jmeno_prijmeni.HeaderText = "Jméno a přijmení";
            this.jmeno_prijmeni.MinimumWidth = 6;
            this.jmeno_prijmeni.Name = "jmeno_prijmeni";
            this.jmeno_prijmeni.ReadOnly = true;
            // 
            // kategorie
            // 
            this.kategorie.HeaderText = "Kategorie";
            this.kategorie.MinimumWidth = 6;
            this.kategorie.Name = "kategorie";
            this.kategorie.ReadOnly = true;
            // 
            // skola
            // 
            this.skola.HeaderText = "Škola";
            this.skola.MinimumWidth = 6;
            this.skola.Name = "skola";
            this.skola.ReadOnly = true;
            // 
            // rocnik
            // 
            this.rocnik.HeaderText = "Ročník";
            this.rocnik.MinimumWidth = 6;
            this.rocnik.Name = "rocnik";
            this.rocnik.ReadOnly = true;
            // 
            // souradnice
            // 
            this.souradnice.HeaderText = "Souřadnice";
            this.souradnice.MinimumWidth = 6;
            this.souradnice.Name = "souradnice";
            this.souradnice.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nový student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCboxStudenti);
            this.tabPage2.Controls.Add(this.cboxStudenti);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upravit studenta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCboxStudenti
            // 
            this.lblCboxStudenti.AutoSize = true;
            this.lblCboxStudenti.Location = new System.Drawing.Point(6, 5);
            this.lblCboxStudenti.Name = "lblCboxStudenti";
            this.lblCboxStudenti.Size = new System.Drawing.Size(96, 15);
            this.lblCboxStudenti.TabIndex = 1;
            this.lblCboxStudenti.Text = "Vyberte studenta";
            // 
            // cboxStudenti
            // 
            this.cboxStudenti.FormattingEnabled = true;
            this.cboxStudenti.Location = new System.Drawing.Point(6, 23);
            this.cboxStudenti.Name = "cboxStudenti";
            this.cboxStudenti.Size = new System.Drawing.Size(276, 23);
            this.cboxStudenti.Sorted = true;
            this.cboxStudenti.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikaciToolStripMenuItem,
            this.nápovědaToolStripMenuItem,
            this.ukončitToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.souborToolStripMenuItem.Text = "SediM";
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.oAplikaciToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ukončitToolStripMenuItem.Text = "Konec";
            this.ukončitToolStripMenuItem.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem oAplikaciToolStripMenuItem;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem ukončitToolStripMenuItem;
        private StatusStrip statusStrip;
        private TabPage tabPage3;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripProgressBar toolStripProgressBar;
        private DataGridView dataviewStudenti;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jmeno_prijmeni;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn skola;
        private DataGridViewTextBoxColumn rocnik;
        private DataGridViewTextBoxColumn souradnice;
        private ComboBox cboxStudenti;
        private Label lblCboxStudenti;
    }
}