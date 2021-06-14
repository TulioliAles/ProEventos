using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 12 e .Net 5",
                Local = "Ribeirão Preto-SP",
                QtdPessoas = 250,
                Lote = "1º lote",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular 12",
                Local = "São Paulo-SP",
                QtdPessoas = 300,
                Lote = "2º lote",
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImagemUrl = "foto.jpg"
            }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet ("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(e => e.EventoId == id);
        }
    }
}
