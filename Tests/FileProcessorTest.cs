using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Tests;

namespace Tests
{
    //TODO with students: Refactor the class, so we could also verify what is intended to be written to Console.
    [TestClass]
    public class FileProcessorTest
    {
        [TestMethod]
        public void Process_FileInfoIsNull_ThrowsException  ()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Process_FailedToProcess_FileMovedToError()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Process_FailedToSaveFile_FileMovedToError()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Process_FailedToSaveFile_ErrorIsReporting()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Process_FailedToMoveFile_ErrorIsReported()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Process_ProcessedSuccesfully_FileSaved()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Process_ProcessedSuccesfully_FileMoved()
        {
            Assert.Inconclusive();
        }
    }
}
