using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using mrsLibrary;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Practice_form_nunit_Testing
{
    
     class Practice : Library
    {
        [SetUp]
        public void intiliaze()
        {
            chrome("https://demoqa.com/text-box");


            time(2000);
        }
        [Test]
        public void TextBox()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            string name = "Rachit Kumar";
            string email = "rachitkumar3014@gmail.com";
            string Caddress = "koderma";
            string Paddress = "patna";

            time(2000);
            Findid("userName").SendKeys(name);
            time(2000);
            Findid("userEmail").SendKeys(email);
            time(2000);
            Findid("currentAddress").SendKeys(Caddress);
            time(2000);
            Findid("permanentAddress").SendKeys(Paddress);

            time(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            time(2000);

            Findid("submit").Click();
            time(5000);
            

            Console.WriteLine("test case ended");
        }
        [TearDown]
        public void endtest()
        {
            quit();

        }
    }
}
