using Display.SDK;
using System.Drawing;

namespace Display.Library
{
    public class Square : IPlug
    {
        public string Name => "Kare";

        public void Draw(Graphics graphics, SolidBrush brush, int x, int y, int width, int height)
        {
            graphics.FillRectangle(brush, x, y, width, height);
        }
    }
}