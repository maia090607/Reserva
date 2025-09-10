using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Reserva
    {
        public Reserva()
        {

        }
        public Reserva(int id, string solicitante, int sala, string fecha)
        {
            Id = id;
            Solicitante = solicitante;
            Sala = sala;
            Fecha = fecha;
        }

        public int Id { get; set; }
        public string Solicitante { get; set; }
        public int Sala { get; set; }
        public string Fecha { get; set; }

    }
}
