using System;
using OpenQA.Selenium;
using TestProject.Common.Attributes;
using TestProject.SDK;
using TestProject.SDK.Addons.ElementAction;
using TestProject.SDK.Addons.Helpers;

namespace ClearTextBoxAddon.Addons
{

    [Action(Name = "Clear Text", Description = "Clears text from the Textbox of Web UI")]
    public class ClearText : IWebElementAction
    {
        public ExecutionResult Execute(WebAddonHelper helper, IWebElement element)
        {
            var driver = helper.Driver;

            //Clear the elements text
            element.Clear();

            return ExecutionResult.Passed;
        }
    }
}
