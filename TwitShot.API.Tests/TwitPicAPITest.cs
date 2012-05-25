using NUnit.Framework;
using TwitShot.API;
using RestSharp;
using TwitShot.Contracts;

namespace TwitShot.API.Tests
{
    /// <summary>
    ///This is a test class for TwitPicAPITest and is intended
    ///to contain all TwitPicAPITest Unit Tests
    ///</summary>
    [TestFixture]
    public class TwitPicAPITest
    {
        /// <summary>
        ///A test for TwitPicAPI Constructor
        ///</summary>
        [Test]
        public void TwitPicAPIConstructorTest()
        {
            var target = new TwitPicAPI();
            Assert.That(target, Is.Not.Null);
        }
        
        /// <summary>
        ///A test for GetTumbnail
        ///</summary>
        [Test]
        public void GetTumbnailTest()
        {
            var target = new TwitPicAPI();

            object expected = null;
            var actual = target.GetTumbnail(0, ThumbSize.mini);
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        ///A test for Upload
        ///</summary>
        [Test]
        public void UploadTest()
        {
            var target = new TwitPicAPI(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            TwitPicResponse expected = null; // TODO: Initialize to an appropriate value
            TwitPicResponse actual;
            actual = target.Upload(path, message);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
