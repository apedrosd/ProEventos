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

        public IEnumerable<Evento> _evento = new Evento[]{
               new Evento(){
               EventoId = 1,
               DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
               ImagemURL = "foto.png",
               Local = "Lisboa",
               Lote = "1",
               QtdPessoas = 10,
               Tema = "Angular 11 e .net 5"
               },
               new Evento(){
               EventoId = 2,
               DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
               ImagemURL = "foto2.png",
               Local = "Cardigos",
               Lote = "12",
               QtdPessoas = 20,
               Tema = "Angular 12 e .net 6"
               }
           };

        public EventoController()
        {
            
        }

        [HttpGet] 
        public IEnumerable<Evento> Get() //Request Resource
        {
           return _evento;
        }

        [HttpGet] 
        public IEnumerable<Evento> GetById(int id) //Request Resource
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post() //Create Resource
        {
           return "Exemplo Post";
        }

        [HttpPut("{id}")]
        public string Put(int id) //Update Resource
        {
           return $"Exemplo Put com id = {id}";
        }

        [HttpPatch("{id}")]
        public string Patch(int id) //Update Partial
        {
           return $"Exemplo Patch com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id) //Delete Resource
        {
           return $"Exemplo Delete com id = {id}";
        }
    }
}
