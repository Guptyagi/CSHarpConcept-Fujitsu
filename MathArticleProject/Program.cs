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
    internal class Program
    {

        static void MainP(String[] args)
        {

            ChromeDriver driver = new ChromeDriver();
            //driver.Url="https://nasscom.in/";
            //driver.URL="https://www.ilovepdf.com/pdf_to_word";
            //driver.Url = "https://netbanking.hdfcbank.com/IpinResetUsingOTP.htm";
            //driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            //driver.Url = "https://www.db4free.net";
            //driver.Url = "https://www.goto.com/meeting";
            //driver.Url = "https://opensource-demo.orangehrmlive.com/";
            //driver.Url = "https://www.facebook.com";
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(40);
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
            //Navigate on to https://www.goto.com/meeting

            /*driver.FindElement(By.XPath("//button[text()='Accept Recommended Settings']")).Click();
            driver.FindElement(By.LinkText("Try Free")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("John");

            driver.FindElement(By.Id("last-name")).SendKeys("Wick");
            driver.FindElement(By.Id("login__email")).SendKeys("john@gmail.com");
            //driver.FindElement(By.ClassName("select__select - wrapper")).Click();

            SelectElement selectCompSize = new SelectElement(driver.FindElement(By.Id("CompanySize")));

            selectCompSize.SelectByText("10 - 99");

            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();

            driver.Quit();*/

            //How to switch to the iFrame OR Frame

            /*driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            //driver.SwitchTo().Frame(drive.FindElement(By.XPath("//frame[contains(@src, 'RSNB')]");

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("Test@123");

            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //Switch to Main HTML

            driver.SwitchTo().DefaultContent();*/


            //driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("");

            //Clicking on Go and Switching to Alert

            /*driver.FindElement(By.XPath("//img[@alt='Go']")).Click();
            
            Thread.Sleep(500);

            String AleString=driver.SwitchTo().Alert().Text;

           Console.WriteLine(AleString);

            driver.SwitchTo().Alert().Accept();

            driver.Close();*/

            //ilove.pdf.com How to Upload File

            //driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"c:\Seleium\ABC.pdf");

            //How to Open a new Window

            // driver.SwitchTo().NewWindow(WindowType.Window);


            //Navigate onto nasscom.in perform Mouse Over on Membership
/*
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[text()='Members Listing']")).Click();
            Thread.Sleep(2000);*/

            //Navigate Onto https://www.salesforce.com/in/form/signup/freetrial-sales/
            //Task 2- Day4

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.Manage().Window.Maximize();

            //Enter First Name
            driver.FindElement(By.XPath("//input[@name='UserFirstName']")).SendKeys("John");

            //Enter Last Name
            driver.FindElement(By.XPath("//input[@name='UserLastName']")).SendKeys("Wick");

            //Enter Email ID
            driver.FindElement(By.XPath("//input[@name='UserEmail']")).SendKeys("John@gmil.com");

            //Enter Job Title
            SelectElement selectJobTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectJobTitle.SelectByText("IT Manager");

            //Enter No. of Employees
            SelectElement selectEmployees = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployees.SelectByText("101 - 500 employees");

            //Enter Country Name
            SelectElement selectCountryName = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountryName.SelectByText("United Kingdom");

            //Enter CompanyName
            driver.FindElement(By.XPath("//input[@Name='CompanyName']")).SendKeys("XYZ");

            //Select Checkbox
            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[1]")).Click();

            //Click on Button Start My Free Trial
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            //Capture Error for Phone No.
            String ErrorValidPhoneNo = driver.FindElement(By.XPath("//span[text()='Enter a valid phone number']")).Text;
            Console.WriteLine("Error Message: "+ ErrorValidPhoneNo);

            if (ErrorValidPhoneNo == "Enter a valid phone number")
            {
                Console.WriteLine("Assertion Passed");
            }
            else Console.WriteLine("Assertion Failed");

            



        }

    }
}
