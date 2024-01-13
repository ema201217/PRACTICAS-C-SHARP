using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;


namespace Practica1WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync("https://servicioscf.afip.gob.ar/FCEServicioConsulta/api/fceconsulta.aspx/getGrandesEmpresas");
                        response.EnsureSuccessStatusCode();
                        
                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<ClientAfip> jsonDocument = JsonDocument.ParseAsync(responseBody);
                        Console.WriteLine(jsonDocument);
                        
                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }
                await Task.Delay(1000000, stoppingToken);
            }
        }
    }

    public interface ClientAfip
    {
        string Cuit { get; set; }
        string Denominacion { get; set; }
        string Fecha_Inicio { get; set; }
        string Actividad_Principal { get; set; }
    };
}