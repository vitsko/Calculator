﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application {
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
    internal class Text {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Text() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Application.Text", typeof(Text).Assembly);
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
        ///   Looks up a localized string similar to Введите два операнда через пробел:.
        /// </summary>
        internal static string AboutInput {
            get {
                return ResourceManager.GetString("AboutInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Нажмите любую клавишу для выхода в главное меню....
        /// </summary>
        internal static string AnyPress {
            get {
                return ResourceManager.GetString("AnyPress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Некорректный ввод операндов. Требования к операндам:
        ///1. Операндов должно быть два. 
        ///2. Каждый из операндов должен быть числом.
        ///3. Если операнд - дробное число, то у него в качестве десятичного разделителя должен использоваться символ &quot;{0}&quot;..
        /// </summary>
        internal static string ErrorOperands {
            get {
                return ResourceManager.GetString("ErrorOperands", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Выберите операцию:
        ///     
        ///[1] -- Сложение
        ///[2] -- Вычитание
        ///[3] -- Умножение
        ///[4] -- Деление
        ///
        ///[Q] -- Закончить работу с Калькулятором.
        ///    .
        /// </summary>
        internal static string MainMenu {
            get {
                return ResourceManager.GetString("MainMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Результат операции:
        ///{0}
        ///  .
        /// </summary>
        internal static string ResultOperation {
            get {
                return ResourceManager.GetString("ResultOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Калькулятор.
        /// </summary>
        internal static string TitleApp {
            get {
                return ResourceManager.GetString("TitleApp", resourceCulture);
            }
        }
    }
}
