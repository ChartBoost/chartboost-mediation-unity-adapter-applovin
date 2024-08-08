using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.AppLovin;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.applovin";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.AppLovin";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, AppLovinAdapter.AdapterUnityVersion);
    }
}
