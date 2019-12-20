using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service.Interface
{
    public interface ICache
    {
        /// <summary>
        /// 获取缓存项
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key);
        /// <summary>
        /// 获取缓存项
        /// </summary>
        /// <param name="key"></param>
        /// <param name="factory">默认生成器</param>
        /// <returns></returns>
        T Get<T>(string key, Func<T> factory);


        /// <summary>
        /// 获取缓存项
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="Default">默认数据</param>
        /// <returns></returns>
        T Get<T>(string key, T Default);


        /// <summary>
        /// 设置缓存项并设置过期时间
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">值</param>
        /// <param name="slidingExpireTime">多久未访问则失效</param>
        /// <param name="absoluteExpireTime">超时失效</param>
        void Set<T>(string key, T value, TimeSpan? slidingExpireTime = null, TimeSpan? absoluteExpireTime = null);

        /// <summary>
        /// 移除缓存项
        /// </summary>
        /// <param name="key"></param>
        void Remove(string key);

        /// <summary>
        /// 清空缓存
        /// </summary>
        void Clear();
    }
}
