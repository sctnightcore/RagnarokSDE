﻿#pragma checksum "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7B633BB1A0F90A9AD888D91B40FC1F9B008725C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ColorPicker.Sliders;
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
    /// SkillLevelEditDialog
    /// </summary>
    public partial class SkillLevelEditDialog : TokeiLibrary.WPF.Styles.TkWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid _upperGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ColorPicker.Sliders.SliderColor _gpRate;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid _footerGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _buttonOk;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml"
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
            System.Uri resourceLocater = new System.Uri("/SDE;component/view/dialogs/skillleveleditdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml"
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
            this._upperGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this._gpRate = ((ColorPicker.Sliders.SliderColor)(target));
            return;
            case 3:
            this._footerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this._buttonOk = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml"
            this._buttonOk.Click += new System.Windows.RoutedEventHandler(this._buttonOk_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\View\Dialogs\SkillLevelEditDialog.xaml"
            this._buttonCancel.Click += new System.Windows.RoutedEventHandler(this._buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

