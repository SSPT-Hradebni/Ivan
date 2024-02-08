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
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.učitelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamUčitelůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.školaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamŠkolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.třídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamTřídToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.novéRozsazenítoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitRozsazenítoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
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
            this.dataToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.učitelToolStripMenuItem,
            this.školaToolStripMenuItem,
            this.třídaToolStripMenuItem});
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
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.oAplikaciToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.Image = global::SediM.Properties.Resources.Help_and_Support;
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            this.nápovědaToolStripMenuItem.Click += new System.EventHandler(this.nápovědaToolStripMenuItem_Click);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Image = global::SediM.Properties.Resources.Power;
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ukončitToolStripMenuItem.Text = "Konec";
            this.ukončitToolStripMenuItem.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::SediM.Properties.Resources.Fax_Received_Succesfully;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::SediM.Properties.Resources.Fax_Sent_Succesfully;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem,
            this.upravitToolStripMenuItem,
            this.seznamToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // novýToolStripMenuItem
            // 
            this.novýToolStripMenuItem.Image = global::SediM.Properties.Resources.Add;
            this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            this.novýToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novýToolStripMenuItem.Text = "Nový student";
            this.novýToolStripMenuItem.Click += new System.EventHandler(this.novýToolStripMenuItem_Click);
            // 
            // upravitToolStripMenuItem
            // 
            this.upravitToolStripMenuItem.Image = global::SediM.Properties.Resources.OE_Signature;
            this.upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            this.upravitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.upravitToolStripMenuItem.Text = "Upravit studenta";
            this.upravitToolStripMenuItem.Click += new System.EventHandler(this.upravitToolStripMenuItem_Click);
            // 
            // seznamToolStripMenuItem
            // 
            this.seznamToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts;
            this.seznamToolStripMenuItem.Name = "seznamToolStripMenuItem";
            this.seznamToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.seznamToolStripMenuItem.Text = "Seznam studentů";
            this.seznamToolStripMenuItem.Click += new System.EventHandler(this.seznamToolStripMenuItem_Click);
            // 
            // učitelToolStripMenuItem
            // 
            this.učitelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem1,
            this.upravitToolStripMenuItem1,
            this.seznamUčitelůToolStripMenuItem});
            this.učitelToolStripMenuItem.Name = "učitelToolStripMenuItem";
            this.učitelToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.učitelToolStripMenuItem.Text = "Učitel";
            // 
            // novýToolStripMenuItem1
            // 
            this.novýToolStripMenuItem1.Image = global::SediM.Properties.Resources.Add;
            this.novýToolStripMenuItem1.Name = "novýToolStripMenuItem1";
            this.novýToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.novýToolStripMenuItem1.Text = "Nový učitel";
            // 
            // upravitToolStripMenuItem1
            // 
            this.upravitToolStripMenuItem1.Image = global::SediM.Properties.Resources.OE_Signature;
            this.upravitToolStripMenuItem1.Name = "upravitToolStripMenuItem1";
            this.upravitToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.upravitToolStripMenuItem1.Text = "Upravit učitele";
            // 
            // seznamUčitelůToolStripMenuItem
            // 
            this.seznamUčitelůToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts;
            this.seznamUčitelůToolStripMenuItem.Name = "seznamUčitelůToolStripMenuItem";
            this.seznamUčitelůToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.seznamUčitelůToolStripMenuItem.Text = "Seznam učitelů";
            // 
            // školaToolStripMenuItem
            // 
            this.školaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováToolStripMenuItem,
            this.upravitToolStripMenuItem2,
            this.seznamŠkolToolStripMenuItem});
            this.školaToolStripMenuItem.Name = "školaToolStripMenuItem";
            this.školaToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.školaToolStripMenuItem.Text = "Škola";
            // 
            // nováToolStripMenuItem
            // 
            this.nováToolStripMenuItem.Image = global::SediM.Properties.Resources.Add;
            this.nováToolStripMenuItem.Name = "nováToolStripMenuItem";
            this.nováToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.nováToolStripMenuItem.Text = "Nová škola";
            // 
            // upravitToolStripMenuItem2
            // 
            this.upravitToolStripMenuItem2.Image = global::SediM.Properties.Resources.OE_Signature;
            this.upravitToolStripMenuItem2.Name = "upravitToolStripMenuItem2";
            this.upravitToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.upravitToolStripMenuItem2.Text = "Upravit školu";
            // 
            // seznamŠkolToolStripMenuItem
            // 
            this.seznamŠkolToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts;
            this.seznamŠkolToolStripMenuItem.Name = "seznamŠkolToolStripMenuItem";
            this.seznamŠkolToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.seznamŠkolToolStripMenuItem.Text = "Seznam škol";
            // 
            // třídaToolStripMenuItem
            // 
            this.třídaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováToolStripMenuItem1,
            this.upravitToolStripMenuItem3,
            this.seznamTřídToolStripMenuItem,
            this.toolStripSeparator1,
            this.novéRozsazenítoolStripMenuItem1,
            this.upravitRozsazenítoolStripMenuItem1});
            this.třídaToolStripMenuItem.Name = "třídaToolStripMenuItem";
            this.třídaToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.třídaToolStripMenuItem.Text = "Třída";
            // 
            // nováToolStripMenuItem1
            // 
            this.nováToolStripMenuItem1.Image = global::SediM.Properties.Resources.Add;
            this.nováToolStripMenuItem1.Name = "nováToolStripMenuItem1";
            this.nováToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.nováToolStripMenuItem1.Text = "Nová třída";
            this.nováToolStripMenuItem1.Click += new System.EventHandler(this.nováToolStripMenuItem1_Click);
            // 
            // upravitToolStripMenuItem3
            // 
            this.upravitToolStripMenuItem3.Image = global::SediM.Properties.Resources.OE_Signature;
            this.upravitToolStripMenuItem3.Name = "upravitToolStripMenuItem3";
            this.upravitToolStripMenuItem3.Size = new System.Drawing.Size(163, 22);
            this.upravitToolStripMenuItem3.Text = "Upravit třídu";
            // 
            // seznamTřídToolStripMenuItem
            // 
            this.seznamTřídToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts;
            this.seznamTřídToolStripMenuItem.Name = "seznamTřídToolStripMenuItem";
            this.seznamTřídToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.seznamTřídToolStripMenuItem.Text = "Seznam tříd";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // novéRozsazenítoolStripMenuItem1
            // 
            this.novéRozsazenítoolStripMenuItem1.Image = global::SediM.Properties.Resources.Add;
            this.novéRozsazenítoolStripMenuItem1.Name = "novéRozsazenítoolStripMenuItem1";
            this.novéRozsazenítoolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.novéRozsazenítoolStripMenuItem1.Text = "Nové rozsazení";
            this.novéRozsazenítoolStripMenuItem1.Click += new System.EventHandler(this.noveRozsazeniToolStripMenuItem_Click);
            // 
            // upravitRozsazenítoolStripMenuItem1
            // 
            this.upravitRozsazenítoolStripMenuItem1.Image = global::SediM.Properties.Resources.OE_Signature;
            this.upravitRozsazenítoolStripMenuItem1.Name = "upravitRozsazenítoolStripMenuItem1";
            this.upravitRozsazenítoolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.upravitRozsazenítoolStripMenuItem1.Text = "Upravit rozsazení";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1001, 494);
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
    }
}