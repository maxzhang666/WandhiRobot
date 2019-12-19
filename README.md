## Native.SDK 优点介绍

> 1. 程序集脱库打包
> 2. 类UWP开发体验
> 3. 完美翻译酷QApi
> 4. 支持酷Q应用打包
> 5. 支持附加进程调试

## Native.SDK 项目结构

![SDK结构](https://github.com/Jie2GG/Image/blob/master/NativeSDK(0).png "SDK结构") <br/>


## Native.SDK 调试流程

    1. 打开 酷Q Air/Pro, 并且登录机器人账号
    2. 打开 Native.Csharp 项目, 修改 "生成" 中的 "输出路径" 为 酷Q的 "dev" 路径
    3. 重新生成 Native.Csharp 项目
    4. 在酷Q上使用 "重载应用" 功能, 重载所有应用
    5. 依次选择VS的菜单项: "调试" -> "附加到进程"
    6. 选择 CQA.exe/CQP.exe 的托管进程, 选择附加
    7. 附加成功后进入调试模式, 即可进行断点 (注: 仅在只加载一个 .Net 应用的酷Q可以进行调试)