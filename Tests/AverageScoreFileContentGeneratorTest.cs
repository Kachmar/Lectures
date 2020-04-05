using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Tests;

namespace Tests
{
    [TestClass]
    public class AverageScoreFileContentGeneratorTest
    {
        [TestMethod]
        public void Process_ReturnsAverageZero_WhenNoElements()
        {
            //Arrange
            var linesProviderMock = new SplitLinesProviderMock(new List<string[]>());
            AverageScoreFileContentGenerator averageScoreFileContentGenerator = new AverageScoreFileContentGenerator(linesProviderMock);

            //Act
            var actual = averageScoreFileContentGenerator.Process(null);

            //Assert
            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void Process_ReturnsAverage_WhenElementsArePresent()
        {
            //Arrange
            var linesProviderMock = new SplitLinesProviderMock(new List<string[]>
            {
                new[] { "", "", "40", "", "", "", "" },
                new[] { "", "", "60", "", "", "", "" },
            });
            AverageScoreFileContentGenerator averageScoreFileContentGenerator =
                new AverageScoreFileContentGenerator(linesProviderMock);

            //Act
            var actual = averageScoreFileContentGenerator.Process(null);

            //Assert
            Assert.AreEqual("50", actual);
        }

        [TestMethod]
        public void GetFileName_Throws_WhenEmptyParameter()
        {
            //Arrange
            AverageScoreFileContentGenerator averageScoreFileContentGenerator = new AverageScoreFileContentGenerator(null);

            //Act
            Exception exception = null;
            try
            {
                averageScoreFileContentGenerator.GetFileName("");
            }
            catch (Exception e)
            {
                exception = e;
            }

            //Assert
            Assert.IsNotNull(exception);
            Assert.AreEqual("Empty file name", exception.Message);
        }

        [TestMethod]
        public void GetFileName_Throws_WhenNullParameter()
        {
            //Arrange
            AverageScoreFileContentGenerator averageScoreFileContentGenerator = new AverageScoreFileContentGenerator(null);

            //Act
            Exception exception = null;
            try
            {
                averageScoreFileContentGenerator.GetFileName(null);
            }
            catch (Exception e)
            {
                exception = e;
            }

            //Assert
            Assert.IsNotNull(exception);
            Assert.AreEqual("Empty file name", exception.Message);
        }

        [TestMethod]
        public void GetFileName_Throws_WhenParameterIsNotCsv()
        {
            //Arrange
            AverageScoreFileContentGenerator averageScoreFileContentGenerator = new AverageScoreFileContentGenerator(null);

            //Act
            Exception exception = null;
            try
            {
                averageScoreFileContentGenerator.GetFileName("file.ppp");
            }
            catch (Exception e)
            {
                exception = e;
            }

            //Assert
            Assert.IsNotNull(exception);
            Assert.AreEqual("File is not .csv", exception.Message);
        }

        [TestMethod]
        public void GetFileName_ReturnsCorrectResult_WhenParameterIsCsv()
        {
            //Arrange
            AverageScoreFileContentGenerator averageScoreFileContentGenerator = new AverageScoreFileContentGenerator(null);

            //Act
            var actual = averageScoreFileContentGenerator.GetFileName("file.csv");

            //Assert
            Assert.AreEqual("file_processed_average_score.csv", actual);
        }
    }

    public class SplitLinesProviderMock : ISplitLinesProvider
    {
        private readonly List<string[]> _items;

        public SplitLinesProviderMock(List<string[]> items)
        {
            _items = items;
        }

        public List<string[]> GetLinesElements(IFileInfo fileInfo)
        {
            return _items;
        }
    }
}
