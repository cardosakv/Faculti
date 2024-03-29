﻿using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;

namespace Faculti.UI
{
    /// <summary>
    ///     Contains events that trigger when a control is on focus.
    /// </summary>
    internal class ControlInteractives
    {
        /// <summary>
        ///     Sets the label fore color brighter when the control is hovered.
        /// </summary>
        public static void SetLabelHoverEvent(Label label)
        {
            Color labelColor = label.ForeColor;
            label.MouseHover += (o, i) => { label.ForeColor = ChangeBrightness(labelColor, 0.80); };
            label.MouseLeave += (o, i) => { label.ForeColor = labelColor; };
        }

        /// <summary>
        ///     Sets the button border and fill color to ligther when hovered.
        /// </summary>
        public static void SetButtonHoverEvent(BunifuButton2 button)
        {
            Color buttonColor = button.OnIdleState.FillColor;
            button.onHoverState.FillColor = ChangeBrightness(buttonColor, 0.80); 
            button.onHoverState.BorderColor = ChangeBrightness(buttonColor, 0.80);
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
        /// </param>
        /// 
        /// <returns>
        ///     Color object changed to a certain brightness by a factor.
        ///</returns>
        private static Color ChangeBrightness(Color c, double factor)
        {
            // Values allowed for factor:
            //      >1.0 = brighten
            //       1.0 = no effect
            //      <1.0 = darken
            int r = (int)(c.R * factor) > 255 ? 255 : (int)(c.R * factor);
            int g = (int)(c.G * factor) > 255 ? 255 : (int)(c.G * factor);
            int b = (int)(c.B * factor) > 255 ? 255 : (int)(c.B * factor);

            return Color.FromArgb(r, g, b);
        }

        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion
    }
}