﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krypton.Toolkit.Suite.Extended.Settings.Settings.Controls {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class ThemeSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ThemeSettings defaultInstance = ((ThemeSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ThemeSettings())));
        
        public static ThemeSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Office 2010 - Blue")]
        public global::Krypton.Toolkit.PaletteMode DefaultTheme {
            get {
                return ((global::Krypton.Toolkit.PaletteMode)(this["DefaultTheme"]));
            }
            set {
                this["DefaultTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Krypton.Toolkit.KryptonManager GlobalManager {
            get {
                return ((global::Krypton.Toolkit.KryptonManager)(this["GlobalManager"]));
            }
            set {
                this["GlobalManager"] = value;
            }
        }
    }
}