using System.Configuration;
using CiSampleNetCore.Contracts;
using CiSampleNetCore.Data.EfContext;
using CiSampleNetCore.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CiSampleNetCore.Dependency
{
    public static class DependencyConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            //services.AddDbContext<DataContext>();

            //services.AddDbContext<DataContext>(options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb;Trusted_Connection=True;"));


            services.AddTransient<IDataContext, DataContext>();
            services.AddTransient<ITodoService, TodoService>();
        }
    }
}
