﻿#pragma checksum "..\..\ColorPickerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA5E253889195969A4C2339BEFFAED68CBBBCA2EEDDC504288AE32E57A3125A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyPaint;
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


namespace MyPaint {
    
    
    /// <summary>
    /// ColorPickerWindow
    /// </summary>
    public partial class ColorPickerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas colorArea;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider brightSlider;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas pickedColor;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hueTextBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contrastTextBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox brightTextBox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox redTextBox;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox greenTextBox;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\ColorPickerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox blueTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/MyPaint;component/colorpickerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ColorPickerWindow.xaml"
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
            this.colorArea = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.brightSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 41 "..\..\ColorPickerWindow.xaml"
            this.brightSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.brightSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pickedColor = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.hueTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\ColorPickerWindow.xaml"
            this.hueTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 72 "..\..\ColorPickerWindow.xaml"
            this.hueTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.contrastTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 81 "..\..\ColorPickerWindow.xaml"
            this.contrastTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 82 "..\..\ColorPickerWindow.xaml"
            this.contrastTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.brightTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\ColorPickerWindow.xaml"
            this.brightTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.brightTextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 92 "..\..\ColorPickerWindow.xaml"
            this.brightTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.redTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\ColorPickerWindow.xaml"
            this.redTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 102 "..\..\ColorPickerWindow.xaml"
            this.redTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.TextBoxRGB_KeyUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.greenTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 111 "..\..\ColorPickerWindow.xaml"
            this.greenTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 112 "..\..\ColorPickerWindow.xaml"
            this.greenTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.TextBoxRGB_KeyUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.blueTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 121 "..\..\ColorPickerWindow.xaml"
            this.blueTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 122 "..\..\ColorPickerWindow.xaml"
            this.blueTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.TextBoxRGB_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
