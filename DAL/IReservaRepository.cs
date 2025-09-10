using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IReservaRepository<Reserva>
    {
        string Agregar(Reserva entity);
        List<Reserva> ObtenerTodo();
    }
}
