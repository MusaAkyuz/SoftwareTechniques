using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace MemoryCacheApp
{
    internal class MemoryCacheService
    {
        private MemoryCache _cache;

        public MemoryCacheService()
        {
            _cache = MemoryCache.Default;
        }

        public void AddItemToCache(string key, object value, int cacheDurationOnSecond)
        {
            var cacheDuration = TimeSpan.FromSeconds(cacheDurationOnSecond);
            _cache.Add(key, value, DateTime.Now.Add(cacheDuration));
        }

        public object GetItemFromCache(string key)
        {
            return _cache.Get(key);
        }

        public void RemoveItemFromCache(string key)
        {
            if (_cache.Contains(key))
            {
                _cache.Remove(key);
            }
        }
    }
}
