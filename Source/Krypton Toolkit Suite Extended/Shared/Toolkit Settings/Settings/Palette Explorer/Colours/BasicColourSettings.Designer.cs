﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krypton.Toolkit.Suite.Extended.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class BasicColourSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static BasicColourSettings defaultInstance = ((BasicColourSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new BasicColourSettings())));
        
        public static BasicColourSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color BaseColour {
            get {
                return ((global::System.Drawing.Color)(this["BaseColour"]));
            }
            set {
                this["BaseColour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color DarkColour {
            get {
                return ((global::System.Drawing.Color)(this["DarkColour"]));
            }
            set {
                this["DarkColour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color MediumColour {
            get {
                return ((global::System.Drawing.Color)(this["MediumColour"]));
            }
            set {
                this["MediumColour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color LightColour {
            get {
                return ((global::System.Drawing.Color)(this["LightColour"]));
            }
            set {
                this["LightColour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Color LightestColour {
            get {
                return ((global::System.Drawing.Color)(this["LightestColour"]));
            }
            set {
                this["LightestColour"] = value;
            }
        }
    }
}
