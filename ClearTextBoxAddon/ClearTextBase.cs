using ClearTextBoxAddon.Addons;
using OpenQA.Selenium;
using System.Threading;
using TestProject.SDK;
using TestProject.SDK.Drivers;

namespace ClearTextBoxAddon
{
    public class ClearTextBase
    {

        public static void RunAction(Runner runner)
        {
            var action = new ClearText();

            var driver = (WebDriver)runner.GetDriver();

            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            driver.FindElementByName("UserName").SendKeys("admin");
            driver.FindElementByName("Password").SendKeys("admin");

            //Call the ClearText addon - Password control
            runner.Run(action, By.Name("Password"));

            Thread.Sleep(3000);
        }

    }
}
