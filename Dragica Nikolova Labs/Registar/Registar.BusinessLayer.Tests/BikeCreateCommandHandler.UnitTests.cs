using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registar.Common;
using Registar.BusinessLayer.Handlers;
using Registar.BusinessLayer.Contracts;
using Registar.BL.Contracts.Contracts;
using Registar.DomainModel;

namespace Registar.BusinessLayer.Tests
{
    /// <summary>
    /// Summary description for BikeCreateCommandHandlerUnitTests
    /// </summary>
    [TestClass]
    public class BikeCreateCommandHandlerUnitTests
    {
        public BikeCreateCommandHandlerUnitTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ExecuteCommand_ValidBikeData_RepoSaveMethodCalled_Test()
        {
             
        }

        [TestMethod]
        public void ExecuteCommand_NotExistingBikeOwnerId_ValidationError_Test()
        {
            //setup
            BikeCreateCommandHandler handler = new BikeCreateCommandHandler();
            BikeCreateCommand command = new BikeCreateCommand();
            command.BikeToRegister = new Bike();
            command.BikeToRegister.BikeOwnerId = int.MinValue;
            //exercise
            BikeCreateResult result = handler.Execute(command) as BikeCreateResult;
            //verify
            Assert.IsFalse(result.IsSuccess, "For not valid owner id operation should be unsuccessful");
            StringAssert.Contains(result.ValidationErrors[0], "not valid owner id", "For not valid owner id validation error is expected");
            //cleanup
        }


    }
}
