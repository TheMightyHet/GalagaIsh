﻿#pragma checksum "C:\GameFiles\GalagaIsh\UWPGame\GameStage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D0F4E35BE3BCF24D20825ED722BDE8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWPGame
{
    partial class GameStage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // GameStage.xaml line 17
                {
                    this.GameCanvas = (global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)(target);
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.GameCanvas).CreateResources += this.GameCanvas_CreateResources;
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.GameCanvas).Draw += this.GameCanvas_Draw;
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.GameCanvas).Tapped += this.GameCanvas_Tapped;
                }
                break;
            case 3: // GameStage.xaml line 23
                {
                    this.Lefty = (global::Windows.UI.Xaml.Controls.Primitives.RepeatButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.RepeatButton)this.Lefty).Click += this.Lefty_Click;
                }
                break;
            case 4: // GameStage.xaml line 40
                {
                    this.Righty = (global::Windows.UI.Xaml.Controls.Primitives.RepeatButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.RepeatButton)this.Righty).Click += this.Righty_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
