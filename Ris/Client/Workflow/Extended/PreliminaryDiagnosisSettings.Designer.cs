﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Client.Workflow.Extended {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class PreliminaryDiagnosisSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static PreliminaryDiagnosisSettings defaultInstance = ((PreliminaryDiagnosisSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new PreliminaryDiagnosisSettings())));
        
        public static PreliminaryDiagnosisSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// XML document that defines the templates available when accessed from Reporting.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that defines the templates available when accessed from Reporting.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PreliminaryDiagnosisFromRadiologyTemplates.xml")]
        public string RadiologyTemplatesXml {
            get {
                return ((string)(this["RadiologyTemplatesXml"]));
            }
        }
        
        /// <summary>
        /// XML document that defines the templates available when accessed from Emergency.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that defines the templates available when accessed from Emergency.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PreliminaryDiagnosisFromEmergencyTemplates.xml")]
        public string EmergencyTemplatesXml {
            get {
                return ((string)(this["EmergencyTemplatesXml"]));
            }
        }
        
        /// <summary>
        /// XML document that defines the soft-keys available when accessed from Reporting.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that defines the soft-keys available when accessed from Reporting.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PreliminaryDiagnosisFromRadiologySoftKeys.xml")]
        public string RadiologySoftKeysXml {
            get {
                return ((string)(this["RadiologySoftKeysXml"]));
            }
        }
        
        /// <summary>
        /// XML document that defines the soft-keys available when accessed from Emergency.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that defines the soft-keys available when accessed from Emergency.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PreliminaryDiagnosisFromEmergencySoftKeys.xml")]
        public string EmergencySoftKeysXml {
            get {
                return ((string)(this["EmergencySoftKeysXml"]));
            }
        }
        
        /// <summary>
        /// XML document that defines the templates available when accessed during Verification.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that defines the templates available when accessed during Verificati" +
            "on.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PreliminaryDiagnosisFromVerificationTemplates.xml")]
        public string VerificationTemplatesXml {
            get {
                return ((string)(this["VerificationTemplatesXml"]));
            }
        }
        
        /// <summary>
        /// XML document that defines the soft-keys available when accessed during Verification.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that defines the soft-keys available when accessed during Verificati" +
            "on.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PreliminaryDiagnosisFromVerificationSoftKeys.xml")]
        public string VerificationSoftKeysXml {
            get {
                return ((string)(this["VerificationSoftKeysXml"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E")]
        public string PreliminaryDiagnosisReviewForPatientClass {
            get {
                return ((string)(this["PreliminaryDiagnosisReviewForPatientClass"]));
            }
        }
    }
}
