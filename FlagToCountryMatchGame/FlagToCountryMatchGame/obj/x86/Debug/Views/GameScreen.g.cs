﻿#pragma checksum "C:\Users\jdsta\CountryGuesser\FlagToCountryMatchGame\FlagToCountryMatchGame\Views\GameScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "479DE928C9CCD38CE16E27D7A36213755778078732F68C9FA3F4B07B48575311"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlagToCountryMatchGame.Views
{
    partial class GameScreen : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\GameScreen.xaml line 15
                {
                    this.CountryName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Views\GameScreen.xaml line 16
                {
                    this.Flag = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // Views\GameScreen.xaml line 17
                {
                    this.Captial = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Views\GameScreen.xaml line 18
                {
                    this.CorrectGuesses = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\GameScreen.xaml line 19
                {
                    this.incorrectGuesses = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Views\GameScreen.xaml line 20
                {
                    this.TimerText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\GameScreen.xaml line 21
                {
                    this.CorrectIncorrect = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\GameScreen.xaml line 22
                {
                    this.Hint = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Views\GameScreen.xaml line 30
                {
                    this.BackBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackBtn).Click += this.BackBtn_Click;
                }
                break;
            case 11: // Views\GameScreen.xaml line 25
                {
                    this.Guess = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // Views\GameScreen.xaml line 26
                {
                    this.NextBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.NextBtn).Click += this.NextBtnClicked;
                }
                break;
            case 13: // Views\GameScreen.xaml line 27
                {
                    this.HintBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.HintBtn).Click += this.HintBtnClicked;
                }
                break;
            case 14: // Views\GameScreen.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.GuesBtnClicked;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

