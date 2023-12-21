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

namespace Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot
{
    /// <summary>
    /// This event describes represents interactive panning.
    /// It is assume the plot has already been reset to the pre-mouse-interaction state,
    /// and processing of this event pans the plot on the axes according to the distance
    /// the mouse has moved.
    /// This is typically called on MouseMove events when the left button is held down.
    /// </summary>
    public class MousePanEvent : IUIEvent
    {
        private readonly InputState Input;
        private readonly Configuration Configuration;
        private readonly Settings Settings;
        public RenderType RenderType => Configuration.QualityConfiguration.MouseInteractiveDragged;

        public MousePanEvent(InputState input, Configuration config, Settings settings)
        {
            Input = input;
            Configuration = config;
            Settings = settings;
        }

        public void ProcessEvent()
        {
            float x = (Input.ShiftDown || Configuration.LockHorizontalAxis) ? Settings.MouseDownX : Input.X;
            float y = (Input.CtrlDown || Configuration.LockVerticalAxis) ? Settings.MouseDownY : Input.Y;
            Settings.MousePan(x, y);
        }
    }
}