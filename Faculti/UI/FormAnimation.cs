using System.Windows.Forms;

namespace Faculti.UI
{
    /// <summary>
    ///     Contains simple fade-in and fade-out animation on forms.
    /// </summary>
    internal class FormAnimation
    {
        /// <summary>
        ///     Adds a fade-in transition animation on forms.
        /// </summary>
        public static void FadeIn(Form form)
        {
            form.Opacity = 0;

            Timer fadeInTimer = new Timer { Interval = 30 };
            fadeInTimer.Start();
            fadeInTimer.Tick += (o, i) =>
            {
                if (form.Opacity == 1) fadeInTimer.Stop();
                form.Opacity += 0.2;
            };
        }

        /// <summary>
        ///     Adds a fade-out transition animation on forms.
        /// </summary>
        public static void FadeOut(Form form)
        {
            Timer fadeOutTimer = new Timer { Interval = 30 };
            fadeOutTimer.Start();
            fadeOutTimer.Tick += (o, i) =>
            {
                if (form.Opacity <= 0) fadeOutTimer.Stop();
                form.Opacity -= 0.2;
            };
        }
    }
}