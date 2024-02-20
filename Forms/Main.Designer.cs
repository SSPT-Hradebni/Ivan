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
            groupBox_Studenti = new GroupBox();
            tableLayout_Studenti = new TableLayoutPanel();
            picbox_StudentNovy = new PictureBox();
            menuStrip.SuspendLayout();
            groupBox_Studenti.SuspendLayout();
            tableLayout_Studenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox_StudentNovy).BeginInit();
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
            menuStrip.Size = new Size(647, 32);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikaciToolStripMenuItem, nápovědaToolStripMenuItem, ukončitToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(50, 24);
            souborToolStripMenuItem.Text = "Ivan";
            // 
            // oAplikaciToolStripMenuItem
            // 
            oAplikaciToolStripMenuItem.Image = Properties.Resources.Information1;
            oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            oAplikaciToolStripMenuItem.Size = new Size(161, 26);
            oAplikaciToolStripMenuItem.Text = "O aplikaci";
            oAplikaciToolStripMenuItem.Click += oAplikaciToolStripMenuItem_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.Image = Properties.Resources.Help_and_Support1;
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(161, 26);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            nápovědaToolStripMenuItem.Click += nápovědaToolStripMenuItem_Click;
            // 
            // ukončitToolStripMenuItem
            // 
            ukončitToolStripMenuItem.Image = Properties.Resources.Power1;
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
            importToolStripMenuItem.Image = Properties.Resources.Fax_Received_Succesfully1;
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(137, 26);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Image = Properties.Resources.Fax_Sent_Succesfully1;
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
            novýToolStripMenuItem.Image = Properties.Resources.Add1;
            novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            novýToolStripMenuItem.Size = new Size(205, 26);
            novýToolStripMenuItem.Text = "Nový student";
            novýToolStripMenuItem.Click += novýToolStripMenuItem_Click;
            // 
            // upravitToolStripMenuItem
            // 
            upravitToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            upravitToolStripMenuItem.Size = new Size(205, 26);
            upravitToolStripMenuItem.Text = "Upravit studenta";
            upravitToolStripMenuItem.Click += upravitToolStripMenuItem_Click;
            // 
            // seznamToolStripMenuItem
            // 
            seznamToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamToolStripMenuItem.Name = "seznamToolStripMenuItem";
            seznamToolStripMenuItem.Size = new Size(205, 26);
            seznamToolStripMenuItem.Text = "Seznam studentů";
            seznamToolStripMenuItem.Click += seznamToolStripMenuItem_Click;
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
            novýToolStripMenuItem1.Image = Properties.Resources.Add1;
            novýToolStripMenuItem1.Name = "novýToolStripMenuItem1";
            novýToolStripMenuItem1.Size = new Size(192, 26);
            novýToolStripMenuItem1.Text = "Nový učitel";
            // 
            // upravitToolStripMenuItem1
            // 
            upravitToolStripMenuItem1.Image = Properties.Resources.OE_Signature1;
            upravitToolStripMenuItem1.Name = "upravitToolStripMenuItem1";
            upravitToolStripMenuItem1.Size = new Size(192, 26);
            upravitToolStripMenuItem1.Text = "Upravit učitele";
            // 
            // seznamUčitelůToolStripMenuItem
            // 
            seznamUčitelůToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
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
            nováToolStripMenuItem.Image = Properties.Resources.Add1;
            nováToolStripMenuItem.Name = "nováToolStripMenuItem";
            nováToolStripMenuItem.Size = new Size(224, 26);
            nováToolStripMenuItem.Text = "Nová škola";
            nováToolStripMenuItem.Click += nováToolStripMenuItem_Click;
            // 
            // upravitToolStripMenuItem2
            // 
            upravitToolStripMenuItem2.Image = Properties.Resources.OE_Signature1;
            upravitToolStripMenuItem2.Name = "upravitToolStripMenuItem2";
            upravitToolStripMenuItem2.Size = new Size(224, 26);
            upravitToolStripMenuItem2.Text = "Upravit školu";
            // 
            // seznamŠkolToolStripMenuItem
            // 
            seznamŠkolToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamŠkolToolStripMenuItem.Name = "seznamŠkolToolStripMenuItem";
            seznamŠkolToolStripMenuItem.Size = new Size(224, 26);
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
            nováToolStripMenuItem1.Image = Properties.Resources.Add1;
            nováToolStripMenuItem1.Name = "nováToolStripMenuItem1";
            nováToolStripMenuItem1.Size = new Size(224, 26);
            nováToolStripMenuItem1.Text = "Nová třída";
            nováToolStripMenuItem1.Click += nováToolStripMenuItem1_Click;
            // 
            // upravitToolStripMenuItem3
            // 
            upravitToolStripMenuItem3.Image = Properties.Resources.OE_Signature1;
            upravitToolStripMenuItem3.Name = "upravitToolStripMenuItem3";
            upravitToolStripMenuItem3.Size = new Size(224, 26);
            upravitToolStripMenuItem3.Text = "Upravit třídu";
            // 
            // seznamTřídToolStripMenuItem
            // 
            seznamTřídToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamTřídToolStripMenuItem.Name = "seznamTřídToolStripMenuItem";
            seznamTřídToolStripMenuItem.Size = new Size(224, 26);
            seznamTřídToolStripMenuItem.Text = "Seznam tříd";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // novéRozsazenítoolStripMenuItem1
            // 
            novéRozsazenítoolStripMenuItem1.Image = Properties.Resources.Add1;
            novéRozsazenítoolStripMenuItem1.Name = "novéRozsazenítoolStripMenuItem1";
            novéRozsazenítoolStripMenuItem1.Size = new Size(224, 26);
            novéRozsazenítoolStripMenuItem1.Text = "Nové rozsazení";
            novéRozsazenítoolStripMenuItem1.Click += noveRozsazeniToolStripMenuItem_Click;
            // 
            // upravitRozsazenítoolStripMenuItem1
            // 
            upravitRozsazenítoolStripMenuItem1.Image = Properties.Resources.OE_Signature1;
            upravitRozsazenítoolStripMenuItem1.Name = "upravitRozsazenítoolStripMenuItem1";
            upravitRozsazenítoolStripMenuItem1.Size = new Size(224, 26);
            upravitRozsazenítoolStripMenuItem1.Text = "Upravit rozsazení";
            // 
            // groupBox_Studenti
            // 
            groupBox_Studenti.Controls.Add(tableLayout_Studenti);
            groupBox_Studenti.Dock = DockStyle.Top;
            groupBox_Studenti.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_Studenti.Location = new Point(0, 32);
            groupBox_Studenti.Margin = new Padding(3, 4, 3, 4);
            groupBox_Studenti.Name = "groupBox_Studenti";
            groupBox_Studenti.Padding = new Padding(3, 4, 3, 4);
            groupBox_Studenti.Size = new Size(647, 156);
            groupBox_Studenti.TabIndex = 2;
            groupBox_Studenti.TabStop = false;
            groupBox_Studenti.Text = "Studenti";
            // 
            // tableLayout_Studenti
            // 
            tableLayout_Studenti.ColumnCount = 5;
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Studenti.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayout_Studenti.Controls.Add(picbox_StudentNovy, 0, 0);
            tableLayout_Studenti.Dock = DockStyle.Fill;
            tableLayout_Studenti.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayout_Studenti.Location = new Point(3, 29);
            tableLayout_Studenti.Margin = new Padding(3, 4, 3, 4);
            tableLayout_Studenti.Name = "tableLayout_Studenti";
            tableLayout_Studenti.RowCount = 1;
            tableLayout_Studenti.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout_Studenti.Size = new Size(641, 123);
            tableLayout_Studenti.TabIndex = 0;
            // 
            // picbox_StudentNovy
            // 
            picbox_StudentNovy.Cursor = Cursors.Hand;
            picbox_StudentNovy.Dock = DockStyle.Fill;
            picbox_StudentNovy.Image = Properties.Resources.IkonaMenu_Student;
            picbox_StudentNovy.Location = new Point(3, 4);
            picbox_StudentNovy.Margin = new Padding(3, 4, 3, 4);
            picbox_StudentNovy.Name = "picbox_StudentNovy";
            picbox_StudentNovy.Size = new Size(90, 115);
            picbox_StudentNovy.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_StudentNovy.TabIndex = 0;
            picbox_StudentNovy.TabStop = false;
            picbox_StudentNovy.Click += picbox_StudentNovy_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(647, 901);
            Controls.Add(groupBox_Studenti);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 5, 3, 5);
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
            ((System.ComponentModel.ISupportInitialize)picbox_StudentNovy).EndInit();
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
        private GroupBox groupBox_Studenti;
        private TableLayoutPanel tableLayout_Studenti;
        private PictureBox picbox_StudentNovy;
    }
}