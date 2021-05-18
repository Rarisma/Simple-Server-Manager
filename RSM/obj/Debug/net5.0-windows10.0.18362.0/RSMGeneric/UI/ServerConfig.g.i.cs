// Updated by XamlIntelliSenseFileGenerator 18/05/2021 22:15:36
#pragma checksum "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0980A6E00FB2CE03E6DC1CEDDFF224F5833B4745"
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
using RSM.RSMGeneric.UI;
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


namespace RSM.RSMGeneric.UI
{


    /// <summary>
    /// ServerConfig
    /// </summary>
    public partial class ServerConfig : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ServerName;

#line default
#line hidden


#line 22 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PerGameSettings;

#line default
#line hidden


#line 27 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton OnLaunch;

#line default
#line hidden


#line 28 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Weekly;

#line default
#line hidden


#line 29 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Monthly;

#line default
#line hidden


#line 30 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Disabled;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RSM;component/rsmgeneric/ui/serverconfig.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.ServerName = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 2:
                    this.PerGameSettings = ((System.Windows.Controls.Frame)(target));
                    return;
                case 3:
                    this.OnLaunch = ((System.Windows.Controls.RadioButton)(target));

#line 27 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
                    this.OnLaunch.Click += new System.Windows.RoutedEventHandler(this.FrequencyOnLaunch);

#line default
#line hidden
                    return;
                case 4:
                    this.Weekly = ((System.Windows.Controls.RadioButton)(target));

#line 28 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
                    this.Weekly.Click += new System.Windows.RoutedEventHandler(this.FrequencyWeekly);

#line default
#line hidden
                    return;
                case 5:
                    this.Monthly = ((System.Windows.Controls.RadioButton)(target));

#line 29 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
                    this.Monthly.Click += new System.Windows.RoutedEventHandler(this.FrequencyMonthly);

#line default
#line hidden
                    return;
                case 6:
                    this.Disabled = ((System.Windows.Controls.RadioButton)(target));

#line 30 "..\..\..\..\..\RSMGeneric\UI\ServerConfig.xaml"
                    this.Disabled.Click += new System.Windows.RoutedEventHandler(this.FrequencyDisabled);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBlock ServerVersion;
        internal System.Windows.Controls.TextBlock LatestVersion;
        internal System.Windows.Controls.TabItem ServerVer;
    }
}

