﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DotNet.Interactive {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DotNet.Interactive.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to File does not exist: &apos;{0}&apos;..
        /// </summary>
        internal static string FileDoesNotExist {
            get {
                return ResourceManager.GetString("FileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} and {1} options cannot be used together..
        /// </summary>
        internal static string Magics_ErrorMessage_CannotBeUsedTogether {
            get {
                return ResourceManager.GetString("Magics_ErrorMessage_CannotBeUsedTogether", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runs another notebook or source code file inline..
        /// </summary>
        internal static string Magics_import_Description {
            get {
                return ResourceManager.GetString("Magics_import_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path to the file to be imported. Supported file extensions include notebooks (.ipynb, .dib) as well as source code for supported languages (.cs, .csx, .fs, .fsx, .ps1, .html, .http, .js)..
        /// </summary>
        internal static string Magics_import_file_Description {
            get {
                return ResourceManager.GetString("Magics_import_file_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enables session logging..
        /// </summary>
        internal static string Magics_log_Description {
            get {
                return ResourceManager.GetString("Magics_log_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shares the specified value by reference if kernels are in the same process..
        /// </summary>
        internal static string Magics_set_byref_Description {
            get {
                return ResourceManager.GetString("Magics_set_byref_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets a value in the current kernel.
        /// </summary>
        internal static string Magics_set_Description {
            get {
                return ResourceManager.GetString("Magics_set_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sharing by reference is not allowed when kernels are remote..
        /// </summary>
        internal static string Magics_set_ErrorMessage_SharingByReference {
            get {
                return ResourceManager.GetString("Magics_set_ErrorMessage_SharingByReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MIME type by which the value should be represented. This will often determine how an object will be formatted into a string..
        /// </summary>
        internal static string Magics_set_mime_type_Description {
            get {
                return ResourceManager.GetString("Magics_set_mime_type_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The --mime-type and --byref options cannot be used together..
        /// </summary>
        internal static string Magics_set_mime_type_ErrorMessage_CannotBeUsed {
            get {
                return ResourceManager.GetString("Magics_set_mime_type_ErrorMessage_CannotBeUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the value to be created in the current kernel..
        /// </summary>
        internal static string Magics_set_name_Description {
            get {
                return ResourceManager.GetString("Magics_set_name_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value to be set. @input:user_prompt allows you to prompt the user for this value. Values can be requested from other kernels by name, for example @csharp:variableName..
        /// </summary>
        internal static string Magics_set_value_Description {
            get {
                return ResourceManager.GetString("Magics_set_value_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name to give the the value in the importing kernel..
        /// </summary>
        internal static string Magics_share_as_Description {
            get {
                return ResourceManager.GetString("Magics_share_as_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get a value from one kernel and create a copy (or a reference if the kernels are in the same process) in another..
        /// </summary>
        internal static string Magics_share_Description {
            get {
                return ResourceManager.GetString("Magics_share_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the kernel to get the value from..
        /// </summary>
        internal static string Magics_share_from_Description {
            get {
                return ResourceManager.GetString("Magics_share_from_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Share the value as a string formatted to the specified MIME type..
        /// </summary>
        internal static string Magics_share_mime_type_Description {
            get {
                return ResourceManager.GetString("Magics_share_mime_type_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the value to share. (This is also the default name of the value created in the destination kernel, unless --as is used to specify a different one.).
        /// </summary>
        internal static string Magics_share_name_Description {
            get {
                return ResourceManager.GetString("Magics_share_name_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies a file whose contents will be stored..
        /// </summary>
        internal static string Magics_value_from_file_Description {
            get {
                return ResourceManager.GetString("Magics_value_from_file_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies a URL whose content will be stored..
        /// </summary>
        internal static string Magics_value_from_url_Description {
            get {
                return ResourceManager.GetString("Magics_value_from_url_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies a value to be stored directly. Specifying @input:value allows you to prompt the user for this value..
        /// </summary>
        internal static string Magics_value_from_value_Description {
            get {
                return ResourceManager.GetString("Magics_value_from_value_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A mime type for the value. If specified, displays the value immediately as an output using the specified mime type..
        /// </summary>
        internal static string Magics_value_mime_type_Description {
            get {
                return ResourceManager.GetString("Magics_value_mime_type_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the value to create. You can use #!share to retrieve this value from another subkernel..
        /// </summary>
        internal static string Magics_value_name_Description {
            get {
                return ResourceManager.GetString("Magics_value_name_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display the names of the current top-level variables..
        /// </summary>
        internal static string Magics_who_Description {
            get {
                return ResourceManager.GetString("Magics_who_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display the names of the current top-level variables and their values..
        /// </summary>
        internal static string Magics_whos_Description {
            get {
                return ResourceManager.GetString("Magics_whos_Description", resourceCulture);
            }
        }
    }
}
