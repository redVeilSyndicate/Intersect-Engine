﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intersect.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Intersect.Properties.ExceptionMessages", typeof(ExceptionMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Sucht eine lokalisierte Zeichenfolge, die Plugin entry type found in the assembly does not have a generic constructor. ähnelt.
        /// </summary>
        internal static string FoundPluginEntryTypeMissingDefaultConstructor {
            get {
                return ResourceManager.GetString("FoundPluginEntryTypeMissingDefaultConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die No plugin assembly was found for the provided path. ähnelt.
        /// </summary>
        internal static string MissingPluginAssembly {
            get {
                return ResourceManager.GetString("MissingPluginAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Unable to find a plugin entry type in: ähnelt.
        /// </summary>
        internal static string MissingPluginEntryExceptionAssemblyName {
            get {
                return ResourceManager.GetString("MissingPluginEntryExceptionAssemblyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Unable to find a plugin entry type in the assembly. ähnelt.
        /// </summary>
        internal static string MissingPluginEntryExceptionDefault {
            get {
                return ResourceManager.GetString("MissingPluginEntryExceptionDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die PluginBootstrap factory needs at lease one non-null argument of type &apos;{0}&apos;. ähnelt.
        /// </summary>
        internal static string PluginBootstrapContextMissingPluginArgument {
            get {
                return ResourceManager.GetString("PluginBootstrapContextMissingPluginArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Swallowing unexpected exception from {0}. ähnelt.
        /// </summary>
        internal static string SwallowingExceptionFrom {
            get {
                return ResourceManager.GetString("SwallowingExceptionFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Swallowing unexpected exception from {0}.{1}. ähnelt.
        /// </summary>
        internal static string SwallowingExceptionFromWithQualifiedName {
            get {
                return ResourceManager.GetString("SwallowingExceptionFromWithQualifiedName", resourceCulture);
            }
        }
    }
}
