using System.Collections.Concurrent;
using YooAsset;

namespace GameFrameX.Asset.Runtime
{
    public partial class AssetManager
    {
        [UnityEngine.Scripting.Preserve]
        private class RemoteServices : IRemoteServices
        {
            [UnityEngine.Scripting.Preserve] public string HostServer { get; }
            [UnityEngine.Scripting.Preserve] public string FallbackHostServer { get; }
            private readonly ConcurrentDictionary<string, string> _mapping = new ConcurrentDictionary<string, string>();

            [UnityEngine.Scripting.Preserve]
            public RemoteServices(string hostServer, string fallbackHostServer)
            {
                HostServer = hostServer;
                FallbackHostServer = fallbackHostServer;
            }

            [UnityEngine.Scripting.Preserve]
            public string GetRemoteMainURL(string fileName, string packageVersion)
            {
                return GetFileLoadURL(fileName);
            }

            [UnityEngine.Scripting.Preserve]
            public string GetRemoteFallbackURL(string fileName, string packageVersion)
            {
                return GetFileLoadURL(fileName, true);
            }

            [UnityEngine.Scripting.Preserve]
            private string GetFileLoadURL(string fileName, bool isFallback = false)
            {
                return _mapping.GetOrAdd(fileName, _ => PathUtility.Combine(isFallback ? FallbackHostServer : HostServer, fileName));
            }
        }
    }
}