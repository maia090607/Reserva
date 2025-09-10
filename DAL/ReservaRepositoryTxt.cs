using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservaRepositoryTxt : IReservaRepository<Reserva>
    {
        private string ruta = "reservas.txt";

        public string Agregar(Reserva entity)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, true);
                escritor.WriteLine($"{entity.Id};{entity.Solicitante};{entity.Sala};{entity.Fecha}");
                escritor.Close();
                return $"se guardo la reserva de {entity.Solicitante}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Reserva> ObtenerTodo()
        {
            try
            {
                List<Reserva> lista = new List<Reserva>();
                StreamReader lector = new StreamReader(ruta);

                while (!lector.EndOfStream)
                {
                    lista.Add(Mappear(lector.ReadLine()));
                }
                lector.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private Reserva Mappear(string linea)
        {
            Reserva reserva = new Reserva();

            reserva.Id = int.Parse(linea.Split(';')[0]);
            reserva.Solicitante = linea.Split(';')[1];
            reserva.Sala = int.Parse(linea.Split(';')[2]);
            reserva.Solicitante = linea.Split(';')[4];
            return reserva;
        }
    }
}