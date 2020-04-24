﻿using Microsoft.Extensions.DependencyInjection;
using PUC.LDSI.Application.Interfaces;
using PUC.LDSI.Application.AppServices;
using PUC.LDSI.Domain.Interfaces.Repository;
using PUC.LDSI.Domain.Interfaces.Services;
using PUC.LDSI.Domain.Services;
using PUC.LDSI.DataBase.Repository;

namespace PUC.LDSI.IoC
{
    public abstract class NativeBootStrapperBase
    {
        public static void RegisterServices(IServiceCollection services) {
            //Application
            services.AddScoped<ITurmaAppService, TurmaAppService>();
            services.AddScoped<IProfessorAppService, ProfessorAppService>();

            //Domain - Repository
            services.AddScoped<ITurmaRepository, TurmaRepository>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IProfessorRepository, ProfessorRepository>();

            //Domain - Services
            services.AddScoped<ITurmaService, TurmaService>();
            services.AddScoped<IProfessorService, ProfessorService>();
        }
    }
}