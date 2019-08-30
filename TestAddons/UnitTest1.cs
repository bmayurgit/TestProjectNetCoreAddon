using ClearTextBoxAddon;
using NUnit.Framework;
using TestProject.Common.Enums;
using TestProject.SDK;

namespace Tests
{

    [TestFixture(AutomatedBrowserType.Edge)]
    [TestFixture(AutomatedBrowserType.Chrome)]..
    public class Tests
    {

        Runner runner;

        public Tests(AutomatedBrowserType automatedBrowserType)
        {
            runner = RunnerFactory.Instance.CreateWeb("U--LKi5tve35kNidu4uRp5IzAWrhL7PNVp3jEn4Y55U1", automatedBrowserType);
        }

        [Test]
        public void Test1()
        {
            ClearTextBase.RunAction(runner);
        }
    }
}