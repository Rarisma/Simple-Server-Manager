﻿#pragma checksum "D:\Projects\RSM3\RSMUltra\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6490C0AC06002178252440A591F274D6E14E57CE68B7809272972440BB98C499"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using WinRT;

namespace RSMUltra
{
    partial class MainWindow : 
        global::Microsoft.UI.Xaml.Window, 
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
            case 2: // MainWindow.xaml line 10
                {
                    this.SideBar = target.As<Microsoft.UI.Xaml.Controls.NavigationView>();
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.SideBar).SelectionChanged += this.SelectionChanged;
                }
                break;
            case 3: // MainWindow.xaml line 12
                {
                    this.New = target.As<Microsoft.UI.Xaml.Controls.NavigationViewItem>();
                }
                break;
            case 4: // MainWindow.xaml line 17
                {
                    this.Import = target.As<Microsoft.UI.Xaml.Controls.NavigationViewItem>();
                }
                break;
            case 5: // MainWindow.xaml line 24
                {
                    this.Settings = target.As<Microsoft.UI.Xaml.Controls.NavigationViewItem>();
                }
                break;
            case 6: // MainWindow.xaml line 30
                {
                    this.MainFrame = target.As<Microsoft.UI.Xaml.Controls.Frame>();
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
