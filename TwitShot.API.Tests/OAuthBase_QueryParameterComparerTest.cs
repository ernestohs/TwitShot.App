using TwitShot.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TwitShot.API.Tests
{
    
    
    /// <summary>
    ///This is a test class for OAuthBase_QueryParameterComparerTest and is intended
    ///to contain all OAuthBase_QueryParameterComparerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OAuthBase_QueryParameterComparerTest
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
        ///A test for QueryParameterComparer Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TwitShot.API.dll")]
        public void OAuthBase_QueryParameterComparerConstructorTest()
        {
            OAuthBase_Accessor.QueryParameterComparer target = new OAuthBase_Accessor.QueryParameterComparer();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Compare
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TwitShot.API.dll")]
        public void CompareTest()
        {
            OAuthBase_Accessor.QueryParameterComparer target = new OAuthBase_Accessor.QueryParameterComparer(); // TODO: Initialize to an appropriate value
            OAuthBase_Accessor.QueryParameter x = null; // TODO: Initialize to an appropriate value
            OAuthBase_Accessor.QueryParameter y = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Compare(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
