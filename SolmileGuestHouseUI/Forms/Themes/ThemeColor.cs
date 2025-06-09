using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Solmile.Forms.Themes
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>()
{
    "#3F51B5", // Indigo
    "#009688", // Teal
    "#FF5722", // Deep Orange
    "#607D8B", // Blue Grey
    "#FF9800", // Orange
    "#9C27B0", // Purple
    "#2196F3", // Blue
    "#EA676C", // Soft Red
    "#E41A4A", // Dark Pink
    "#5978BB", // Steel Blue
    "#018790", // Dark Cyan
    "#0E3441", // Dark Slate
    "#00B0AD", // Turquoise
    "#721D47", // Maroon
    "#EA4833", // Bright Red
    "#EF937E", // Salmon
    "#F37521", // Bright Orange
    "#A12059", // Deep Pink
    "#126881", // Ocean Blue
    "#8BC240", // Lime Green
    "#364D5B", // Slate Grey
    "#C7DC5B", // Light Lime
    "#0094BC", // Cerulean
    "#E4126B", // Hot Pink
    "#43B76E", // Emerald Green
    "#7BCFE9", // Sky Blue
    "#B71C46", // Crimson
    "#FF6F61", // Coral
    "#6A1B9A", // Deep Purple
    "#00BCD4", // Cyan
    "#8D6E63", // Brown
    "#F44336", // Red
    "#4CAF50", // Green
    "#FFC107", // Amber
    "#795548", // Dark Brown
    "#9E9E9E", // Grey
    "#673AB7", // Deep Indigo
    "#FFEB3B", // Yellow
    "#03A9F4", // Light Blue
    "#E91E63", // Pink
    "#CDDC39", // Lime
    "#00ACC1", // Light Cyan
    "#FF7043", // Burnt Orange
    "#5C6BC0", // Periwinkle
    "#66BB6A", // Soft Green
    "#FFA726", // Light Orange
    "#8E24AA", // Violet
    "#FDD835", // Golden Yellow
    "#29B6F6", // Bright Blue
    "#EC407A", // Rose
    "#9CCC65", // Light Green
    "#FFB74D", // Peach
    "#7E57C2", // Lavender
    "#26A69A", // Teal Green
    "#D4E157", // Light Lime
    "#42A5F5", // Azure
    "#AB47BC", // Orchid
    "#FFCA28", // Light Amber
    "#5C6BC0", // Periwinkle
    "#66BB6A", // Soft Green
    "#FFA726", // Light Orange
    "#8E24AA", // Violet
    "#FDD835", // Golden Yellow
    "#29B6F6", // Bright Blue
    "#EC407A", // Rose
    "#9CCC65", // Light Green
    "#FFB74D", // Peach
    "#7E57C2", // Lavender
    "#26A69A", // Teal Green
    "#D4E157", // Light Lime
    "#42A5F5", // Azure
    "#AB47BC", // Orchid
    "#FFCA28", // Light Amber
    "#5C6BC0", // Periwinkle
    "#66BB6A", // Soft Green
    "#FFA726", // Light Orange
    "#8E24AA", // Violet
    "#FDD835", // Golden Yellow
    "#29B6F6", // Bright Blue
    "#EC407A", // Rose
    "#9CCC65", // Light Green
    "#FFB74D", // Peach
    "#7E57C2", // Lavender
    "#26A69A", // Teal Green
    "#D4E157", // Light Lime
    "#42A5F5", // Azure
    "#AB47BC", // Orchid
    "#FFCA28", // Light Amber
    "#5C6BC0", // Periwinkle
    "#66BB6A", // Soft Green
    "#FFA726", // Light Orange
    "#8E24AA", // Violet
    "#FDD835", // Golden Yellow
    "#29B6F6", // Bright Blue
    "#EC407A", // Rose
    "#9CCC65", // Light Green
    "#FFB74D", // Peach
    "#7E57C2", // Lavender
    "#26A69A", // Teal Green"
};

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
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
