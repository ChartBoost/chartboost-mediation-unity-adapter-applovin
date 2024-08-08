using Chartboost.Constants;
using Chartboost.Mediation.AppLovin.Common;
using UnityEngine;

namespace Chartboost.Mediation.AppLovin.Android
{
    internal sealed class AppLovinAdapter : IAppLovinAdapter
    {
        private const string AppLovinAdapterConfiguration = "com.chartboost.mediation.applovinadapter.AppLovinAdapterConfiguration";
        private const string FunctionGetIsMuted = "isMuted";
        private const string FunctionSetMuteAudio = "setMuted";
        private const string FunctionIsVerboseLoggingEnabled = "isVerboseLoggingEnabled";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            AppLovin.AppLovinAdapter.Instance = new AppLovinAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }

        /// <inheritdoc/>
        public bool TestMode
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                return adapterConfiguration.Call<bool>(SharedAndroidConstants.FunctionGetTestMode);;
            }
            set
            {
                using var currentActivity = SharedAndroidConstants.UnityPlayerCurrentActivity();
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetTestMode, currentActivity, value);
            }
        }

        /// <inheritdoc/>
        public bool MuteAudio
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                return adapterConfiguration.Call<bool>(FunctionGetIsMuted);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                adapterConfiguration.Call(FunctionSetMuteAudio, value);
            }
        }
        
        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                return adapterConfiguration.Call<bool>(FunctionIsVerboseLoggingEnabled);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(AppLovinAdapterConfiguration);
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetVerboseLoggingEnabled, value);
            }
        }
    }
}
