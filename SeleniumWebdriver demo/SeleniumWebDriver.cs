using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumWebdriver_demo
{
    public class SeleniumWebDriver
    {
        static void Main(string[] args)
        {
            //creating browser
            var driver = new ChromeDriver();
            //navi to wikipedia
            driver.Url = "https://wikipedia.org";

            //get page title
            var pageTitle = driver.Title;
            Console.WriteLine("The page title is: " + pageTitle);
            if (pageTitle == "Wikipedia")
            {
                Console.WriteLine("Test PASS");

            }
            else
            {
                Console.WriteLine("Test Fail");
            }
            //close browser
            driver.Quit();  
            
        }
    }
}
