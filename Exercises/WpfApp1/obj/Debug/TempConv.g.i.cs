// Updated by XamlIntelliSenseFileGenerator 2021-01-08 7:28:43 PM
#pragma checksum "..\..\TempConv.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F2CE706159BAC4B330435C2A85DEC99B12EEEB2586FBD92D046877B07F35ADB"
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
using System.Windows.Shell;
using WpfApp1;


namespace WpfApp1
{


    /// <summary>
    /// TempConv
    /// </summary>
    public partial class TempConv : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\TempConv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label input;

#line default
#line hidden


#line 11 "..\..\TempConv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label inputScale;

#line default
#line hidden


#line 12 "..\..\TempConv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label outputScale;

#line default
#line hidden


#line 14 "..\..\TempConv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label output;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/tempconv.xaml", System.UriKind.Relative);

#line 1 "..\..\TempConv.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.input = ((System.Windows.Controls.Label)(target));
                    return;
                case 2:
                    this.inputScale = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.outputScale = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.output = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.inpt = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:
                    this.outp = ((System.Windows.Controls.TextBlock)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.RadioButton rbtnInputCelcius;
        internal System.Windows.Controls.RadioButton rbtnInputFarenheit;
        internal System.Windows.Controls.RadioButton rbtnInputKelvin;
        internal System.Windows.Controls.RadioButton rbtnOutputCelcius;
        internal System.Windows.Controls.RadioButton rbtnOutputFarenheit;
        internal System.Windows.Controls.RadioButton rbtnOutputKelvin;
        internal System.Windows.Controls.TextBlock lblResult;
        internal System.Windows.Controls.TextBlock lblInput;
    }
}

