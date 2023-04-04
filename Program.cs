using Microsoft.AspNetCore.HttpOverrides;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// configuración de canalización de solicitudes
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // agregar
    app.UseSwagger();
    app.UseSwaggerUI();
}else {
    app.UseHsts(); // agregará middleware para usar HSTS, que agrega el encabezado Strict-Transport-Security

}

app.UseHttpsRedirection();
//mas config
app.UseStaticFiles(); // habilita el uso de archivos estáticos para la solicitud. Si noestablecemos una ruta al directorio de archivos 
// estáticos, utilizará unwwwroot carpeta en nuestro proyecto por defecto.
app.UseForwardedHeaders(new ForwardedHeadersOptions { // reenviará encabezados de proxy a la solicitud actual. Esto nos ayudará durante la implementación de la aplicación
    ForwardedHeaders = ForwardedHeaders.All 
    }); 
app.UseCors("CorsPolicy");
//
app.UseAuthorization();

app.MapControllers();

app.Run();
