using TwitShot.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace TwitShot.API.Tests
{
    
    
    /// <summary>
    ///This is a test class for TwitterHelperTest and is intended
    ///to contain all TwitterHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TwitterHelperTest
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
        
        /// <summary>
        ///A test for AccessTokenGet
        ///</summary>
        [TestMethod()]
        public void AccessTokenGetTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            string authToken = string.Empty; // TODO: Initialize to an appropriate value
            string verifier = string.Empty; // TODO: Initialize to an appropriate value
            target.AccessTokenGet(authToken, verifier);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AuthorizationLinkGet
        ///</summary>
        [TestMethod()]
        public void AuthorizationLinkGetTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AuthorizationLinkGet();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WebRequest
        ///</summary>
        [TestMethod()]
        public void WebRequestTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            TwitterHelper.Method method = new TwitterHelper.Method(); // TODO: Initialize to an appropriate value
            string url = string.Empty; // TODO: Initialize to an appropriate value
            string postData = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.WebRequest(method, url, postData);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WebResponseGet
        ///</summary>
        [TestMethod()]
        public void WebResponseGetTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            HttpWebRequest webRequest = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.WebResponseGet(webRequest);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for oAuthWebRequest
        ///</summary>
        [TestMethod()]
        public void oAuthWebRequestTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            TwitterHelper.Method method = new TwitterHelper.Method(); // TODO: Initialize to an appropriate value
            string url = string.Empty; // TODO: Initialize to an appropriate value
            string postData = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.oAuthWebRequest(method, url, postData);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ConsumerKey
        ///</summary>
        [TestMethod()]
        public void ConsumerKeyTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ConsumerKey = expected;
            actual = target.ConsumerKey;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ConsumerSecret
        ///</summary>
        [TestMethod()]
        public void ConsumerSecretTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ConsumerSecret = expected;
            actual = target.ConsumerSecret;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Token
        ///</summary>
        [TestMethod()]
        public void TokenTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Token = expected;
            actual = target.Token;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TokenSecret
        ///</summary>
        [TestMethod()]
        public void TokenSecretTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TokenSecret = expected;
            actual = target.TokenSecret;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Verifier
        ///</summary>
        [TestMethod()]
        public void VerifierTest()
        {
            TwitterHelper target = new TwitterHelper(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Verifier = expected;
            actual = target.Verifier;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
