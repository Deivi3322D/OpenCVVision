﻿#pragma checksum "..\..\..\..\..\Operation\Op05Morphology\MorphologyView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8A3F049BD0C682E5A44F9E5B07AC9FDB5C5B7BBD"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Client.View.Operation;
using Client.ViewModel.Operation;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ReactiveUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Client.View.Operation {
    
    
    /// <summary>
    /// MorphologyView
    /// </summary>
    public partial class MorphologyView : ReactiveUI.ReactiveUserControl<Client.ViewModel.Operation.MorphologyViewModel>, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\Operation\Op05Morphology\MorphologyView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card cardMain;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Operation\Op05Morphology\MorphologyView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Operation\Op05Morphology\MorphologyView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxMorphologyModes;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Operation\Op05Morphology\MorphologyView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxMorphShapes;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\Operation\Op05Morphology\MorphologyView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderKernelSizeX;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\Operation\Op05Morphology\MorphologyView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderKernelSizeY;
        
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
            System.Uri resourceLocater = new System.Uri("/Client.View;V1.0.0.0;component/operation/op05morphology/morphologyview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Operation\Op05Morphology\MorphologyView.xaml"
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
            this.cardMain = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            case 2:
            this.Title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.cbxMorphologyModes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cbxMorphShapes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.sliderKernelSizeX = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.sliderKernelSizeY = ((System.Windows.Controls.Slider)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

