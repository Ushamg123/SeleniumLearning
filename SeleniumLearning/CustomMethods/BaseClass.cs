using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.CustomMethods
{
    public class BaseClass
    {

        // custom method for entering a text in to a field
        public void EnterText(IWebElement element, string value)
        {
            element.Click();
            element.Clear();
            element.SendKeys(value);
        }
        // Custom Method for Selecting from a dropdown
        public static void SelectFromDropDownByText(IWebElement element, string inputText)
        {
            SelectElement se = new SelectElement(element);
            se.SelectByText(inputText);
        }
        // Custom Method for Selecting from a dropdown using values
        public static void SelectFromDropDownByValue(IWebElement element, string inputValue)
        {
            SelectElement se = new SelectElement(element);
            se.SelectByText(inputValue);
        }
        public static void SelectFromDropDownByIndex(IWebElement element, int index)
        {
            //new SelectElement(element).SelectByValue(inputValue);
            SelectElement se = new SelectElement(element);
            se.SelectByIndex(index);
        }

    }
}
