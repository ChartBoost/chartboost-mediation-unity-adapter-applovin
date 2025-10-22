# Chartboost Mediation Unity SDK - AppLovin Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.appLovin/Editor/AppLovinAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.applovin)

In order to add the Chartboost Mediation Unity SDK - AppLovin Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.applovin": "5.3.2",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.AppLovin)

To add the Chartboost Mediation Unity SDK - AppLovin Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.AppLovin` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.AppLovin` package. Choose the appropriate version and install.

# Usage
The following code block exemplifies usage of the `AppLovinAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {AppLovinAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.12.5.0.0
Debug.Log($"Adapter Native Version: {AppLovinAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 12.5.0
Debug.Log($"Partner SDK Version: {AppLovinAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: applovin
Debug.Log($"Partner Identifier: {AppLovinAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: AppLovin
Debug.Log($"Partner Display Name: {AppLovinAdapter.PartnerDisplayName}");
```

## Test Mode
To enable test mode for the AppLovin adapter, the following property has been made available:

```csharp
AppLovinAdapter.TestMode = true;
```

## Mute Audio
To mute the audio from videos for the AppLovin adapter, the following property has been made available:

```csharp
AppLovinAdapter.MuteAudio = true;
```

## Verbose Logging
To enable verbose logging for the AppLovin adapter, the following property has been made available:

```csharp
AppLovinAdapter.VerboseLogging = true;
```