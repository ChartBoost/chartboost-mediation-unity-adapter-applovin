#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterAppLovin/ChartboostMediationAdapterAppLovin-Swift.h>

extern "C" {

    const char * _CBMAppLovinAdapterAdapterVersion(){
        return toCStringOrNull([AppLovinAdapterConfiguration adapterVersion]);
    }

    const char * _CBMAppLovinAdapterPartnerSDKVersion(){
        return toCStringOrNull([AppLovinAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMAppLovinAdapterPartnerId(){
        return toCStringOrNull([AppLovinAdapterConfiguration partnerID]);
    }

    const char * _CBMAppLovinAdapterPartnerDisplayName(){
        return toCStringOrNull([AppLovinAdapterConfiguration partnerDisplayName]);
    }

    BOOL _CBMAppLovinAdapterGetTestMode() {
        return [AppLovinAdapterConfiguration testMode];
    }

    void _CBMAppLovinAdapterSetTestMode(BOOL enabled) {
        return [AppLovinAdapterConfiguration setTestMode:enabled];
    }

    BOOL _CBMAppLovinAdapterGetMuteAudio(){
        return [AppLovinAdapterConfiguration isMuted];
    }

    void _CBMAppLovinAdapterSetMuteAudio(BOOL muteAudio){
        [AppLovinAdapterConfiguration setIsMuted:muteAudio];
    }

    BOOL _CBMAppLovinAdapterGetVerboseLogging(){
        return [AppLovinAdapterConfiguration verboseLogging];
    }

    void _CBMAppLovinAdapterSetVerboseLogging(BOOL verboseLogging){
        [AppLovinAdapterConfiguration setVerboseLogging:verboseLogging];
    }
}
