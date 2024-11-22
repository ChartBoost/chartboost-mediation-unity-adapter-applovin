# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.2.0 *(2024-10-10)*
This version of the AppLovin Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-applovin:chartboost-mediation-adapter-applovin:5.12.6.+`
  * iOS: `ChartboostMediationAdapterAppLovin: ~> 5.13.0.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - AppLovin Adapter.

#Added
- Support for the following `AppLovin` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-applovin:5.12.6.+`
    * iOS: `ChartboostMediationAdapterAppLovin ~> 5.12.5.0`
    
- `AppLovinAdapter.cs` with Configuration Properties for `AppLovin`.
- The following properties have been added in `AppLovinAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool TestMode`
    * `bool MuteAudio`
    * `bool VerboseLogging`