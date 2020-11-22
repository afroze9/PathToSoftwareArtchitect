using CA.Application.Interfaces;
using CA.Application.Services;
using CA.Domain.Interfaces;
using CA.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CA.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CA.Application
            services.AddScoped<IBookService, BookService>();

            //CA.Domain.Interfaces | CA.Infrastructure.Data.Repositories
            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
