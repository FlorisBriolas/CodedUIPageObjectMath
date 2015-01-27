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


    public partial class Basic : Shared<Basic>
    {
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
    }
}
