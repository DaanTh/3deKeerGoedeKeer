﻿#pragma checksum "..\..\Tafels.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B19CF34CCDFD4A1A7F592C6B58DB8BCB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ProjectChallenge {
    
    
    /// <summary>
    /// Tafels
    /// </summary>
    public partial class Tafels : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Tafels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox punten;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\Tafels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox op10;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Tafels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox oefening;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Tafels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uitkomst;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Tafels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button volgende;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Tafels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eindig;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/tafels.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tafels.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.punten = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.op10 = ((System.Windows.Controls.TextBox)(target));
            
            #line 7 "..\..\Tafels.xaml"
            this.op10.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.op10_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.oefening = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.uitkomst = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.volgende = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Tafels.xaml"
            this.volgende.Click += new System.Windows.RoutedEventHandler(this.volgende_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.eindig = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

