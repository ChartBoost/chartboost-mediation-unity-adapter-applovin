using System.Runtime.CompilerServices;
using Chartboost.Mediation.AppLovin;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.AppLovinAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.AppLovinAssemblyInfoIOS)]

namespace Chartboost.Mediation.AppLovin
{
    internal class AssemblyInfo
    {
        public const string AppLovinAssemblyInfoAndroid = "Chartboost.Mediation.AppLovin.Android";
        public const string AppLovinAssemblyInfoIOS = "Chartboost.Mediation.AppLovin.IOS";
    }
}
