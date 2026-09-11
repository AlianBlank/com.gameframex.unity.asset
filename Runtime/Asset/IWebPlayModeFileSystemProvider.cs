using YooAsset;

namespace GameFrameX.Asset.Runtime
{
    /// <summary>
    /// Web 运行模式文件系统提供者。
    /// 各小游戏渠道在各自的适配包内实现本接口，并通过运行时初始化自注册到 <see cref="WebPlayModeFileSystemProviderRegistry"/>。
    /// </summary>
    public interface IWebPlayModeFileSystemProvider
    {
        /// <summary>
        /// 渠道名称（用于日志诊断）
        /// </summary>
        string ChannelName { get; }

        /// <summary>
        /// 优先级，数值越小越优先。多渠道适配包同时安装时决定生效顺序
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// 创建渠道文件系统参数（含渠道预热副作用，如并发预载与配置组件挂载）
        /// </summary>
        /// <param name="context">创建上下文</param>
        /// <returns></returns>
        FileSystemParameters CreateFileSystemParameters(WebPlayModeProviderContext context);
    }
}
