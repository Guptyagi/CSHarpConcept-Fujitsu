using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Day5Program
    {

        static void Main(String[] args)
        {

            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(50);

            //Day 4 Task 3 Navigate to citibank.co.in

            driver.Url = "https://www.online.citibank.co.in/";

            //Click on Popup

            driver.FindElement(By.LinkText("Proceed to Home Page")).Click();

            Thread.Sleep(7000);

            driver.FindElement(By.XPath("//span[@class='txtSign']")).Click();

            Thread.Sleep(7000);

            // Switch t second tab

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            //driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[contains(@src,'about:blank')]")));

            //Click on Forgot User ID

            driver.FindElement(By.XPath("//div[contains(text(),' Forgot User ID? ')]")).Click();

            driver.FindElement(By.XPath("(//a[text()='select your product type'])[1]")).Click();

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//a[text()='Credit Card']")).Click();

            //Enter Credit Card Number

            driver.FindElement(By.XPath("//input[@Name='citiCard1']")).SendKeys("4545");

            driver.FindElement(By.XPath("//input[@Name='citiCard2']")).SendKeys("5656");

            driver.FindElement(By.XPath("//input[@Name='citiCard3']")).SendKeys("8887");

            driver.FindElement(By.XPath("//input[@Name='citiCard4']")).SendKeys("9998");

            //Enter CVV No.

            driver.FindElement(By.XPath("//input[@Name='CCVNO']")).SendKeys("555");

            Thread.Sleep(4000);

            //ENter Date

            driver.ExecuteScript("document.querySelector('#bill-date-long').value = '13/05/2000'");

            //driver.FindElement(By.Id("bill-date-long")).SendKeys("14/04/2022");

            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//b[contains(text(),'Terms and Conditions')]")).Click();

            


            //Click on Proceed

            driver.FindElement(By.XPath("//input[@type='button']")).Click();






            //Day 5 Task 1 

            /*driver.SwitchTo().NewWindow(WindowType.Window);

            driver.Url= "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";*/














        }

    }
}
