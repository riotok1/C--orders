﻿#pragma checksum "..\..\..\..\..\..\View\Pages\Students\FunctionsWithData\StudAddOrEditPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "341805DB3C89D71822D0122A0EC17DCB2C700C309E9D0CDD00BAE2BDD73B0464"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using School_Application.View.Pages.Students.FunctionsWithData;
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


namespace School_Application.View.Pages.Students.FunctionsWithData {
    
    
    /// <summary>
    /// StudAddOrEditPage
    /// </summary>
    public partial class StudAddOrEditPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 72 "..\..\..\..\..\..\View\Pages\Students\FunctionsWithData\StudAddOrEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\..\View\Pages\Students\FunctionsWithData\StudAddOrEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addOrEditBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/School Application;component/view/pages/students/functionswithdata/studaddoredit" +
                    "page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\View\Pages\Students\FunctionsWithData\StudAddOrEditPage.xaml"
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
            
            #line 7 "..\..\..\..\..\..\View\Pages\Students\FunctionsWithData\StudAddOrEditPage.xaml"
            ((School_Application.View.Pages.Students.FunctionsWithData.StudAddOrEditPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\..\..\View\Pages\Students\FunctionsWithData\StudAddOrEditPage.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addOrEditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\..\..\View\Pages\Students\FunctionsWithData\StudAddOrEditPage.xaml"
            this.addOrEditBtn.Click += new System.Windows.RoutedEventHandler(this.addOrEditBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

