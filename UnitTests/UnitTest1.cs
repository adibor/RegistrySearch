using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchForm;
using System.ComponentModel;



namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        DoWorkEventArgs e = new DoWorkEventArgs("");
        RegistryHelper rh = new RegistryHelper();
        System.ComponentModel.BackgroundWorker bw = new BackgroundWorker();

        [TestMethod]
        public void SearchKeyHardware()
        {
            rh.results.Clear();
            rh.RecursiveSearchKeysTreeWrapper(true, "HARDWARE", bw, e);
            Assert.AreEqual(rh.results[0].keyPath, "HKEY_LOCAL_MACHINE" + @"\" + "HARDWARE");
            Assert.AreEqual(rh.results[0].value, "no values");
        }

        [TestMethod]
        public void SearchValSetupType()
        {
            rh.results.Clear();
            rh.RecursiveSearchKeysTreeWrapper(false, "SetupType", bw, e);
            Assert.AreEqual(rh.results[0].keyPath, "HKEY_LOCAL_MACHINE" + @"\" + "SYSTEM" + @"\" + "Setup");
            Assert.AreEqual(rh.results[0].value, "SetupType");
        }

        [TestMethod]
        public void SearchValCurrentUser()
        {
            rh.results.Clear();
            rh.RecursiveSearchKeysTreeWrapper(false, "CurrentUser", bw, e);
            Assert.AreEqual(rh.results.Count, 3);
        }

        [TestMethod]
        public void SearchKeyKeyboardClass()
        {
            rh.results.Clear();
            rh.RecursiveSearchKeysTreeWrapper(true, "KeyboardClass", bw, e);
            Assert.AreEqual(rh.results.Count, 2);
        }
    }
}
