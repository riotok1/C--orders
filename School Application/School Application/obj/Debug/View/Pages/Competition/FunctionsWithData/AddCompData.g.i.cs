﻿#pragma checksum "..\..\..\..\..\..\View\Pages\Competition\FunctionsWithData\AddCompData.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5D5FD7F73B90D936FCAF699574BE459F4F8D404158BCA6CEACF6C17AB9F9B106"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using School_Application.View.Pages.Competition.FunctionsWithData;
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


namespace School_Application.View.Pages.Competition.FunctionsWithData {
    
    
    /// <summary>
    /// AddCompData
    /// </summary>
    public partial class AddCompData : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\..\View\Pages\Competition\FunctionsWithData\AddCompData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLoad;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\View\Pages\Competition\FunctionsWithData\AddCompData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\View\Pages\Competition\FunctionsWithData\AddCompData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/School Application;component/view/pages/competition/functionswithdata/addcompdat" +
                    "a.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\View\Pages\Competition\FunctionsWithData\AddCompData.xaml"
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
            this.imgLoad = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.openBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\..\..\View\Pages\Competition\FunctionsWithData\AddCompData.xaml"
            this.openBtn.Click += new System.Windows.RoutedEventHandler(this.openBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\..\View\Pages\Competition\FunctionsWithData\AddCompData.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
