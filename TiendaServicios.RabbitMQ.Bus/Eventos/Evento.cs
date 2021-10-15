using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaServicios.RabbitMQ.Bus.Eventos
{
    public abstract class Evento
    {
        public DateTime Timestamp { get; set; }

        protected Evento()
        {
            Timestamp = DateTime.Now;
        }
    }
}
