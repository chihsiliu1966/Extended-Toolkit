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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class StandardControlTextColourSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static StandardControlTextColourSettings defaultInstance = ((StandardControlTextColourSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new StandardControlTextColourSettings())));
        
        public static StandardControlTextColourSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color MenuTextColour {
            get {
                return ((global::System.Drawing.Color)(this["MenuTextColour"]));
            }
            set {
                this["MenuTextColour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color StatusStripTextColour {
            get {
                return ((global::System.Drawing.Color)(this["StatusStripTextColour"]));
            }
            set {
                this["StatusStripTextColour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color RibbonTabTextColour {
            get {
                return ((global::System.Drawing.Color)(this["RibbonTabTextColour"]));
            }
            set {
                this["RibbonTabTextColour"] = value;
            }
        }
    }
}