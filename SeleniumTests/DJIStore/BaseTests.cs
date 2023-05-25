using NUnit.Framework;
using SeleniumFramework;
using NUnit.Framework.Interfaces;

namespace SeleniumTests.DJIStore
{
    internal class BaseTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success) 
            { 
                Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName); 
            }
            Driver.ShutdownDriver();
        }
    }
}
