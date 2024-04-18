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
            this.napovedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukoncitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novyStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitStudentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamStudentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.učitelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novyUcitelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitUciteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamUciteluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.školaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaSkolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitSkoluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamSkolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.třídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaTridaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitTriduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamTridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.noveRozsazenitoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazitRozsazenitoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Studenti = new System.Windows.Forms.GroupBox();
            this.tableLayout_Studenti = new System.Windows.Forms.TableLayoutPanel();
            this.picbox_StudentNovy = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBox_Studenti.SuspendLayout();
            this.tableLayout_Studenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_StudentNovy)).BeginInit();
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
            this.novyStudentToolStripMenuItem,
            this.upravitStudentaToolStripMenuItem,
            this.seznamStudentuToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // novyStudentToolStripMenuItem
            // 
            this.novyStudentToolStripMenuItem.Image = global::SediM.Properties.Resources.Add1;
            this.novyStudentToolStripMenuItem.Name = "novyStudentToolStripMenuItem";
            this.novyStudentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novyStudentToolStripMenuItem.Text = "Nový student";
            this.novyStudentToolStripMenuItem.Click += new System.EventHandler(this.novyStudentToolStripMenuItem_Click);
            // 
            // upravitStudentaToolStripMenuItem
            // 
            this.upravitStudentaToolStripMenuItem.Image = global::SediM.Properties.Resources.OE_Signature1;
            this.upravitStudentaToolStripMenuItem.Name = "upravitStudentaToolStripMenuItem";
            this.upravitStudentaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.upravitStudentaToolStripMenuItem.Text = "Upravit studenta";
            this.upravitStudentaToolStripMenuItem.Click += new System.EventHandler(this.upravitStudentaToolStripMenuItem_Click);
            // 
            // seznamStudentuToolStripMenuItem
            // 
            this.seznamStudentuToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts1;
            this.seznamStudentuToolStripMenuItem.Name = "seznamStudentuToolStripMenuItem";
            this.seznamStudentuToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.seznamStudentuToolStripMenuItem.Text = "Seznam studentů";
            this.seznamStudentuToolStripMenuItem.Click += new System.EventHandler(this.seznamStudentuToolStripMenuItem_Click);
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
            this.novaTridaToolStripMenuItem,
            this.upravitTriduToolStripMenuItem,
            this.seznamTridToolStripMenuItem,
            this.toolStripSeparator1,
            this.noveRozsazenitoolStripMenuItem,
            this.zobrazitRozsazenitoolStripMenuItem});
            this.třídaToolStripMenuItem.Name = "třídaToolStripMenuItem";
            this.třídaToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.třídaToolStripMenuItem.Text = "Třída";
            // 
            // novaTridaToolStripMenuItem
            // 
            this.novaTridaToolStripMenuItem.Image = global::SediM.Properties.Resources.Add1;
            this.novaTridaToolStripMenuItem.Name = "novaTridaToolStripMenuItem";
            this.novaTridaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.novaTridaToolStripMenuItem.Text = "Nová třída";
            this.novaTridaToolStripMenuItem.Click += new System.EventHandler(this.novaTridaToolStripMenuItem_Click);
            // 
            // upravitTriduToolStripMenuItem
            // 
            this.upravitTriduToolStripMenuItem.Image = global::SediM.Properties.Resources.OE_Signature1;
            this.upravitTriduToolStripMenuItem.Name = "upravitTriduToolStripMenuItem";
            this.upravitTriduToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.upravitTriduToolStripMenuItem.Text = "Upravit třídu";
            this.upravitTriduToolStripMenuItem.Click += new System.EventHandler(this.upravitTriduToolStripMenuItem_Click);
            // 
            // seznamTridToolStripMenuItem
            // 
            this.seznamTridToolStripMenuItem.Image = global::SediM.Properties.Resources.User_Accounts1;
            this.seznamTridToolStripMenuItem.Name = "seznamTridToolStripMenuItem";
            this.seznamTridToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.seznamTridToolStripMenuItem.Text = "Seznam tříd";
            this.seznamTridToolStripMenuItem.Click += new System.EventHandler(this.seznamTridToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // noveRozsazenitoolStripMenuItem
            // 
            this.noveRozsazenitoolStripMenuItem.Image = global::SediM.Properties.Resources.Add1;
            this.noveRozsazenitoolStripMenuItem.Name = "noveRozsazenitoolStripMenuItem";
            this.noveRozsazenitoolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.noveRozsazenitoolStripMenuItem.Text = "Nové rozsazení";
            this.noveRozsazenitoolStripMenuItem.Click += new System.EventHandler(this.noveRozsazeniToolStripMenuItem_Click);
            // 
            // zobrazitRozsazenitoolStripMenuItem
            // 
            this.zobrazitRozsazenitoolStripMenuItem.Image = global::SediM.Properties.Resources.Search;
            this.zobrazitRozsazenitoolStripMenuItem.Name = "zobrazitRozsazenitoolStripMenuItem";
            this.zobrazitRozsazenitoolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.zobrazitRozsazenitoolStripMenuItem.Text = "Zobrazit rozsazení";
            this.zobrazitRozsazenitoolStripMenuItem.Click += new System.EventHandler(this.zobrazitRozsazenitoolStripMenuItem_Click);
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
            this.groupBox_Studenti.Text = "Studenti";
            // 
            // tableLayout_Studenti
            // 
            this.tableLayout_Studenti.ColumnCount = 5;
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Studenti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayout_Studenti.Controls.Add(this.picbox_StudentNovy, 0, 0);
            this.tableLayout_Studenti.Controls.Add(this.button1, 1, 0);
            this.tableLayout_Studenti.Controls.Add(this.button2, 2, 0);
            this.tableLayout_Studenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Studenti.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayout_Studenti.Location = new System.Drawing.Point(3, 23);
            this.tableLayout_Studenti.Name = "tableLayout_Studenti";
            this.tableLayout_Studenti.RowCount = 1;
            this.tableLayout_Studenti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Studenti.Size = new System.Drawing.Size(560, 91);
            this.tableLayout_Studenti.TabIndex = 0;
            // 
            // picbox_StudentNovy
            // 
            this.picbox_StudentNovy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_StudentNovy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox_StudentNovy.Image = global::SediM.Properties.Resources.IkonaMenu_Student;
            this.picbox_StudentNovy.Location = new System.Drawing.Point(3, 3);
            this.picbox_StudentNovy.Name = "picbox_StudentNovy";
            this.picbox_StudentNovy.Size = new System.Drawing.Size(78, 85);
            this.picbox_StudentNovy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_StudentNovy.TabIndex = 0;
            this.picbox_StudentNovy.TabStop = false;
            this.picbox_StudentNovy.Click += new System.EventHandler(this.picbox_StudentNovy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rozsadit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.noveRozsazeniToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zobrazit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.zobrazitRozsazenitoolStripMenuItem_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.picbox_StudentNovy)).EndInit();
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
        private ToolStripMenuItem novyStudentToolStripMenuItem;
        private ToolStripMenuItem upravitStudentaToolStripMenuItem;
        private ToolStripMenuItem novyUcitelToolStripMenuItem;
        private ToolStripMenuItem upravitUciteleToolStripMenuItem;
        private ToolStripMenuItem novaSkolaToolStripMenuItem;
        private ToolStripMenuItem upravitSkoluToolStripMenuItem;
        private ToolStripMenuItem novaTridaToolStripMenuItem;
        private ToolStripMenuItem upravitTriduToolStripMenuItem;
        private ToolStripMenuItem seznamStudentuToolStripMenuItem;
        private ToolStripMenuItem seznamUciteluToolStripMenuItem;
        private ToolStripMenuItem seznamSkolToolStripMenuItem;
        private ToolStripMenuItem seznamTridToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem noveRozsazenitoolStripMenuItem;
        private ToolStripMenuItem zobrazitRozsazenitoolStripMenuItem;
        private GroupBox groupBox_Studenti;
        private TableLayoutPanel tableLayout_Studenti;
        private PictureBox picbox_StudentNovy;
        private Button button1;
        private Button button2;
    }
}