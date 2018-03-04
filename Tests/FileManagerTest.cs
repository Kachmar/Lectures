using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Tests;

namespace Tests
{
    //TODO with students: Create mock class for FileCommander, and see the power of interfaces :)
    [TestClass]
    public class FileManagerTest
    {
       
        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void GetFiles_EmptyInputFolder_ThrowsException()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetFiles_NoFilesFound_ReturnsEmptyResult()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetFiles_VariousFiles_ReturnsOnlyCsvFiles()
        {
            Assert.Inconclusive();  
        }
    }
}
