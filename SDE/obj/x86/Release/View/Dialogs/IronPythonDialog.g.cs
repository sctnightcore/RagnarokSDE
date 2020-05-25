﻿#pragma checksum "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E91DC700BF3171B552261408229C35E7420526B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Rendering;
using ICSharpCode.AvalonEdit.Search;
using SDE.WPF;
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
    /// IronPythonDialog
    /// </summary>
    public partial class IronPythonDialog : TokeiLibrary.WPF.Styles.TkWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid _jobGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition _rowConsole;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TokeiLibrary.WPF.Styles.TkMenuItem _miLoadRecent;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem _miAutocomplete;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ICSharpCode.AvalonEdit.TextEditor _textEditor;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _tbOutput;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TokeiLibrary.WPF.Styles.FancyButton _buttonCloseConsole;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonOk;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
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
            System.Uri resourceLocater = new System.Uri("/SDE;component/view/dialogs/ironpythondialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
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
            this._rowConsole = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            
            #line 25 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((TokeiLibrary.WPF.Styles.TkMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._buttonOk_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((TokeiLibrary.WPF.Styles.TkMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._miLoadClear_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((TokeiLibrary.WPF.Styles.TkMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._miLoadLoad_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this._miLoadRecent = ((TokeiLibrary.WPF.Styles.TkMenuItem)(target));
            return;
            case 7:
            
            #line 30 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((TokeiLibrary.WPF.Styles.TkMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._buttonSave_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 32 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this._miAutocomplete = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 10:
            
            #line 38 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._miSample_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 39 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._miSample_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 40 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._miSample_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 41 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._miSample_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 42 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._miSample_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 43 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this._miSample_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this._textEditor = ((ICSharpCode.AvalonEdit.TextEditor)(target));
            return;
            case 17:
            this._tbOutput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            this._buttonCloseConsole = ((TokeiLibrary.WPF.Styles.FancyButton)(target));
            
            #line 54 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            this._buttonCloseConsole.Click += new System.Windows.RoutedEventHandler(this._button_ConsoleClose_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this._buttonOk = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            this._buttonOk.Click += new System.Windows.RoutedEventHandler(this._buttonOk_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this._buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\..\View\Dialogs\IronPythonDialog.xaml"
            this._buttonCancel.Click += new System.Windows.RoutedEventHandler(this._buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
