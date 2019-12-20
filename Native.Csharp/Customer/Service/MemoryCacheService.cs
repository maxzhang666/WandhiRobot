using Native.Csharp.App;
using Native.Csharp.Customer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service
{
    public class MemoryCacheService : BaseCache, ICache
    {
        private MemoryCache _MemoryCache;
        public MemoryCacheService() : base()
        {
            this._MemoryCache = new MemoryCache("Wandhi");
        }
        public override void Clear()
        {
            _MemoryCache.Dispose();
            _MemoryCache = new MemoryCache("Wandhi");
        }

        public override T Get<T>(string key)
        {
            T value = default;
            try
            {
                value = (T)_MemoryCache.Get(key);
            }
            catch (Exception e)
            {
                Common.Debug($"内存读取失败[{key}]:{e.Message}");
            }
            return value;
        }

        public override void Remove(string key)
        {
            _MemoryCache.Remove(key);
        }

        /// <summary>
        /// 设置缓存(默认失效时间5分钟)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="time"></param>
        public override void Set<T>(string key, T value, TimeSpan? time)
        {
            TimeSpan t = time.HasValue ? time.Value : TimeSpan.FromMinutes(5);

            _MemoryCache.Set(key, value, DateTime.Now.Add(t));
        }
        /// <summary>
        /// 设置缓存(默认失效时间5分钟)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public override void Set<T>(string key, T value)
        {
            Set<T>(key, value, null);
        }
    }
}
