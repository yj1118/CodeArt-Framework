﻿#pragma checksum "..\..\..\..\Playstation\ProgressBar\ProgressBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DAEF22169CDACC47E71F9C9D195D3153038CEA69"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using CodeArt.WPF.Controls.Playstation;
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


namespace CodeArt.WPF.Controls.Playstation {
    
    
    /// <summary>
    /// ProgressBox
    /// </summary>
    public partial class ProgressBox : CodeArt.WPF.Controls.Playstation.WorkScene, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\Playstation\ProgressBar\ProgressBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CodeArt.WPF.Controls.Playstation.Page page;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\Playstation\ProgressBar\ProgressBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid inProgress;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Playstation\ProgressBar\ProgressBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CodeArt.WPF.Controls.Playstation.ProgressBar progress;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Playstation\ProgressBar\ProgressBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CodeArt.WPF.Controls.Playstation.Button cancel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Playstation\ProgressBar\ProgressBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid completed;
        
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
            System.Uri resourceLocater = new System.Uri("/CodeArt.WPF.Controls;component/playstation/progressbar/progressbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Playstation\ProgressBar\ProgressBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.page = ((CodeArt.WPF.Controls.Playstation.Page)(target));
            return;
            case 2:
            this.inProgress = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.progress = ((CodeArt.WPF.Controls.Playstation.ProgressBar)(target));
            return;
            case 4:
            this.cancel = ((CodeArt.WPF.Controls.Playstation.Button)(target));
            return;
            case 5:
            this.completed = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

