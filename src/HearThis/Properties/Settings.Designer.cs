﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HearThis.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Project {
            get {
                return ((string)(this["Project"]));
            }
            set {
                this["Project"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int Book {
            get {
                return ((int)(this["Book"]));
            }
            set {
                this["Book"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int Chapter {
            get {
                return ((int)(this["Chapter"]));
            }
            set {
                this["Chapter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int Block {
            get {
                return ((int)(this["Block"]));
            }
            set {
                this["Block"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool NeedUpgrade {
            get {
                return ((bool)(this["NeedUpgrade"]));
            }
            set {
                this["NeedUpgrade"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::SIL.Reporting.ReportingSettings Reporting {
            get {
                return ((global::SIL.Reporting.ReportingSettings)(this["Reporting"]));
            }
            set {
                this["Reporting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PublishRootPath {
            get {
                return ((string)(this["PublishRootPath"]));
            }
            set {
                this["PublishRootPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserInterfaceLanguage {
            get {
                return ((string)(this["UserInterfaceLanguage"]));
            }
            set {
                this["UserInterfaceLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BreakLinesAtClauses {
            get {
                return ((bool)(this["BreakLinesAtClauses"]));
            }
            set {
                this["BreakLinesAtClauses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastVersionLaunched {
            get {
                return ((string)(this["LastVersionLaunched"]));
            }
            set {
                this["LastVersionLaunched"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Administrative")]
        public string ActiveMode {
            get {
                return ((string)(this["ActiveMode"]));
            }
            set {
                this["ActiveMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowAdministrativeMode {
            get {
                return ((bool)(this["AllowAdministrativeMode"]));
            }
            set {
                this["AllowAdministrativeMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowNormalRecordingMode {
            get {
                return ((bool)(this["AllowNormalRecordingMode"]));
            }
            set {
                this["AllowNormalRecordingMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(", ; :")]
        public string ClauseBreakCharacters {
            get {
                return ((string)(this["ClauseBreakCharacters"]));
            }
            set {
                this["ClauseBreakCharacters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BreakQuotesIntoBlocks {
            get {
                return ((bool)(this["BreakQuotesIntoBlocks"]));
            }
            set {
                this["BreakQuotesIntoBlocks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ReplaceChevronsWithQuotes {
            get {
                return ((bool)(this["ReplaceChevronsWithQuotes"]));
            }
            set {
                this["ReplaceChevronsWithQuotes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PublishAudioFormat {
            get {
                return ((string)(this["PublishAudioFormat"]));
            }
            set {
                this["PublishAudioFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PublishVerseIndexFormat {
            get {
                return ((string)(this["PublishVerseIndexFormat"]));
            }
            set {
                this["PublishVerseIndexFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PublishCurrentBookOnly {
            get {
                return ((bool)(this["PublishCurrentBookOnly"]));
            }
            set {
                this["PublishCurrentBookOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AdditionalBlockBreakCharacters {
            get {
                return ((string)(this["AdditionalBlockBreakCharacters"]));
            }
            set {
                this["AdditionalBlockBreakCharacters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultBundleDirectory {
            get {
                return ((string)(this["DefaultBundleDirectory"]));
            }
            set {
                this["DefaultBundleDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::SIL.Windows.Forms.PortableSettingsProvider.FormSettings ChooseProjectFormSettings {
            get {
                return ((global::SIL.Windows.Forms.PortableSettingsProvider.FormSettings)(this["ChooseProjectFormSettings"]));
            }
            set {
                this["ChooseProjectFormSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::SIL.Windows.Forms.PortableSettingsProvider.GridSettings ChooseProjectGridSettings {
            get {
                return ((global::SIL.Windows.Forms.PortableSettingsProvider.GridSettings)(this["ChooseProjectGridSettings"]));
            }
            set {
                this["ChooseProjectGridSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserSpecifiedParatextProjectsDir {
            get {
                return ((string)(this["UserSpecifiedParatextProjectsDir"]));
            }
            set {
                this["UserSpecifiedParatextProjectsDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0, 0, 0")]
        public global::System.Drawing.Rectangle RestoreBounds {
            get {
                return ((global::System.Drawing.Rectangle)(this["RestoreBounds"]));
            }
            set {
                this["RestoreBounds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public float ZoomFactor {
            get {
                return ((float)(this["ZoomFactor"]));
            }
            set {
                this["ZoomFactor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::SIL.Windows.Forms.PortableSettingsProvider.FormSettings RecordInPartsFormSettings {
            get {
                return ((global::SIL.Windows.Forms.PortableSettingsProvider.FormSettings)(this["RecordInPartsFormSettings"]));
            }
            set {
                this["RecordInPartsFormSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int CurrentDataVersion {
            get {
                return ((int)(this["CurrentDataVersion"]));
            }
            set {
                this["CurrentDataVersion"] = value;
            }
        }
    }
}
