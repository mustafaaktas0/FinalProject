using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule // bu aspect için kullanılan bağimliliklar için
    {
        public void Load(IServiceCollection serviceColection)
        {
            serviceColection.AddMemoryCache(); // microsoft tarafındaki Imemorycache inteface bağimliliği için
            serviceColection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceColection.AddSingleton<ICacheManager, MemoryCachManager>();
            serviceColection.AddSingleton<Stopwatch>();
        }
    }
}
