using Chartboost.Mediation.AppLovin.Common;

namespace Chartboost.Mediation.AppLovin.Default
{
    internal class AppLovinDefault : IAppLovinAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => AppLovinAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => AppLovinAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "applovin";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "AppLovin";

        /// <inheritdoc/>
        public bool TestMode { get; set; }
        
        /// <inheritdoc/>
        public bool MuteAudio { get; set; }
        
        /// <inheritdoc/>
        public bool VerboseLogging { get; set; }
    }
}
