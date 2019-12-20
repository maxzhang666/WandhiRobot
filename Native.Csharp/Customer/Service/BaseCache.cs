using Native.Csharp.Customer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service
{
    public abstract class BaseCache : ICache
    {
        /// <summary>
        /// 锁
        /// </summary>
        protected readonly object Lock = new object();

        public BaseCache()
        {

        }

        public abstract void Clear();

        public abstract T Get<T>(string key);

        public virtual T Get<T>(string key, Func<T> factory)
        {
            var value = Get<T>(key);
            if (value == null)
            {
                value = factory.Invoke();
                lock (Lock)
                {
                    Set(key, value);
                }
            }
            return value;
        }

        public T Get<T>(string key, T Default)
        {
            var value = Get<T>(key);
            if (value == null)
            {
                value = Default;
                lock (Lock)
                {
                    Set(key, Default);
                }
            }
            return value;
        }

        public abstract void Remove(string key);        

        public abstract void Set<T>(string key, T value, TimeSpan? time);

    }
}
