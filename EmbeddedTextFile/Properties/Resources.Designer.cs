﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WizardWrx.EmbeddedTextFile.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WizardWrx.EmbeddedTextFile.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Resource {0} cannot be found in assembly {1}..
        /// </summary>
        internal static string ERRMSG_EMBEDDED_RESOURCE_NOT_FOUND {
            get {
                return ResourceManager.GetString("ERRMSG_EMBEDDED_RESOURCE_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while reading data from resources embedded in an assembly.{3}Assembly Full Name     = {0}{3}Internal Resource Name = {1}{3}I/O Error Message      = {2}{3}{3}The associated Inner Exception may contain additional clues..
        /// </summary>
        internal static string ERRMSG_EMBEDDED_RESOURCE_READ_ERROR {
            get {
                return ResourceManager.GetString("ERRMSG_EMBEDDED_RESOURCE_READ_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while reading a file from resources embedded in an assembly.{3}Internal Name = {0}{3}Expected File Length (bytes) = {1}{3}Bytes successfully read = {2}.
        /// </summary>
        internal static string ERRMSG_EMBEDDED_RESOURCE_READ_TRUNCATED {
            get {
                return ResourceManager.GetString("ERRMSG_EMBEDDED_RESOURCE_READ_TRUNCATED", resourceCulture);
            }
        }
    }
}
