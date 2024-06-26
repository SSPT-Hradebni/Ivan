﻿namespace SediM
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
            this.napovedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukoncitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novyZakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitZakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamZakuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.učitelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novyUcitelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitUciteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamUciteluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.školaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaSkolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitSkoluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamSkolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.třídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaUcebnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitUcebnuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamUcebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RozsazenitoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Studenti = new System.Windows.Forms.GroupBox();
            this.tableLayout_Studenti = new System.Windows.Forms.TableLayoutPanel();
            this.picbox_NovyZak = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.groupBox_Studenti.SuspendLayout();
            this.tableLayout_Studenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_NovyZak)).BeginInit();
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
            this.studentToolStripMenuItem,
            this.učitelToolStripMenuItem,
            this.školaToolStripMenuItem,
            this.třídaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(566, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikaciToolStripMenuItem,
            this.napovedaToolStripMenuItem,
            this.ukoncitToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.souborToolStripMenuItem.Text = "Ivan";
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.Image = global::SediM.Properties.Resources.Information1;
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.oAplikaciToolStripMenuItem_Click);
            // 
            // napovedaToolStripMenuItem
            // 
            this.napovedaToolStripMenuItem.Image = global::SediM.Properties.Resources.Help_and_Support1;
            this.napovedaToolStripMenuItem.Name = "napovedaToolStripMenuItem";
            this.napovedaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.napovedaToolStripMenuItem.Text = "Nápověda";
            this.napovedaToolStripMenuItem.Click += new System.EventHandler(this.napovedaToolStripMenuItem_Click);
            // 
            // ukoncitToolStripMenuItem
            // 
            this.ukoncitToolStripMenuItem.Image = global::SediM.Properties.Resources.Power1;
            this.ukoncitToolStripMenuItem.Name = "ukoncitToolStripMenuItem";
            this.ukoncitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ukoncitToolStripMenuItem.Text = "Konec";
            this.ukoncitToolStripMenuItem.Click += new System.EventHandler(this.ukoncitToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novyZakToolStripMenuItem,
            this.upravitZakaToolStripMenuItem,
            this.seznamZakuToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.studentToolStripMenuItem.Text = "Žák";
            // 
            // novyZakToolStripMenuItem
            // 
            this.novyZakToolStripMenuItem.Image = global::SediM.Properties.Resources.Add1;
            this.novyZakToolStripMenuItem.Name = "novyZakToolStripMenuItem";
            this.novyZakToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.novyZakToolStripMenuItem.Text = "Nový žák";
            this.novyZakToolStripMenuItem.Click += new System.EventHandler(this.novyZakToolStripMenuItem_Click);
            // 
            // upravitZakaToolStripMenuItem
            // 
            this.upravitZakaToolStripMenuItem.Image = global::SediM.Properties.Resources.OE_Signature1;
            this.upravitZakaToolStripMenuItem.Name = "upravitZakaToolStripMenuItem";
            this.upravitZakaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.upravitZakaToolStripMenuItem.Text = "Upravit žáka";
            this.upravitZakaToolStripMenuItem.Click += new System.EventHandler(this.upravitZakaToolStripMenuItem_Click);
            // 
            // seznamZakuToolStripMenuItem
            // 
            this.seznamZakuToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts1;
            this.seznamZakuToolStripMenuItem.Name = "seznamZakuToolStripMenuItem";
            this.seznamZakuToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.seznamZakuToolStripMenuItem.Text = "Seznam žáků";
            this.seznamZakuToolStripMenuItem.Click += new System.EventHandler(this.seznamZakuToolStripMenuItem_Click);
            // 
            // učitelToolStripMenuItem
            // 
            this.učitelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novyUcitelToolStripMenuItem,
            this.upravitUciteleToolStripMenuItem,
            this.seznamUciteluToolStripMenuItem});
            this.učitelToolStripMenuItem.Name = "učitelToolStripMenuItem";
            this.učitelToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.učitelToolStripMenuItem.Text = "Učitel";
            // 
            // novyUcitelToolStripMenuItem
            // 
            this.novyUcitelToolStripMenuItem.Image = global::SediM.Properties.Resources.Add1;
            this.novyUcitelToolStripMenuItem.Name = "novyUcitelToolStripMenuItem";
            this.novyUcitelToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.novyUcitelToolStripMenuItem.Text = "Nový učitel";
            this.novyUcitelToolStripMenuItem.Click += new System.EventHandler(this.novyUcitelToolStripMenuItem_Click);
            // 
            // upravitUciteleToolStripMenuItem
            // 
            this.upravitUciteleToolStripMenuItem.Image = global::SediM.Properties.Resources.OE_Signature1;
            this.upravitUciteleToolStripMenuItem.Name = "upravitUciteleToolStripMenuItem";
            this.upravitUciteleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.upravitUciteleToolStripMenuItem.Text = "Upravit učitele";
            this.upravitUciteleToolStripMenuItem.Click += new System.EventHandler(this.upravitUciteleToolStripMenuItem_Click);
            // 
            // seznamUciteluToolStripMenuItem
            // 
            this.seznamUciteluToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts1;
            this.seznamUciteluToolStripMenuItem.Name = "seznamUciteluToolStripMenuItem";
            this.seznamUciteluToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.seznamUciteluToolStripMenuItem.Text = "Seznam učitelů";
            this.seznamUciteluToolStripMenuItem.Click += new System.EventHandler(this.seznamUciteluToolStripMenuItem_Click);
            // 
            // školaToolStripMenuItem
            // 
            this.školaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaSkolaToolStripMenuItem,
            this.upravitSkoluToolStripMenuItem,
            this.seznamSkolToolStripMenuItem});
            this.školaToolStripMenuItem.Name = "školaToolStripMenuItem";
            this.školaToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.školaToolStripMenuItem.Text = "Škola";
            // 
            // novaSkolaToolStripMenuItem
            // 
            this.novaSkolaToolStripMenuItem.Image = global::SediM.Properties.Resources.Add1;
            this.novaSkolaToolStripMenuItem.Name = "novaSkolaToolStripMenuItem";
            this.novaSkolaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.novaSkolaToolStripMenuItem.Text = "Nová škola";
            this.novaSkolaToolStripMenuItem.Click += new System.EventHandler(this.novaSkolaToolStripMenuItem_Click);
            // 
            // upravitSkoluToolStripMenuItem
            // 
            this.upravitSkoluToolStripMenuItem.Image = global::SediM.Properties.Resources.OE_Signature1;
            this.upravitSkoluToolStripMenuItem.Name = "upravitSkoluToolStripMenuItem";
            this.upravitSkoluToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.upravitSkoluToolStripMenuItem.Text = "Upravit školu";
            this.upravitSkoluToolStripMenuItem.Click += new System.EventHandler(this.upravitSkoluToolStripMenuItem_Click);
            // 
            // seznamSkolToolStripMenuItem
            // 
            this.seznamSkolToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts1;
            this.seznamSkolToolStripMenuItem.Name = "seznamSkolToolStripMenuItem";
            this.seznamSkolToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.seznamSkolToolStripMenuItem.Text = "Seznam škol";
            this.seznamSkolToolStripMenuItem.Click += new System.EventHandler(this.seznamSkolToolStripMenuItem_Click);
            // 
            // třídaToolStripMenuItem
            // 
            this.třídaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaUcebnaToolStripMenuItem,
            this.upravitUcebnuToolStripMenuItem,
            this.seznamUcebenToolStripMenuItem,
            this.toolStripSeparator1,
            this.RozsazenitoolStripMenuItem});
            this.třídaToolStripMenuItem.Name = "třídaToolStripMenuItem";
            this.třídaToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.třídaToolStripMenuItem.Text = "Učebna";
            // 
            // novaUcebnaToolStripMenuItem
            // 
            this.novaUcebnaToolStripMenuItem.Image = global::SediM.Properties.Resources.Add1;
            this.novaUcebnaToolStripMenuItem.Name = "novaUcebnaToolStripMenuItem";
            this.novaUcebnaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.novaUcebnaToolStripMenuItem.Text = "Nová učebna";
            this.novaUcebnaToolStripMenuItem.Click += new System.EventHandler(this.novaUcebnaToolStripMenuItem_Click);
            // 
            // upravitUcebnuToolStripMenuItem
            // 
            this.upravitUcebnuToolStripMenuItem.Image = global::SediM.Properties.Resources.OE_Signature1;
            this.upravitUcebnuToolStripMenuItem.Name = "upravitUcebnuToolStripMenuItem";
            this.upravitUcebnuToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.upravitUcebnuToolStripMenuItem.Text = "Upravit učebnu";
            this.upravitUcebnuToolStripMenuItem.Click += new System.EventHandler(this.upravitUcebnuToolStripMenuItem_Click);
            // 
            // seznamUcebenToolStripMenuItem
            // 
            this.seznamUcebenToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts1;
            this.seznamUcebenToolStripMenuItem.Name = "seznamUcebenToolStripMenuItem";
            this.seznamUcebenToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.seznamUcebenToolStripMenuItem.Text = "Seznam učeben";
            this.seznamUcebenToolStripMenuItem.Click += new System.EventHandler(this.seznamUcebenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // RozsazenitoolStripMenuItem
            // 
            this.RozsazenitoolStripMenuItem.Image = global::SediM.Properties.Resources.Add1;
            this.RozsazenitoolStripMenuItem.Name = "RozsazenitoolStripMenuItem";
            this.RozsazenitoolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.RozsazenitoolStripMenuItem.Text = "Rozsazení";
            this.RozsazenitoolStripMenuItem.Click += new System.EventHandler(this.RozsazenitoolStripMenuItem_Click);
            // 
            // groupBox_Studenti
            // 
            this.groupBox_Studenti.Controls.Add(this.tableLayout_Studenti);
            this.groupBox_Studenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Studenti.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Studenti.Location = new System.Drawing.Point(0, 25);
            this.groupBox_Studenti.Name = "groupBox_Studenti";
            this.groupBox_Studenti.Size = new System.Drawing.Size(566, 117);
            this.groupBox_Studenti.TabIndex = 2;
            this.groupBox_Studenti.TabStop = false;
            this.groupBox_Studenti.Text = "Žáci";
            // 
            // tableLayout_Studenti
            // 
            this.tableLayout_Studenti.ColumnCount = 5;
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayout_Studenti.Controls.Add(this.picbox_NovyZak, 0, 0);
            this.tableLayout_Studenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Studenti.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayout_Studenti.Location = new System.Drawing.Point(3, 23);
            this.tableLayout_Studenti.Name = "tableLayout_Studenti";
            this.tableLayout_Studenti.RowCount = 1;
            this.tableLayout_Studenti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Studenti.Size = new System.Drawing.Size(560, 91);
            this.tableLayout_Studenti.TabIndex = 0;
            // 
            // picbox_NovyZak
            // 
            this.picbox_NovyZak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_NovyZak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox_NovyZak.Image = global::SediM.Properties.Resources.IkonaMenu_Student;
            this.picbox_NovyZak.Location = new System.Drawing.Point(3, 3);
            this.picbox_NovyZak.Name = "picbox_NovyZak";
            this.picbox_NovyZak.Size = new System.Drawing.Size(78, 85);
            this.picbox_NovyZak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_NovyZak.TabIndex = 0;
            this.picbox_NovyZak.TabStop = false;
            this.picbox_NovyZak.Click += new System.EventHandler(this.picbox_NovyZak_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(566, 676);
            this.Controls.Add(this.groupBox_Studenti);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ivan";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_Studenti.ResumeLayout(false);
            this.tableLayout_Studenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_NovyZak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripMenuItem novaUcebnaToolStripMenuItem;
        private ToolStripMenuItem upravitUcebnuToolStripMenuItem;
        private ToolStripMenuItem seznamZakuToolStripMenuItem;
        private ToolStripMenuItem seznamUciteluToolStripMenuItem;
        private ToolStripMenuItem seznamSkolToolStripMenuItem;
        private ToolStripMenuItem seznamUcebenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem RozsazenitoolStripMenuItem;
        private GroupBox groupBox_Studenti;
        private TableLayoutPanel tableLayout_Studenti;
        private PictureBox picbox_NovyZak;
    }
}