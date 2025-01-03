﻿/* Sourced from Son A. Pham's Sublime color scheme by the same name
 * https://github.com/sonph/onehalf
 */

namespace Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot
{
    public class OneHalf : IPalette
    {
        public string Name { get; } = "One Half";

        public string Description { get; } = "A Sublime color scheme " +
                                             "by Son A. Pham: https://github.com/sonph/onehalf";

        public Color[] Colors { get; } = Color.FromHex(_hexColors);

        private static readonly string[] _hexColors =
        [
            "#383a42", "#e4564a", "#50a14f", "#c18402", "#0084bc", "#a626a4", "#0897b3"
        ];

        public Color GetColor(int index) => Colors[index % Colors.Length];
    }
}