# [3.2.0](https://github.com/gameframex/com.gameframex.unity.asset/compare/3.1.1...3.2.0) (2026-09-11)


### Features

* **asset:** Web运行模式改为文件系统提供者适配机制 ([cdb142c](https://github.com/gameframex/com.gameframex.unity.asset/commit/cdb142c17783fb49e0571ccba025ceae5db03414))

## [3.1.1](https://github.com/gameframex/com.gameframex.unity.asset/compare/3.1.0...3.1.1) (2026-07-28)


### Bug Fixes

* use PhysicsMaterial type alias for Unity 6 ([#1](https://github.com/gameframex/com.gameframex.unity.asset/issues/1)) ([a6b5f0c](https://github.com/gameframex/com.gameframex.unity.asset/commit/a6b5f0cceb7dd9ce8e7a7531a8c02be43ffefe82))

# [3.1.0](https://github.com/gameframex/com.gameframex.unity.asset/compare/3.0.2...3.1.0) (2026-07-03)


### Features

* **asset:** 同步 GamePlayMode 变更到 AssetManager ([548c0d0](https://github.com/gameframex/com.gameframex.unity.asset/commit/548c0d01e6333d323a8905f14c4f74962f340439))

## [3.0.2](https://github.com/gameframex/com.gameframex.unity.asset/compare/3.0.1...3.0.2) (2026-06-07)


### Bug Fixes

* 补全包规范文件（LICENSE/CHANGELOG/URL 字段/unity 字段） ([85bda0e](https://github.com/gameframex/com.gameframex.unity.asset/commit/85bda0e32e7ec7cfaf244e8a9657c304952c807d))

## [3.0.1](https://github.com/gameframex/com.gameframex.unity.asset/compare/3.0.0...3.0.1) (2026-06-01)


### Bug Fixes

* **ci:** 修复持续集成配置 ([b8473c8](https://github.com/gameframex/com.gameframex.unity.asset/commit/b8473c81918e94bc4266d09909991d211c5dd457))

# [3.0.0](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.5.2...3.0.0) (2026-06-01)


### Bug Fixes

* **asset:** 修复 RemoteServices 并发安全问题 ([8b31fa6](https://github.com/gameframex/com.gameframex.unity.asset/commit/8b31fa6f0b86a873497b72fbfd896ef1b2e4c2d9))
* **asset:** 修正资源清理方法实现错误 ([de1a597](https://github.com/gameframex/com.gameframex.unity.asset/commit/de1a59714574c3ef3c95b291bad217a0e510f939))
* **asset:** 实现 Shutdown 资源释放 ([1b33034](https://github.com/gameframex/com.gameframex.unity.asset/commit/1b3303410150cd5788de7423bb2104531363cd52))
* **asset:** 统一 EventArgs 属性为 private set ([f1f65a6](https://github.com/gameframex/com.gameframex.unity.asset/commit/f1f65a6a0c866bb3e06c7432f86a09cd8d0e1d46))
* **asset:** 防止 PlayMode 未知时返回 null ([86ae180](https://github.com/gameframex/com.gameframex.unity.asset/commit/86ae180c5decfe7dcabe700b8fb37b23a2692778))


### Code Refactoring

* **asset:** 移除未使用的 ReadOnlyPath 和 ReadWritePath ([f74ede5](https://github.com/gameframex/com.gameframex.unity.asset/commit/f74ede5d24c2d783954715c57821f6b0582adc62))


### BREAKING CHANGES

* **asset:** IAssetManager 接口移除 ReadOnlyPath、ReadWritePath、
SetReadOnlyPath、SetReadWritePath 四个成员。

## [2.5.2](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.5.1...2.5.2) (2026-05-29)


### Bug Fixes

* **asset:** 移除 BetterStreamingAssets 依赖 ([bb0e58a](https://github.com/gameframex/com.gameframex.unity.asset/commit/bb0e58a8ac2d07a8d9ae3b781a27d953dca8346e))

## [2.5.1](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.5.0...2.5.1) (2026-05-28)


### Bug Fixes

* **ci:** 统一 .github 工作流配置 ([6fa0fae](https://github.com/gameframex/com.gameframex.unity.asset/commit/6fa0fae2cb569575b65a0f1d69cd56954f572274))
* **deps:** 补充 package.json 中缺失的包依赖 ([ce58bc2](https://github.com/gameframex/com.gameframex.unity.asset/commit/ce58bc2bc489ed11f7ff890a64a5980407d72abd))

# [2.5.0](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.4.2...2.5.0) (2026-05-07)


### Features

* **asset:** 为AssetComponent添加多种资源类型的加载扩展方法 ([3d107a6](https://github.com/gameframex/com.gameframex.unity.asset/commit/3d107a6c237af8758be1f9f7a2c92e3fd4e1c2ea))
* **Asset:** 添加RequireComponent属性依赖 ([7a8d1ac](https://github.com/gameframex/com.gameframex.unity.asset/commit/7a8d1acb36f5e3dd8fa4992e7120db70547f5388))
* **Asset:** 添加多种Unity资源类型的加载扩展方法 ([3ae43f5](https://github.com/gameframex/com.gameframex.unity.asset/commit/3ae43f56c082ac494d485bdb242a790efaf1096c))

## [2.4.2](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.4.1...2.4.2) (2026-05-07)


### Bug Fixes

* **Asset:** 修复场景加载方法中LoadSceneMode类型引用错误 ([3512f34](https://github.com/gameframex/com.gameframex.unity.asset/commit/3512f34515cbae79ebced8fae177b497f52dbd62))

## [2.4.1](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.4.0...2.4.1) (2026-05-07)


### Bug Fixes

* **Asset:** 修复场景加载方法参数类型错误 ([ebf626e](https://github.com/gameframex/com.gameframex.unity.asset/commit/ebf626e20462380cefdaa5f184d220bd29377940))
* **asset:** 移除冲突的Object别名，使用UnityEngine.Object ([556bb5a](https://github.com/gameframex/com.gameframex.unity.asset/commit/556bb5ac22496cc27f5bba861b10c0b0b1b6f1ed))

# [2.4.0](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.3.0...2.4.0) (2026-04-10)


### Bug Fixes

* **AssetManager:** 修复快手小游戏平台下的编译错误 ([5999a16](https://github.com/gameframex/com.gameframex.unity.asset/commit/5999a16c40d96f1cc42965421fd775faa65d9bf1))


### Features

* **AssetManager:** 添加快手小游戏平台的文件系统支持 ([f26f993](https://github.com/gameframex/com.gameframex.unity.asset/commit/f26f993914d39e5a794417e23b4b30e497685a96))

# [2.3.0](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.2.2...2.3.0) (2026-03-29)


### Bug Fixes

* 移除微信小游戏平台的条件编译宏定义 ([2a52d59](https://github.com/gameframex/com.gameframex.unity.asset/commit/2a52d59138245617c26be76416a2fdfc3d4e1bb1))


### Features

* **AssetManager:** 添加抖音小游戏预加载并发控制 ([feac7f6](https://github.com/gameframex/com.gameframex.unity.asset/commit/feac7f6600552ef6b9e12458e6eab21222a9219a))

## [2.2.2](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.2.1...2.2.2) (2026-03-27)


### Bug Fixes

* 修复微信小游戏环境下 AssetManager 初始化条件编译错误 ([6b65a6a](https://github.com/gameframex/com.gameframex.unity.asset/commit/6b65a6a55b5c567f9100026e6c7248a8e15e40a0))

## [2.2.1](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.2.0...2.2.1) (2026-03-14)


### Bug Fixes

* **Asset:** 修复远程资源URL生成逻辑 ([e8ab2f5](https://github.com/gameframex/com.gameframex.unity.asset/commit/e8ab2f5aaa09be16dade4bc88d87784a500ba421))

# [2.2.0](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.1.2...2.2.0) (2026-03-06)


### Features

* **Asset:** 为清理资源方法添加默认包名参数 ([29983d5](https://github.com/gameframex/com.gameframex.unity.asset/commit/29983d5922a89c2a51e779adeaa0301accbd8a4c))
* **Asset:** 为资源清理方法添加可选参数默认值 ([7fd31d5](https://github.com/gameframex/com.gameframex.unity.asset/commit/7fd31d59f6d2091a81ea2484b990be08728d3800))
* **Asset:** 为远程资源URL生成添加包版本支持 ([f3d6121](https://github.com/gameframex/com.gameframex.unity.asset/commit/f3d612178f08f8b39a5b62e80bf6e0f0fdbe4be3))

## [2.1.2](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.1.1...2.1.2) (2026-03-05)


### Bug Fixes

* **AssetManager:** 修复清理未使用资源包的方法调用 ([23e41a2](https://github.com/gameframex/com.gameframex.unity.asset/commit/23e41a29c6c7ee20435bd19b3ac176497b9d1125))

## [2.1.1](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.1.0...2.1.1) (2026-03-05)


### Bug Fixes

* **AssetManager:** 修复抖音小游戏平台文件系统创建调用路径 ([3c8650a](https://github.com/gameframex/com.gameframex.unity.asset/commit/3c8650a4c1dd5e7f290ead633ecf15d16b1e0c6a))

# [2.1.0](https://github.com/gameframex/com.gameframex.unity.asset/compare/2.0.0...2.1.0) (2025-12-23)


### Bug Fixes

* **AssetManager:** 禁用WebGL和微信小游戏的catalog文件 ([ca1ba5f](https://github.com/gameframex/com.gameframex.unity.asset/commit/ca1ba5ff77bf8952d48e2da84fe24fdbae3a12ed))
* **AssetManager:** 移除微信小游戏文件系统创建中的多余参数 ([cfd088a](https://github.com/gameframex/com.gameframex.unity.asset/commit/cfd088ab2f895c19397b8bbf6401d3005be8b00a))


### Features

* **AssetManager:** 添加自动卸载未使用资源包的功能 ([6f96ac4](https://github.com/gameframex/com.gameframex.unity.asset/commit/6f96ac42ab60788cd05d28d3b7367c563ff08b1e))
* **Asset:** 添加对YooAsset.MiniGame的支持并增加微信小游戏配置 ([28f917a](https://github.com/gameframex/com.gameframex.unity.asset/commit/28f917ac5d248ac0172118c8a82eade98e233e87))
* **Asset:** 添加通过资源句柄卸载资源的方法 ([a249afb](https://github.com/gameframex/com.gameframex.unity.asset/commit/a249afb89874c750639857d88d4819dacedf5e94))

# Changelog

## [2.0.0](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/2.0.0) (2025-10-25)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.10...2.0.0)

## [1.0.10](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.10) (2025-06-01)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.9...1.0.10)

## [1.0.9](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.9) (2025-05-30)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.8...1.0.9)

## [1.0.8](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.8) (2025-05-29)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.7...1.0.8)

## [1.0.7](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.7) (2024-12-20)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.6...1.0.7)

## [1.0.6](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.6) (2024-09-09)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.5...1.0.6)

## [1.0.5](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.5) (2024-09-09)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.4...1.0.5)

## [1.0.4](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.4) (2024-07-31)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.3...1.0.4)

## [1.0.3](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.3) (2024-07-13)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.2...1.0.3)

## [1.0.2](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.2) (2024-06-15)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/v1.0.1...1.0.2)

## [v1.0.1](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/v1.0.1) (2024-05-20)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/1.0.0...v1.0.1)

## [1.0.0](https://github.com/GameFrameX/com.gameframex.unity.asset/tree/1.0.0) (2024-04-11)

[Full Changelog](https://github.com/GameFrameX/com.gameframex.unity.asset/compare/bf8595347e20d29a2e62c69d06725167aac9e2a2...1.0.0)



\* *This Changelog was automatically generated by [github_changelog_generator](https://github.com/github-changelog-generator/github-changelog-generator)*
