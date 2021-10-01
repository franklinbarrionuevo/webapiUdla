using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiUdla.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatosUdlaController : ControllerBase
    {
        private static readonly string[] Ciudades = new[]
        {
            "Ambato", "Quito", "Riobamba", "Ibarra", "Salcedo", "Otavalo", "Latacunga", "Guaranda", "Atuntaqui", "Baños"
        };

        private readonly ILogger<DatosUdlaController> _logger;

        public DatosUdlaController(ILogger<DatosUdlaController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        public DatosUdla GetDatosUdla()
        {
            var rng = new Random();
            return new DatosUdla
            {
                Fecha = DateTime.Now,
                Mensaje = "Hola Mundo",
                Nombres = "Ricardo Barrionuevo",
                Ciudad = Ciudades[rng.Next(Ciudades.Length)]
            };
        }
    }
}
