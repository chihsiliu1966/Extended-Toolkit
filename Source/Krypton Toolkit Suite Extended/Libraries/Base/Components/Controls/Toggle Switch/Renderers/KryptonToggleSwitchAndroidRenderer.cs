﻿using System;
using System.Drawing;

namespace Krypton.Toolkit.Suite.Extended.Base
{
    public class KryptonToggleSwitchAndroidRenderer : KryptonToggleSwitchRendererBase
    {
        #region Public Properties
        public Color BorderColour { get; set; }

        public Color BackColour { get; set; }

        public Color LeftSideColour { get; set; }

        public Color RightSideColour { get; set; }

        public Color OffButtonColour { get; set; }

        public Color OnButtonColour { get; set; }

        public Color OffButtonBorderColour { get; set; }

        public Color OnButtonBorderColour { get; set; }

        public int SlantAngle { get; set; }
        #endregion

        public override Rectangle GetButtonRectangle()
        {
            throw new NotImplementedException();
        }

        public override Rectangle GetButtonRectangle(int buttonWidth)
        {
            throw new NotImplementedException();
        }

        public override int GetButtonWidth()
        {
            throw new NotImplementedException();
        }

        public override void RenderBorder(Graphics g, Rectangle borderRectangle)
        {
            throw new NotImplementedException();
        }

        public override void RenderButton(Graphics g, Rectangle buttonRectangle)
        {
            throw new NotImplementedException();
        }

        public override void RenderLeftToggleField(Graphics g, Rectangle leftRectangle, int totalToggleFieldWidth)
        {
            throw new NotImplementedException();
        }

        public override void RenderRightToggleField(Graphics g, Rectangle rightRectangle, int totalToggleFieldWidth)
        {
            throw new NotImplementedException();
        }
    }
}