using System;
using System.Collections.Generic;
using System.Drawing;

namespace Solmile.Forms.Themes
{
    public static class ThemeColor
    {
        // Single primary and secondary color that you can set from ColorList or elsewhere
        public static Color PrimaryColor { get; set; } = ColorTranslator.FromHtml("#111827"); // Default charcoal gray
        public static Color SecondaryColor { get; set; } = ColorTranslator.FromHtml("#718096"); // Default medium gray

        // Only gray colors are enabled here
        public static List<string> ColorList = new List<string>()
        {
            //"#111827", // Charcoal (very dark gray)
            //"#2D3748", // Dark slate gray
            "#4A5568", // Cool gray
            "#718096", // Medium gray
            "#E2E8F0"  // Light gray
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
