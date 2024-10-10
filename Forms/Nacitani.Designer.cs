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
            components = new System.ComponentModel.Container();
            loading = new System.Windows.Forms.Timer(components);
            loadingBar = new ProgressBar();
            lblCopyright = new Label();
            lblAutori = new Label();
            lblTip = new Label();
            SuspendLayout();
            // 
            // loading
            // 
            loading.Tick += loading_Tick;
            // 
            // loadingBar
            // 
            loadingBar.Dock = DockStyle.Bottom;
            loadingBar.Location = new Point(0, 757);
            loadingBar.Margin = new Padding(4, 5, 4, 5);
            loadingBar.Name = "loadingBar";
            loadingBar.Size = new Size(1197, 22);
            loadingBar.TabIndex = 0;
            // 
            // lblCopyright
            // 
            lblCopyright.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCopyright.BackColor = Color.White;
            lblCopyright.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCopyright.Location = new Point(61, 200);
            lblCopyright.Margin = new Padding(4, 0, 4, 0);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(488, 26);
            lblCopyright.TabIndex = 1;
            lblCopyright.Text = "© 2023-2024 ŠSPT. Všechna práva vyhrazena.";
            lblCopyright.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAutori
            // 
            lblAutori.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAutori.BackColor = Color.White;
            lblAutori.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAutori.Location = new Point(61, 328);
            lblAutori.Margin = new Padding(4, 0, 4, 0);
            lblAutori.Name = "lblAutori";
            lblAutori.Size = new Size(488, 180);
            lblAutori.TabIndex = 2;
            lblAutori.Text = "Petr Vurm, Radek Kalous, Jan Píša, Petr Šalda, Štěpán Vodička, Jonáš Vitásek, Filip Richter, Adam Částek, Vojta Bednář";
            // 
            // lblTip
            // 
            lblTip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTip.AutoEllipsis = true;
            lblTip.BackColor = Color.White;
            lblTip.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTip.Location = new Point(61, 266);
            lblTip.Margin = new Padding(4, 0, 4, 0);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(488, 26);
            lblTip.TabIndex = 3;
            lblTip.Text = "Akce načítání";
            lblTip.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Nacitani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.loadingBG;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1197, 779);
            Controls.Add(lblTip);
            Controls.Add(lblAutori);
            Controls.Add(lblCopyright);
            Controls.Add(loadingBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Nacitani";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SW";
            TransparencyKey = Color.DeepPink;
            Load += Nacitani_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer loading;
        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblAutori;
        private System.Windows.Forms.Label lblTip;
    }
}

