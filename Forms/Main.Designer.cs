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
            napovedaToolStripMenuItem = new ToolStripMenuItem();
            ukoncitToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            novyZakToolStripMenuItem = new ToolStripMenuItem();
            upravitZakaToolStripMenuItem = new ToolStripMenuItem();
            seznamZakuToolStripMenuItem = new ToolStripMenuItem();
            učitelToolStripMenuItem = new ToolStripMenuItem();
            novyUcitelToolStripMenuItem = new ToolStripMenuItem();
            upravitUciteleToolStripMenuItem = new ToolStripMenuItem();
            seznamUciteluToolStripMenuItem = new ToolStripMenuItem();
            školaToolStripMenuItem = new ToolStripMenuItem();
            novaSkolaToolStripMenuItem = new ToolStripMenuItem();
            upravitSkoluToolStripMenuItem = new ToolStripMenuItem();
            seznamSkolToolStripMenuItem = new ToolStripMenuItem();
            třídaToolStripMenuItem = new ToolStripMenuItem();
            novaTridaToolStripMenuItem = new ToolStripMenuItem();
            upravitTriduToolStripMenuItem = new ToolStripMenuItem();
            seznamTridToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            noveRozsazenitoolStripMenuItem = new ToolStripMenuItem();
            zobrazitRozsazenitoolStripMenuItem = new ToolStripMenuItem();
            groupBox_Studenti = new GroupBox();
            tableLayout_Studenti = new TableLayoutPanel();
            picbox_NovyZak = new PictureBox();
            menuStrip.SuspendLayout();
            groupBox_Studenti.SuspendLayout();
            tableLayout_Studenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox_NovyZak).BeginInit();
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
            menuStrip.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, studentToolStripMenuItem, učitelToolStripMenuItem, školaToolStripMenuItem, třídaToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(566, 25);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikaciToolStripMenuItem, napovedaToolStripMenuItem, ukoncitToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(41, 19);
            souborToolStripMenuItem.Text = "Ivan";
            // 
            // oAplikaciToolStripMenuItem
            // 
            oAplikaciToolStripMenuItem.Image = Properties.Resources.Information1;
            oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            oAplikaciToolStripMenuItem.Size = new Size(128, 22);
            oAplikaciToolStripMenuItem.Text = "O aplikaci";
            oAplikaciToolStripMenuItem.Click += oAplikaciToolStripMenuItem_Click;
            // 
            // napovedaToolStripMenuItem
            // 
            napovedaToolStripMenuItem.Image = Properties.Resources.Help_and_Support1;
            napovedaToolStripMenuItem.Name = "napovedaToolStripMenuItem";
            napovedaToolStripMenuItem.Size = new Size(128, 22);
            napovedaToolStripMenuItem.Text = "Nápověda";
            napovedaToolStripMenuItem.Click += napovedaToolStripMenuItem_Click;
            // 
            // ukoncitToolStripMenuItem
            // 
            ukoncitToolStripMenuItem.Image = Properties.Resources.Power1;
            ukoncitToolStripMenuItem.Name = "ukoncitToolStripMenuItem";
            ukoncitToolStripMenuItem.Size = new Size(128, 22);
            ukoncitToolStripMenuItem.Text = "Konec";
            ukoncitToolStripMenuItem.Click += ukoncitToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novyZakToolStripMenuItem, upravitZakaToolStripMenuItem, seznamZakuToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(38, 19);
            studentToolStripMenuItem.Text = "Žák";
            // 
            // novyZakToolStripMenuItem
            // 
            novyZakToolStripMenuItem.Image = Properties.Resources.Add1;
            novyZakToolStripMenuItem.Name = "novyZakToolStripMenuItem";
            novyZakToolStripMenuItem.Size = new Size(184, 26);
            novyZakToolStripMenuItem.Text = "Nový žák";
            novyZakToolStripMenuItem.Click += novyZakToolStripMenuItem_Click;
            // 
            // upravitZakaToolStripMenuItem
            // 
            upravitZakaToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitZakaToolStripMenuItem.Name = "upravitZakaToolStripMenuItem";
            upravitZakaToolStripMenuItem.Size = new Size(184, 26);
            upravitZakaToolStripMenuItem.Text = "Upravit žáka";
            upravitZakaToolStripMenuItem.Click += upravitZakaToolStripMenuItem_Click;
            // 
            // seznamZakuToolStripMenuItem
            // 
            seznamZakuToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamZakuToolStripMenuItem.Name = "seznamZakuToolStripMenuItem";
            seznamZakuToolStripMenuItem.Size = new Size(184, 26);
            seznamZakuToolStripMenuItem.Text = "Seznam žáků";
            seznamZakuToolStripMenuItem.Click += seznamZakuToolStripMenuItem_Click;
            // 
            // učitelToolStripMenuItem
            // 
            učitelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novyUcitelToolStripMenuItem, upravitUciteleToolStripMenuItem, seznamUciteluToolStripMenuItem });
            učitelToolStripMenuItem.Name = "učitelToolStripMenuItem";
            učitelToolStripMenuItem.Size = new Size(49, 19);
            učitelToolStripMenuItem.Text = "Učitel";
            // 
            // novyUcitelToolStripMenuItem
            // 
            novyUcitelToolStripMenuItem.Image = Properties.Resources.Add1;
            novyUcitelToolStripMenuItem.Name = "novyUcitelToolStripMenuItem";
            novyUcitelToolStripMenuItem.Size = new Size(154, 22);
            novyUcitelToolStripMenuItem.Text = "Nový učitel";
            novyUcitelToolStripMenuItem.Click += novyUcitelToolStripMenuItem_Click;
            // 
            // upravitUciteleToolStripMenuItem
            // 
            upravitUciteleToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitUciteleToolStripMenuItem.Name = "upravitUciteleToolStripMenuItem";
            upravitUciteleToolStripMenuItem.Size = new Size(154, 22);
            upravitUciteleToolStripMenuItem.Text = "Upravit učitele";
            upravitUciteleToolStripMenuItem.Click += upravitUciteleToolStripMenuItem_Click;
            // 
            // seznamUciteluToolStripMenuItem
            // 
            seznamUciteluToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamUciteluToolStripMenuItem.Name = "seznamUciteluToolStripMenuItem";
            seznamUciteluToolStripMenuItem.Size = new Size(154, 22);
            seznamUciteluToolStripMenuItem.Text = "Seznam učitelů";
            seznamUciteluToolStripMenuItem.Click += seznamUciteluToolStripMenuItem_Click;
            // 
            // školaToolStripMenuItem
            // 
            školaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaSkolaToolStripMenuItem, upravitSkoluToolStripMenuItem, seznamSkolToolStripMenuItem });
            školaToolStripMenuItem.Name = "školaToolStripMenuItem";
            školaToolStripMenuItem.Size = new Size(47, 19);
            školaToolStripMenuItem.Text = "Škola";
            // 
            // novaSkolaToolStripMenuItem
            // 
            novaSkolaToolStripMenuItem.Image = Properties.Resources.Add1;
            novaSkolaToolStripMenuItem.Name = "novaSkolaToolStripMenuItem";
            novaSkolaToolStripMenuItem.Size = new Size(143, 22);
            novaSkolaToolStripMenuItem.Text = "Nová škola";
            novaSkolaToolStripMenuItem.Click += novaSkolaToolStripMenuItem_Click;
            // 
            // upravitSkoluToolStripMenuItem
            // 
            upravitSkoluToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitSkoluToolStripMenuItem.Name = "upravitSkoluToolStripMenuItem";
            upravitSkoluToolStripMenuItem.Size = new Size(143, 22);
            upravitSkoluToolStripMenuItem.Text = "Upravit školu";
            upravitSkoluToolStripMenuItem.Click += upravitSkoluToolStripMenuItem_Click;
            // 
            // seznamSkolToolStripMenuItem
            // 
            seznamSkolToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamSkolToolStripMenuItem.Name = "seznamSkolToolStripMenuItem";
            seznamSkolToolStripMenuItem.Size = new Size(143, 22);
            seznamSkolToolStripMenuItem.Text = "Seznam škol";
            seznamSkolToolStripMenuItem.Click += seznamSkolToolStripMenuItem_Click;
            // 
            // třídaToolStripMenuItem
            // 
            třídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaTridaToolStripMenuItem, upravitTriduToolStripMenuItem, seznamTridToolStripMenuItem, toolStripSeparator1, noveRozsazenitoolStripMenuItem, zobrazitRozsazenitoolStripMenuItem });
            třídaToolStripMenuItem.Name = "třídaToolStripMenuItem";
            třídaToolStripMenuItem.Size = new Size(44, 19);
            třídaToolStripMenuItem.Text = "Třída";
            // 
            // novaTridaToolStripMenuItem
            // 
            novaTridaToolStripMenuItem.Image = Properties.Resources.Add1;
            novaTridaToolStripMenuItem.Name = "novaTridaToolStripMenuItem";
            novaTridaToolStripMenuItem.Size = new Size(168, 22);
            novaTridaToolStripMenuItem.Text = "Nová třída";
            novaTridaToolStripMenuItem.Click += novaTridaToolStripMenuItem_Click;
            // 
            // upravitTriduToolStripMenuItem
            // 
            upravitTriduToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitTriduToolStripMenuItem.Name = "upravitTriduToolStripMenuItem";
            upravitTriduToolStripMenuItem.Size = new Size(168, 22);
            upravitTriduToolStripMenuItem.Text = "Upravit třídu";
            upravitTriduToolStripMenuItem.Click += upravitTriduToolStripMenuItem_Click;
            // 
            // seznamTridToolStripMenuItem
            // 
            seznamTridToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamTridToolStripMenuItem.Name = "seznamTridToolStripMenuItem";
            seznamTridToolStripMenuItem.Size = new Size(168, 22);
            seznamTridToolStripMenuItem.Text = "Seznam tříd";
            seznamTridToolStripMenuItem.Click += seznamTridToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(165, 6);
            // 
            // noveRozsazenitoolStripMenuItem
            // 
            noveRozsazenitoolStripMenuItem.Image = Properties.Resources.Add1;
            noveRozsazenitoolStripMenuItem.Name = "noveRozsazenitoolStripMenuItem";
            noveRozsazenitoolStripMenuItem.Size = new Size(168, 22);
            noveRozsazenitoolStripMenuItem.Text = "Nové rozsazení";
            noveRozsazenitoolStripMenuItem.Click += noveRozsazeniToolStripMenuItem_Click;
            // 
            // zobrazitRozsazenitoolStripMenuItem
            // 
            zobrazitRozsazenitoolStripMenuItem.Image = Properties.Resources.Search;
            zobrazitRozsazenitoolStripMenuItem.Name = "zobrazitRozsazenitoolStripMenuItem";
            zobrazitRozsazenitoolStripMenuItem.Size = new Size(168, 22);
            zobrazitRozsazenitoolStripMenuItem.Text = "Zobrazit rozsazení";
            zobrazitRozsazenitoolStripMenuItem.Click += zobrazitRozsazenitoolStripMenuItem_Click;
            // 
            // groupBox_Studenti
            // 
            groupBox_Studenti.Controls.Add(tableLayout_Studenti);
            groupBox_Studenti.Dock = DockStyle.Top;
            groupBox_Studenti.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_Studenti.Location = new Point(0, 25);
            groupBox_Studenti.Name = "groupBox_Studenti";
            groupBox_Studenti.Size = new Size(566, 117);
            groupBox_Studenti.TabIndex = 2;
            groupBox_Studenti.TabStop = false;
            groupBox_Studenti.Text = "Žáci";
            // 
            // tableLayout_Studenti
            // 
            tableLayout_Studenti.ColumnCount = 5;
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayout_Studenti.Controls.Add(picbox_NovyZak, 0, 0);
            tableLayout_Studenti.Dock = DockStyle.Fill;
            tableLayout_Studenti.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayout_Studenti.Location = new Point(3, 23);
            tableLayout_Studenti.Name = "tableLayout_Studenti";
            tableLayout_Studenti.RowCount = 1;
            tableLayout_Studenti.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout_Studenti.Size = new Size(560, 91);
            tableLayout_Studenti.TabIndex = 0;
            // 
            // picbox_NovyZak
            // 
            picbox_NovyZak.Cursor = Cursors.Hand;
            picbox_NovyZak.Dock = DockStyle.Fill;
            picbox_NovyZak.Image = Properties.Resources.IkonaMenu_Student;
            picbox_NovyZak.Location = new Point(3, 3);
            picbox_NovyZak.Name = "picbox_NovyZak";
            picbox_NovyZak.Size = new Size(78, 85);
            picbox_NovyZak.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_NovyZak.TabIndex = 0;
            picbox_NovyZak.TabStop = false;
            picbox_NovyZak.Click += picbox_NovyZak_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(566, 676);
            Controls.Add(groupBox_Studenti);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ivan";
            Load += Main_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBox_Studenti.ResumeLayout(false);
            tableLayout_Studenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picbox_NovyZak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem oAplikaciToolStripMenuItem;
        private ToolStripMenuItem napovedaToolStripMenuItem;
        private ToolStripMenuItem ukoncitToolStripMenuItem;
        private DataGridViewTextBoxColumn rocnik;
        private DataGridViewTextBoxColumn souradnice;
        private ListBox listBoxIdeckaStudentu;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem učitelToolStripMenuItem;
        private ToolStripMenuItem školaToolStripMenuItem;
        private ToolStripMenuItem třídaToolStripMenuItem;
        private ToolStripMenuItem novyZakToolStripMenuItem;
        private ToolStripMenuItem upravitZakaToolStripMenuItem;
        private ToolStripMenuItem novyUcitelToolStripMenuItem;
        private ToolStripMenuItem upravitUciteleToolStripMenuItem;
        private ToolStripMenuItem novaSkolaToolStripMenuItem;
        private ToolStripMenuItem upravitSkoluToolStripMenuItem;
        private ToolStripMenuItem novaTridaToolStripMenuItem;
        private ToolStripMenuItem upravitTriduToolStripMenuItem;
        private ToolStripMenuItem seznamZakuToolStripMenuItem;
        private ToolStripMenuItem seznamUciteluToolStripMenuItem;
        private ToolStripMenuItem seznamSkolToolStripMenuItem;
        private ToolStripMenuItem seznamTridToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem noveRozsazenitoolStripMenuItem;
        private ToolStripMenuItem zobrazitRozsazenitoolStripMenuItem;
        private GroupBox groupBox_Studenti;
        private TableLayoutPanel tableLayout_Studenti;
        private PictureBox picbox_NovyZak;
    }
}