using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using StudyIO.App.Extensions;
using StudyIO.Business.Interfaces;
using StudyIO.Data.Context;
using StudyIO.Data.Repositories;

namespace StudyIO.App.Configuration
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            return services;
        }
    }
}