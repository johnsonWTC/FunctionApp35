using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(FunctionApp35.Startup))]
namespace FunctionApp35
{

    public class Startup : FunctionsStartup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<BookContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }

}
