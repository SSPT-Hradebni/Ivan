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
            txtbxNazevTridy = new TextBox();
            panelEditClassroom = new Panel();
            btnOdstranitTridu = new Button();
            btnNastavitTridu = new Button();
            numupdownClassroomHeight = new NumericUpDown();
            lblUpravaTrid = new Label();
            numupdownClassroomWidth = new NumericUpDown();
            combobxVyberTrid = new ComboBox();
            tabControl1 = new TabControl();
            menuStrip.SuspendLayout();
            tabUpravitTrida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).BeginInit();
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
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(43, 19);
            dataToolStripMenuItem.Text = "Data";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Image = Properties.Resources.Fax_Received_Succesfully;
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Image = Properties.Resources.Fax_Sent_Succesfully;
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(110, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novýToolStripMenuItem, upravitToolStripMenuItem, seznamToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 19);
            studentToolStripMenuItem.Text = "Student";
            // 
            // novýToolStripMenuItem
            // 
            novýToolStripMenuItem.Image = Properties.Resources.Add;
            novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            novýToolStripMenuItem.Size = new Size(184, 26);
            novýToolStripMenuItem.Text = "Nový student";
            novýToolStripMenuItem.Click += novýToolStripMenuItem_Click;
            // 
            // upravitToolStripMenuItem
            // 
            upravitToolStripMenuItem.Image = Properties.Resources.OE_Signature;
            upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            upravitToolStripMenuItem.Size = new Size(184, 26);
            upravitToolStripMenuItem.Text = "Upravit studenta";
            upravitToolStripMenuItem.Click += upravitToolStripMenuItem_Click;
            // 
            // seznamToolStripMenuItem
            // 
            seznamToolStripMenuItem.Image = Properties.Resources.User_Accounts;
            seznamToolStripMenuItem.Name = "seznamToolStripMenuItem";
            seznamToolStripMenuItem.Size = new Size(184, 26);
            seznamToolStripMenuItem.Text = "Seznam studentů";
            seznamToolStripMenuItem.Click += seznamToolStripMenuItem_Click;
            // 
            // učitelToolStripMenuItem
            // 
            učitelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novýToolStripMenuItem1, upravitToolStripMenuItem1, seznamUčitelůToolStripMenuItem });
            učitelToolStripMenuItem.Name = "učitelToolStripMenuItem";
            učitelToolStripMenuItem.Size = new Size(49, 19);
            učitelToolStripMenuItem.Text = "Učitel";
            // 
            // novýToolStripMenuItem1
            // 
            novýToolStripMenuItem1.Image = Properties.Resources.Add;
            novýToolStripMenuItem1.Name = "novýToolStripMenuItem1";
            novýToolStripMenuItem1.Size = new Size(154, 22);
            novýToolStripMenuItem1.Text = "Nový učitel";
            // 
            // upravitToolStripMenuItem1
            // 
            upravitToolStripMenuItem1.Image = Properties.Resources.OE_Signature;
            upravitToolStripMenuItem1.Name = "upravitToolStripMenuItem1";
            upravitToolStripMenuItem1.Size = new Size(154, 22);
            upravitToolStripMenuItem1.Text = "Upravit učitele";
            // 
            // seznamUčitelůToolStripMenuItem
            // 
            seznamUčitelůToolStripMenuItem.Image = Properties.Resources.User_Accounts;
            seznamUčitelůToolStripMenuItem.Name = "seznamUčitelůToolStripMenuItem";
            seznamUčitelůToolStripMenuItem.Size = new Size(154, 22);
            seznamUčitelůToolStripMenuItem.Text = "Seznam učitelů";
            // 
            // školaToolStripMenuItem
            // 
            školaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nováToolStripMenuItem, upravitToolStripMenuItem2, seznamŠkolToolStripMenuItem });
            školaToolStripMenuItem.Name = "školaToolStripMenuItem";
            školaToolStripMenuItem.Size = new Size(47, 19);
            školaToolStripMenuItem.Text = "Škola";
            // 
            // nováToolStripMenuItem
            // 
            nováToolStripMenuItem.Image = Properties.Resources.Add;
            nováToolStripMenuItem.Name = "nováToolStripMenuItem";
            nováToolStripMenuItem.Size = new Size(143, 22);
            nováToolStripMenuItem.Text = "Nová škola";
            // 
            // upravitToolStripMenuItem2
            // 
            upravitToolStripMenuItem2.Image = Properties.Resources.OE_Signature;
            upravitToolStripMenuItem2.Name = "upravitToolStripMenuItem2";
            upravitToolStripMenuItem2.Size = new Size(143, 22);
            upravitToolStripMenuItem2.Text = "Upravit školu";
            // 
            // seznamŠkolToolStripMenuItem
            // 
            seznamŠkolToolStripMenuItem.Image = Properties.Resources.User_Accounts;
            seznamŠkolToolStripMenuItem.Name = "seznamŠkolToolStripMenuItem";
            seznamŠkolToolStripMenuItem.Size = new Size(143, 22);
            seznamŠkolToolStripMenuItem.Text = "Seznam škol";
            // 
            // třídaToolStripMenuItem
            // 
            třídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nováToolStripMenuItem1, upravitToolStripMenuItem3, seznamTřídToolStripMenuItem, toolStripSeparator1, novéRozsazenítoolStripMenuItem1, upravitRozsazenítoolStripMenuItem1 });
            třídaToolStripMenuItem.Name = "třídaToolStripMenuItem";
            třídaToolStripMenuItem.Size = new Size(44, 19);
            třídaToolStripMenuItem.Text = "Třída";
            // 
            // nováToolStripMenuItem1
            // 
            nováToolStripMenuItem1.Image = Properties.Resources.Add;
            nováToolStripMenuItem1.Name = "nováToolStripMenuItem1";
            nováToolStripMenuItem1.Size = new Size(163, 22);
            nováToolStripMenuItem1.Text = "Nová třída";
            // 
            // upravitToolStripMenuItem3
            // 
            upravitToolStripMenuItem3.Image = Properties.Resources.OE_Signature;
            upravitToolStripMenuItem3.Name = "upravitToolStripMenuItem3";
            upravitToolStripMenuItem3.Size = new Size(163, 22);
            upravitToolStripMenuItem3.Text = "Upravit třídu";
            // 
            // seznamTřídToolStripMenuItem
            // 
            seznamTřídToolStripMenuItem.Image = Properties.Resources.User_Accounts;
            seznamTřídToolStripMenuItem.Name = "seznamTřídToolStripMenuItem";
            seznamTřídToolStripMenuItem.Size = new Size(163, 22);
            seznamTřídToolStripMenuItem.Text = "Seznam tříd";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(160, 6);
            // 
            // novéRozsazenítoolStripMenuItem1
            // 
            novéRozsazenítoolStripMenuItem1.Image = Properties.Resources.Add;
            novéRozsazenítoolStripMenuItem1.Name = "novéRozsazenítoolStripMenuItem1";
            novéRozsazenítoolStripMenuItem1.Size = new Size(163, 22);
            novéRozsazenítoolStripMenuItem1.Text = "Nové rozsazení";
            novéRozsazenítoolStripMenuItem1.Click += noveRozsazeniToolStripMenuItem_Click;
            // 
            // upravitRozsazenítoolStripMenuItem1
            // 
            upravitRozsazenítoolStripMenuItem1.Image = Properties.Resources.OE_Signature;
            upravitRozsazenítoolStripMenuItem1.Name = "upravitRozsazenítoolStripMenuItem1";
            upravitRozsazenítoolStripMenuItem1.Size = new Size(163, 22);
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
            tabUpravitTrida.Location = new Point(4, 24);
            tabUpravitTrida.Margin = new Padding(3, 4, 3, 4);
            tabUpravitTrida.Name = "tabUpravitTrida";
            tabUpravitTrida.Padding = new Padding(3, 4, 3, 4);
            tabUpravitTrida.Size = new Size(993, 441);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabUpravitTrida);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1001, 469);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1001, 494);
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
            tabUpravitTrida.ResumeLayout(false);
            tabUpravitTrida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).EndInit();
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
        private TabControl tabControl1;
    }
}