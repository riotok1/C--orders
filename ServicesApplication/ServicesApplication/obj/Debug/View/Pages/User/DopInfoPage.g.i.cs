﻿#pragma checksum "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EDE4E48A29F32EE682FE824B4C6D9936D3477EF614C64743CB202C29DA8623FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ServicesApplication.View.Pages.User;
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


namespace ServicesApplication.View.Pages.User {
    
    
    /// <summary>
    /// DopInfoPage
    /// </summary>
    public partial class DopInfoPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock serviceTxb;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock timingTxb;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dateDtp;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock priceTxb;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock descriptionTxb;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/ServicesApplication;component/view/pages/user/dopinfopage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
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
            
            #line 7 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
            ((ServicesApplication.View.Pages.User.DopInfoPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.serviceTxb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.timingTxb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.dateDtp = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.priceTxb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.descriptionTxb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\..\View\Pages\User\DopInfoPage.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
