using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      public IEnumerable<Evento> _Evento = new Evento[] {
            new Evento() {
              EventoID = 1,
              Local = "Foz do Iguaçu",
              DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
              Tema = "Angular e .NET 5",
              QtdPessoas = 350,
              Lote = "1ª Lote",
              ImagemURL = "foto.png"
            },
            new Evento() {
              EventoID = 2,
              Local = "Foz do Iguaçu",
              DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
              Tema = "Angular e .NET 5",
              QtdPessoas = 350,
              Lote = "1ª Lote",
              ImagemURL = "foto.png"
            }
      };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _Evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByID(int id)
        {
          return _Evento.Where(evento=> evento.EventoID == id);
        }

        [HttpPost]
        public string Post() {
            return "Exemplo Post";
        }

        [HttpPut("{id}")]
        public string Post(int id) {
            return $"Exemplo de PUT com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id) {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
