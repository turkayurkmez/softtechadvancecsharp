using Display.SDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.Library
{
    public class Circle : IPlug
    {
        public string Name => "Daire";

        public void Draw(Graphics graphics, SolidBrush brush, int x, int y, int width, int height)
        {
            graphics.FillEllipse(brush, x, y, width, height);
        }
    }
}
