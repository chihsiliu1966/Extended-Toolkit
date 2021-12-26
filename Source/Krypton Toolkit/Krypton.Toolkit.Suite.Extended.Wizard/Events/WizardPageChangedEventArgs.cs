﻿#region BSD License
/*
 *
 * Use of this source code is governed by a BSD-style
 * license or other governing licenses that can be found in the LICENSE.md file or at
 * https://raw.githubusercontent.com/Krypton-Suite/Extended-Toolkit/master/LICENSE
 *
 * Base code by Steve Bate 2003 - 2017 (https://github.com/SteveBate/AdvancedWizard), modifications by Peter Wagner (aka Wagnerp) 2021.
 *
 */
#endregion

namespace Krypton.Toolkit.Suite.Extended.Wizard
{
    public class WizardPageChangedEventArgs : EventArgs
    {
        public WizardPageChangedEventArgs(KryptonAdvancedWizardPage page, int pageIndex)
        {
            Page = page;
            PageIndex = pageIndex;
        }

        public KryptonAdvancedWizardPage Page { get; set; }

        public int PageIndex { get; }
    }
}