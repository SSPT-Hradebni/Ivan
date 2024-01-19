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
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            novýToolStripMenuItem = new ToolStripMenuItem();
            upravitToolStripMenuItem = new ToolStripMenuItem();
            seznamToolStripMenuItem = new ToolStripMenuItem();
            učitelToolStripMenuItem = new ToolStripMenuItem();
            novýToolStripMenuItem1 = new ToolStripMenuItem();
            upravitToolStripMenuItem1 = new ToolStripMenuItem();
            seznamUčitelůToolStripMenuItem = new ToolStripMenuItem();
            školaToolStripMenuItem = new ToolStripMenuItem();
            nováToolStripMenuItem = new ToolStripMenuItem();
            upravitToolStripMenuItem2 = new ToolStripMenuItem();
            seznamŠkolToolStripMenuItem = new ToolStripMenuItem();
            třídaToolStripMenuItem = new ToolStripMenuItem();
            nováToolStripMenuItem1 = new ToolStripMenuItem();
            upravitToolStripMenuItem3 = new ToolStripMenuItem();
            seznamTřídToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            novéRozsazenítoolStripMenuItem1 = new ToolStripMenuItem();
            upravitRozsazenítoolStripMenuItem1 = new ToolStripMenuItem();
            tabUpravitTrida = new TabPage();
            combobxVyberTrid = new ComboBox();
            numupdownClassroomWidth = new NumericUpDown();
            lblUpravaTrid = new Label();
            numupdownClassroomHeight = new NumericUpDown();
            btnNastavitTridu = new Button();
            btnOdstranitTridu = new Button();
            panelEditClassroom = new Panel();
            txtbxNazevTridy = new TextBox();
            tabSeznam = new TabPage();
            dataviewStudenti = new DataGridView();
            skola = new DataGridViewTextBoxColumn();
            kategorie = new DataGridViewTextBoxColumn();
            jmeno_prijmeni = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            menuStrip.SuspendLayout();
            tabUpravitTrida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).BeginInit();
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
            menuStrip.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, dataToolStripMenuItem, studentToolStripMenuItem, učitelToolStripMenuItem, školaToolStripMenuItem, třídaToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 4, 0, 4);
            menuStrip.Size = new Size(1144, 32);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikaciToolStripMenuItem, nápovědaToolStripMenuItem, ukončitToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(65, 24);
            souborToolStripMenuItem.Text = "SediM";
            // 
            // oAplikaciToolStripMenuItem
            // 
            oAplikaciToolStripMenuItem.Image = Properties.Resources.Information;
            oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            oAplikaciToolStripMenuItem.Size = new Size(161, 26);
            oAplikaciToolStripMenuItem.Text = "O aplikaci";
            oAplikaciToolStripMenuItem.Click += oAplikaciToolStripMenuItem_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.Image = Properties.Resources.Help_and_Support;
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(161, 26);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // ukončitToolStripMenuItem
            // 
            ukončitToolStripMenuItem.Image = Properties.Resources.Power;
            ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            ukončitToolStripMenuItem.Size = new Size(161, 26);
            ukončitToolStripMenuItem.Text = "Konec";
            ukončitToolStripMenuItem.Click += ukončitToolStripMenuItem_Click;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(55, 24);
            dataToolStripMenuItem.Text = "Data";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Image = Properties.Resources.Fax_Received_Succesfully;
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(137, 26);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Image = Properties.Resources.Fax_Sent_Succesfully;
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(137, 26);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novýToolStripMenuItem, upravitToolStripMenuItem, seznamToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(74, 24);
            studentToolStripMenuItem.Text = "Student";
            // 
            // novýToolStripMenuItem
            // 
            novýToolStripMenuItem.Image = Properties.Resources.Add;
            novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            novýToolStripMenuItem.Size = new Size(205, 26);
            novýToolStripMenuItem.Text = "Nový student";
            novýToolStripMenuItem.Click += novýToolStripMenuItem_Click;
            // 
            // upravitToolStripMenuItem
            // 
            upravitToolStripMenuItem.Image = Properties.Resources.OE_Signature;
            upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            upravitToolStripMenuItem.Size = new Size(205, 26);
            upravitToolStripMenuItem.Text = "Upravit studenta";
            upravitToolStripMenuItem.Click += upravitToolStripMenuItem_Click;
            // 
            // seznamToolStripMenuItem
            // 
            seznamToolStripMenuItem.Image = Properties.Resources.User_Accounts;
            seznamToolStripMenuItem.Name = "seznamToolStripMenuItem";
            seznamToolStripMenuItem.Size = new Size(205, 26);
            seznamToolStripMenuItem.Text = "Seznam studentů";
            // 
            // učitelToolStripMenuItem
            // 
            učitelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novýToolStripMenuItem1, upravitToolStripMenuItem1, seznamUčitelůToolStripMenuItem });
            učitelToolStripMenuItem.Name = "učitelToolStripMenuItem";
            učitelToolStripMenuItem.Size = new Size(61, 24);
            učitelToolStripMenuItem.Text = "Učitel";
            // 
            // novýToolStripMenuItem1
            // 
            novýToolStripMenuItem1.Image = Properties.Resources.Add;
            novýToolStripMenuItem1.Name = "novýToolStripMenuItem1";
            novýToolStripMenuItem1.Size = new Size(192, 26);
            novýToolStripMenuItem1.Text = "Nový učitel";
            // 
            // upravitToolStripMenuItem1
            // 
            upravitToolStripMenuItem1.Image = Properties.Resources.OE_Signature;
            upravitToolStripMenuItem1.Name = "upravitToolStripMenuItem1";
            upravitToolStripMenuItem1.Size = new Size(192, 26);
            upravitToolStripMenuItem1.Text = "Upravit učitele";
            // 
            // seznamUčitelůToolStripMenuItem
            // 
            seznamUčitelůToolStripMenuItem.Image = Properties.Resources.User_Accounts;
            seznamUčitelůToolStripMenuItem.Name = "seznamUčitelůToolStripMenuItem";
            seznamUčitelůToolStripMenuItem.Size = new Size(192, 26);
            seznamUčitelůToolStripMenuItem.Text = "Seznam učitelů";
            // 
            // školaToolStripMenuItem
            // 
            školaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nováToolStripMenuItem, upravitToolStripMenuItem2, seznamŠkolToolStripMenuItem });
            školaToolStripMenuItem.Name = "školaToolStripMenuItem";
            školaToolStripMenuItem.Size = new Size(59, 24);
            školaToolStripMenuItem.Text = "Škola";
            // 
            // nováToolStripMenuItem
            // 
            nováToolStripMenuItem.Image = Properties.Resources.Add;
            nováToolStripMenuItem.Name = "nováToolStripMenuItem";
            nováToolStripMenuItem.Size = new Size(178, 26);
            nováToolStripMenuItem.Text = "Nová škola";
            // 
            // upravitToolStripMenuItem2
            // 
            upravitToolStripMenuItem2.Image = Properties.Resources.OE_Signature;
            upravitToolStripMenuItem2.Name = "upravitToolStripMenuItem2";
            upravitToolStripMenuItem2.Size = new Size(178, 26);
            upravitToolStripMenuItem2.Text = "Upravit školu";
            // 
            // seznamŠkolToolStripMenuItem
            // 
            seznamŠkolToolStripMenuItem.Image = Properties.Resources.User_Accounts;
            seznamŠkolToolStripMenuItem.Name = "seznamŠkolToolStripMenuItem";
            seznamŠkolToolStripMenuItem.Size = new Size(178, 26);
            seznamŠkolToolStripMenuItem.Text = "Seznam škol";
            // 
            // třídaToolStripMenuItem
            // 
            třídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nováToolStripMenuItem1, upravitToolStripMenuItem3, seznamTřídToolStripMenuItem, toolStripSeparator1, novéRozsazenítoolStripMenuItem1, upravitRozsazenítoolStripMenuItem1 });
            třídaToolStripMenuItem.Name = "třídaToolStripMenuItem";
            třídaToolStripMenuItem.Size = new Size(56, 24);
            třídaToolStripMenuItem.Text = "Třída";
            // 
            // nováToolStripMenuItem1
            // 
            nováToolStripMenuItem1.Image = Properties.Resources.Add;
            nováToolStripMenuItem1.Name = "nováToolStripMenuItem1";
            nováToolStripMenuItem1.Size = new Size(206, 26);
            nováToolStripMenuItem1.Text = "Nová třída";
            // 
            // upravitToolStripMenuItem3
            // 
            upravitToolStripMenuItem3.Image = Properties.Resources.OE_Signature;
            upravitToolStripMenuItem3.Name = "upravitToolStripMenuItem3";
            upravitToolStripMenuItem3.Size = new Size(206, 26);
            upravitToolStripMenuItem3.Text = "Upravit třídu";
            // 
            // seznamTřídToolStripMenuItem
            // 
            seznamTřídToolStripMenuItem.Image = Properties.Resources.User_Accounts;
            seznamTřídToolStripMenuItem.Name = "seznamTřídToolStripMenuItem";
            seznamTřídToolStripMenuItem.Size = new Size(206, 26);
            seznamTřídToolStripMenuItem.Text = "Seznam tříd";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(203, 6);
            // 
            // novéRozsazenítoolStripMenuItem1
            // 
            novéRozsazenítoolStripMenuItem1.Image = Properties.Resources.Add;
            novéRozsazenítoolStripMenuItem1.Name = "novéRozsazenítoolStripMenuItem1";
            novéRozsazenítoolStripMenuItem1.Size = new Size(206, 26);
            novéRozsazenítoolStripMenuItem1.Text = "Nové rozsazení";
            novéRozsazenítoolStripMenuItem1.Click += noveRozsazeniToolStripMenuItem_Click;
            // 
            // upravitRozsazenítoolStripMenuItem1
            // 
            upravitRozsazenítoolStripMenuItem1.Image = Properties.Resources.OE_Signature;
            upravitRozsazenítoolStripMenuItem1.Name = "upravitRozsazenítoolStripMenuItem1";
            upravitRozsazenítoolStripMenuItem1.Size = new Size(206, 26);
            upravitRozsazenítoolStripMenuItem1.Text = "Upravit rozsazení";
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
            tabUpravitTrida.Location = new Point(4, 29);
            tabUpravitTrida.Margin = new Padding(3, 5, 3, 5);
            tabUpravitTrida.Name = "tabUpravitTrida";
            tabUpravitTrida.Padding = new Padding(3, 5, 3, 5);
            tabUpravitTrida.Size = new Size(1136, 593);
            tabUpravitTrida.TabIndex = 3;
            tabUpravitTrida.Text = "Úprava tříd";
            tabUpravitTrida.UseVisualStyleBackColor = true;
            // 
            // combobxVyberTrid
            // 
            combobxVyberTrid.FormattingEnabled = true;
            combobxVyberTrid.Items.AddRange(new object[] { "Nový" });
            combobxVyberTrid.Location = new Point(8, 11);
            combobxVyberTrid.Margin = new Padding(3, 5, 3, 5);
            combobxVyberTrid.Name = "combobxVyberTrid";
            combobxVyberTrid.Size = new Size(162, 28);
            combobxVyberTrid.TabIndex = 0;
            combobxVyberTrid.Click += combobxVyberTrid_SelectedIndexChanged;
            // 
            // numupdownClassroomWidth
            // 
            numupdownClassroomWidth.Location = new Point(8, 113);
            numupdownClassroomWidth.Margin = new Padding(3, 5, 3, 5);
            numupdownClassroomWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomWidth.Name = "numupdownClassroomWidth";
            numupdownClassroomWidth.Size = new Size(65, 27);
            numupdownClassroomWidth.TabIndex = 1;
            numupdownClassroomWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomWidth.Click += numupdownClassroomWidth_ValueChanged;
            // 
            // lblUpravaTrid
            // 
            lblUpravaTrid.AutoSize = true;
            lblUpravaTrid.Location = new Point(81, 117);
            lblUpravaTrid.Name = "lblUpravaTrid";
            lblUpravaTrid.Size = new Size(16, 20);
            lblUpravaTrid.TabIndex = 2;
            lblUpravaTrid.Text = "x";
            // 
            // numupdownClassroomHeight
            // 
            numupdownClassroomHeight.Location = new Point(106, 113);
            numupdownClassroomHeight.Margin = new Padding(3, 5, 3, 5);
            numupdownClassroomHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomHeight.Name = "numupdownClassroomHeight";
            numupdownClassroomHeight.Size = new Size(65, 27);
            numupdownClassroomHeight.TabIndex = 3;
            numupdownClassroomHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomHeight.Click += numupdownClassroomHeight_ValueChanged;
            // 
            // btnNastavitTridu
            // 
            btnNastavitTridu.Location = new Point(8, 165);
            btnNastavitTridu.Margin = new Padding(3, 5, 3, 5);
            btnNastavitTridu.Name = "btnNastavitTridu";
            btnNastavitTridu.Size = new Size(163, 41);
            btnNastavitTridu.TabIndex = 4;
            btnNastavitTridu.Text = "Nastavit";
            btnNastavitTridu.UseVisualStyleBackColor = true;
            btnNastavitTridu.Click += btnNastavitTridu_Click;
            // 
            // btnOdstranitTridu
            // 
            btnOdstranitTridu.Location = new Point(8, 217);
            btnOdstranitTridu.Margin = new Padding(3, 5, 3, 5);
            btnOdstranitTridu.Name = "btnOdstranitTridu";
            btnOdstranitTridu.Size = new Size(163, 41);
            btnOdstranitTridu.TabIndex = 5;
            btnOdstranitTridu.Text = "Odstranit";
            btnOdstranitTridu.UseVisualStyleBackColor = true;
            btnOdstranitTridu.Click += btnOdstranitTridu_Click;
            // 
            // panelEditClassroom
            // 
            panelEditClassroom.Location = new Point(179, 11);
            panelEditClassroom.Margin = new Padding(3, 5, 3, 5);
            panelEditClassroom.Name = "panelEditClassroom";
            panelEditClassroom.Size = new Size(895, 601);
            panelEditClassroom.TabIndex = 6;
            panelEditClassroom.Paint += panelEditClassroom_Paint;
            // 
            // txtbxNazevTridy
            // 
            txtbxNazevTridy.Location = new Point(8, 63);
            txtbxNazevTridy.Margin = new Padding(3, 5, 3, 5);
            txtbxNazevTridy.Name = "txtbxNazevTridy";
            txtbxNazevTridy.PlaceholderText = "Název třídy";
            txtbxNazevTridy.Size = new Size(162, 27);
            txtbxNazevTridy.TabIndex = 7;
            // 
            // tabSeznam
            // 
            tabSeznam.Controls.Add(dataviewStudenti);
            tabSeznam.Location = new Point(4, 29);
            tabSeznam.Margin = new Padding(3, 5, 3, 5);
            tabSeznam.Name = "tabSeznam";
            tabSeznam.Size = new Size(1136, 593);
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
            dataviewStudenti.Margin = new Padding(3, 5, 3, 5);
            dataviewStudenti.Name = "dataviewStudenti";
            dataviewStudenti.ReadOnly = true;
            dataviewStudenti.RowHeadersWidth = 51;
            dataviewStudenti.RowTemplate.Height = 25;
            dataviewStudenti.Size = new Size(1136, 593);
            dataviewStudenti.TabIndex = 4;
            // 
            // skola
            // 
            skola.HeaderText = "Škola";
            skola.MinimumWidth = 6;
            skola.Name = "skola";
            skola.ReadOnly = true;
            // 
            // kategorie
            // 
            kategorie.HeaderText = "Kategorie";
            kategorie.MinimumWidth = 6;
            kategorie.Name = "kategorie";
            kategorie.ReadOnly = true;
            // 
            // jmeno_prijmeni
            // 
            jmeno_prijmeni.HeaderText = "Jméno a přijmení";
            jmeno_prijmeni.MinimumWidth = 6;
            jmeno_prijmeni.Name = "jmeno_prijmeni";
            jmeno_prijmeni.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSeznam);
            tabControl1.Controls.Add(tabUpravitTrida);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 32);
            tabControl1.Margin = new Padding(3, 5, 3, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1144, 626);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1144, 658);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SediM";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tabUpravitTrida.ResumeLayout(false);
            tabUpravitTrida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).EndInit();
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
        private DataGridViewTextBoxColumn rocnik;
        private DataGridViewTextBoxColumn souradnice;
        private ListBox listBoxIdeckaStudentu;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem učitelToolStripMenuItem;
        private ToolStripMenuItem školaToolStripMenuItem;
        private ToolStripMenuItem třídaToolStripMenuItem;
        private ToolStripMenuItem novýToolStripMenuItem;
        private ToolStripMenuItem upravitToolStripMenuItem;
        private ToolStripMenuItem novýToolStripMenuItem1;
        private ToolStripMenuItem upravitToolStripMenuItem1;
        private ToolStripMenuItem nováToolStripMenuItem;
        private ToolStripMenuItem upravitToolStripMenuItem2;
        private ToolStripMenuItem nováToolStripMenuItem1;
        private ToolStripMenuItem upravitToolStripMenuItem3;
        private ToolStripMenuItem seznamToolStripMenuItem;
        private ToolStripMenuItem seznamUčitelůToolStripMenuItem;
        private ToolStripMenuItem seznamŠkolToolStripMenuItem;
        private ToolStripMenuItem seznamTřídToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem novéRozsazenítoolStripMenuItem1;
        private ToolStripMenuItem upravitRozsazenítoolStripMenuItem1;
        private TabPage tabUpravitTrida;
        private TextBox txtbxNazevTridy;
        private Panel panelEditClassroom;
        private Button btnOdstranitTridu;
        private Button btnNastavitTridu;
        private NumericUpDown numupdownClassroomHeight;
        private Label lblUpravaTrid;
        private NumericUpDown numupdownClassroomWidth;
        private ComboBox combobxVyberTrid;
        private TabPage tabSeznam;
        private DataGridView dataviewStudenti;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jmeno_prijmeni;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn skola;
        private TabControl tabControl1;
    }
}