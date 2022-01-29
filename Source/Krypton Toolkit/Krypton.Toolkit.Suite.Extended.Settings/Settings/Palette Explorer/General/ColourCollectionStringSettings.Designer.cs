﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license or other governing licenses that can be found in the LICENSE.md file or at
 * https://raw.githubusercontent.com/Krypton-Suite/Extended-Toolkit/master/LICENSE
 */
#endregion

//------------------------------------------------------------------------------
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
    internal sealed partial class ColourCollectionStringSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ColourCollectionStringSettings defaultInstance = ((ColourCollectionStringSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ColourCollectionStringSettings())));
        
        public static ColourCollectionStringSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"
        <?xml version=""1.0"" encoding=""utf-16""?>
        <ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
        <string>Border Colour</string>
        <string>Alternative Normal Text Colour</string>
        <string>Normal Text Colour</string>
        <string>Disabled Text Colour</string>
        <string>Focused Text Colour</string>
        <string>Pressed Text Colour</string>
        <string>Disabled Control Colour</string>
        <string>Link Normal Colour</string>
        <string>Link Focused Colour</string>
        <string>Link Hover Colour</string>
        <string>Link Visited Colour</string>
        <string>Custom Colour One</string>
        <string>Custom Colour Two</string>
        <string>Custom Colour Three</string>
        <string>Custom Colour Four</string>
        <string>Custom Colour Five</string>
        <string>Custom Colour Six</string>
        <string>Custom Text Colour One</string>
        <string>Custom Text Colour Two</string>
        <string>Custom Text Colour Three</string>
        <string>Custom Text Colour Four</string>
        <string>Custom Text Colour Five</string>
        <string>Custom Text Colour Six</string>
        <string>Menu Text Colour</string>
        <string>Status Text Colour</string>
        <string>Ribbon Tab Text Colour</string>
        </ArrayOfString>
      ")]
        public global::System.Collections.Specialized.StringCollection ColourStringCollectionValues {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ColourStringCollectionValues"]));
            }
            set {
                this["ColourStringCollectionValues"] = value;
            }
        }
    }
}