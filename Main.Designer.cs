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
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            dataviewStudenti = new DataGridView();

            id = new DataGridViewTextBoxColumn();
            jmeno_prijmeni = new DataGridViewTextBoxColumn();
            kategorie = new DataGridViewTextBoxColumn();
            skola = new DataGridViewTextBoxColumn();
            rocnik = new DataGridViewTextBoxColumn();
            souradnice = new DataGridViewTextBoxColumn();

            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lblCboxStudenti = new Label();
            cboxStudenti = new ComboBox();

            tabPage4 = new TabPage();
            txtbxNazevTridy = new TextBox();
            panelEditClassroom = new Panel();
            btnOdstranitTridu = new Button();
            btnNastavitTridu = new Button();
            numupdownClassroomHeight = new NumericUpDown();
            lblUpravaTrid = new Label();
            numupdownClassroomWidth = new NumericUpDown();
            combobxVyberTrid = new ComboBox();

            menuStrip = new MenuStrip();
            souborToolStripMenuItem = new ToolStripMenuItem();
            oAplikaciToolStripMenuItem = new ToolStripMenuItem();
            nápovědaToolStripMenuItem = new ToolStripMenuItem();
            ukončitToolStripMenuItem = new ToolStripMenuItem();
            dataToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();

            noveRozsazeniToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            toolStripStatusLabel = new ToolStripStatusLabel();
            id = new DataGridViewTextBoxColumn();
            jmeno_prijmeni = new DataGridViewTextBoxColumn();
            kategorie = new DataGridViewTextBoxColumn();
            skola = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).BeginInit();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).BeginInit();

            statusStrip = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            toolStripStatusLabel = new ToolStripStatusLabel();
            lblJmeno = new Label();
            tboxJmeno = new TextBox();
            tboxPrijmeni = new TextBox();
            lblPrijmeni = new Label();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).BeginInit();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();

            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();

            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);

            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 36);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 531);

            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 398);

            tabControl1.TabIndex = 0;

            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataviewStudenti);

            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(906, 498);

            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 370);

            tabPage3.TabIndex = 2;
            tabPage3.Text = "Seznam studentů";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataviewStudenti
            // 
            dataviewStudenti.AllowUserToAddRows = false;
            dataviewStudenti.AllowUserToDeleteRows = false;
            dataviewStudenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataviewStudenti.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataviewStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataviewStudenti.Columns.AddRange(new DataGridViewColumn[] { id, jmeno_prijmeni, kategorie, skola });
            dataviewStudenti.Location = new Point(0, 0);
            dataviewStudenti.Margin = new Padding(3, 4, 3, 4);

            dataviewStudenti.Columns.AddRange(new DataGridViewColumn[] { id, jmeno_prijmeni, kategorie, skola, rocnik, souradnice });
            dataviewStudenti.Location = new Point(0, 0);

            dataviewStudenti.Name = "dataviewStudenti";
            dataviewStudenti.ReadOnly = true;
            dataviewStudenti.RowHeadersWidth = 51;
            dataviewStudenti.RowTemplate.Height = 25;

            dataviewStudenti.Size = new Size(906, 499);
            dataviewStudenti.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(906, 498);

            dataviewStudenti.Size = new Size(793, 374);
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
            // rocnik
            // 
            rocnik.HeaderText = "Ročník";
            rocnik.MinimumWidth = 6;
            rocnik.Name = "rocnik";
            rocnik.ReadOnly = true;
            // 
            // souradnice
            // 
            souradnice.HeaderText = "Souřadnice";
            souradnice.MinimumWidth = 6;
            souradnice.Name = "souradnice";
            souradnice.ReadOnly = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tboxPrijmeni);
            tabPage1.Controls.Add(lblPrijmeni);
            tabPage1.Controls.Add(tboxJmeno);
            tabPage1.Controls.Add(lblJmeno);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 370);

            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nový student";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblCboxStudenti);
            tabPage2.Controls.Add(cboxStudenti);

            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(906, 498);

            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 370);

            tabPage2.TabIndex = 1;
            tabPage2.Text = "Upravit studenta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCboxStudenti
            // 
            lblCboxStudenti.AutoSize = true;

            lblCboxStudenti.Location = new Point(7, 7);
            lblCboxStudenti.Name = "lblCboxStudenti";
            lblCboxStudenti.Size = new Size(121, 20);

            lblCboxStudenti.Location = new Point(6, 5);
            lblCboxStudenti.Name = "lblCboxStudenti";
            lblCboxStudenti.Size = new Size(96, 15);

            lblCboxStudenti.TabIndex = 1;
            lblCboxStudenti.Text = "Vyberte studenta";
            // 
            // cboxStudenti
            // 
            cboxStudenti.FormattingEnabled = true;

            cboxStudenti.Location = new Point(7, 31);
            cboxStudenti.Margin = new Padding(3, 4, 3, 4);
            cboxStudenti.Name = "cboxStudenti";
            cboxStudenti.Size = new Size(315, 28);
            cboxStudenti.Sorted = true;
            cboxStudenti.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtbxNazevTridy);
            tabPage4.Controls.Add(panelEditClassroom);
            tabPage4.Controls.Add(btnOdstranitTridu);
            tabPage4.Controls.Add(btnNastavitTridu);
            tabPage4.Controls.Add(numupdownClassroomHeight);
            tabPage4.Controls.Add(lblUpravaTrid);
            tabPage4.Controls.Add(numupdownClassroomWidth);
            tabPage4.Controls.Add(combobxVyberTrid);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(906, 498);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Úprava tříd";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtbxNazevTridy
            // 
            txtbxNazevTridy.Location = new Point(7, 47);
            txtbxNazevTridy.Margin = new Padding(3, 4, 3, 4);
            txtbxNazevTridy.Name = "txtbxNazevTridy";
            txtbxNazevTridy.PlaceholderText = "Název třídy";
            txtbxNazevTridy.Size = new Size(142, 27);
            txtbxNazevTridy.TabIndex = 7;
            // 
            // panelEditClassroom
            // 
            panelEditClassroom.Location = new Point(157, 8);
            panelEditClassroom.Margin = new Padding(3, 4, 3, 4);
            panelEditClassroom.Name = "panelEditClassroom";
            panelEditClassroom.Size = new Size(731, 467);
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
            numupdownClassroomHeight.Size = new Size(57, 27);
            numupdownClassroomHeight.TabIndex = 3;
            numupdownClassroomHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomHeight.ValueChanged += numupdownClassroomHeight_ValueChanged;
            // 
            // lblUpravaTrid
            // 
            lblUpravaTrid.AutoSize = true;
            lblUpravaTrid.Location = new Point(71, 88);
            lblUpravaTrid.Name = "lblUpravaTrid";
            lblUpravaTrid.Size = new Size(16, 20);
            lblUpravaTrid.TabIndex = 2;
            lblUpravaTrid.Text = "x";
            // 
            // numupdownClassroomWidth
            // 
            numupdownClassroomWidth.Location = new Point(7, 85);
            numupdownClassroomWidth.Margin = new Padding(3, 4, 3, 4);
            numupdownClassroomWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomWidth.Name = "numupdownClassroomWidth";
            numupdownClassroomWidth.Size = new Size(57, 27);
            numupdownClassroomWidth.TabIndex = 1;
            numupdownClassroomWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomWidth.ValueChanged += numupdownClassroomWidth_ValueChanged;
            // 
            // combobxVyberTrid
            // 
            combobxVyberTrid.FormattingEnabled = true;
            combobxVyberTrid.Items.AddRange(new object[] { "Nový" });
            combobxVyberTrid.Location = new Point(7, 8);
            combobxVyberTrid.Margin = new Padding(3, 4, 3, 4);
            combobxVyberTrid.Name = "combobxVyberTrid";
            combobxVyberTrid.Size = new Size(142, 28);
            combobxVyberTrid.TabIndex = 0;
            combobxVyberTrid.SelectedIndexChanged += combobxVyberTrid_SelectedIndexChanged;

            cboxStudenti.Location = new Point(6, 23);
            cboxStudenti.Name = "cboxStudenti";
            cboxStudenti.Size = new Size(276, 23);
            cboxStudenti.Sorted = true;
            cboxStudenti.TabIndex = 0;

            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, dataToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";

            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(914, 30);

            menuStrip.Size = new Size(800, 24);

            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikaciToolStripMenuItem, nápovědaToolStripMenuItem, ukončitToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";

            souborToolStripMenuItem.Size = new Size(65, 24);

            souborToolStripMenuItem.Size = new Size(52, 20);

            souborToolStripMenuItem.Text = "SediM";
            // 
            // oAplikaciToolStripMenuItem
            // 
            oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";

            oAplikaciToolStripMenuItem.Size = new Size(161, 26);

            oAplikaciToolStripMenuItem.Size = new Size(128, 22);

            oAplikaciToolStripMenuItem.Text = "O aplikaci";
            oAplikaciToolStripMenuItem.Click += oAplikaciToolStripMenuItem_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";

            nápovědaToolStripMenuItem.Size = new Size(161, 26);

            nápovědaToolStripMenuItem.Size = new Size(128, 22);

            nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // ukončitToolStripMenuItem
            // 
            ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";

            ukončitToolStripMenuItem.Size = new Size(161, 26);

            ukončitToolStripMenuItem.Size = new Size(128, 22);

            ukončitToolStripMenuItem.Text = "Konec";
            ukončitToolStripMenuItem.Click += ukončitToolStripMenuItem_Click;
            // 
            // dataToolStripMenuItem
            // 

            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, noveRozsazeniToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(55, 24);

            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(43, 20);

            dataToolStripMenuItem.Text = "Data";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";

            importToolStripMenuItem.Size = new Size(193, 26);

            importToolStripMenuItem.Size = new Size(110, 22);

            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";

            exportToolStripMenuItem.Size = new Size(193, 26);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // noveRozsazeniToolStripMenuItem
            // 
            noveRozsazeniToolStripMenuItem.Name = "noveRozsazeniToolStripMenuItem";
            noveRozsazeniToolStripMenuItem.Size = new Size(193, 26);
            noveRozsazeniToolStripMenuItem.Text = "Nové rozsazení";
            noveRozsazeniToolStripMenuItem.Click += noveRozsazeniToolStripMenuItem_Click;

            exportToolStripMenuItem.Size = new Size(110, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;

            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripProgressBar, toolStripStatusLabel });

            statusStrip.Location = new Point(0, 573);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(914, 27);

            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);

            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";

            toolStripProgressBar.Size = new Size(114, 19);

            toolStripProgressBar.Size = new Size(100, 16);

            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";

            toolStripStatusLabel.Size = new Size(143, 21);
            toolStripStatusLabel.Text = "toolStripStatusLabel";
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(914, 600);

            toolStripStatusLabel.Size = new Size(112, 17);
            toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // lblJmeno
            // 
            lblJmeno.AutoSize = true;
            lblJmeno.Location = new Point(8, 3);
            lblJmeno.Name = "lblJmeno";
            lblJmeno.Size = new Size(42, 15);
            lblJmeno.TabIndex = 0;
            lblJmeno.Text = "Jméno";
            // 
            // tboxJmeno
            // 
            tboxJmeno.Location = new Point(8, 21);
            tboxJmeno.Name = "tboxJmeno";
            tboxJmeno.Size = new Size(100, 23);
            tboxJmeno.TabIndex = 1;
            // 
            // tboxPrijmeni
            // 
            tboxPrijmeni.Location = new Point(114, 21);
            tboxPrijmeni.Name = "tboxPrijmeni";
            tboxPrijmeni.Size = new Size(100, 23);
            tboxPrijmeni.TabIndex = 3;
            // 
            // lblPrijmeni
            // 
            lblPrijmeni.AutoSize = true;
            lblPrijmeni.Location = new Point(114, 3);
            lblPrijmeni.Name = "lblPrijmeni";
            lblPrijmeni.Size = new Size(51, 15);
            lblPrijmeni.TabIndex = 2;
            lblPrijmeni.Text = "Příjmení";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);

            Controls.Add(statusStrip);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip;

            Margin = new Padding(3, 4, 3, 4);

            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).EndInit();

            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).EndInit();

            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();

            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox cboxStudenti;
        private Label lblCboxStudenti;
        private Label lblJmeno;
        private TextBox tboxJmeno;
        private TextBox tboxPrijmeni;
        private Label lblPrijmeni;
    }
}