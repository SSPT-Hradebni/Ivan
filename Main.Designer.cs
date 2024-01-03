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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tboxPrijmeni = new System.Windows.Forms.TextBox();
            this.lblPrijmeni = new System.Windows.Forms.Label();
            this.tboxJmeno = new System.Windows.Forms.TextBox();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCboxStudenti = new System.Windows.Forms.Label();
            this.cboxStudenti = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtbxNazevTridy = new System.Windows.Forms.TextBox();
            this.panelEditClassroom = new System.Windows.Forms.Panel();
            this.btnOdstranitTridu = new System.Windows.Forms.Button();
            this.btnNastavitTridu = new System.Windows.Forms.Button();
            this.numupdownClassroomHeight = new System.Windows.Forms.NumericUpDown();
            this.lblUpravaTrid = new System.Windows.Forms.Label();
            this.numupdownClassroomWidth = new System.Windows.Forms.NumericUpDown();
            this.combobxVyberTrid = new System.Windows.Forms.ComboBox();
            this.rocnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.souradnice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noveRozsazeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownClassroomHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownClassroomWidth)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataviewStudenti);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(948, 467);
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
            this.skola});
            this.dataviewStudenti.Location = new System.Drawing.Point(0, 0);
            this.dataviewStudenti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataviewStudenti.Name = "dataviewStudenti";
            this.dataviewStudenti.ReadOnly = true;
            this.dataviewStudenti.RowHeadersWidth = 51;
            this.dataviewStudenti.RowTemplate.Height = 25;
            this.dataviewStudenti.Size = new System.Drawing.Size(945, 463);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tboxPrijmeni);
            this.tabPage1.Controls.Add(this.lblPrijmeni);
            this.tabPage1.Controls.Add(this.tboxJmeno);
            this.tabPage1.Controls.Add(this.lblJmeno);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(948, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nový student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tboxPrijmeni
            // 
            this.tboxPrijmeni.Location = new System.Drawing.Point(114, 21);
            this.tboxPrijmeni.Name = "tboxPrijmeni";
            this.tboxPrijmeni.Size = new System.Drawing.Size(100, 23);
            this.tboxPrijmeni.TabIndex = 3;
            // 
            // lblPrijmeni
            // 
            this.lblPrijmeni.AutoSize = true;
            this.lblPrijmeni.Location = new System.Drawing.Point(114, 3);
            this.lblPrijmeni.Name = "lblPrijmeni";
            this.lblPrijmeni.Size = new System.Drawing.Size(51, 15);
            this.lblPrijmeni.TabIndex = 2;
            this.lblPrijmeni.Text = "Příjmení";
            // 
            // tboxJmeno
            // 
            this.tboxJmeno.Location = new System.Drawing.Point(8, 21);
            this.tboxJmeno.Name = "tboxJmeno";
            this.tboxJmeno.Size = new System.Drawing.Size(100, 23);
            this.tboxJmeno.TabIndex = 1;
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(8, 3);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(42, 15);
            this.lblJmeno.TabIndex = 0;
            this.lblJmeno.Text = "Jméno";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCboxStudenti);
            this.tabPage2.Controls.Add(this.cboxStudenti);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(948, 467);
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
            this.cboxStudenti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxStudenti.Name = "cboxStudenti";
            this.cboxStudenti.Size = new System.Drawing.Size(276, 23);
            this.cboxStudenti.Sorted = true;
            this.cboxStudenti.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtbxNazevTridy);
            this.tabPage4.Controls.Add(this.panelEditClassroom);
            this.tabPage4.Controls.Add(this.btnOdstranitTridu);
            this.tabPage4.Controls.Add(this.btnNastavitTridu);
            this.tabPage4.Controls.Add(this.numupdownClassroomHeight);
            this.tabPage4.Controls.Add(this.lblUpravaTrid);
            this.tabPage4.Controls.Add(this.numupdownClassroomWidth);
            this.tabPage4.Controls.Add(this.combobxVyberTrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(948, 467);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Úprava tříd";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtbxNazevTridy
            // 
            this.txtbxNazevTridy.Location = new System.Drawing.Point(7, 47);
            this.txtbxNazevTridy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxNazevTridy.Name = "txtbxNazevTridy";
            this.txtbxNazevTridy.PlaceholderText = "Název třídy";
            this.txtbxNazevTridy.Size = new System.Drawing.Size(142, 23);
            this.txtbxNazevTridy.TabIndex = 7;
            // 
            // panelEditClassroom
            // 
            this.panelEditClassroom.Location = new System.Drawing.Point(157, 8);
            this.panelEditClassroom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEditClassroom.Name = "panelEditClassroom";
            this.panelEditClassroom.Size = new System.Drawing.Size(783, 451);
            this.panelEditClassroom.TabIndex = 6;
            this.panelEditClassroom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEditClassroom_Paint);
            // 
            // btnOdstranitTridu
            // 
            this.btnOdstranitTridu.Location = new System.Drawing.Point(7, 163);
            this.btnOdstranitTridu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOdstranitTridu.Name = "btnOdstranitTridu";
            this.btnOdstranitTridu.Size = new System.Drawing.Size(143, 31);
            this.btnOdstranitTridu.TabIndex = 5;
            this.btnOdstranitTridu.Text = "Odstranit";
            this.btnOdstranitTridu.UseVisualStyleBackColor = true;
            this.btnOdstranitTridu.Click += new System.EventHandler(this.btnOdstranitTridu_Click);
            // 
            // btnNastavitTridu
            // 
            this.btnNastavitTridu.Location = new System.Drawing.Point(7, 124);
            this.btnNastavitTridu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNastavitTridu.Name = "btnNastavitTridu";
            this.btnNastavitTridu.Size = new System.Drawing.Size(143, 31);
            this.btnNastavitTridu.TabIndex = 4;
            this.btnNastavitTridu.Text = "Nastavit";
            this.btnNastavitTridu.UseVisualStyleBackColor = true;
            this.btnNastavitTridu.Click += new System.EventHandler(this.btnNastavitTridu_Click);
            // 
            // numupdownClassroomHeight
            // 
            this.numupdownClassroomHeight.Location = new System.Drawing.Point(93, 85);
            this.numupdownClassroomHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numupdownClassroomHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupdownClassroomHeight.Name = "numupdownClassroomHeight";
            this.numupdownClassroomHeight.Size = new System.Drawing.Size(57, 23);
            this.numupdownClassroomHeight.TabIndex = 3;
            this.numupdownClassroomHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupdownClassroomHeight.ValueChanged += new System.EventHandler(this.numupdownClassroomHeight_ValueChanged);
            // 
            // lblUpravaTrid
            // 
            this.lblUpravaTrid.AutoSize = true;
            this.lblUpravaTrid.Location = new System.Drawing.Point(71, 88);
            this.lblUpravaTrid.Name = "lblUpravaTrid";
            this.lblUpravaTrid.Size = new System.Drawing.Size(13, 15);
            this.lblUpravaTrid.TabIndex = 2;
            this.lblUpravaTrid.Text = "x";
            // 
            // numupdownClassroomWidth
            // 
            this.numupdownClassroomWidth.Location = new System.Drawing.Point(7, 85);
            this.numupdownClassroomWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numupdownClassroomWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupdownClassroomWidth.Name = "numupdownClassroomWidth";
            this.numupdownClassroomWidth.Size = new System.Drawing.Size(57, 23);
            this.numupdownClassroomWidth.TabIndex = 1;
            this.numupdownClassroomWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupdownClassroomWidth.ValueChanged += new System.EventHandler(this.numupdownClassroomWidth_ValueChanged);
            // 
            // combobxVyberTrid
            // 
            this.combobxVyberTrid.FormattingEnabled = true;
            this.combobxVyberTrid.Items.AddRange(new object[] {
            "Nový"});
            this.combobxVyberTrid.Location = new System.Drawing.Point(7, 8);
            this.combobxVyberTrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combobxVyberTrid.Name = "combobxVyberTrid";
            this.combobxVyberTrid.Size = new System.Drawing.Size(142, 23);
            this.combobxVyberTrid.TabIndex = 0;
            this.combobxVyberTrid.SelectedIndexChanged += new System.EventHandler(this.combobxVyberTrid_SelectedIndexChanged);
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
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(956, 25);
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
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.souborToolStripMenuItem.Text = "SediM";
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.oAplikaciToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ukončitToolStripMenuItem.Text = "Konec";
            this.ukončitToolStripMenuItem.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noveRozsazeniToolStripMenuItem,
            this.toolStripSeparator,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // noveRozsazeniToolStripMenuItem
            // 
            this.noveRozsazeniToolStripMenuItem.Name = "noveRozsazeniToolStripMenuItem";
            this.noveRozsazeniToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.noveRozsazeniToolStripMenuItem.Text = "Nové rozsazení";
            this.noveRozsazeniToolStripMenuItem.Click += new System.EventHandler(this.noveRozsazeniToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(150, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 526);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(956, 22);
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
            this.ClientSize = new System.Drawing.Size(956, 548);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownClassroomHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownClassroomWidth)).EndInit();
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
        private ComboBox cboxStudenti;
        private Label lblCboxStudenti;
        private TabPage tabPage4;
        private ComboBox combobxVyberTrid;
        private Button btnNastavitTridu;
        private NumericUpDown numupdownClassroomHeight;
        private Label lblUpravaTrid;
        private NumericUpDown numupdownClassroomWidth;
        private Panel panelEditClassroom;
        private Button btnOdstranitTridu;
        private TextBox txtbxNazevTridy;
        private ToolStripMenuItem noveRozsazeniToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jmeno_prijmeni;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn skola;
        private DataGridViewTextBoxColumn rocnik;
        private DataGridViewTextBoxColumn souradnice;
        private Label lblJmeno;
        private TextBox tboxJmeno;
        private TextBox tboxPrijmeni;
        private Label lblPrijmeni;
        private ToolStripSeparator toolStripSeparator;
    }
}