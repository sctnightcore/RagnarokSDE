﻿#pragma checksum "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9686ABBB9DE87B64CE66F84EBF1E9D1C7924F212"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using TokeiLibrary;
using TokeiLibrary.WPF.Styles;
using TokeiLibrary.WPF.Styles.ListView;


namespace SDE.View.Dialogs {
    
    
    /// <summary>
    /// ReplaceDialog
    /// </summary>
    public partial class ReplaceDialog : TokeiLibrary.WPF.Styles.TkWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid _jobGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _cbAttribute;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _tbNewValue;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonOk;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/SDE;component/view/dialogs/replacedialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml"
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
            this._jobGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this._cbAttribute = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this._tbNewValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this._buttonOk = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml"
            this._buttonOk.Click += new System.Windows.RoutedEventHandler(this._buttonOk_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\View\Dialogs\ReplaceDialog.xaml"
            this._buttonCancel.Click += new System.Windows.RoutedEventHandler(this._buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

