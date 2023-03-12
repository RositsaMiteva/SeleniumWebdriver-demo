using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumWebDriverNunitDemo
{
    public class WebDriverTests
    {
        private WebDriver driver;
        private string searchInput;

        [SetUp]
        public void OpenBrowser()
        {
            this.driver = new ChromeDriver();
        }
        [TearDown]
        public void CloseBrowser()
        {
           // this.driver.Quit();
        }

        [Test]
        public void Test_CheckTitle()
        {
            driver.Url = "https://wikipedia.org";
            var pageTitle = driver.Title;
            Assert.That("Wikipedia", Is.EqualTo(pageTitle));

        }
        [Test]  
        public void TestWikipediaSearchFiled()
        {
            driver.Url = "https://wikipedia.org";
            var searchfiled = driver.FindElement(By.Id("searchInput"));
            searchfiled.SendKeys("QA" + Keys.Enter);
            var pageTitle = driver.Title;
           Assert.That("QA - Wikipedia", Is.EqualTo(pageTitle));
           
        }
        [Test]
        public void TestWikipediaCheckItaliano() 
        {
            var allStrongElements = driver.FindElement(By.TagName("strong"));
            var italianoLinkText = allStrongElements[7].Text;
            Assert.That("Italiano", Is.EqualTo(italianoLinkText));


        }

    }
}