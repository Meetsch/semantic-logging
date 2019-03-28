﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Etw.Service.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Etw.Service.Properties.Reso" +
                            "urces", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ -a=type | -account=type]	Specifies the account type. Accepted values are User, LocalSystem, and LocalService. Default is LocalService..
        /// </summary>
        internal static string AccountArgDescription {
            get {
                return ResourceManager.GetString("AccountArgDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service is already installed or has been marked for deletion..
        /// </summary>
        internal static string AlreadyInstalledService {
            get {
                return ResourceManager.GetString("AlreadyInstalledService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file was not found in the service config file &apos;appSettings&apos; section with key name &apos;EtwConfigurationFileName&apos;. .
        /// </summary>
        internal static string ConfigFileNameNotFoundError {
            get {
                return ResourceManager.GetString("ConfigFileNameNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ -c | -console ]		Run as a console application..
        /// </summary>
        internal static string ConsoleArgDescription {
            get {
                return ResourceManager.GetString("ConsoleArgDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event Trace Session prefix: {0}.
        /// </summary>
        internal static string EventSessionMessage {
            get {
                return ResourceManager.GetString("EventSessionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arguments: {0}.
        /// </summary>
        internal static string EventSourceArgumentsMessage {
            get {
                return ResourceManager.GetString("EventSourceArgumentsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}, Level: {1}, MatchAnyKeyword: {2}.
        /// </summary>
        internal static string EventSourceDescriptionMessage {
            get {
                return ResourceManager.GetString("EventSourceDescriptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event sources:.
        /// </summary>
        internal static string EventSourceListMessage {
            get {
                return ResourceManager.GetString("EventSourceListMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name: {0}.
        /// </summary>
        internal static string EventSourceNameMessage {
            get {
                return ResourceManager.GetString("EventSourceNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processes: {0}.
        /// </summary>
        internal static string EventSourceProcessNamesMessage {
            get {
                return ResourceManager.GetString("EventSourceProcessNamesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ -h | -help | -? ]		Display list of arguments.
        /// </summary>
        internal static string HelpArgDescription {
            get {
                return ResourceManager.GetString("HelpArgDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ -i | -install ]		Install as a Windows Service. .
        /// </summary>
        internal static string InstallArgDescription {
            get {
                return ResourceManager.GetString("InstallArgDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested operation requires elevation..
        /// </summary>
        internal static string InsufficientAccessPermission {
            get {
                return ResourceManager.GetString("InsufficientAccessPermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration settings loaded from file: {0}.
        /// </summary>
        internal static string LoadedConfigurationMessage {
            get {
                return ResourceManager.GetString("LoadedConfigurationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading configuration ....
        /// </summary>
        internal static string LoadingServiceConfigurationMessage {
            get {
                return ResourceManager.GetString("LoadingServiceConfigurationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service is not installed..
        /// </summary>
        internal static string NotInstalledService {
            get {
                return ResourceManager.GetString("NotInstalledService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file changed and the current service instance will restart to reflect the changes..
        /// </summary>
        internal static string RecyclingServiceOnConfigChanged {
            get {
                return ResourceManager.GetString("RecyclingServiceOnConfigChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service is already running..
        /// </summary>
        internal static string ServiceAlreadyStarted {
            get {
                return ResourceManager.GetString("ServiceAlreadyStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service can collect strongly typed events captured by event tracing for Windows (ETW) and foward to the configured EventListeners in the xml service configuration file. For further details read the service documentation..
        /// </summary>
        internal static string ServiceDescription {
            get {
                return ResourceManager.GetString("ServiceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Semantic Logging Out-of-Process Service.
        /// </summary>
        internal static string ServiceDisplayName {
            get {
                return ResourceManager.GetString("ServiceDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The account identifier is invalid &apos;{0}&apos;..
        /// </summary>
        internal static string ServiceInvalidAccount {
            get {
                return ResourceManager.GetString("ServiceInvalidAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service cannot start because it is in &apos;{0}&apos; state..
        /// </summary>
        internal static string ServiceNotStarted {
            get {
                return ResourceManager.GetString("ServiceNotStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service could not be started. Check the eventlog for more details..
        /// </summary>
        internal static string ServiceNotStartedTimeout {
            get {
                return ResourceManager.GetString("ServiceNotStartedTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service has started..
        /// </summary>
        internal static string ServiceStarted {
            get {
                return ResourceManager.GetString("ServiceStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service stopped successfully..
        /// </summary>
        internal static string ServiceStoppedMessage {
            get {
                return ResourceManager.GetString("ServiceStoppedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Closing all resources....
        /// </summary>
        internal static string ShutdownServiceMessage {
            get {
                return ResourceManager.GetString("ShutdownServiceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sink name: {0}.
        /// </summary>
        internal static string SinkNameMessage {
            get {
                return ResourceManager.GetString("SinkNameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ -s | -start ]			Start or install and start the service..
        /// </summary>
        internal static string StartArgDescription {
            get {
                return ResourceManager.GetString("StartArgDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service started..
        /// </summary>
        internal static string StartedServiceMessage {
            get {
                return ResourceManager.GetString("StartedServiceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press enter to end ....
        /// </summary>
        internal static string StopServiceMessage {
            get {
                return ResourceManager.GetString("StopServiceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ -u | -uninstall ]		Uninstall the Windows Service..
        /// </summary>
        internal static string UninstallArgDescription {
            get {
                return ResourceManager.GetString("UninstallArgDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration is incomplete. Please update the configuration. The service will detect the configuration file change and reload the new settings..
        /// </summary>
        internal static string UpdateConfigFileMessage {
            get {
                return ResourceManager.GetString("UpdateConfigFileMessage", resourceCulture);
            }
        }
    }
}
