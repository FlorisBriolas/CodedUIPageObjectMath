using CodedUI_Calculator.SharedClasses;

namespace CodedUI_Calculator.BasicClasses
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


    public partial class Basic : Shared
    {

        public Basic push_1()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow.UIItem1Button);
            return this;
        }

        public Basic push_2()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow1.UIItem2Button);
            return this;
        }

        public Basic push_3()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow2.UIItem3Button);
            return this;
        }

        public Basic push_4()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow3.UIItem4Button);
            return this;
        }

        public Basic push_5()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow4.UIItem5Button);
            return this;
        }

        public Basic push_6()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow5.UIItem6Button);
            return this;
        }

        public Basic push_7()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow6.UIItem7Button);
            return this;
        }

        public Basic push_8()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow7.UIItem8Button);
            return this;
        }

        public Basic push_9()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow8.UIItem9Button);
            return this;
        }

        public Basic push_0()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow9.UIItem0Button);
            return this;
        }

        public Basic Decimal()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow10.UIDecimalseparatorButton);
            return this;
        }

        public Basic Add()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow11.UIAddButton);
            return this;
        }

        public Basic Minus()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow12.UISubtractButton);
            return this;
        }

        public Basic Multiply()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow13.UIMultiplyButton);
            return this;
        }

        public Basic Divide()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow14.UIDivideButton);
            return this;
        }
        
        public Basic Equals()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow15.UIEqualsButton);
            return this;
        }

        public Basic Sqrt()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow18.UISquarerootButton);
            return this;
        }

        public Basic Clear()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow20.UIClearButton);
            return this;
        }

        public string Result
        {
            get { return this.UICalculatorWindow.UIItem0Window.UIItem0Text.DisplayText; }
        }

    }
}
