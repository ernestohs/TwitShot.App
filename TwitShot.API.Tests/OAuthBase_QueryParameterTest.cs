using TwitShot.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TwitShot.API.Tests
{
    
    
    /// <summary>
    ///This is a test class for OAuthBase_QueryParameterTest and is intended
    ///to contain all OAuthBase_QueryParameterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OAuthBase_QueryParameterTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for QueryParameter Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TwitShot.API.dll")]
        public void OAuthBase_QueryParameterConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            OAuthBase_Accessor.QueryParameter target = new OAuthBase_Accessor.QueryParameter(name, value);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TwitShot.API.dll")]
        public void NameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            OAuthBase_Accessor.QueryParameter target = new OAuthBase_Accessor.QueryParameter(param0); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Value
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TwitShot.API.dll")]
        public void ValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            OAuthBase_Accessor.QueryParameter target = new OAuthBase_Accessor.QueryParameter(param0); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Value;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
