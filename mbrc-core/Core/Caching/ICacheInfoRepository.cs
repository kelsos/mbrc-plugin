﻿using System;
using System.Linq;
using LiteDB;
using MusicBeeRemote.Core.Settings;

namespace MusicBeeRemote.Core.Caching
{
    public interface ICacheInfoRepository
    {
        void Update(CacheInfo update);

        CacheInfo GetCacheInfo();
    }

    public class CacheInfoRepository : ICacheInfoRepository
    {
        private readonly IStorageLocationProvider _storageProvider;

        public CacheInfoRepository(IStorageLocationProvider storageProvider)
        {
            _storageProvider = storageProvider;
        }

        public void Update(CacheInfo update)
        {
            if (update == null)
            {
                throw new ArgumentNullException(nameof(update));
            }

            using (var db = new LiteDatabase(_storageProvider.CacheDatabase))
            {
                var collection = db.GetCollection<CacheInfo>("cache_info");
                if (collection.Count() == 0)
                {
                    collection.Insert(update);
                }
                else
                {
                    var cacheInfo = collection.FindAll().First();
                    update.Id = cacheInfo.Id;
                    collection.Update(update);
                }
            }
        }

        public CacheInfo GetCacheInfo()
        {
            using (var db = new LiteDatabase(_storageProvider.CacheDatabase))
            {
                var collection = db.GetCollection<CacheInfo>("cache_info");
                var cacheInfos = collection.FindAll().ToList();
                return !cacheInfos.Any() ? new CacheInfo() : cacheInfos.First();
            }
        }
    }
}
