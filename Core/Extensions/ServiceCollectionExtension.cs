using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
   public static class ServiceCollectionExtension // Eklenen butun injectionları bir arada toplanabilmek için olusturaulan yapı
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection servicColection,ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(servicColection);
            }
            return ServiceTool.Create(servicColection);
        }
    }
}
