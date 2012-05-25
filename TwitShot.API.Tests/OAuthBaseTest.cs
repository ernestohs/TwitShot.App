using TwitShot.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace TwitShot.API.Tests
{
    /// <summary>
    ///This is a test class for OAuthBaseTest and is intended
    ///to contain all OAuthBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OAuthBaseTest
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
        ///A test for OAuthBase Constructor
        ///</summary>
        [TestMethod()]
        public void OAuthBaseConstructorTest()
        {
            OAuthBase target = new OAuthBase();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ComputeHash
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TwitShot.API.dll")]
        public void ComputeHashTest()
        {
            OAuthBase_Accessor target = new OAuthBase_Accessor(); // TODO: Initialize to an appropriate value
            HashAlgorithm hashAlgorithm = null; // TODO: Initialize to an appropriate value
            string data = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ComputeHash(hashAlgorithm, data);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GenerateNonce
        ///</summary>
        [TestMethod()]
        public void GenerateNonceTest()
        {
            OAuthBase target = new OAuthBase(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GenerateNonce();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GenerateSignature
        ///</summary>
        [TestMethod()]
        public void GenerateSignatureTest()
        {
            OAuthBase target = new OAuthBase(); // TODO: Initialize to an appropriate value
            Uri url = null; // TODO: Initialize to an appropriate value
            string consumerKey = string.Empty; // TODO: Initialize to an appropriate value
            string consumerSecret = string.Empty; // TODO: Initialize to an appropriate value
            string token = string.Empty; // TODO: Initialize to an appropriate value
            string tokenSecret = string.Empty; // TODO: Initialize to an appropriate value
            string verifier = string.Empty; // TODO: Initialize to an appropriate value
            string httpMethod = string.Empty; // TODO: Initialize to an appropriate value
            string timeStamp = string.Empty; // TODO: Initialize to an appropriate value
            string nonce = string.Empty; // TODO: Initialize to an appropriate value
            OAuthBase.SignatureTypes signatureType = new OAuthBase.SignatureTypes(); // TODO: Initialize to an appropriate value
            string normalizedUrl = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedUrlExpected = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedRequestParameters = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedRequestParametersExpected = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GenerateSignature(url, consumerKey, consumerSecret, token, tokenSecret, verifier, httpMethod, timeStamp, nonce, signatureType, out normalizedUrl, out normalizedRequestParameters);
            Assert.AreEqual(normalizedUrlExpected, normalizedUrl);
            Assert.AreEqual(normalizedRequestParametersExpected, normalizedRequestParameters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GenerateSignature
        ///</summary>
        [TestMethod()]
        public void GenerateSignatureTest1()
        {
            OAuthBase target = new OAuthBase(); // TODO: Initialize to an appropriate value
            Uri url = null; // TODO: Initialize to an appropriate value
            string consumerKey = string.Empty; // TODO: Initialize to an appropriate value
            string consumerSecret = string.Empty; // TODO: Initialize to an appropriate value
            string token = string.Empty; // TODO: Initialize to an appropriate value
            string tokenSecret = string.Empty; // TODO: Initialize to an appropriate value
            string verifier = string.Empty; // TODO: Initialize to an appropriate value
            string httpMethod = string.Empty; // TODO: Initialize to an appropriate value
            string timeStamp = string.Empty; // TODO: Initialize to an appropriate value
            string nonce = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedUrl = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedUrlExpected = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedRequestParameters = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedRequestParametersExpected = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GenerateSignature(url, consumerKey, consumerSecret, token, tokenSecret, verifier, httpMethod, timeStamp, nonce, out normalizedUrl, out normalizedRequestParameters);
            Assert.AreEqual(normalizedUrlExpected, normalizedUrl);
            Assert.AreEqual(normalizedRequestParametersExpected, normalizedRequestParameters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GenerateSignatureBase
        ///</summary>
        [TestMethod()]
        public void GenerateSignatureBaseTest()
        {
            OAuthBase target = new OAuthBase(); // TODO: Initialize to an appropriate value
            Uri url = null; // TODO: Initialize to an appropriate value
            string consumerKey = string.Empty; // TODO: Initialize to an appropriate value
            string token = string.Empty; // TODO: Initialize to an appropriate value
            string tokenSecret = string.Empty; // TODO: Initialize to an appropriate value
            string verifier = string.Empty; // TODO: Initialize to an appropriate value
            string httpMethod = string.Empty; // TODO: Initialize to an appropriate value
            string timeStamp = string.Empty; // TODO: Initialize to an appropriate value
            string nonce = string.Empty; // TODO: Initialize to an appropriate value
            string signatureType = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedUrl = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedUrlExpected = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedRequestParameters = string.Empty; // TODO: Initialize to an appropriate value
            string normalizedRequestParametersExpected = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GenerateSignatureBase(url, consumerKey, token, tokenSecret, verifier, httpMethod, timeStamp, nonce, signatureType, out normalizedUrl, out normalizedRequestParameters);
            Assert.AreEqual(normalizedUrlExpected, normalizedUrl);
            Assert.AreEqual(normalizedRequestParametersExpected, normalizedRequestParameters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GenerateSignatureUsingHash
        ///</summary>
        [TestMethod()]
        public void GenerateSignatureUsingHashTest()
        {
            OAuthBase target = new OAuthBase(); // TODO: Initialize to an appropriate value
            string signatureBase = string.Empty; // TODO: Initialize to an appropriate value
            HashAlgorithm hash = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GenerateSignatureUsingHash(signatureBase, hash);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GenerateTimeStamp
        ///</summary>
        [TestMethod()]
        public void GenerateTimeStampTest()
        {
            OAuthBase target = new OAuthBase(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GenerateTimeStamp();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetQueryParameters
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TwitShot.API.dll")]
        public void GetQueryParametersTest()
        {
            OAuthBase_Accessor target = new OAuthBase_Accessor(); // TODO: Initialize to an appropriate value
            string parameters = string.Empty; // TODO: Initialize to an appropriate value
            List<OAuthBase_Accessor.QueryParameter> expected = null; // TODO: Initialize to an appropriate value
            List<OAuthBase_Accessor.QueryParameter> actual;
            actual = target.GetQueryParameters(parameters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NormalizeRequestParameters
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TwitShot.API.dll")]
        public void NormalizeRequestParametersTest()
        {
            OAuthBase_Accessor target = new OAuthBase_Accessor(); // TODO: Initialize to an appropriate value
            IList<OAuthBase_Accessor.QueryParameter> parameters = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.NormalizeRequestParameters(parameters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UrlEncode
        ///</summary>
        [TestMethod()]
        public void UrlEncodeTest()
        {
            OAuthBase target = new OAuthBase(); // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.UrlEncode(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
