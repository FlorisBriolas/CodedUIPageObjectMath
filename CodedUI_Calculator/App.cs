using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodedUI_Calculator.BasicClasses;
using CodedUI_Calculator.SharedClasses;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUI_Calculator
{
    static class App
    {
        private static ApplicationUnderTest _instance;

        public static Shared Start()
        {
            _instance = ApplicationUnderTest.Launch(@"c:\windows\system32\calc.exe");
            return new Shared();
        }

    }
}
