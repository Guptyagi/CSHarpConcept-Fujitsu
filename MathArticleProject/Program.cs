using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            String  curentURL=driver.Url;
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
            driver.FindElement(By.LinkText("Logout"));

        }

    }
}
