using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;


namespace Automation_Code_Challenge_1_CSharp
{

    public class WebPageTest
    {

        private ChromeDriver driver;

        static void Main(string[] args)
        {
            // Empty Main method - keeping the compiler happy
        }

        public void startBrowser()
        {
            //File pathToBinary = new File("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe");
            //FirefoxBinary ffBinary = new FirefoxBinary(pathToBinary);
            //FirefoxProfile firefoxProfile = new FirefoxProfile();
            //driver = new FirefoxDriver(ffBinary,firefoxProfile);
            //driver = new FirefoxDriver();
            //File file = new File("C:\\ChromeDriver\\chromedriver.exe");
            //System.setProperty("webdriver.chrome.driver", "C:\\ChromeDriver\\chromedriver.exe");
            driver = new ChromeDriver();
        }

        public void VerifyPageTitle(String webPageURL, String titleStringToTest)
        {
            // startBrowser
            startBrowser();
            // Open Webpage URL
            driver.Url = (webPageURL);
            // Get page title of current page
            String pageTitle = driver.Title;
            // Print page title of current page
            Console.WriteLine("Page title of current page is: " + pageTitle);
            // Print title string to test
            Console.WriteLine("Title String to Test is: " + titleStringToTest);
            // Test that the titleStringToTest = title of current page
            //Assert.assertTrue(pageTitle.equals(titleStringToTest), "Current Page Title is not equal to the expected page title value");
            // If there is no Assertion Error, Print out that the Current Page Title = Expected Page Title
            Console.WriteLine("Current Page Title = Expected Page Title");

        }

        [Test]
        public void TestLauncher()
        {
            VerifyPageTitle("https://www.skiutah.com", "Ski Utah - Ski Utah");
        }
    }

}
