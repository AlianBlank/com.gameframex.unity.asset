using System.Collections.Generic;

namespace GameFrameX.Asset.Runtime
{
    /// <summary>
    /// Web 运行模式文件系统提供者注册中心。
    /// 渠道适配包通过运行时初始化自注册，<see cref="AssetManager"/> 初始化 Web 运行模式时从中解析生效渠道。
    /// </summary>
    public static class WebPlayModeFileSystemProviderRegistry
    {
        private static readonly List<IWebPlayModeFileSystemProvider> Providers = new List<IWebPlayModeFileSystemProvider>();

        /// <summary>
        /// 注册提供者。同一类型重复注册会被忽略
        /// </summary>
        /// <param name="provider">渠道提供者</param>
        public static void Register(IWebPlayModeFileSystemProvider provider)
        {
            if (provider == null)
            {
                return;
            }

            for (int i = 0; i < Providers.Count; i++)
            {
                if (Providers[i].GetType() == provider.GetType())
                {
                    return;
                }
            }

            Providers.Add(provider);
        }

        /// <summary>
        /// 解析当前生效的提供者。未注册任何渠道提供者时返回 null，由调用方回退到默认 WebGL 文件系统
        /// </summary>
        /// <returns></returns>
        public static IWebPlayModeFileSystemProvider Resolve()
        {
            IWebPlayModeFileSystemProvider bestProvider = null;
            for (int i = 0; i < Providers.Count; i++)
            {
                if (bestProvider == null || Providers[i].Priority < bestProvider.Priority)
                {
                    bestProvider = Providers[i];
                }
            }

            return bestProvider;
        }
    }
}
