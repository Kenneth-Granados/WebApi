using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Repository.IRepositoryGeneric;
using Repository.RepositoryGeneric;

namespace WebApi.Extensions
{
    public static class ServiceExtensions
    {
        // configurar CORS en nuestra aplicación.CORS (Cross-Origin Resource Sharing) es un mecanismo para dar o restringir
        // derechos de acceso a aplicaciones de diferentes dominios.
        public static void ConfigureCors(this IServiceCollection services) 
        => services.AddCors(options => { 
            options.AddPolicy("CorsPolicy", builder => 
            builder.AllowAnyOrigin() //método que permite solicitudes de cualquierfuente, podemos usar 
            //WithOrigins("https://example.com") que lo hará permitir solicitudes solo de esa fuente concreta.
            .AllowAnyMethod() // que permite todos los métodos HTTP, o
            // WithMethods("POST", "GET") que solo permitirá métodos HTTP específicos
            .AllowAnyHeader()); }); // PermitirCualquierEncabezado()método utilizando, por ejemplo, 
            //el WithHeaders("accept", "content-type")para permitir solo encabezados específicos.
    
        //si queremos
// alojar nuestra aplicación en IIS, necesitamos configurar una integración de IIS que eventualmente nos ayudará con la implementación en IIS.
        public static void ConfigureIISIntegration(this IServiceCollection services) => 
            services.Configure<IISOptions>(options => { });

// agregar el servicio de registro dentro de .NET Contenedor IOC de Core.
         public static void ConfigureLoggerService(this IServiceCollection services) => 
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) => 
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) => 
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => 
            services.AddDbContext<RepositoryContext>(opts => 
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

    }

}