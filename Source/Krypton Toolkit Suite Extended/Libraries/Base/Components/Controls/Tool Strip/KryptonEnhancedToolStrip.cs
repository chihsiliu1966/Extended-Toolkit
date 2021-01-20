﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license or other governing licenses that can be found in the LICENSE.md file or at
 * https://raw.githubusercontent.com/Krypton-Suite/Extended-Toolkit/master/LICENSE
 */
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Krypton.Toolkit.Suite.Extended.Base
{
    [Description("A standard tool strip, with a few enhancements."), ToolboxItem(false)]
	/// <summary>A standard tool strip, with a few enhancements.</summary>
    public class KryptonEnhancedToolStrip : ToolStrip
    {
		#region Variables
		private bool _clickThrough = false;
		#endregion
		
		#region Properties
		/// <summary>Gets or sets whether the ToolStripEx honors item clicks when its containing form does not have input focus.</summary>
        /// <remarks>Default value is false, which is the same behavior provided by the base ToolStrip class.</remarks>
		public bool ClickThrough { get => _clickThrough; set => _clickThrough = value; }
		#endregion
		
		#region Constructor
		public KryptonEnhancedToolStrip() {}
        #endregion

        #region Overrides
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (_clickThrough && m.Msg == NativeConstants.WM_MOUSEACTIVATE && m.Result == (IntPtr)NativeConstants.MA_ACTIVATEANDEAT)
            {
                m.Result = (IntPtr)NativeConstants.MA_ACTIVATE;
            }
        }
        #endregion
    }
}