﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CnSharp.VisualStudio.NuPack {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CnSharp.VisualStudio.NuPack.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap folder {
            get {
                object obj = ResourceManager.GetObject("folder", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon nuget {
            get {
                object obj = ResourceManager.GetObject("nuget", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;package&gt;
        ///  &lt;metadata&gt;
        ///    &lt;!--*--&gt;
        ///    &lt;id&gt;$id$&lt;/id&gt;
        ///    &lt;!--*--&gt;
        ///    &lt;version&gt;$version$&lt;/version&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///    &lt;!--*--&gt;
        ///    &lt;authors&gt;$author$&lt;/authors&gt;
        ///    &lt;owners&gt;$author$&lt;/owners&gt;
        ///&lt;!--
        ///    &lt;licenseUrl&gt;&lt;/licenseUrl&gt;
        ///    &lt;projectUrl&gt;&lt;/projectUrl&gt;
        ///    &lt;iconUrl&gt;&lt;/iconUrl&gt;
        ///--&gt;
        ///    &lt;requireLicenseAcceptance&gt;false&lt;/requireLicenseAcceptance&gt;
        ///    &lt;!--*--&gt;
        ///    &lt;description&gt;$description$&lt;/description&gt;
        ///    &lt;!--*--&gt;
        ///    &lt;releaseNotes&gt; &lt;/releaseNotes&gt;
        ///    &lt;copyrig [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NuSpecTemplate {
            get {
                return ResourceManager.GetString("NuSpecTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon zip {
            get {
                object obj = ResourceManager.GetObject("zip", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
