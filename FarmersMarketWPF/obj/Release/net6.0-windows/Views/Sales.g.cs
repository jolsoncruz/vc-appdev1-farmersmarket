﻿#pragma checksum "..\..\..\..\Views\Sales.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5CA4BF3A3943B060C0EEE7335882F6A633C6C160"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FarmersMarket;
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


namespace FarmersMarket {
    
    
    /// <summary>
    /// Sales
    /// </summary>
    public partial class Sales : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Sales;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView grid_Products;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Min;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView grid_Basket;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_GrandTotal;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle box_Total;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Buy;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_GrandTotalValue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FarmersMarket;component/views/sales.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Sales.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbl_Sales = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.grid_Products = ((System.Windows.Controls.ListView)(target));
            
            #line 12 "..\..\..\..\Views\Sales.xaml"
            this.grid_Products.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grid_Products_Selection);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_Add = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Views\Sales.xaml"
            this.btn_Add.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Min = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Views\Sales.xaml"
            this.btn_Min.Click += new System.Windows.RoutedEventHandler(this.btn_Min_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grid_Basket = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.lbl_GrandTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.box_Total = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this.btn_Buy = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Views\Sales.xaml"
            this.btn_Buy.Click += new System.Windows.RoutedEventHandler(this.btn_Buy_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbl_GrandTotalValue = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

