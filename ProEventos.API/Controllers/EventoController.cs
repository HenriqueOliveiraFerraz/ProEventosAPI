using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _Eventos = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = ".NET",
                Local = "Internet",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular",
                Local = "Internet",
                Lote = "2º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            }
        };

        public EventoController()
        {

        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _Eventos.FirstOrDefault(f => f.EventoId == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _Eventos;
        }
    }
}