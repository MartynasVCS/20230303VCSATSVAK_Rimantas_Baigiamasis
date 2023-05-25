using NUnit.Framework;
using SeleniumFramework;

namespace SeleniumTests.DJIStore
{
    internal class BaseTestsWithChromeProfile
    {
        [SetUp]
        public void SetUp()
        {
            string userDataDir = "C:\\Users\\Rimas\\AppData\\Local\\Temp\\scoped_dir29120_2073148784";
            string profileDir = "Profile 1";
            Driver.InitializeDriver(userDataDir, profileDir);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
