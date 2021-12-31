using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passman
{
    public partial class CustomListView : System.Windows.Forms.ListView
    {
        public CustomListView()
        {
            InitializeComponent();
        }
        [DefaultValue("")]
        public string EmptyMessage { get; set; } = "";
        [DefaultValue(typeof(Color), "0xFF0000")]
        public Color EmptyMessageColor { get; set; }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xF)
            {
                if (this.Items.Count == 0)
                    using (var g = Graphics.FromHwnd(this.Handle))
                        TextRenderer.DrawText(g, EmptyMessage, Font, ClientRectangle, EmptyMessageColor);
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
