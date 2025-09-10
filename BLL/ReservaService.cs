using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReservaService : IReservaRepository<Reserva>
    {
        List<Reserva> reservas;
        ReservaRepositoryTxt reservaRepository;

        public ReservaService()
        {
            reservaRepository = new ReservaRepositoryTxt();
            reservas = reservaRepository.ObtenerTodo();
        }

        public string Agregar(Reserva reserva)
        {
            var mensaje = reservaRepository.Agregar(reserva);
            reservas = reservaRepository.ObtenerTodo();
            return mensaje;
        }

        public List<Reserva> ObtenerTodo()
        {
            throw new NotImplementedException();
        }
    }
}

