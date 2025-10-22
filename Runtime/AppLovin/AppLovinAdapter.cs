using System.Collections.Generic;
using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.AppLovin.Common;
using Chartboost.Mediation.AppLovin.Default;

namespace Chartboost.Mediation.AppLovin
{
    /// <inheritdoc cref="IAppLovinAdapter"/>
    public sealed class AppLovinAdapter 
    {
        internal static IAppLovinAdapter Instance = new AppLovinDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.3.4";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IAppLovinAdapter.TestMode"/>
        public static bool TestMode
        {
            get => Instance.TestMode;
            set => Instance.TestMode = value;
        }

        /// <inheritdoc cref="IAppLovinAdapter.MuteAudio"/>
        public static bool MuteAudio
        {
            get => Instance.MuteAudio;
            set => Instance.MuteAudio = value;
        }

        /// <inheritdoc cref="IAppLovinAdapter.VerboseLogging"/>
        public static bool VerboseLogging
        {
            get => Instance.VerboseLogging;
            set => Instance.VerboseLogging = value;
        }
    }
}
