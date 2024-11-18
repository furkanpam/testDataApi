﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectionProvider.Abstraction.StatusCodes.Resources {
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
    internal class StatusCodeResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StatusCodeResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ConnectionProvider.Abstraction.StatusCodes.Resources.StatusCodeResource", typeof(StatusCodeResource).Assembly);
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
        ///   Looks up a localized string similar to Veritabanı Hatası.
        /// </summary>
        internal static string Status110DatabaseError {
            get {
                return ResourceManager.GetString("Status110DatabaseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Veri Bulunamadı.
        /// </summary>
        internal static string Status111DataNotFound {
            get {
                return ResourceManager.GetString("Status111DataNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kayıt Daha Önceden Oluşturulmuş..
        /// </summary>
        internal static string Status112DataAlreadyExists {
            get {
                return ResourceManager.GetString("Status112DataAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entegrasyon Servis Hatası.
        /// </summary>
        internal static string Status113IntegrationServiceError {
            get {
                return ResourceManager.GetString("Status113IntegrationServiceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Başarılı.
        /// </summary>
        internal static string Status200OK {
            get {
                return ResourceManager.GetString("Status200OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bilinmeyen Data Model.
        /// </summary>
        internal static string Status2301IncompatibleBodyModel {
            get {
                return ResourceManager.GetString("Status2301IncompatibleBodyModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hatalı İstek.
        /// </summary>
        internal static string Status400BadRequest {
            get {
                return ResourceManager.GetString("Status400BadRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yetkisiz Kullanıcı.
        /// </summary>
        internal static string Status401Unauthorized {
            get {
                return ResourceManager.GetString("Status401Unauthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to İstek Kaynağı Bulunamadı.
        /// </summary>
        internal static string Status404NotFound {
            get {
                return ResourceManager.GetString("Status404NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to İstek Zaman Aşımına Uğradı.
        /// </summary>
        internal static string Status408TimeOut {
            get {
                return ResourceManager.GetString("Status408TimeOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Veri Kesişimi Hatası..
        /// </summary>
        internal static string Status409Conflict {
            get {
                return ResourceManager.GetString("Status409Conflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yabancı Anahtar Hatası.
        /// </summary>
        internal static string Status422ForeignKeyConstraint {
            get {
                return ResourceManager.GetString("Status422ForeignKeyConstraint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Genel Hata.
        /// </summary>
        internal static string Status500InternalServerError {
            get {
                return ResourceManager.GetString("Status500InternalServerError", resourceCulture);
            }
        }
    }
}
