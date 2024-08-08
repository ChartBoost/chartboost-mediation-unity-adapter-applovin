using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.AppLovin.Common;
using UnityEngine;

namespace Chartboost.Mediation.AppLovin.IOS
{
    internal sealed class AppLovinAdapter : IAppLovinAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            AppLovin.AppLovinAdapter.Instance = new AppLovinAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMAppLovinAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMAppLovinAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMAppLovinAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMAppLovinAdapterPartnerDisplayName();

        /// <inheritdoc/>
        public bool TestMode
        {
            get => _CBMAppLovinAdapterGetTestMode();
            set => _CBMAppLovinAdapterSetTestMode(value);
        }

        /// <inheritdoc/>
        public bool MuteAudio
        {
            get => _CBMAppLovinAdapterGetMuteAudio();
            set => _CBMAppLovinAdapterSetMuteAudio(value);
        }
        
        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get => _CBMAppLovinAdapterGetVerboseLogging();
            set => _CBMAppLovinAdapterSetVerboseLogging(value);
        }
        
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAppLovinAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAppLovinAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAppLovinAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMAppLovinAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMAppLovinAdapterGetTestMode();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMAppLovinAdapterSetTestMode(bool enabled);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMAppLovinAdapterGetMuteAudio();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMAppLovinAdapterSetMuteAudio(bool muteAudio);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMAppLovinAdapterGetVerboseLogging();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMAppLovinAdapterSetVerboseLogging(bool verboseLogging);
    }
}
