﻿#pragma checksum "D:\Projects\RSM3\RSMUltra\UltraUI\NewServer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "91ECA16740698CBF3E2655CA34544AF706A6C45DFEB34485897EAB45E0EDD547"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using WinRT;

namespace RSMUltra.UltraUI
{
    partial class NewServer : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // UltraUI\NewServer.xaml line 13
                {
                    this.GameLists = target.As<Microsoft.UI.Xaml.Controls.ComboBox>();
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.GameLists).SelectionChanged += this.GameChanged;
                }
                break;
            case 3: // UltraUI\NewServer.xaml line 15
                {
                    this.VersionPannel = target.As<Microsoft.UI.Xaml.Controls.StackPanel>();
                }
                break;
            case 4: // UltraUI\NewServer.xaml line 20
                {
                    this.VariantPannel = target.As<Microsoft.UI.Xaml.Controls.StackPanel>();
                }
                break;
            case 5: // UltraUI\NewServer.xaml line 22
                {
                    this.Variant = target.As<Microsoft.UI.Xaml.Controls.ComboBox>();
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.Variant).SelectionChanged += this.EnableContinue;
                }
                break;
            case 6: // UltraUI\NewServer.xaml line 17
                {
                    this.Versions = target.As<Microsoft.UI.Xaml.Controls.ComboBox>();
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.Versions).SelectionChanged += this.VersionChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
