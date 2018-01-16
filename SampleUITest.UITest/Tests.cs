using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SampleUITest.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void Add_2_to_3_results_5()
        {
            //app.Screenshot("First screen.");

            // Arrange
            var expectedResult = "5";
            app.EnterText("ValueA", "2");
            app.EnterText("ValueB", "3");
            // Action
            app.Tap("AddButton");
            var resultLabel = app.Query("ResultLabel").FirstOrDefault();
            var result = resultLabel != null ? resultLabel.Text : string.Empty;
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

