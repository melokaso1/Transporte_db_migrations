using ejercicio_5.src.Shared.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ejercicio_5.src.Shared.Helpers
{
    public class DbContextFactory
    {
        public static AppDbContext Create()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            string? connectionString =
                Environment.GetEnvironmentVariable("MYSQL_CONNECTION")
                ?? config.GetConnectionString("MySqlDB");

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException(
                    "No se encontró una cadena de conexión válida."
                );

            // Si quieres seguir usando tu resolver de versión, déjalo;
            // pero el provider oficial no necesita MySqlServerVersion aquí.
            var detectedVersion = MySqlVersionResolver.DetectVersion(connectionString);
            var minVersion = new Version(8, 0, 0);
            if (detectedVersion < minVersion)
                throw new NotSupportedException(
                    $"Versión de MySQL no soportada: {detectedVersion}. Requiere {minVersion} o superior."
                );

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySQL(connectionString)
                .Options;

            return new AppDbContext(options);
        }
    }
}
