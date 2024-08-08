using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.AppLovin.Common
{
    /// <summary>
    /// The Chartboost Mediation AppLovin adapter.
    /// </summary>
    internal interface IAppLovinAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Enable/disable AppLovin's test mode. Remember to set this to false in production.
        /// </summary>
        bool TestMode { get; set; }

        /// <summary>
        /// Enable/disable AppLovin's mute setting.
        /// </summary>
        bool MuteAudio { get; set; }

        /// <summary>
        /// Enable/disable AppLovin's verbose logging.
        /// </summary>
        bool VerboseLogging { get; set; }
    }
}
