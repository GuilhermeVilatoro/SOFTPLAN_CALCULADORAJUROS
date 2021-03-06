﻿using AutoMapper;
using CalculadoraJuros.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CalculadoraJuros.WebApi.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            // Registering Mappings automatically only works if the 
            // Automapper Profile classes are in ASP.NET project
            AutoMapperConfig.RegisterMappings();
        }

        public static void RemoveAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            AutoMapperConfig.ResetMappings();
        }
    }
}