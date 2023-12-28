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
            txtxbxNazevTridy = new TextBox();
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
            statusStrip = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            toolStripStatusLabel = new ToolStripStatusLabel();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataviewStudenti).BeginInit();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numupdownClassroomWidth).BeginInit();
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
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 398);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataviewStudenti);
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
            dataviewStudenti.Columns.AddRange(new DataGridViewColumn[] { id, jmeno_prijmeni, kategorie, skola, rocnik, souradnice });
            dataviewStudenti.Location = new Point(0, 0);
            dataviewStudenti.Name = "dataviewStudenti";
            dataviewStudenti.ReadOnly = true;
            dataviewStudenti.RowHeadersWidth = 51;
            dataviewStudenti.RowTemplate.Height = 25;
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
            lblCboxStudenti.Location = new Point(6, 5);
            lblCboxStudenti.Name = "lblCboxStudenti";
            lblCboxStudenti.Size = new Size(96, 15);
            lblCboxStudenti.TabIndex = 1;
            lblCboxStudenti.Text = "Vyberte studenta";
            // 
            // cboxStudenti
            // 
            cboxStudenti.FormattingEnabled = true;
            cboxStudenti.Location = new Point(6, 23);
            cboxStudenti.Name = "cboxStudenti";
            cboxStudenti.Size = new Size(276, 23);
            cboxStudenti.Sorted = true;
            cboxStudenti.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtxbxNazevTridy);
            tabPage4.Controls.Add(panelEditClassroom);
            tabPage4.Controls.Add(btnOdstranitTridu);
            tabPage4.Controls.Add(btnNastavitTridu);
            tabPage4.Controls.Add(numupdownClassroomHeight);
            tabPage4.Controls.Add(lblUpravaTrid);
            tabPage4.Controls.Add(numupdownClassroomWidth);
            tabPage4.Controls.Add(combobxVyberTrid);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 370);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Úprava tříd";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtxbxNazevTridy
            // 
            txtxbxNazevTridy.Location = new Point(6, 35);
            txtxbxNazevTridy.Name = "txtxbxNazevTridy";
            txtxbxNazevTridy.PlaceholderText = "Název třídy";
            txtxbxNazevTridy.Size = new Size(125, 23);
            txtxbxNazevTridy.TabIndex = 7;
            // 
            // panelEditClassroom
            // 
            panelEditClassroom.Location = new Point(137, 6);
            panelEditClassroom.Name = "panelEditClassroom";
            panelEditClassroom.Size = new Size(640, 350);
            panelEditClassroom.TabIndex = 6;
            panelEditClassroom.Paint += panelEditClassroom_Paint;
            // 
            // btnOdstranitTridu
            // 
            btnOdstranitTridu.Location = new Point(6, 122);
            btnOdstranitTridu.Name = "btnOdstranitTridu";
            btnOdstranitTridu.Size = new Size(125, 23);
            btnOdstranitTridu.TabIndex = 5;
            btnOdstranitTridu.Text = "Odstranit";
            btnOdstranitTridu.UseVisualStyleBackColor = true;
            // 
            // btnNastavitTridu
            // 
            btnNastavitTridu.Location = new Point(6, 93);
            btnNastavitTridu.Name = "btnNastavitTridu";
            btnNastavitTridu.Size = new Size(125, 23);
            btnNastavitTridu.TabIndex = 4;
            btnNastavitTridu.Text = "Nastavit";
            btnNastavitTridu.UseVisualStyleBackColor = true;
            btnNastavitTridu.Click += btnSetClassroon_Click;
            // 
            // numupdownClassroomHeight
            // 
            numupdownClassroomHeight.Location = new Point(81, 64);
            numupdownClassroomHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomHeight.Name = "numupdownClassroomHeight";
            numupdownClassroomHeight.Size = new Size(50, 23);
            numupdownClassroomHeight.TabIndex = 3;
            numupdownClassroomHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomHeight.ValueChanged += numupdownClassroomHeight_ValueChanged;
            // 
            // lblUpravaTrid
            // 
            lblUpravaTrid.AutoSize = true;
            lblUpravaTrid.Location = new Point(62, 66);
            lblUpravaTrid.Name = "lblUpravaTrid";
            lblUpravaTrid.Size = new Size(13, 15);
            lblUpravaTrid.TabIndex = 2;
            lblUpravaTrid.Text = "x";
            // 
            // numupdownClassroomWidth
            // 
            numupdownClassroomWidth.Location = new Point(6, 64);
            numupdownClassroomWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomWidth.Name = "numupdownClassroomWidth";
            numupdownClassroomWidth.Size = new Size(50, 23);
            numupdownClassroomWidth.TabIndex = 1;
            numupdownClassroomWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numupdownClassroomWidth.ValueChanged += numupdownClassroomWidth_ValueChanged;
            // 
            // combobxVyberTrid
            // 
            combobxVyberTrid.FormattingEnabled = true;
            combobxVyberTrid.Items.AddRange(new object[] { "Nový" });
            combobxVyberTrid.Location = new Point(6, 6);
            combobxVyberTrid.Name = "combobxVyberTrid";
            combobxVyberTrid.Size = new Size(125, 23);
            combobxVyberTrid.TabIndex = 0;
            combobxVyberTrid.SelectedIndexChanged += combobxVyberTrid_SelectedIndexChanged;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, dataToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikaciToolStripMenuItem, nápovědaToolStripMenuItem, ukončitToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(52, 20);
            souborToolStripMenuItem.Text = "SediM";
            // 
            // oAplikaciToolStripMenuItem
            // 
            oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            oAplikaciToolStripMenuItem.Size = new Size(128, 22);
            oAplikaciToolStripMenuItem.Text = "O aplikaci";
            oAplikaciToolStripMenuItem.Click += oAplikaciToolStripMenuItem_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(128, 22);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // ukončitToolStripMenuItem
            // 
            ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            ukončitToolStripMenuItem.Size = new Size(128, 22);
            ukončitToolStripMenuItem.Text = "Konec";
            ukončitToolStripMenuItem.Click += ukončitToolStripMenuItem_Click;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(43, 20);
            dataToolStripMenuItem.Text = "Data";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(110, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripProgressBar, toolStripStatusLabel });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jmeno_prijmeni;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn skola;
        private DataGridViewTextBoxColumn rocnik;
        private DataGridViewTextBoxColumn souradnice;
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
        private TextBox txtxbxNazevTridy;
    }
}