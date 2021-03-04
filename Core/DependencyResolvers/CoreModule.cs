﻿using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceColllection)
        {
            serviceColllection.AddMemoryCache();
            serviceColllection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceColllection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}
