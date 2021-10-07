using System.Drawing;
using System.Windows.Forms;

namespace Faculti.UI
{
    internal class ControlInteractives
    {
        public static void SetLabelHover(Label label)
        {
            Color labelColor = label.ForeColor;
            label.MouseHover += (o, i) => { label.ForeColor = ChangeBrightness(labelColor, 1.15); };
            label.MouseLeave += (o, i) => { label.ForeColor = labelColor; };
        }

        private static Color ChangeBrightness(Color c, double factor)
        {
            // Returns a color changed to a certain brightness by a factor (< 1 = lower brightness).
            int r = (int)(c.R * factor) > 255 ? 255 : (int)(c.R * factor);
            int g = (int)(c.G * factor) > 255 ? 255 : (int)(c.G * factor);
            int b = (int)(c.B * factor) > 255 ? 255 : (int)(c.B * factor);

            return Color.FromArgb(r, g, b);
        }
    }
}