using UnityEngine;
using UnityEngine.Scripting;

namespace GameFrameX.Asset.Runtime
{
    [Preserve]
    public class GameFrameXAssetCroppingHelper : MonoBehaviour
    {
        [Preserve]
        private void Start()
        {
            _ = typeof(AssetManager);
            _ = typeof(Constant);
            _ = typeof(IAssetManager);
            _ = typeof(AssetComponent);
            _ = typeof(IWebPlayModeFileSystemProvider);
            _ = typeof(WebPlayModeFileSystemProviderRegistry);
            _ = typeof(WebPlayModeProviderContext);
        }
    }
}