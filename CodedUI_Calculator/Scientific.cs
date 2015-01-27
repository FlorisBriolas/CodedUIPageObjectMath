using CodedUI_Calculator.SharedClasses;

namespace CodedUI_Calculator.ScientificClasses
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


    public partial class Scientific : Shared<Scientific>
    {
        public Scientific Negate()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow.UINegateButton);
            return this;
        }

        public Scientific Sqrt()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow1.UISquarerootButton);
            return this;
        }

        public Scientific Divide()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow2.UIDivideButton);
            return this;
        }

        public Scientific Percantage()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow3.UIPercentageButton);
            return this;
        }

        public Scientific Multiply()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow4.UIMultiplyButton);
            return this;
        }

        public Scientific Reciprocal()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow5.UIReciprocalButton);
            return this;
        }

        public Scientific Substract()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow6.UISubtractButton);
            return this;
        }

        public Scientific Equals()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow7.UIEqualsButton);
            return this;
        }

        public Scientific Add()
        {
            Mouse.Click(this.UICalculatorWindow.UIItemWindow8.UIAddButton);
            return this;
        }
    }
}
