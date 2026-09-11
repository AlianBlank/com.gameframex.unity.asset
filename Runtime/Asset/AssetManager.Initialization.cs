using System;
using System.IO;
using GameFrameX.Runtime;
using UnityEngine;
using YooAsset;

namespace GameFrameX.Asset.Runtime
{
    public partial class AssetManager
    {
        public const string ConstDefaultPackageName = "DefaultPackage";

        /// <summary>
        /// 根据运行模式创建初始化操作数据
        /// </summary>
        /// <returns></returns>
        [UnityEngine.Scripting.Preserve]
        private InitializationOperation CreateInitializationOperationHandler(ResourcePackage resourcePackage, string hostServerURL, string fallbackHostServerURL)
        {
            switch (PlayMode)
            {
                case EPlayMode.EditorSimulateMode:
                {
                    // 编辑器下的模拟模式
                    return InitializeYooAssetEditorSimulateMode(resourcePackage);
                }
                case EPlayMode.OfflinePlayMode:
                {
                    // 单机运行模式
                    return InitializeYooAssetOfflinePlayMode(resourcePackage);
                }
                case EPlayMode.HostPlayMode:
                {
                    // 联机运行模式
                    return InitializeYooAssetHostPlayMode(resourcePackage, hostServerURL, fallbackHostServerURL);
                }
                case EPlayMode.WebPlayMode:
                {
                    // WebGL运行模式
                    return InitializeYooAssetWebPlayMode(resourcePackage, hostServerURL, fallbackHostServerURL);
                }
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(PlayMode), PlayMode, $"Unsupported play mode: {PlayMode}");
                }
            }
        }

        /// <summary>
        /// 初始化YooAsset编辑器模拟运行模式
        /// </summary>
        /// <param name="resourcePackage">资源包</param>
        /// <returns></returns>
        [UnityEngine.Scripting.Preserve]
        private InitializationOperation InitializeYooAssetEditorSimulateMode(ResourcePackage resourcePackage)
        {
            var simulateBuildResult = EditorSimulateModeHelper.SimulateBuild(nameof(EDefaultBuildPipeline.BuiltinBuildPipeline), ConstDefaultPackageName);
            var createParameters = new EditorSimulateModeParameters();
            createParameters.EditorFileSystemParameters = FileSystemParameters.CreateDefaultEditorFileSystemParameters(simulateBuildResult);
            return resourcePackage.InitializeAsync(createParameters);
        }

        /// <summary>
        /// 初始化YooAsset单机运行模式
        /// </summary>
        /// <param name="resourcePackage">资源包</param>
        /// <returns></returns>
        [UnityEngine.Scripting.Preserve]
        private InitializationOperation InitializeYooAssetOfflinePlayMode(ResourcePackage resourcePackage)
        {
            var buildinFileSystem = FileSystemParameters.CreateDefaultBuildinFileSystemParameters();
            var initParameters = new OfflinePlayModeParameters();
            initParameters.BuildinFileSystemParameters = buildinFileSystem;
            return resourcePackage.InitializeAsync(initParameters);
        }

        /// <summary>
        /// 初始化YooAsset WebGL运行模式
        /// </summary>
        /// <param name="resourcePackage">资源包</param>
        /// <param name="hostServerURL">主机服务器URL</param>
        /// <param name="fallbackHostServerURL">备用主机服务器URL</param>
        /// <returns></returns>
        [UnityEngine.Scripting.Preserve]
        private InitializationOperation InitializeYooAssetWebPlayMode(ResourcePackage resourcePackage, string hostServerURL, string fallbackHostServerURL)
        {
            var initParameters = new WebPlayModeParameters();
            var provider = WebPlayModeFileSystemProviderRegistry.Resolve();
            FileSystemParameters webFileSystem = null;
            if (provider != null)
            {
                // 渠道适配包注册的提供者生效（抖音/微信/快手/B站/支付宝/TapTap等小游戏）
                Log.Info($"Web运行模式文件系统提供者：{provider.ChannelName}");
                var context = new WebPlayModeProviderContext
                {
                    HostServerURL = hostServerURL,
                    FallbackHostServerURL = fallbackHostServerURL,
                };
                webFileSystem = provider.CreateFileSystemParameters(context);
            }

            if (webFileSystem == null)
            {
                // 未注册渠道提供者或提供者返回空时，创建默认WebGL文件系统
                webFileSystem = FileSystemParameters.CreateDefaultWebFileSystemParameters();
            }

            initParameters.WebFileSystemParameters = webFileSystem;
            return resourcePackage.InitializeAsync(initParameters);
        }

        /// <summary>
        /// 初始化YooAsset热更新运行模式
        /// </summary>
        /// <param name="resourcePackage">资源包</param>
        /// <param name="hostServerURL">主机服务器URL</param>
        /// <param name="fallbackHostServerURL">备用主机服务器URL</param>
        /// <returns></returns>
        private InitializationOperation InitializeYooAssetHostPlayMode(ResourcePackage resourcePackage, string hostServerURL, string fallbackHostServerURL)
        {
            var remoteServices = new RemoteServices(hostServerURL, fallbackHostServerURL);
            var createParameters = new HostPlayModeParameters
            {
                BuildinFileSystemParameters = FileSystemParameters.CreateDefaultBuildinFileSystemParameters(),
                CacheFileSystemParameters = FileSystemParameters.CreateDefaultCacheFileSystemParameters(remoteServices),
            };
            return resourcePackage.InitializeAsync(createParameters);
        }
    }
}