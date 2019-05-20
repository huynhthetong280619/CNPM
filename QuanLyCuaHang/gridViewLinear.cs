using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    class gridViewLinear:BunifuCustomDataGrid
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        //protected override void PaintBackgound(PaintEventArgs e)
        //{
        //    LinearGradientBrush gradientColor = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
        //    Graphics g = e.Graphics;
        //    g.FillRectangle(gradientColor, this.ClientRectangle);
        //    base.OnPaint(e);
        //}

        protected override void PaintBackground(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);

            System.Drawing.Drawing2D.LinearGradientBrush gradientColor = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            graphics.FillRectangle(gradientColor, clipBounds);
        }
    }
}
