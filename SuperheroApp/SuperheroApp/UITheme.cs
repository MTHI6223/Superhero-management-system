using System.Drawing;

namespace SuperheroApp
{
    /// <summary>
    /// Central palette and fonts for the comic-book UI theme.
    /// Keeps colors consistent across all controls in the application.
    /// </summary>
    public static class UITheme
    {
        // Core palette
        public static readonly Color Paper = Color.FromArgb(255, 249, 230);
        public static readonly Color Ink = Color.FromArgb(20, 20, 20);
        public static readonly Color White = Color.White;

        public static readonly Color Red = Color.FromArgb(200, 16, 46);
        public static readonly Color RedDark = Color.FromArgb(150, 10, 32);

        public static readonly Color Blue = Color.FromArgb(0, 87, 184);
        public static readonly Color BlueDark = Color.FromArgb(3, 60, 136);

        public static readonly Color Gold = Color.FromArgb(255, 212, 0);
        public static readonly Color GoldDark = Color.FromArgb(224, 175, 0);

        public static readonly Color Green = Color.FromArgb(30, 158, 80);
        public static readonly Color GreenDark = Color.FromArgb(20, 120, 58);

        public static readonly Color Orange = Color.FromArgb(240, 120, 0);

        // Grid theme
        public static readonly Color GridLine = Color.FromArgb(224, 220, 200);
        public static readonly Color AltRow = Color.FromArgb(255, 244, 194);
        public static readonly Color SelectionGold = Color.FromArgb(255, 212, 0);

        // Fonts
        public static readonly Font HeaderFont = new Font("Impact", 30F, FontStyle.Regular);
        public static readonly Font SubHeaderFont = new Font("Arial", 10F, FontStyle.Bold);
        public static readonly Font ComicFont = new Font("Arial Black", 10F, FontStyle.Regular);
        public static readonly Font LabelFont = new Font("Segoe UI", 9F, FontStyle.Bold);
        public static readonly Font GridFont = new Font("Segoe UI", 9F, FontStyle.Regular);
    }
}