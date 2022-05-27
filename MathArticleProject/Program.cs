using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArticleProject
{
    internal class Program
    {

        static void Main(String[] args)
        {

            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://www.goto.com/meeting";
            //driver.Url = "https://opensource-demo.orangehrmlive.com/";
            //driver.Url = "https://www.facebook.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(50);
            /*String  curentURL=driver.Url;
            Console.WriteLine(curentURL);

           String title= driver.Title;
            Console.WriteLine(title);

            String pageSource=driver.PageSource;

            Console.WriteLine(pageSource);
            Console.WriteLine(pageSource.Contains("LOGIN Panel"));

            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();
            driver.FindElement(By.Id("welcome")).Click();
            driver.FindElement(By.LinkText("Logout"));*/
            /*driver.Url = "https://www.facebook.com";
            driver.FindElement(By.LinkText("Create New Account")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys("John");
            driver.FindElement(By.Name("lastname")).SendKeys("Wick");
            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome@123");

            //Enter the Date
            SelectElement selectDate = new SelectElement(driver.FindElement(By.Id("day")));
            selectDate.SelectByText("15");
            //Enter Month
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Dec");
            //Enter Year

            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("2000");


            driver.FindElement(By.XPath("//input[@value='-1']")).Click();
            driver.FindElement(By.Name("websubmit")).Click();*/

            //Day 5 Assignment

            driver.FindElement(By.XPath("//button[text()='Accept Recommended Settings']")).Click();
            driver.FindElement(By.LinkText("Try Free")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("John");

            driver.FindElement(By.Id("last-name")).SendKeys("Wick");
            driver.FindElement(By.Id("login__email")).SendKeys("john@gmail.com");
            //driver.FindElement(By.ClassName("select__select - wrapper")).Click();

            SelectElement selectCompSize = new SelectElement(driver.FindElement(By.Id("CompanySize")));

            selectCompSize.SelectByText("10 - 99");

            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();

            driver.Quit();
            









        }

    }
}
