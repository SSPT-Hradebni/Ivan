using System.ComponentModel;

namespace Ivan.Controls
{
    public partial class MenuItem : Button
    {
        public MenuItem()
        {
            InitializeComponent();
        }

        [Category("Vzhled")]
        public Image ItemImage { get; set; } = null;

        [Category("Vzhled")]
        public string ItemText { get; set; } = null;

        protected void TriggerClick(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                base.OnClick(e);
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            if (this.Enabled)
            {
                base.OnDoubleClick(e);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            base.OnMouseClick(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            base.OnMouseDoubleClick(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.Click += this.TriggerClick;

            this.picboxItem.Image = ItemImage;
            this.lblItem.Text = ItemText;

        }
    }
}
