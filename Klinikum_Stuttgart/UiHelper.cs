using System;
using System.Drawing;
using System.Windows.Forms;

namespace Klinikum_Stuttgart
{
    /// <summary>
    /// Sorgt dafuer, dass Fenster auf jedem Bildschirm sinnvoll erscheinen:
    /// zentriert, nie kleiner als das Design und nie groesser als der Arbeitsbereich.
    /// </summary>
    internal static class UiHelper
    {
        internal static void Anpassen(Form form)
        {
            if (form.StartPosition == FormStartPosition.WindowsDefaultLocation)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
            }

            Size entwurfsGroesse = form.Size;
            form.Load += delegate { FensterEinpassen(form, entwurfsGroesse); };
        }

        private static void FensterEinpassen(Form form, Size entwurfsGroesse)
        {
            Rectangle arbeitsbereich = Screen.FromControl(form).WorkingArea;

            int maximaleBreite = Math.Max(320, arbeitsbereich.Width - 60);
            int maximaleHoehe = Math.Max(240, arbeitsbereich.Height - 60);

            int minimaleBreite = Math.Min(entwurfsGroesse.Width, maximaleBreite);
            int minimaleHoehe = Math.Min(entwurfsGroesse.Height, maximaleHoehe);

            form.MinimumSize = new Size(minimaleBreite, minimaleHoehe);

            if (form.Width > maximaleBreite || form.Height > maximaleHoehe)
            {
                form.Size = new Size(
                    Math.Min(form.Width, maximaleBreite),
                    Math.Min(form.Height, maximaleHoehe));
            }
        }
    }
}
