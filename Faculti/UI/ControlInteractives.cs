using System.Drawing;
using System.Windows.Forms;

namespace Faculti.UI
{
    /// <summary>
    ///     Contains events that trigger when a control is on focus.
    /// </summary>
    internal class ControlInteractives
    {
        /// <summary>
        ///     Sets the label fore color brighten when the control is hovered.
        /// </summary>
        public static void SetLabelHover(Label label)
        {
            Color labelColor = label.ForeColor;
            label.MouseHover += (o, i) => { label.ForeColor = ChangeBrightness(labelColor, 1.15); };
            label.MouseLeave += (o, i) => { label.ForeColor = labelColor; };
        }

        /// <summary>
        ///     Change the brightness of a color to a certain degree.
        /// </summary>
        ///
        /// <param name="c">
        ///     Input Color object.
        /// </param>
        /// 
        /// <param name="factor">
        ///     Intensity of the color to brighten or darken. 
        ///         >1.0 = brighten
        ///          1.0 = no effect
        ///         <1.0 = darken
        /// </param>
        /// 
        /// <returns>
        ///     Color object changed to a certain brightness by a factor.
        /// </returns>
        private static Color ChangeBrightness(Color c, double factor)
        {
            int r = (int)(c.R * factor) > 255 ? 255 : (int)(c.R * factor);
            int g = (int)(c.G * factor) > 255 ? 255 : (int)(c.G * factor);
            int b = (int)(c.B * factor) > 255 ? 255 : (int)(c.B * factor);

            return Color.FromArgb(r, g, b);
        }
    }
}