﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krypton.Toolkit.Suite.Extended.Settings.Settings.Palette_Explorer.Colours {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.0.0")]
    internal sealed partial class MiscellaneousColourSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MiscellaneousColourSettings defaultInstance = ((MiscellaneousColourSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MiscellaneousColourSettings())));
        
        public static MiscellaneousColourSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color BorderColour {
            get {
                return ((global::System.Drawing.Color)(this["BorderColour"]));
            }
            set {
                this["BorderColour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color DisabledControlColour {
            get {
                return ((global::System.Drawing.Color)(this["DisabledControlColour"]));
            }
            set {
                this["DisabledControlColour"] = value;
            }
        }
    }
}
