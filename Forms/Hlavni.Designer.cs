namespace Ivan.Forms
{
    partial class Hlavni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hlavni));
            this.appNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAppNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaKAppNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitIvanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApp = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuItem_StudentNovy = new Ivan.Controls.MenuItem();
            this.menuApp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appNameToolStripMenuItem
            // 
            this.appNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAppNameToolStripMenuItem,
            this.nápovědaKAppNameToolStripMenuItem,
            this.ukončitIvanaToolStripMenuItem});
            this.appNameToolStripMenuItem.Name = "appNameToolStripMenuItem";
            this.appNameToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.appNameToolStripMenuItem.Text = "Ivan";
            // 
            // oAppNameToolStripMenuItem
            // 
            this.oAppNameToolStripMenuItem.Name = "oAppNameToolStripMenuItem";
            this.oAppNameToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.oAppNameToolStripMenuItem.Text = "O Ivanovi";
            // 
            // nápovědaKAppNameToolStripMenuItem
            // 
            this.nápovědaKAppNameToolStripMenuItem.Name = "nápovědaKAppNameToolStripMenuItem";
            this.nápovědaKAppNameToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nápovědaKAppNameToolStripMenuItem.Text = "Nápověda k Ivanovi";
            // 
            // ukončitIvanaToolStripMenuItem
            // 
            this.ukončitIvanaToolStripMenuItem.Name = "ukončitIvanaToolStripMenuItem";
            this.ukončitIvanaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ukončitIvanaToolStripMenuItem.Text = "Ukončit Ivana";
            // 
            // menuApp
            // 
            this.menuApp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appNameToolStripMenuItem});
            this.menuApp.Location = new System.Drawing.Point(0, 0);
            this.menuApp.Name = "menuApp";
            this.menuApp.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuApp.Size = new System.Drawing.Size(600, 24);
            this.menuApp.TabIndex = 0;
            this.menuApp.Text = "Hlavní menu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(600, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studenti";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.menuItem_StudentNovy, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuItem_StudentNovy
            // 
            this.menuItem_StudentNovy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuItem_StudentNovy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuItem_StudentNovy.ItemImage = global::Ivan.Properties.Resources.student;
            this.menuItem_StudentNovy.ItemText = "Nový";
            this.menuItem_StudentNovy.Location = new System.Drawing.Point(4, 4);
            this.menuItem_StudentNovy.Margin = new System.Windows.Forms.Padding(4);
            this.menuItem_StudentNovy.Name = "menuItem_StudentNovy";
            this.menuItem_StudentNovy.Size = new System.Drawing.Size(67, 94);
            this.menuItem_StudentNovy.TabIndex = 0;
            this.menuItem_StudentNovy.Click += new System.EventHandler(this.menuItem_StudentNovy_Click);
            // 
            // Hlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuApp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuApp;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Hlavni";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hlavní okno";
            this.Load += new System.EventHandler(this.Hlavni_Load);
            this.menuApp.ResumeLayout(false);
            this.menuApp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem appNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAppNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nápovědaKAppNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukončitIvanaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.MenuItem menuItem_StudentNovy;
    }
}