using Aplicacao.Interface;
using Aplicacao.Servico;
using Aplicacao.Servico.Interface;
using Dominio.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSingleton<IAtividadeRepository, AtividadeRepository>();
            services.AddSingleton<IAtividadeServico, AtividadeServico>();            
            services.AddSingleton<IAtividadeAppServico, AtividadeAppServico>();
            
            return services;
        }
    }
}
