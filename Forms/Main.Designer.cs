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
            školaToolStripMenuItem = new ToolStripMenuItem();
            novaSkolaToolStripMenuItem = new ToolStripMenuItem();
            upravitSkoluToolStripMenuItem = new ToolStripMenuItem();
            seznamSkolToolStripMenuItem = new ToolStripMenuItem();
            třídaToolStripMenuItem = new ToolStripMenuItem();
            novaUcebnaToolStripMenuItem = new ToolStripMenuItem();
            upravitUcebnuToolStripMenuItem = new ToolStripMenuItem();
            seznamUcebenToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            RozsazenitoolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, studentToolStripMenuItem, školaToolStripMenuItem, třídaToolStripMenuItem });
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
            novyZakToolStripMenuItem.Size = new Size(142, 22);
            novyZakToolStripMenuItem.Text = "Nový žák";
            novyZakToolStripMenuItem.Click += novyZakToolStripMenuItem_Click;
            // 
            // upravitZakaToolStripMenuItem
            // 
            upravitZakaToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitZakaToolStripMenuItem.Name = "upravitZakaToolStripMenuItem";
            upravitZakaToolStripMenuItem.Size = new Size(142, 22);
            upravitZakaToolStripMenuItem.Text = "Upravit žáka";
            upravitZakaToolStripMenuItem.Click += upravitZakaToolStripMenuItem_Click;
            // 
            // seznamZakuToolStripMenuItem
            // 
            seznamZakuToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamZakuToolStripMenuItem.Name = "seznamZakuToolStripMenuItem";
            seznamZakuToolStripMenuItem.Size = new Size(142, 22);
            seznamZakuToolStripMenuItem.Text = "Seznam žáků";
            seznamZakuToolStripMenuItem.Click += seznamZakuToolStripMenuItem_Click;
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
            novaSkolaToolStripMenuItem.Size = new Size(184, 26);
            novaSkolaToolStripMenuItem.Text = "Nová škola";
            novaSkolaToolStripMenuItem.Click += novaSkolaToolStripMenuItem_Click;
            // 
            // upravitSkoluToolStripMenuItem
            // 
            upravitSkoluToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitSkoluToolStripMenuItem.Name = "upravitSkoluToolStripMenuItem";
            upravitSkoluToolStripMenuItem.Size = new Size(184, 26);
            upravitSkoluToolStripMenuItem.Text = "Upravit školu";
            upravitSkoluToolStripMenuItem.Click += upravitSkoluToolStripMenuItem_Click;
            // 
            // seznamSkolToolStripMenuItem
            // 
            seznamSkolToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamSkolToolStripMenuItem.Name = "seznamSkolToolStripMenuItem";
            seznamSkolToolStripMenuItem.Size = new Size(184, 26);
            seznamSkolToolStripMenuItem.Text = "Seznam škol";
            seznamSkolToolStripMenuItem.Click += seznamSkolToolStripMenuItem_Click;
            // 
            // třídaToolStripMenuItem
            // 
            třídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaUcebnaToolStripMenuItem, upravitUcebnuToolStripMenuItem, seznamUcebenToolStripMenuItem, toolStripSeparator1, RozsazenitoolStripMenuItem });
            třídaToolStripMenuItem.Name = "třídaToolStripMenuItem";
            třídaToolStripMenuItem.Size = new Size(59, 19);
            třídaToolStripMenuItem.Text = "Učebna";
            // 
            // novaUcebnaToolStripMenuItem
            // 
            novaUcebnaToolStripMenuItem.Image = Properties.Resources.Add1;
            novaUcebnaToolStripMenuItem.Name = "novaUcebnaToolStripMenuItem";
            novaUcebnaToolStripMenuItem.Size = new Size(184, 26);
            novaUcebnaToolStripMenuItem.Text = "Nová učebna";
            novaUcebnaToolStripMenuItem.Click += novaUcebnaToolStripMenuItem_Click;
            // 
            // upravitUcebnuToolStripMenuItem
            // 
            upravitUcebnuToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitUcebnuToolStripMenuItem.Name = "upravitUcebnuToolStripMenuItem";
            upravitUcebnuToolStripMenuItem.Size = new Size(184, 26);
            upravitUcebnuToolStripMenuItem.Text = "Upravit učebnu";
            upravitUcebnuToolStripMenuItem.Click += upravitUcebnuToolStripMenuItem_Click;
            // 
            // seznamUcebenToolStripMenuItem
            // 
            seznamUcebenToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamUcebenToolStripMenuItem.Name = "seznamUcebenToolStripMenuItem";
            seznamUcebenToolStripMenuItem.Size = new Size(184, 26);
            seznamUcebenToolStripMenuItem.Text = "Seznam učeben";
            seznamUcebenToolStripMenuItem.Click += seznamUcebenToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(181, 6);
            // 
            // RozsazenitoolStripMenuItem
            // 
            RozsazenitoolStripMenuItem.Image = Properties.Resources.Add1;
            RozsazenitoolStripMenuItem.Name = "RozsazenitoolStripMenuItem";
            RozsazenitoolStripMenuItem.Size = new Size(184, 26);
            RozsazenitoolStripMenuItem.Text = "Rozsazení";
            RozsazenitoolStripMenuItem.Click += RozsazenitoolStripMenuItem_Click;
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
        private ToolStripMenuItem školaToolStripMenuItem;
        private ToolStripMenuItem třídaToolStripMenuItem;
        private ToolStripMenuItem novyZakToolStripMenuItem;
        private ToolStripMenuItem upravitZakaToolStripMenuItem;
        private ToolStripMenuItem novaSkolaToolStripMenuItem;
        private ToolStripMenuItem upravitSkoluToolStripMenuItem;
        private ToolStripMenuItem novaUcebnaToolStripMenuItem;
        private ToolStripMenuItem upravitUcebnuToolStripMenuItem;
        private ToolStripMenuItem seznamZakuToolStripMenuItem;
        private ToolStripMenuItem seznamSkolToolStripMenuItem;
        private ToolStripMenuItem seznamUcebenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem RozsazenitoolStripMenuItem;
        private GroupBox groupBox_Studenti;
        private TableLayoutPanel tableLayout_Studenti;
        private PictureBox picbox_NovyZak;
    }
}