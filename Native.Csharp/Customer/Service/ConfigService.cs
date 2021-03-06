﻿using Native.Csharp.App;
using Native.Csharp.Customer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service
{
    public class ConfigService
    {
        #region 成员属性
        /// <summary>
        /// 配置目录
        /// </summary>
        public string Path = Common.AppDirectory;
        /// <summary>
        /// 配置文件名
        /// </summary>
        public string file = "wandhi.json";
        /// <summary>
        /// 绝对路径
        /// </summary>
        private string abPath => $"{Path}\\{file}";
        /// <summary>
        /// 配置信息
        /// </summary>
        public BaseConfig Config { private set; get; }
        #endregion


        #region 构造函数

        /// <summary>
        /// 初始化配置信息
        /// </summary>
        public ConfigService()
        {
            this.Config = InitConfig();
        }
        #endregion

        #region 保存配置
        /// <summary>
        /// 保存内部配置
        /// </summary>
        /// <returns></returns>
        public BaseConfig SaveConfig()
        {
            if (this.Config != null)
            {
                writeConfig();
            }
            return InitConfig();
        }
        /// <summary>
        /// 保存外部配置
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public BaseConfig SaveConfig(BaseConfig config)
        {
            writeConfig(config);
            return InitConfig();
        }
        #endregion


        /// <summary>
        /// 初始化配置信息
        /// </summary>
        /// <returns></returns>
        public BaseConfig InitConfig()
        {
            var configStr = readConfig();
            BaseConfig config;
            if (string.IsNullOrEmpty(configStr))
            {
                config = new BaseConfig();
                writeConfig(config);
            }
            else
            {
                try
                {
                    config = JsonConvert.DeserializeObject<BaseConfig>(configStr);
                }
                catch (Exception e)
                {
                    Common.CqApi.AddLoger(Sdk.Cqp.Enum.LogerLevel.Error, "配置读取", $"配置信息反序列化异常:{e.Message}");
                    File.WriteAllText(abPath + ".bak", configStr);
                    config = new BaseConfig();
                    writeConfig(config);
                }
            }
            return config;
        }

        #region 内部函数

        private void writeConfig()
        {
            writeConfig(this.Config);
        }

        private void writeConfig(BaseConfig config)
        {
            var jsonStr = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(abPath, jsonStr);
        }
        private string readConfig()
        {
            if (!File.Exists(abPath))
            {
                File.Create(abPath);
            }
            try
            {
                return File.ReadAllText(abPath);
            }
            catch (Exception e)
            {
                Common.CqApi.AddLoger(Sdk.Cqp.Enum.LogerLevel.Error, "配置读取", $"读取配置文件异常,文件位置:[{abPath}],异常信息:{e.Message}");
                return "";
            }
        }
        #endregion
    }
}
