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
            menuStrip.SuspendLayout();
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
            menuStrip.BackColor = Color.Transparent;
            menuStrip.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, studentToolStripMenuItem, školaToolStripMenuItem, třídaToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 4, 0, 4);
            menuStrip.Size = new Size(1033, 32);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oAplikaciToolStripMenuItem, napovedaToolStripMenuItem, ukoncitToolStripMenuItem });
            souborToolStripMenuItem.ForeColor = Color.Black;
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(50, 24);
            souborToolStripMenuItem.Text = "Ivan";
            // 
            // oAplikaciToolStripMenuItem
            // 
            oAplikaciToolStripMenuItem.Image = Properties.Resources.Information1;
            oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            oAplikaciToolStripMenuItem.Size = new Size(224, 26);
            oAplikaciToolStripMenuItem.Text = "O aplikaci";
            oAplikaciToolStripMenuItem.Click += oAplikaciToolStripMenuItem_Click;
            // 
            // napovedaToolStripMenuItem
            // 
            napovedaToolStripMenuItem.Image = Properties.Resources.Help_and_Support1;
            napovedaToolStripMenuItem.Name = "napovedaToolStripMenuItem";
            napovedaToolStripMenuItem.Size = new Size(224, 26);
            napovedaToolStripMenuItem.Text = "Nápověda";
            napovedaToolStripMenuItem.Click += napovedaToolStripMenuItem_Click;
            // 
            // ukoncitToolStripMenuItem
            // 
            ukoncitToolStripMenuItem.Image = Properties.Resources.Power1;
            ukoncitToolStripMenuItem.Name = "ukoncitToolStripMenuItem";
            ukoncitToolStripMenuItem.Size = new Size(224, 26);
            ukoncitToolStripMenuItem.Text = "Konec";
            ukoncitToolStripMenuItem.Click += ukoncitToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novyZakToolStripMenuItem, upravitZakaToolStripMenuItem, seznamZakuToolStripMenuItem });
            studentToolStripMenuItem.ForeColor = Color.Black;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(47, 24);
            studentToolStripMenuItem.Text = "Žák";
            // 
            // novyZakToolStripMenuItem
            // 
            novyZakToolStripMenuItem.Image = Properties.Resources.Add1;
            novyZakToolStripMenuItem.Name = "novyZakToolStripMenuItem";
            novyZakToolStripMenuItem.Size = new Size(178, 26);
            novyZakToolStripMenuItem.Text = "Nový žák";
            novyZakToolStripMenuItem.Click += novyZakToolStripMenuItem_Click;
            // 
            // upravitZakaToolStripMenuItem
            // 
            upravitZakaToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitZakaToolStripMenuItem.Name = "upravitZakaToolStripMenuItem";
            upravitZakaToolStripMenuItem.Size = new Size(178, 26);
            upravitZakaToolStripMenuItem.Text = "Upravit žáka";
            upravitZakaToolStripMenuItem.Click += upravitZakaToolStripMenuItem_Click;
            // 
            // seznamZakuToolStripMenuItem
            // 
            seznamZakuToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamZakuToolStripMenuItem.Name = "seznamZakuToolStripMenuItem";
            seznamZakuToolStripMenuItem.Size = new Size(178, 26);
            seznamZakuToolStripMenuItem.Text = "Seznam žáků";
            seznamZakuToolStripMenuItem.Click += seznamZakuToolStripMenuItem_Click;
            // 
            // školaToolStripMenuItem
            // 
            školaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaSkolaToolStripMenuItem, upravitSkoluToolStripMenuItem, seznamSkolToolStripMenuItem });
            školaToolStripMenuItem.ForeColor = Color.Black;
            školaToolStripMenuItem.Name = "školaToolStripMenuItem";
            školaToolStripMenuItem.Size = new Size(59, 24);
            školaToolStripMenuItem.Text = "Škola";
            // 
            // novaSkolaToolStripMenuItem
            // 
            novaSkolaToolStripMenuItem.Image = Properties.Resources.Add1;
            novaSkolaToolStripMenuItem.Name = "novaSkolaToolStripMenuItem";
            novaSkolaToolStripMenuItem.Size = new Size(178, 26);
            novaSkolaToolStripMenuItem.Text = "Nová škola";
            novaSkolaToolStripMenuItem.Click += novaSkolaToolStripMenuItem_Click;
            // 
            // upravitSkoluToolStripMenuItem
            // 
            upravitSkoluToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitSkoluToolStripMenuItem.Name = "upravitSkoluToolStripMenuItem";
            upravitSkoluToolStripMenuItem.Size = new Size(178, 26);
            upravitSkoluToolStripMenuItem.Text = "Upravit školu";
            upravitSkoluToolStripMenuItem.Click += upravitSkoluToolStripMenuItem_Click;
            // 
            // seznamSkolToolStripMenuItem
            // 
            seznamSkolToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamSkolToolStripMenuItem.Name = "seznamSkolToolStripMenuItem";
            seznamSkolToolStripMenuItem.Size = new Size(178, 26);
            seznamSkolToolStripMenuItem.Text = "Seznam škol";
            seznamSkolToolStripMenuItem.Click += seznamSkolToolStripMenuItem_Click;
            // 
            // třídaToolStripMenuItem
            // 
            třídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaUcebnaToolStripMenuItem, upravitUcebnuToolStripMenuItem, seznamUcebenToolStripMenuItem, toolStripSeparator1, RozsazenitoolStripMenuItem });
            třídaToolStripMenuItem.ForeColor = Color.Black;
            třídaToolStripMenuItem.Name = "třídaToolStripMenuItem";
            třídaToolStripMenuItem.Size = new Size(73, 24);
            třídaToolStripMenuItem.Text = "Učebna";
            // 
            // novaUcebnaToolStripMenuItem
            // 
            novaUcebnaToolStripMenuItem.Image = Properties.Resources.Add1;
            novaUcebnaToolStripMenuItem.Name = "novaUcebnaToolStripMenuItem";
            novaUcebnaToolStripMenuItem.Size = new Size(224, 26);
            novaUcebnaToolStripMenuItem.Text = "Nová učebna";
            novaUcebnaToolStripMenuItem.Click += novaUcebnaToolStripMenuItem_Click;
            // 
            // upravitUcebnuToolStripMenuItem
            // 
            upravitUcebnuToolStripMenuItem.Image = Properties.Resources.OE_Signature1;
            upravitUcebnuToolStripMenuItem.Name = "upravitUcebnuToolStripMenuItem";
            upravitUcebnuToolStripMenuItem.Size = new Size(224, 26);
            upravitUcebnuToolStripMenuItem.Text = "Upravit učebnu";
            upravitUcebnuToolStripMenuItem.Click += upravitUcebnuToolStripMenuItem_Click;
            // 
            // seznamUcebenToolStripMenuItem
            // 
            seznamUcebenToolStripMenuItem.Image = Properties.Resources.User_Accounts1;
            seznamUcebenToolStripMenuItem.Name = "seznamUcebenToolStripMenuItem";
            seznamUcebenToolStripMenuItem.Size = new Size(224, 26);
            seznamUcebenToolStripMenuItem.Text = "Seznam učeben";
            seznamUcebenToolStripMenuItem.Click += seznamUcebenToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // RozsazenitoolStripMenuItem
            // 
            RozsazenitoolStripMenuItem.Image = Properties.Resources.Add1;
            RozsazenitoolStripMenuItem.Name = "RozsazenitoolStripMenuItem";
            RozsazenitoolStripMenuItem.Size = new Size(224, 26);
            RozsazenitoolStripMenuItem.Text = "Rozsazení";
            RozsazenitoolStripMenuItem.Click += RozsazenitoolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1033, 503);
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
    }
}