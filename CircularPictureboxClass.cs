using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insuarance
{
    public class CircularPictureboxClass:PictureBox
    {
        protected override void OnPaint(PaintEventArgs prevent)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region = new System.Drawing.Region(p);
            //this.SizeMode = PictureBoxSizeMode.Zoom;
            base.OnPaint(prevent);
        }
    }
}
