namespace GameFrameX.Asset.Runtime
{
    /// <summary>
    /// Web 运行模式文件系统创建上下文
    /// </summary>
    public sealed class WebPlayModeProviderContext
    {
        /// <summary>
        /// 主机服务器URL，为空时使用渠道默认地址
        /// </summary>
        public string HostServerURL { get; set; }

        /// <summary>
        /// 备用主机服务器URL
        /// </summary>
        public string FallbackHostServerURL { get; set; }
    }
}
