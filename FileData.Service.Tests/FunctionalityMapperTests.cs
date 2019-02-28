using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileData.Service.Tests
{
    [TestClass]
    public class FunctionalityMapperTests
    {
        [TestMethod]
        public void Version()
        {
            var functionalityMapper = new FunctionalityMapper();

            Assert.IsInstanceOfType(functionalityMapper.GetFunctionalityAssociatedTo("-v"), typeof(FileVersionFunctionality));
            Assert.IsInstanceOfType(functionalityMapper.GetFunctionalityAssociatedTo("--v"), typeof(FileVersionFunctionality));
            Assert.IsInstanceOfType(functionalityMapper.GetFunctionalityAssociatedTo("--version"), typeof(FileVersionFunctionality));
            Assert.IsInstanceOfType(functionalityMapper.GetFunctionalityAssociatedTo("/v"), typeof(FileVersionFunctionality));
        }

        [TestMethod]
        public void Size()
        {
            var functionalityMapper = new FunctionalityMapper();

            Assert.IsInstanceOfType(functionalityMapper.GetFunctionalityAssociatedTo("-s"), typeof(FileSizeFunctionality));
            Assert.IsInstanceOfType(functionalityMapper.GetFunctionalityAssociatedTo("--s"), typeof(FileSizeFunctionality));
            Assert.IsInstanceOfType(functionalityMapper.GetFunctionalityAssociatedTo("--size"), typeof(FileSizeFunctionality));
            Assert.IsInstanceOfType(functionalityMapper.GetFunctionalityAssociatedTo("/s"), typeof(FileSizeFunctionality));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Unknown()
        {
            var functionalityMapper = new FunctionalityMapper();

            functionalityMapper.GetFunctionalityAssociatedTo("-a");
        }
    }
}
