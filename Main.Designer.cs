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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.tabUpravitTrida = new System.Windows.Forms.TabPage();
            this.txtbxNazevTridy = new System.Windows.Forms.TextBox();
            this.panelEditClassroom = new System.Windows.Forms.Panel();
            this.btnOdstranitTridu = new System.Windows.Forms.Button();
            this.btnNastavitTridu = new System.Windows.Forms.Button();
            this.numupdownClassroomHeight = new System.Windows.Forms.NumericUpDown();
            this.lblUpravaTrid = new System.Windows.Forms.Label();
            this.numupdownClassroomWidth = new System.Windows.Forms.NumericUpDown();
            this.combobxVyberTrid = new System.Windows.Forms.ComboBox();
            this.tabUpravitStudent = new System.Windows.Forms.TabPage();
            this.splitContUpravitStudenta = new System.Windows.Forms.SplitContainer();
            this.lboxStudenti = new System.Windows.Forms.ListBox();
            this.tboxJmeno = new System.Windows.Forms.TextBox();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.lblPrijmeni = new System.Windows.Forms.Label();
            this.lblIdecko = new System.Windows.Forms.Label();
            this.tboxPrijmeni = new System.Windows.Forms.TextBox();
            this.btnUlozit = new System.Windows.Forms.Button();
            this.lblCboxStudenti = new System.Windows.Forms.Label();
            this.tabSeznam = new System.Windows.Forms.TabPage();
            this.dataviewStudenti = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmeno_prijmeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabUpravitTrida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownClassroomHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownClassroomWidth)).BeginInit();
            this.tabUpravitStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContUpravitStudenta)).BeginInit();
            this.splitContUpravitStudenta.Panel1.SuspendLayout();
            this.splitContUpravitStudenta.Panel2.SuspendLayout();
            this.splitContUpravitStudenta.SuspendLayout();
            this.tabSeznam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rocnik
            // 
            this.rocnik.HeaderText = "Ročník";
            this.rocnik.MinimumWidth = 6;
            this.rocnik.Name = "rocnik";
            this.rocnik.ReadOnly = true;
            this.rocnik.Width = 125;
            // 
            // souradnice
            // 
            this.souradnice.HeaderText = "Souřadnice";
            this.souradnice.MinimumWidth = 6;
            this.souradnice.Name = "souradnice";
            this.souradnice.ReadOnly = true;
            this.souradnice.Width = 125;
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
            this.menuStrip.Size = new System.Drawing.Size(1001, 25);
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
            this.oAplikaciToolStripMenuItem.Image = global::SediM.Properties.Resources.Information;
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.oAplikaciToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.Image = global::SediM.Properties.Resources.Help_and_Support;
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Image = global::SediM.Properties.Resources.Power;
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
            this.noveRozsazeniToolStripMenuItem.Image = global::SediM.Properties.Resources.Add;
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
            this.importToolStripMenuItem.Image = global::SediM.Properties.Resources.Fax_Received_Succesfully;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::SediM.Properties.Resources.Fax_Sent_Succesfully;
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
            this.statusStrip.Location = new System.Drawing.Point(0, 585);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1001, 22);
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
            // tabUpravitTrida
            // 
            this.tabUpravitTrida.Controls.Add(this.txtbxNazevTridy);
            this.tabUpravitTrida.Controls.Add(this.panelEditClassroom);
            this.tabUpravitTrida.Controls.Add(this.btnOdstranitTridu);
            this.tabUpravitTrida.Controls.Add(this.btnNastavitTridu);
            this.tabUpravitTrida.Controls.Add(this.numupdownClassroomHeight);
            this.tabUpravitTrida.Controls.Add(this.lblUpravaTrid);
            this.tabUpravitTrida.Controls.Add(this.numupdownClassroomWidth);
            this.tabUpravitTrida.Controls.Add(this.combobxVyberTrid);
            this.tabUpravitTrida.Location = new System.Drawing.Point(4, 24);
            this.tabUpravitTrida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUpravitTrida.Name = "tabUpravitTrida";
            this.tabUpravitTrida.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUpravitTrida.Size = new System.Drawing.Size(993, 554);
            this.tabUpravitTrida.TabIndex = 3;
            this.tabUpravitTrida.Text = "Úprava tříd";
            this.tabUpravitTrida.UseVisualStyleBackColor = true;
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
            this.numupdownClassroomHeight.Click += new System.EventHandler(this.numupdownClassroomHeight_ValueChanged);
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
            this.numupdownClassroomWidth.Click += new System.EventHandler(this.numupdownClassroomWidth_ValueChanged);
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
            this.combobxVyberTrid.Click += new System.EventHandler(this.combobxVyberTrid_SelectedIndexChanged);
            // 
            // tabUpravitStudent
            // 
            this.tabUpravitStudent.Controls.Add(this.splitContUpravitStudenta);
            this.tabUpravitStudent.Controls.Add(this.btnUlozit);
            this.tabUpravitStudent.Controls.Add(this.lblCboxStudenti);
            this.tabUpravitStudent.Location = new System.Drawing.Point(4, 24);
            this.tabUpravitStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUpravitStudent.Name = "tabUpravitStudent";
            this.tabUpravitStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpravitStudent.Size = new System.Drawing.Size(993, 554);
            this.tabUpravitStudent.TabIndex = 1;
            this.tabUpravitStudent.Text = "Upravit studenta";
            this.tabUpravitStudent.UseVisualStyleBackColor = true;
            // 
            // splitContUpravitStudenta
            // 
            this.splitContUpravitStudenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContUpravitStudenta.Location = new System.Drawing.Point(3, 3);
            this.splitContUpravitStudenta.Name = "splitContUpravitStudenta";
            // 
            // splitContUpravitStudenta.Panel1
            // 
            this.splitContUpravitStudenta.Panel1.Controls.Add(this.lboxStudenti);
            // 
            // splitContUpravitStudenta.Panel2
            // 
            this.splitContUpravitStudenta.Panel2.Controls.Add(this.tboxJmeno);
            this.splitContUpravitStudenta.Panel2.Controls.Add(this.lblJmeno);
            this.splitContUpravitStudenta.Panel2.Controls.Add(this.lblPrijmeni);
            this.splitContUpravitStudenta.Panel2.Controls.Add(this.lblIdecko);
            this.splitContUpravitStudenta.Panel2.Controls.Add(this.tboxPrijmeni);
            this.splitContUpravitStudenta.Size = new System.Drawing.Size(987, 548);
            this.splitContUpravitStudenta.SplitterDistance = 208;
            this.splitContUpravitStudenta.TabIndex = 9;
            // 
            // lboxStudenti
            // 
            this.lboxStudenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxStudenti.FormattingEnabled = true;
            this.lboxStudenti.ItemHeight = 15;
            this.lboxStudenti.Location = new System.Drawing.Point(0, 0);
            this.lboxStudenti.Name = "lboxStudenti";
            this.lboxStudenti.Size = new System.Drawing.Size(208, 548);
            this.lboxStudenti.Sorted = true;
            this.lboxStudenti.TabIndex = 2;
            this.lboxStudenti.SelectedIndexChanged += new System.EventHandler(this.lboxStudenti_SelectedIndexChanged);
            // 
            // tboxJmeno
            // 
            this.tboxJmeno.Enabled = false;
            this.tboxJmeno.Location = new System.Drawing.Point(7, 26);
            this.tboxJmeno.Name = "tboxJmeno";
            this.tboxJmeno.Size = new System.Drawing.Size(248, 23);
            this.tboxJmeno.TabIndex = 5;
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(7, 8);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(42, 15);
            this.lblJmeno.TabIndex = 3;
            this.lblJmeno.Text = "Jméno";
            // 
            // lblPrijmeni
            // 
            this.lblPrijmeni.AutoSize = true;
            this.lblPrijmeni.Location = new System.Drawing.Point(277, 8);
            this.lblPrijmeni.Name = "lblPrijmeni";
            this.lblPrijmeni.Size = new System.Drawing.Size(51, 15);
            this.lblPrijmeni.TabIndex = 4;
            this.lblPrijmeni.Text = "Příjmení";
            // 
            // lblIdecko
            // 
            this.lblIdecko.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdecko.AutoSize = true;
            this.lblIdecko.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdecko.ForeColor = System.Drawing.Color.Red;
            this.lblIdecko.Location = new System.Drawing.Point(694, 11);
            this.lblIdecko.Name = "lblIdecko";
            this.lblIdecko.Size = new System.Drawing.Size(76, 37);
            this.lblIdecko.TabIndex = 7;
            this.lblIdecko.Text = "ID: 0";
            this.lblIdecko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxPrijmeni
            // 
            this.tboxPrijmeni.Enabled = false;
            this.tboxPrijmeni.Location = new System.Drawing.Point(277, 25);
            this.tboxPrijmeni.Name = "tboxPrijmeni";
            this.tboxPrijmeni.Size = new System.Drawing.Size(248, 23);
            this.tboxPrijmeni.TabIndex = 6;
            // 
            // btnUlozit
            // 
            this.btnUlozit.Enabled = false;
            this.btnUlozit.Location = new System.Drawing.Point(300, 439);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(75, 23);
            this.btnUlozit.TabIndex = 8;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.UseVisualStyleBackColor = true;
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // lblCboxStudenti
            // 
            this.lblCboxStudenti.AutoSize = true;
            this.lblCboxStudenti.Location = new System.Drawing.Point(6, 5);
            this.lblCboxStudenti.Name = "lblCboxStudenti";
            this.lblCboxStudenti.Size = new System.Drawing.Size(86, 15);
            this.lblCboxStudenti.TabIndex = 1;
            this.lblCboxStudenti.Text = "Výběr studenta";
            // 
            // tabSeznam
            // 
            this.tabSeznam.Controls.Add(this.dataviewStudenti);
            this.tabSeznam.Location = new System.Drawing.Point(4, 24);
            this.tabSeznam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSeznam.Name = "tabSeznam";
            this.tabSeznam.Size = new System.Drawing.Size(993, 554);
            this.tabSeznam.TabIndex = 2;
            this.tabSeznam.Text = "Seznam studentů";
            this.tabSeznam.UseVisualStyleBackColor = true;
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
            this.dataviewStudenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataviewStudenti.Location = new System.Drawing.Point(0, 0);
            this.dataviewStudenti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataviewStudenti.Name = "dataviewStudenti";
            this.dataviewStudenti.ReadOnly = true;
            this.dataviewStudenti.RowHeadersWidth = 51;
            this.dataviewStudenti.RowTemplate.Height = 25;
            this.dataviewStudenti.Size = new System.Drawing.Size(993, 554);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSeznam);
            this.tabControl1.Controls.Add(this.tabUpravitStudent);
            this.tabControl1.Controls.Add(this.tabUpravitTrida);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 582);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1001, 607);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SediM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabUpravitTrida.ResumeLayout(false);
            this.tabUpravitTrida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownClassroomHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownClassroomWidth)).EndInit();
            this.tabUpravitStudent.ResumeLayout(false);
            this.tabUpravitStudent.PerformLayout();
            this.splitContUpravitStudenta.Panel1.ResumeLayout(false);
            this.splitContUpravitStudenta.Panel2.ResumeLayout(false);
            this.splitContUpravitStudenta.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContUpravitStudenta)).EndInit();
            this.splitContUpravitStudenta.ResumeLayout(false);
            this.tabSeznam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewStudenti)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem oAplikaciToolStripMenuItem;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem ukončitToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripMenuItem noveRozsazeniToolStripMenuItem;
        private DataGridViewTextBoxColumn rocnik;
        private DataGridViewTextBoxColumn souradnice;
        private ToolStripSeparator toolStripSeparator;
        private ListBox listBoxIdeckaStudentu;
        private TabPage tabUpravitTrida;
        private TextBox txtbxNazevTridy;
        private Panel panelEditClassroom;
        private Button btnOdstranitTridu;
        private Button btnNastavitTridu;
        private NumericUpDown numupdownClassroomHeight;
        private Label lblUpravaTrid;
        private NumericUpDown numupdownClassroomWidth;
        private ComboBox combobxVyberTrid;
        private TabPage tabUpravitStudent;
        private Label lblJmeno;
        private ListBox lboxStudenti;
        private Label lblCboxStudenti;
        private TabPage tabSeznam;
        private DataGridView dataviewStudenti;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jmeno_prijmeni;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn skola;
        private TabControl tabControl1;
        private Label lblPrijmeni;
        private TextBox tboxJmeno;
        private TextBox tboxPrijmeni;
        private Label lblIdecko;
        private Button btnUlozit;
        private SplitContainer splitContUpravitStudenta;
    }
}