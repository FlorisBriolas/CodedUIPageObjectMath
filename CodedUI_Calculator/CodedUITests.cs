﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using CodedUI_Calculator.SharedClasses;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUI_Calculator
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITests
    {
        public CodedUITests()
        {
        }

        private Shared codePage;

        [TestInitialize]
       public void Init()
       {
           codePage = App.Start();
       }


       [TestMethod]
       public void Multiply_100_8_Expects800()
       {
           //Act
           var result = codePage.Basic().push_1().push_0().push_0().
               Multiply().
               push_8().
               Equals().Result;
           //Assert
           Assert.AreEqual("800",result);
           // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
       }

       [TestMethod]
       public void Sqrt_4_Min_4_Expects0()
       {
           //Act
           var result = codePage.Basic().push_4().Sqrt().
               Substract().
               push_4().
               Equals().Result;
           //Assert
           Assert.AreEqual("-2", result);
       }


       [TestMethod]
       public void Sqrt_4_Min_2_Expects0()
       {
           //Act
           var result = codePage.Basic().push_4().Sqrt().
               Substract().
               push_2().
               Equals().Result;
           //Assert
           Assert.AreEqual("0", result);
       }

       [TestMethod]
       public void Both_Basic_and_Scientific_SQRT4Min2_ExpectsSameResult()
       {
           //Act
           var result1 = codePage.Basic().push_4().Sqrt().
               Substract().
               push_2().
               Equals().Result;

           var result2 = codePage.Scientific().push_4().Sqrt().
               Substract().
               push_2().
               Equals().Result;
           //Assert
           Assert.AreEqual(result1, result2);
       }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }

  
}
