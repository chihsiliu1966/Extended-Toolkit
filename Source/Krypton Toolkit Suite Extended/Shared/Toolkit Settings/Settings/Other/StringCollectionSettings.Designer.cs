﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krypton.Toolkit.Suite.Extended.Settings.Settings.Other {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.0.0")]
    internal sealed partial class StringCollectionSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static StringCollectionSettings defaultInstance = ((StringCollectionSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new StringCollectionSettings())));
        
        public static StringCollectionSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>MD-5</string>
  <string>SHA-1</string>
  <string>SHA-256</string>
  <string>SHA-384</string>
  <string>SHA-512</string>
  <string>RIPEMD-160</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SupportedHashTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SupportedHashTypes"]));
            }
            set {
                this["SupportedHashTypes"] = value;
            }
        }
    }
}
