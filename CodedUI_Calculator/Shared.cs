using CodedUI_Calculator.BasicClasses;

namespace CodedUI_Calculator.SharedClasses
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class Shared
    {
        public Basic Basic()
        {
            SwitchToBasic();
            return new Basic();
        }

        public string Result
        {
            get { return this.UICalculatorWindow.UIResultWindow.UIResultText.DisplayText; }
        }

    }

    public partial class Shared<T> : Shared
        where T : Shared
    {

        public T push_0()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow.UIItem0Button);
            return this as T;
        }

        public T push_1()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow1.UIItem1Button);
            return this as T;
        }

        public T push_2()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow2.UIItem2Button);
            return this as T;
        }

        public T push_3()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow3.UIItem3Button);
            return this as T;
        }

        public T push_4()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow4.UIItem4Button);
            return this as T;
        }

        public T push_5()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow5.UIItem5Button);
            return this as T;
        }
        public T push_6()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow6.UIItem6Button);
            return this as T;
        }
        public T push_7()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow7.UIItem7Button);
            return this as T;
        }

        public T push_8()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow8.UIItem8Button);
            return this as T;
        }
        public T push_9()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow9.UIItem9Button);
            return this as T;
        }
    }
}
