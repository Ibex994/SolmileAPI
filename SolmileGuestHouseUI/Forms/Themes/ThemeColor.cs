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
            // Sophisticated Neutrals
    "#2D3748", // Dark slate
    "#4A5568", // Cool gray
    "#718096", // Medium gray
    "#E2E8F0", // Light gray
    
    // Nature-Inspired
    "#38A169", // Emerald green
    "#2F855A", // Forest green
    "#68D391", // Mint green
    "#9AE6B4", // Soft green
    "#4299E1", // Sky blue
    "#3182CE", // Denim blue
    "#90CDF4", // Light blue
    "#ECC94B", // Golden yellow
    "#D69E2E", // Mustard
    "#ED8936", // Terracotta
    "#DD6B20", // Burnt orange
    
    // Elegant Jewel Tones
    "#6B46C1", // Amethyst
    "#805AD5", // Light purple
    "#B794F4", // Lavender
    "#553C9A", // Deep purple
    "#D53F8C", // Fuchsia
    "#F687B3", // Pink
    "#B83280", // Raspberry
    "#0BC5EA", // Cyan
    "#00B5D8", // Teal
    "#0987A0", // Dark teal
    
    // Modern Pastels
    "#BEE3F8", // Baby blue
    "#FED7D7", // Blush pink
    "#FEEDD3", // Peach
    "#C6F6D5", // Pale green
    "#E9D8FD", // Lilac
    
    // Vibrant Accents
    "#F56565", // Coral
    "#E53E3E", // Ruby red
    "#48BB78", // Jade
    "#38B2AC", // Turquoise
    "#4299E1", // Azure
    "#667EEA", // Cornflower
    "#764ABC", // Royal purple
    
    // Earth Tones
    "#C05621", // Rust
    "#9C4221", // Clay
    "#744210", // Brown
    "#5F370E", // Dark brown
    "#975A16", // Amber
    
    // Cool Blues/Greens
    "#2C5282", // Navy
    "#1A365D", // Midnight blue
    "#234E52", // Dark teal
    "#285E61", // Ocean green
    "#38B2AC", // Aqua
    
    // Warm Oranges/Reds
    "#C53030", // Crimson
    "#9B2C2C", // Burgundy
    "#E02424", // Bright red
    "#DD6B20", // Pumpkin
    "#ED8936", // Sunset
    "#F6AD55", // Peach
    
    // Unique Specials
    "#6EE7B7", // Seafoam
    "#A3BFFA", // Periwinkle
    "#D6BCFA", // Wisteria
    "#F687B3", // Cotton candy
    "#FC8181", // Salmon
    "#63B3ED", // Pool blue
    "#68D391", // Fresh green
    "#F6E05E", // Lemon
    "#F6AD55", // Apricot
    "#F687B3", // Bubblegum
    //
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
    //
    "#1F2937", // Charcoal
    "#374151", // Blue Gray
    "#F3F4F6", // Light Silver
    "#E5E7EB", // Cool Gray
    "#3B82F6", // Blue (Vibrant)
    "#60A5FA", // Soft Blue
    "#2563EB", // Royal Blue
    "#9333EA", // Vivid Purple
    "#A855F7", // Bright Lilac
    "#F59E0B", // Amber Orange
    "#84CC16", // Lime
    "#14B8A6", // Aqua Green
    "#0D9488", // Deep Aqua
    "#F43F5E", // Pinkish Red
    "#E11D48", // Cherry
    "#BE123C", // Dark Crimson
    "#22C55E", // Bright Green
    "#15803D", // Forest Green
    "#F87171", // Light Coral
    "#FB923C", // Orange
    "#FBBF24", // Bright Amber
    "#64748B", // Slate
    "#A1A1AA", // Ash Gray
    "#E879F9", // Soft Pink Purple
    "#C084FC", // Muted Purple
    "#818CF8", // Soft Indigo
    "#FCD34D", // Light Gold
    "#EF4444", // Bright Red
    "#A3A3A3", // Medium Gray
    "#5EEAD4", // Light Aqua
    "#FBCFE8", // Light Pink
    "#F5D0FE", // Cotton Pink
    "#DBEAFE", // Pale Blue
    "#FDE68A", // Lemon Yellow
    "#FCA5A5", // Pastel Red
    "#BBF7D0", // Mint Green
    "#D1FAE5", // Pale Teal
    "#C7D2FE", // Soft Periwinkle
    "#DDD6FE", // Light Lavender
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
