﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krypton.Toolkit.Suite.Extended.Settings.Settings.Global {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.0.0")]
    internal sealed partial class GlobalEnumerationSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static GlobalEnumerationSettings defaultInstance = ((GlobalEnumerationSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new GlobalEnumerationSettings())));
        
        public static GlobalEnumerationSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BracketType {
            get {
                return ((string)(this["BracketType"]));
            }
            set {
                this["BracketType"] = value;
            }
        }
    }
}
