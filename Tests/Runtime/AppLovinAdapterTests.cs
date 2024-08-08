using Chartboost.Logging;
using Chartboost.Mediation.AppLovin;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class AppLovinAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => AppLovinAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => AppLovinAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => AppLovinAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => AppLovinAdapter.PartnerDisplayName);

        [Test]
        public void TestMode()
            => TestUtilities.TestBooleanAccessor(() => AppLovinAdapter.TestMode, value => AppLovinAdapter.TestMode = value);
        
        [Test]
        public void MuteAudio()
            => TestUtilities.TestBooleanAccessor(() => AppLovinAdapter.MuteAudio, value => AppLovinAdapter.MuteAudio = value);
        
        [Test]
        public void VerboseLogging()
            => TestUtilities.TestBooleanAccessor(() => AppLovinAdapter.VerboseLogging, value => AppLovinAdapter.VerboseLogging = value);
    }
}
