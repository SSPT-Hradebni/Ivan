namespace SediM
{
    partial class Nacitani
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loading = new System.Windows.Forms.Timer(this.components);
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblAutori = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.Tick += new System.EventHandler(this.loading_Tick);
            // 
            // loadingBar
            // 
            this.loadingBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingBar.Location = new System.Drawing.Point(0, 595);
            this.loadingBar.Margin = new System.Windows.Forms.Padding(4);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(1197, 28);
            this.loadingBar.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.BackColor = System.Drawing.Color.White;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCopyright.Location = new System.Drawing.Point(61, 160);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(488, 21);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "© 2023-2024 ŠSPT. Všechna práva vyhrazena.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAutori
            // 
            this.lblAutori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutori.BackColor = System.Drawing.Color.White;
            this.lblAutori.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutori.Location = new System.Drawing.Point(61, 262);
            this.lblAutori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutori.Name = "lblAutori";
            this.lblAutori.Size = new System.Drawing.Size(488, 144);
            this.lblAutori.TabIndex = 2;
            this.lblAutori.Text = "Petr Vurm, Radek Kalous, Jan Píša, Petr Šalda, Štěpán Vodička, Jonáš Vitásek, Fil" +
    "ip Richter, Adam Částek, Vojta Bednář";
            // 
            // lblTip
            // 
            this.lblTip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTip.AutoEllipsis = true;
            this.lblTip.BackColor = System.Drawing.Color.White;
            this.lblTip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.Location = new System.Drawing.Point(61, 213);
            this.lblTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(488, 21);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Akce načítání";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Nacitani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SediM.Properties.Resources.loadingBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1197, 623);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblAutori);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.loadingBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nacitani";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SW";
            this.TransparencyKey = System.Drawing.Color.DeepPink;
            this.Load += new System.EventHandler(this.Nacitani_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer loading;
        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblAutori;
        private System.Windows.Forms.Label lblTip;
    }
}

