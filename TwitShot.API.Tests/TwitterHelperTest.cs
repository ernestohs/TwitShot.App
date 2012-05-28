using NUnit.Framework;
using System.Net;

namespace TwitShot.API.Tests
{
    /// <summary>
    ///This is a test class for TwitterHelperTest and is intended
    ///to contain all TwitterHelperTest Unit Tests
    ///</summary>
    [TestFixture]
    public class TwitterHelperTest
    {
        /// <summary>
        ///A test for AccessTokenGet
        ///</summary>
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
