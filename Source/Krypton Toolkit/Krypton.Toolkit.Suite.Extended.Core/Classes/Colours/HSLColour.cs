﻿#region MIT License
/*
 *
 * MIT License
 *
 * Copyright (c) 2017 - 2024 Krypton Suite
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 */
#endregion

namespace Krypton.Toolkit.Suite.Extended.Core
{
    /// <summary>
    /// Code adapted from: https://richnewman.wordpress.com/2007/04/29/using-hsl-color-hue-saturation-luminosity-to-create-better-looking-guis-part-1/
    /// </summary>
    internal class HSLColour
    {
        #region Variables
        private double _hue = 1.0, _saturation = 1.0, _luminosity = 1.0;
        #endregion

        #region Constants
        private const double SCALE = 240.0;
        #endregion

        #region Properties
        public double Hue
        {
            get => _hue * SCALE;
            set => _hue = CheckRange(value / SCALE);
        }

        public double Saturation
        {
            get => _saturation * SCALE;
            set => _saturation = CheckRange(value / SCALE);
        }

        public double Luminosity
        {
            get => _luminosity * SCALE;
            set => _luminosity = CheckRange(value / SCALE);
        }
        #endregion

        #region Constructors
        public HSLColour()
        {

        }

        public HSLColour(Color colour)
        {
            SetRGB(colour.R, colour.G, colour.B);
        }

        public HSLColour(int red, int green, int blue)
        {
            SetRGB(red, green, blue);
        }

        public HSLColour(double hue, double saturation, double luminosity)
        {
            Hue = hue;

            Saturation = saturation;

            Luminosity = luminosity;
        }
        #endregion

        #region Methods
        private double CheckRange(double value)
        {
            if (value < 0.0)
            {
                value = 0.0;
            }
            else if (value > 1.0)
            {
                value = 1.0;
            }

            return value;
        }

        public string ToRGBString()
        {
            Color colour = (Color)this;

            return String.Format("R: {0:#0.##} G: {1:#0.##} B: {2:#0.##}", colour.R, colour.G, colour.B);
        }

        public void SetRGB(int red, int green, int blue)
        {
            HSLColour hslColour = (HSLColour)Color.FromArgb(red, green, blue);

            Hue = hslColour._hue;

            Saturation = hslColour._saturation;

            Luminosity = hslColour._luminosity;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return String.Format("H: {0:#0.##} S: {1:#0.##} L: {2:#0.##}", Hue, Saturation, Luminosity);
        }
        #endregion

        #region Casts to/from System.Drawing.Color
        public static implicit operator Color(HSLColour hslColour)
        {
            double r = 0, g = 0, b = 0;
            if (hslColour._luminosity != 0)
            {
                if (hslColour._saturation == 0)
                {
                    r = g = b = hslColour._luminosity;
                }
                else
                {
                    double temp2 = GetTemp2(hslColour);
                    double temp1 = 2.0 * hslColour._luminosity - temp2;

                    r = GetColourComponent(temp1, temp2, hslColour._hue + 1.0 / 3.0);
                    g = GetColourComponent(temp1, temp2, hslColour._hue);
                    b = GetColourComponent(temp1, temp2, hslColour._hue - 1.0 / 3.0);
                }
            }
            return Color.FromArgb((int)(255 * r), (int)(255 * g), (int)(255 * b));
        }

        private static double GetColourComponent(double temp1, double temp2, double temp3)
        {
            temp3 = MoveIntoRange(temp3);
            if (temp3 < 1.0 / 6.0)
            {
                return temp1 + (temp2 - temp1) * 6.0 * temp3;
            }
            else if (temp3 < 0.5)
            {
                return temp2;
            }
            else if (temp3 < 2.0 / 3.0)
            {
                return temp1 + (temp2 - temp1) * (2.0 / 3.0 - temp3) * 6.0;
            }
            else
            {
                return temp1;
            }
        }

        private static double MoveIntoRange(double temp3)
        {
            if (temp3 < 0.0)
            {
                temp3 += 1.0;
            }
            else if (temp3 > 1.0)
            {
                temp3 -= 1.0;
            }

            return temp3;
        }

        private static double GetTemp2(HSLColour hslColour)
        {
            double temp2;
            if (hslColour._luminosity < 0.5)  //<=??
            {
                temp2 = hslColour._luminosity * (1.0 + hslColour._saturation);
            }
            else
            {
                temp2 = hslColour._luminosity + hslColour._saturation - hslColour._luminosity * hslColour._saturation;
            }

            return temp2;
        }

        public static implicit operator HSLColour(Color colour)
        {
            HSLColour hslColour = new();
            hslColour._hue = colour.GetHue() / 360.0; // we store hue as 0-1 as opposed to 0-360 
            hslColour._luminosity = colour.GetBrightness();
            hslColour._saturation = colour.GetSaturation();
            return hslColour;
        }
        #endregion
    }
}