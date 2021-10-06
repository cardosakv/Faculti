using System.Windows.Forms;

namespace Faculti.Misc
{
    /// <summary>
    /// Adds a fade-in and fade-out animation on forms.
    /// </summary>
    internal class FormAnimation
    {
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