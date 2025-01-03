﻿#region MIT License
/*
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

namespace Krypton.Toolkit.Suite.Extended.Drawing.Utilities
{
    public class ColourHexadecimalComboBox : KryptonComboBox
    {
        private Color _colour;

        private Font _typeface;

        /// <summary>
        /// Gets or sets a value indicating whether input changes should be processed.
        /// </summary>
        /// <value><c>true</c> if input changes should be processed; otherwise, <c>false</c>.</value>
        protected bool LockUpdates { get; set; }

        public Color Colour { set => _colour = value; }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }

        public ColourHexadecimalComboBox()
        {
            Typeface = TypefaceHelper.DefaultTypeface();

            DrawItem += ColourHexadecimalComboBox_DrawItem;

            DropDown += ColourHexadecimalComboBox_DropDown;

            KeyDown += ColourHexadecimalComboBox_KeyDown;

            SelectedIndexChanged += ColourHexadecimalComboBox_SelectedIndexChanged;
        }

        private void ColourHexadecimalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndex != -1)
            {
                this.LockUpdates = true;
                this.Colour = Color.FromName((string)SelectedItem);
                this.LockUpdates = false;
            }
        }

        private void ColourHexadecimalComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.PageUp:
                case Keys.PageDown:
#if !NETCOREAPP
                    if (Items.Count == 0)
                    {
                        this.FillNamedColours();
                    }
#endif
                    break;
            }
        }

        private void ColourHexadecimalComboBox_DropDown(object sender, EventArgs e)
        {
#if !NETCOREAPP
            if (Items.Count == 0)
            {
                this.FillNamedColours();
            }
#endif
        }

#if !NETCOREAPP
        private void FillNamedColours()
        {
            this.AddColourProperties<SystemColors>();
            this.AddColourProperties<Color>();
            this.SetDropDownWidth();
        }

        private void SetDropDownWidth()
        {
            if (Items.Count != 0)
            {
                DropDownWidth = ItemHeight * 2 + Items.Cast<string>().Max(s => TextRenderer.MeasureText(s, this.Font).Width);
            }
        }

        private void AddColourProperties<T>()
        {
            Type type;
            Type colourType;

            type = typeof(T);
            colourType = typeof(Color);

            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                if (property.PropertyType == colourType)
                {
                    Color colour;

                    colour = (Color)property.GetValue(type, null);
                    if (!colour.IsEmpty)
                    {
                        Items.Add(colour.Name);
                    }
                }
            }
        }
#endif

        private void ColourHexadecimalComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                Rectangle colourBox;
                string name;
                Color colour;

                e.DrawBackground();

                name = (string)Items[e.Index];
                colour = Color.FromName(name);
                colourBox = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1, e.Bounds.Height - 3, e.Bounds.Height - 3);

                using (Brush brush = new SolidBrush(colour))
                {
                    e.Graphics.FillRectangle(brush, colourBox);
                }
                e.Graphics.DrawRectangle(SystemPens.ControlText, colourBox);

                TextRenderer.DrawText(e.Graphics, this.AddSpaces(name), this.Font, new Point(colourBox.Right + 3, colourBox.Top), e.ForeColor);

                //if (colour == Colour.Transparent && (e.State & DrawItemState.Selected) != DrawItemState.Selected)
                //  e.Graphics.DrawLine(SystemPens.ControlText, e.Bounds.Left, e.Bounds.Top, e.Bounds.Right, e.Bounds.Top);

                e.DrawFocusRectangle();
            }
        }

        private string AddSpaces(string name)
        {
            string result;

            //http://stackoverflow.com/a/272929/148962

            if (!string.IsNullOrEmpty(name))
            {
                StringBuilder newText;

                newText = new StringBuilder(name.Length * 2);
                newText.Append(name[0]);
                for (int i = 1; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i]) && name[i - 1] != ' ')
                    {
                        newText.Append(' ');
                    }
                    newText.Append(name[i]);
                }

                result = newText.ToString();
            }
            else
            {
                result = null;
            }

            return result;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            StateCommon.ComboBox.Content.Font = Typeface;

            base.OnPaint(e);
        }
    }
}