﻿namespace Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot
{
    public abstract class ByteColormapBase : ColormapBase
    {
        public abstract (byte r, byte g, byte b)[] Rgbs { get; }
        public override Color GetColor(double normalizedIntensity)
        {
            var rgb = Rgbs?[(int)(normalizedIntensity * (Rgbs.Length - 1))] ?? (0, 0, 0);
            return new(rgb.r, rgb.g, rgb.b);
        }
    }
}
