﻿#pragma checksum "..\..\..\..\..\Creator\VersionSelecter.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E9E0AA48E381E211646E47C474727216F26C62D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ModernWpf;
using ModernWpf.Controls;
using ModernWpf.Controls.Primitives;
using ModernWpf.DesignTime;
using ModernWpf.Markup;
using ModernWpf.Media.Animation;
using RSM.Creator;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RSM.Creator {
    
    
    /// <summary>
    /// VersionSelecter
    /// </summary>
    public partial class VersionSelecter : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\Creator\VersionSelecter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Variants;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Creator\VersionSelecter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Description;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Creator\VersionSelecter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Version;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Creator\VersionSelecter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EULA;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RSM;component/creator/versionselecter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Creator\VersionSelecter.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Variants = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\..\..\Creator\VersionSelecter.xaml"
            this.Variants.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.VariantsUpdated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Version = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\..\..\Creator\VersionSelecter.xaml"
            this.Version.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.VersionUpdated);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EULA = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 42 "..\..\..\..\..\Creator\VersionSelecter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Continue);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 43 "..\..\..\..\..\Creator\VersionSelecter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

