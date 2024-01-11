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
            rocnik = new DataGridViewTextBoxColumn();
            souradnice = new DataGridViewTextBoxColumn();
            menuStrip = new MenuStrip();
            souborToolStripMenuItem = new ToolStripMenuItem();
            oAplikaciToolStripMenuItem = new ToolStripMenuItem();
            nápovědaToolStripMenuItem = new ToolStripMenuItem();
            ukončitToolStripMenuItem = new ToolStripMenuItem();
            dataToolStripMenuItem = new ToolStripMenuItem();
            noveRozsazeniToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            toolStripStatusLabel = new ToolStripStatusLabel();
            tabUpravitTrida = new TabPage();
            txtbxNazevTridy = new TextBox();
            panelEditClassroom = new Panel();
            btnOdstranitTridu = new Button();
            btnNastavitTridu = new Button();
            numupdownClassroomHeight = new NumericUpDown();
            lblUpravaTrid = new Label();
            numupdownClassroomWidth = new NumericUpDown();
            combobxVyberTrid = new ComboBox();
            tabUpravitStudent = new TabPage();
            splitContUpravitStudenta = new SplitContainer();
            lboxStudenti = new ListBox();
            lblSkola = new Label();
            cboxSkoly = new ComboBox();
            tboxJmeno = new TextBox();
            btnUlozit = new Button();
            lblJmeno = new Label();
            lblPrijmeni = new Label();
            lblIdecko = new Label();
            tboxPrijmeni = new TextBox();
            lblCboxStudenti = new Label();
            tabSeznam = new TabPage();
            dataviewStudenti = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            jmeno_prijmeni = new DataGridViewTextBoxColumn();
            kategorie = new DataGridViewTextBoxColumn();
            skola = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            tabUpravitTrida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).BeginInit();
            tabUpravitStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContUpravitStudenta).BeginInit();
            splitContUpravitStudenta.Panel1.SuspendLayout();
            splitContUpravitStudenta.Panel2.SuspendLayout();
            splitContUpravitStudenta.SuspendLayout();
            tabSeznam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // rocnik
            // 
            rocnik.HeaderText = "Ročník";
            rocnik.MinimumWidth = 6;
            rocnik.Name = "rocnik";
            rocnik.ReadOnly = true;
            rocnik.Width = 125;
            // 
            // souradnice
            // 
            souradnice.HeaderText = "Souřadnice";
            souradnice.MinimumWidth = 6;
            souradnice.Name = "souradnice";
            souradnice.ReadOnly = true;
            souradnice.Width = 125;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, dataToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(1001, 25);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikaciToolStripMenuItem, nápovědaToolStripMenuItem, ukončitToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(52, 19);
            souborToolStripMenuItem.Text = "SediM";
            // 
            // oAplikaciToolStripMenuItem
            // 
            oAplikaciToolStripMenuItem.Image = Properties.Resources.Information;
            oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            oAplikaciToolStripMenuItem.Size = new Size(128, 22);
            oAplikaciToolStripMenuItem.Text = "O aplikaci";
            oAplikaciToolStripMenuItem.Click += oAplikaciToolStripMenuItem_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.Image = Properties.Resources.Help_and_Support;
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(128, 22);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // ukončitToolStripMenuItem
            // 
            ukončitToolStripMenuItem.Image = Properties.Resources.Power;
            ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            ukončitToolStripMenuItem.Size = new Size(128, 22);
            ukončitToolStripMenuItem.Text = "Konec";
            ukončitToolStripMenuItem.Click += ukončitToolStripMenuItem_Click;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noveRozsazeniToolStripMenuItem, toolStripSeparator, importToolStripMenuItem, exportToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(43, 19);
            dataToolStripMenuItem.Text = "Data";
            // 
            // noveRozsazeniToolStripMenuItem
            // 
            noveRozsazeniToolStripMenuItem.Image = Properties.Resources.Add;
            noveRozsazeniToolStripMenuItem.Name = "noveRozsazeniToolStripMenuItem";
            noveRozsazeniToolStripMenuItem.Size = new Size(153, 22);
            noveRozsazeniToolStripMenuItem.Text = "Nové rozsazení";
            noveRozsazeniToolStripMenuItem.Click += noveRozsazeniToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(150, 6);
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Image = Properties.Resources.Fax_Received_Succesfully;
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(153, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Image = Properties.Resources.Fax_Sent_Succesfully;
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(153, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripProgressBar, toolStripStatusLabel });
            statusStrip.Location = new Point(0, 585);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1001, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            statusStrip.Visible = false;
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(112, 17);
            toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // tabUpravitTrida
            // 
            tabUpravitTrida.Controls.Add(txtbxNazevTridy);
            tabUpravitTrida.Controls.Add(panelEditClassroom);
            tabUpravitTrida.Controls.Add(btnOdstranitTridu);
            tabUpravitTrida.Controls.Add(btnNastavitTridu);
            tabUpravitTrida.Controls.Add(numupdownClassroomHeight);
            tabUpravitTrida.Controls.Add(lblUpravaTrid);
            tabUpravitTrida.Controls.Add(numupdownClassroomWidth);
            tabUpravitTrida.Controls.Add(combobxVyberTrid);
            tabUpravitTrida.Location = new Point(4, 24);
            tabUpravitTrida.Margin = new Padding(3, 4, 3, 4);
            tabUpravitTrida.Name = "tabUpravitTrida";
            tabUpravitTrida.Padding = new Padding(3, 4, 3, 4);
            tabUpravitTrida.Size = new Size(993, 554);
            tabUpravitTrida.TabIndex = 3;
            tabUpravitTrida.Text = "Úprava tříd";
            tabUpravitTrida.UseVisualStyleBackColor = true;
            // 
            // txtbxNazevTridy
            // 
            txtbxNazevTridy.Location = new Point(7, 47);
            txtbxNazevTridy.Margin = new Padding(3, 4, 3, 4);
            txtbxNazevTridy.Name = "txtbxNazevTridy";
            txtbxNazevTridy.PlaceholderText = "Název třídy";
            txtbxNazevTridy.Size = new Size(142, 23);
            txtbxNazevTridy.TabIndex = 7;
            // 
            // panelEditClassroom
            // 
            panelEditClassroom.Location = new Point(157, 8);
            panelEditClassroom.Margin = new Padding(3, 4, 3, 4);
            panelEditClassroom.Name = "panelEditClassroom";
            panelEditClassroom.Size = new Size(783, 451);
            panelEditClassroom.TabIndex = 6;
            panelEditClassroom.Paint += panelEditClassroom_Paint;
            // 
            // btnOdstranitTridu
            // 
            btnOdstranitTridu.Location = new Point(7, 163);
            btnOdstranitTridu.Margin = new Padding(3, 4, 3, 4);
            btnOdstranitTridu.Name = "btnOdstranitTridu";
            btnOdstranitTridu.Size = new Size(143, 31);
            btnOdstranitTridu.TabIndex = 5;
            btnOdstranitTridu.Text = "Odstranit";
            btnOdstranitTridu.UseVisualStyleBackColor = true;
            btnOdstranitTridu.Click += btnOdstranitTridu_Click;
            // 
            // btnNastavitTridu
            // 
            btnNastavitTridu.Location = new Point(7, 124);
            btnNastavitTridu.Margin = new Padding(3, 4, 3, 4);
            btnNastavitTridu.Name = "btnNastavitTridu";
            btnNastavitTridu.Size = new Size(143, 31);
            btnNastavitTridu.TabIndex = 4;
            btnNastavitTridu.Text = "Nastavit";
            btnNastavitTridu.UseVisualStyleBackColor = true;
            btnNastavitTridu.Click += btnNastavitTridu_Click;
            // 
            // numupdownClassroomHeight
            // 
            numupdownClassroomHeight.Location = new Point(93, 85);
            numupdownClassroomHeight.Margin = new Padding(3, 4, 3, 4);
            numupdownClassroomHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomHeight.Name = "numupdownClassroomHeight";
            numupdownClassroomHeight.Size = new Size(57, 23);
            numupdownClassroomHeight.TabIndex = 3;
            numupdownClassroomHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomHeight.Click += numupdownClassroomHeight_ValueChanged;
            // 
            // lblUpravaTrid
            // 
            lblUpravaTrid.AutoSize = true;
            lblUpravaTrid.Location = new Point(71, 88);
            lblUpravaTrid.Name = "lblUpravaTrid";
            lblUpravaTrid.Size = new Size(13, 15);
            lblUpravaTrid.TabIndex = 2;
            lblUpravaTrid.Text = "x";
            // 
            // numupdownClassroomWidth
            // 
            numupdownClassroomWidth.Location = new Point(7, 85);
            numupdownClassroomWidth.Margin = new Padding(3, 4, 3, 4);
            numupdownClassroomWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomWidth.Name = "numupdownClassroomWidth";
            numupdownClassroomWidth.Size = new Size(57, 23);
            numupdownClassroomWidth.TabIndex = 1;
            numupdownClassroomWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomWidth.Click += numupdownClassroomWidth_ValueChanged;
            // 
            // combobxVyberTrid
            // 
            combobxVyberTrid.FormattingEnabled = true;
            combobxVyberTrid.Items.AddRange(new object[] { "Nový" });
            combobxVyberTrid.Location = new Point(7, 8);
            combobxVyberTrid.Margin = new Padding(3, 4, 3, 4);
            combobxVyberTrid.Name = "combobxVyberTrid";
            combobxVyberTrid.Size = new Size(142, 23);
            combobxVyberTrid.TabIndex = 0;
            combobxVyberTrid.Click += combobxVyberTrid_SelectedIndexChanged;
            // 
            // tabUpravitStudent
            // 
            tabUpravitStudent.Controls.Add(splitContUpravitStudenta);
            tabUpravitStudent.Controls.Add(lblCboxStudenti);
            tabUpravitStudent.Location = new Point(4, 24);
            tabUpravitStudent.Margin = new Padding(3, 4, 3, 4);
            tabUpravitStudent.Name = "tabUpravitStudent";
            tabUpravitStudent.Padding = new Padding(3);
            tabUpravitStudent.Size = new Size(993, 554);
            tabUpravitStudent.TabIndex = 1;
            tabUpravitStudent.Text = "Upravit studenta";
            tabUpravitStudent.UseVisualStyleBackColor = true;
            // 
            // splitContUpravitStudenta
            // 
            splitContUpravitStudenta.Dock = DockStyle.Fill;
            splitContUpravitStudenta.Location = new Point(3, 3);
            splitContUpravitStudenta.Name = "splitContUpravitStudenta";
            // 
            // splitContUpravitStudenta.Panel1
            // 
            splitContUpravitStudenta.Panel1.Controls.Add(lboxStudenti);
            // 
            // splitContUpravitStudenta.Panel2
            // 
            splitContUpravitStudenta.Panel2.Controls.Add(lblSkola);
            splitContUpravitStudenta.Panel2.Controls.Add(cboxSkoly);
            splitContUpravitStudenta.Panel2.Controls.Add(tboxJmeno);
            splitContUpravitStudenta.Panel2.Controls.Add(btnUlozit);
            splitContUpravitStudenta.Panel2.Controls.Add(lblJmeno);
            splitContUpravitStudenta.Panel2.Controls.Add(lblPrijmeni);
            splitContUpravitStudenta.Panel2.Controls.Add(lblIdecko);
            splitContUpravitStudenta.Panel2.Controls.Add(tboxPrijmeni);
            splitContUpravitStudenta.Size = new Size(987, 548);
            splitContUpravitStudenta.SplitterDistance = 208;
            splitContUpravitStudenta.TabIndex = 9;
            // 
            // lboxStudenti
            // 
            lboxStudenti.Dock = DockStyle.Fill;
            lboxStudenti.FormattingEnabled = true;
            lboxStudenti.ItemHeight = 15;
            lboxStudenti.Location = new Point(0, 0);
            lboxStudenti.Name = "lboxStudenti";
            lboxStudenti.Size = new Size(208, 548);
            lboxStudenti.Sorted = true;
            lboxStudenti.TabIndex = 2;
            lboxStudenti.SelectedIndexChanged += lboxStudenti_SelectedIndexChanged;
            // 
            // lblSkola
            // 
            lblSkola.AutoSize = true;
            lblSkola.Location = new Point(101, 61);
            lblSkola.Name = "lblSkola";
            lblSkola.Size = new Size(35, 15);
            lblSkola.TabIndex = 10;
            lblSkola.Text = "Škola";
            // 
            // cboxSkoly
            // 
            cboxSkoly.FormattingEnabled = true;
            cboxSkoly.Location = new Point(101, 79);
            cboxSkoly.Name = "cboxSkoly";
            cboxSkoly.Size = new Size(248, 23);
            cboxSkoly.TabIndex = 9;
            // 
            // tboxJmeno
            // 
            tboxJmeno.Enabled = false;
            tboxJmeno.Location = new Point(101, 26);
            tboxJmeno.Name = "tboxJmeno";
            tboxJmeno.Size = new Size(248, 23);
            tboxJmeno.TabIndex = 5;
            // 
            // btnUlozit
            // 
            btnUlozit.Enabled = false;
            btnUlozit.Location = new Point(638, 25);
            btnUlozit.Name = "btnUlozit";
            btnUlozit.Size = new Size(75, 23);
            btnUlozit.TabIndex = 8;
            btnUlozit.Text = "Uložit";
            btnUlozit.UseVisualStyleBackColor = true;
            btnUlozit.Click += btnUlozit_Click;
            // 
            // lblJmeno
            // 
            lblJmeno.AutoSize = true;
            lblJmeno.Location = new Point(101, 8);
            lblJmeno.Name = "lblJmeno";
            lblJmeno.Size = new Size(42, 15);
            lblJmeno.TabIndex = 3;
            lblJmeno.Text = "Jméno";
            // 
            // lblPrijmeni
            // 
            lblPrijmeni.AutoSize = true;
            lblPrijmeni.Location = new Point(371, 8);
            lblPrijmeni.Name = "lblPrijmeni";
            lblPrijmeni.Size = new Size(51, 15);
            lblPrijmeni.TabIndex = 4;
            lblPrijmeni.Text = "Příjmení";
            // 
            // lblIdecko
            // 
            lblIdecko.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIdecko.AutoSize = true;
            lblIdecko.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdecko.ForeColor = Color.Red;
            lblIdecko.Location = new Point(7, 11);
            lblIdecko.Name = "lblIdecko";
            lblIdecko.Size = new Size(76, 37);
            lblIdecko.TabIndex = 7;
            lblIdecko.Text = "ID: 0";
            lblIdecko.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tboxPrijmeni
            // 
            tboxPrijmeni.Enabled = false;
            tboxPrijmeni.Location = new Point(371, 25);
            tboxPrijmeni.Name = "tboxPrijmeni";
            tboxPrijmeni.Size = new Size(248, 23);
            tboxPrijmeni.TabIndex = 6;
            // 
            // lblCboxStudenti
            // 
            lblCboxStudenti.AutoSize = true;
            lblCboxStudenti.Location = new Point(6, 5);
            lblCboxStudenti.Name = "lblCboxStudenti";
            lblCboxStudenti.Size = new Size(86, 15);
            lblCboxStudenti.TabIndex = 1;
            lblCboxStudenti.Text = "Výběr studenta";
            // 
            // tabSeznam
            // 
            tabSeznam.Controls.Add(dataviewStudenti);
            tabSeznam.Location = new Point(4, 24);
            tabSeznam.Margin = new Padding(3, 4, 3, 4);
            tabSeznam.Name = "tabSeznam";
            tabSeznam.Size = new Size(993, 554);
            tabSeznam.TabIndex = 2;
            tabSeznam.Text = "Seznam studentů";
            tabSeznam.UseVisualStyleBackColor = true;
            // 
            // dataviewStudenti
            // 
            dataviewStudenti.AllowUserToAddRows = false;
            dataviewStudenti.AllowUserToDeleteRows = false;
            dataviewStudenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataviewStudenti.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataviewStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewStudenti.Columns.AddRange(new DataGridViewColumn[] { id, jmeno_prijmeni, kategorie, skola });
            dataviewStudenti.Dock = DockStyle.Fill;
            dataviewStudenti.Location = new Point(0, 0);
            dataviewStudenti.Margin = new Padding(3, 4, 3, 4);
            dataviewStudenti.Name = "dataviewStudenti";
            dataviewStudenti.ReadOnly = true;
            dataviewStudenti.RowHeadersWidth = 51;
            dataviewStudenti.RowTemplate.Height = 25;
            dataviewStudenti.Size = new Size(993, 554);
            dataviewStudenti.TabIndex = 4;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // jmeno_prijmeni
            // 
            jmeno_prijmeni.HeaderText = "Jméno a přijmení";
            jmeno_prijmeni.MinimumWidth = 6;
            jmeno_prijmeni.Name = "jmeno_prijmeni";
            jmeno_prijmeni.ReadOnly = true;
            // 
            // kategorie
            // 
            kategorie.HeaderText = "Kategorie";
            kategorie.MinimumWidth = 6;
            kategorie.Name = "kategorie";
            kategorie.ReadOnly = true;
            // 
            // skola
            // 
            skola.HeaderText = "Škola";
            skola.MinimumWidth = 6;
            skola.Name = "skola";
            skola.ReadOnly = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSeznam);
            tabControl1.Controls.Add(tabUpravitStudent);
            tabControl1.Controls.Add(tabUpravitTrida);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1001, 582);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1001, 607);
            Controls.Add(statusStrip);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SediM";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tabUpravitTrida.ResumeLayout(false);
            tabUpravitTrida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).EndInit();
            tabUpravitStudent.ResumeLayout(false);
            tabUpravitStudent.PerformLayout();
            splitContUpravitStudenta.Panel1.ResumeLayout(false);
            splitContUpravitStudenta.Panel2.ResumeLayout(false);
            splitContUpravitStudenta.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContUpravitStudenta).EndInit();
            splitContUpravitStudenta.ResumeLayout(false);
            tabSeznam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox cboxSkoly;
        private Label lblSkola;
    }
}